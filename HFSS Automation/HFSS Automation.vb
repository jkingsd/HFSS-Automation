' HFSS Automation - Engineering tool to help draw, modify HSFF designs. By Dong Jing
' This goal of this tool is to make HFSS filter design easier and faster. 
' At this moment, it has two major capabilities: 1. Draw resonators, cavities, lumped ports.
' 2. Change variable values. 

'Imports HFSSAppLib
Imports System.IO
Imports System.Collections.Generic.List(Of String)
Imports clsHFSSExtract
Imports System.Xml

Public Class HFSSAutomation

    'Global variables
    Dim sErr As String  ' for err reporting
    Dim sPath As String = ""    ' AWR file path. This is the working folder. Files will be saved to this folder
    Dim bAbortFlag As Boolean = False
    Private mstrDefaultDirectory As String = CurDir.ToString  ' default director 
    Public sConfigFileName As String = "AutoHFSS.ini"   ' initial configuration file name. Actually XML format.

    'Public Structure ustuResonatorList

    'End Structure
    Dim oMyHFSS As Object   'HFSSAppLib.HfssAppComInterface
    Dim oMyDesktop As Object
    Dim oProject As Object
    Dim oDesign As Object
    Dim oEditor As Object
    Dim oModule As Object
    Dim cProject As clsHFSSProject
    Dim projList As New List(Of String)
    Dim cDesign As clsHFSSDesign
    Dim strDesignVariableList As List(Of String) = New List(Of String)
    Dim sHFSSAutomationFileName As String
    Private frmOptions As clsfrmOptions ' Options window form for setting options

    Const sUnit As String = "mm"

    Private Sub InitializeHFSS()
        ' Add any initialization after the InitializeComponent() call.
        If oMyHFSS Is Nothing Then oMyHFSS = CreateObject("AnsoftHfss.HfssScriptInterface") 'New HfssAppComInterface
        If oMyDesktop Is Nothing Then oMyDesktop = oMyHFSS.GetAppDesktop() : oMyDesktop.RestoreWindow()
    End Sub

    Private Sub getProjList()
        'projList = oMyDesktop.GetProjectList()
        Dim p As Integer = 0
        Try
            For p = 0 To UBound(oMyDesktop.getprojectlist())
                projList.Add(oMyDesktop.GetProjectList()(p))
            Next

            'p = p + 1
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BuildDesignVariableList()

        If IsNothing(oProject) Then Throw New Exception("No project loaded")
        oDesign = oProject.GetActiveDesign()
        oMyDesktop.RestoreWindow()

        ' get variable list of the design
        strDesignVariableList.Clear()
        Dim oTemp As Object
        oTemp = oDesign.GetVariables()
        For i As Integer = 0 To UBound(oTemp)
            strDesignVariableList.Add(oTemp(i).ToString)
        Next
    End Sub



    Private Sub btnDrawHFSS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawHFSS.Click

        Me.Cursor = Cursors.WaitCursor

        Dim sCavH, sCavR, sResR, sIrisW, sIrisThk, sName, sResH, sDesign, sIrisLen As String

        Try

            sCavH = Trim(txtCavH.Text) & sUnit
            sCavR = Trim(txtCavR.Text) & sUnit
            sResH = Trim(txbResH.Text) & sUnit
            sResR = Trim(txtResR.Text) & sUnit
            sName = Trim(txtName.Text)
            sDesign = Trim(cboDesigns.Text)

            sIrisThk = sCavH
            sIrisW = sCavR

            oDesign = oProject.SetActiveDesign(sDesign)
            oEditor = oDesign.SetActiveEditor("3D Modeler")
            oModule = oDesign.GetModule("BoundarySetup")

            BuildDesignVariableList()

            ' Load test cases from datagridview1 control
            Dim iTotalTests As Integer
            iTotalTests = ResonatorGrid.Rows.Count - 1
            If iTotalTests <= 0 Then MsgBox("Resonator item grid is empty. Please add items!", vbOKOnly, "No resonator item") : Exit Sub

            ' Add global variables. Cavity Height and radius
            Call AddVariable("Cav_H", sCavH)
            Call AddVariable("Cav_R", sCavR)
            Call AddVariable("Res_R", sResR)
            Dim sItem, sX, sY, sZ As String
            Dim dX, dY, dIrisLen As Double
            For i As Integer = 0 To iTotalTests - 1
                sItem = Convert.ToString(ResonatorGrid.Rows(i).Cells(0).Value)
                sX = Convert.ToString(ResonatorGrid.Rows(i).Cells(1).Value) & sUnit
                sY = Convert.ToString(ResonatorGrid.Rows(i).Cells(2).Value) & sUnit
                sZ = Convert.ToString(ResonatorGrid.Rows(i).Cells(3).Value) & sUnit
                sResH = Convert.ToString(ResonatorGrid.Rows(i).Cells(4).Value) & sUnit
                ' Draw individual resonator and cavity
                Call DrawResonatorSection(sName, sItem, sX, sY, sZ, "Cav_H", "Cav_R", sResH, "Res_R")

                ' Draw IRIS. Length is depend on adjacent resonator locations
                If i > 0 Then
                    dX = Convert.ToDouble(ResonatorGrid.Rows(i).Cells(1).Value) - Convert.ToDouble(ResonatorGrid.Rows(i - 1).Cells(1).Value)
                    dY = Convert.ToDouble(ResonatorGrid.Rows(i).Cells(2).Value) - Convert.ToDouble(ResonatorGrid.Rows(i - 1).Cells(2).Value)
                    'dZ = Convert.ToDouble(ResonatorGrid.Rows(i).Cells(3).Value)
                    dIrisLen = Format(Math.Sqrt(dX * dX + dY * dY), "#.00")
                    sIrisLen = Convert.ToString(dIrisLen) & sUnit
                    If chkDrawCavity.Checked = True Then Call DrawIRIS(sName, Trim(Str(Val(sItem) - 1)), sItem, sIrisW, sIrisLen, "Cav_H")
                End If
            Next

        Catch ex As Exception
            MsgBox("Draw HFSS objects failed. " & Err.Description)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub DrawResonatorSection(ByVal sCHName As String, ByVal sIndex As String, ByVal sX As String, ByVal sY As String, ByVal sZ As String, ByVal sCavH As String, ByVal sCavR As String, ByVal sResH As String, ByVal sResR As String)
        Dim sCavName As String, sResName As String, sOrientation As String
        sOrientation = cboOrientation.Text.Trim
        sCavName = sCHName & "_Cav" & sIndex
        sResName = sCHName & "_Res" & sIndex
        Dim sXVar, sYVar, sHVar As String
        sXVar = sCHName & "_Res" & sIndex & "_X"
        Call AddVariable(sXVar, sX)
        sYVar = sCHName & "_Res" & sIndex & "_Y"
        Call AddVariable(sYVar, sY)

        If chkDrawCavity.Checked = True Then
            Select Case cboCavType.Text
                Case Is = "Cylinder"
                    Call DrawCylinder(sCavR, sCavH, sXVar, sYVar, sZ, sCavName)  ' Draw cylinder cavity
                Case Is = "Hex"
                    Call DrawHex3D(sCavR, sCavH, sXVar, sYVar, sZ, sOrientation, sCavName)    ' Draw Hex cavity
            End Select
        End If

        If chkDrawResonator.Checked = True Or chkDrawPort.Checked = True Then
            sHVar = sCHName & "_Res" & sIndex & "_H"    ' resonator height variable
            sZ = "0"
            Call AddVariable(sHVar, sResH)
        End If

        If chkDrawResonator.Checked = True Then
            Select Case cboResType.Text
                Case Is = "Cylinder"
                    Call DrawCylinder(sResR, sResH, sXVar, sYVar, sZ, sResName)  ' Draw cylinder Resonator
                Case Is = "Hex"
                    Call DrawHex3D(sResR, sResH, sXVar, sYVar, sZ, sOrientation, sResName)    ' Draw Hex Resonator
            End Select
            Call AssignMaterial(sResName, "perfect conductor")

            Select Case cboResType.Text
                Case Is = "Cylinder"
                    Call ChangeCylinderProperty(sResName, "Height", sHVar)  ' change cylinder resonator height property
                Case Is = "Hex"
                    Call ChangeHex3DProperty(sResName, "Height", sHVar)     ' change Hex resonator height property
            End Select
        End If


        ' Draw lumped port
        If chkDrawPort.Checked = True Then
            Dim sLP As String
            sLP = "LP_" & sCHName & "_R" & sIndex
            Call DrawRetangle(sLP)
            Call DrawLumpedPort(sLP)
            Call Move3DSolid(sLP, sXVar, sYVar, "Cav_H")
            Call ChangeRectangleproperty(sLP, "ZSize", sHVar & "-Cav_H")
        End If
    End Sub

    ''' <summary>
    ''' Draw Iris rectangular box.
    ''' </summary>
    ''' <param name="sName"></param>
    ''' <param name="sIndex1">From this resonator</param>
    ''' <param name="sIndex2">To this resonator</param>
    ''' <param name="sIRISWidth"></param>
    ''' <param name="sIRISThk"></param>
    ''' <param name="sCavH">Iris box height. Usually the same as cavity height</param>
    ''' <remarks></remarks>
    Private Sub DrawIRIS(ByVal sName As String, ByVal sIndex1 As String, ByVal sIndex2 As String, ByVal sIRISWidth As String, ByVal sIRISThk As String, ByVal sCavH As String)
        Dim sX1, sX2, sY1, sY2 As String
        Dim sX, sY As String
        Dim sIRISWVar As String, sIRISName As String
        sIRISName = "IRIS_" & sName & "_" & sIndex1 & sIndex2
        sIRISWVar = sIRISName & "_W"    ' Iris width
        Call AddVariable(sIRISWVar, sIRISWidth)
        sX1 = sName & "_Res" & sIndex1 & "_X"
        sX2 = sName & "_Res" & sIndex2 & "_X"
        sX = "(" & sX1 & "+" & sX2 & ")/2"
        sY1 = sName & "_Res" & sIndex1 & "_Y"
        sY2 = sName & "_Res" & sIndex2 & "_Y"
        sY = "(" & sY1 & "+" & sY2 & ")/2"
        Call DrawBox(sIRISName, "vacuum", sIRISThk, sIRISWVar, "Cav_H")
        Call RotateObject(sIRISName, "ATAN((" & sY2 & "-" & sY1 & ")/(" & sX2 & "-" & sX1 & "))")
        Call Move3DSolid(sIRISName, sX, sY, "0mm")
    End Sub

    ''' <summary>
    ''' Create a cylinder. Could be a resonator or a cavity. Material is set to Vacuum
    ''' </summary>
    ''' <param name="sR">Radius</param>
    ''' <param name="sH">Height</param>
    ''' <param name="sX">Location:X</param>
    ''' <param name="sY">Location:Y</param>
    ''' <param name="sZ">Location:Z</param>
    ''' <param name="sName">Name of this cylinder</param>
    ''' <remarks></remarks>
    Private Sub DrawCylinder(ByVal sR As String, ByVal sH As String, ByVal sX As String, ByVal sY As String, ByVal sZ As String, ByVal sName As String)
        Dim S1 As Object() = {"NAME:CylinderParameters", "XCenter:=", sX, "YCenter:=", _
            sY, "ZCenter:=", sZ, "Radius:=", sR, "Height:=", sH, "WhichAxis:=", _
            "Z", "NumSides:=", "0"}
        Dim S2 As Array = {"NAME:Attributes", "Name:=", sName, "Flags:=", _
            "", "Color:=", "(132 132 193)", "Transparency:=", 0.75, "PartCoordinateSystem:=", _
            "Global", "UDMId:=", "", "MaterialValue:=", "" & Chr(34) & "vacuum" & Chr(34) & "", "SolveInside:=", _
            True}
        oEditor.CreateCylinder(S1, S2)
    End Sub

    ''' <summary>
    ''' Draw polyhedron (Hex) shape
    ''' </summary>
    ''' <param name="sR"></param>
    ''' <param name="sH"></param>
    ''' <param name="sX"></param>
    ''' <param name="sY"></param>
    ''' <param name="sZ"></param>
    ''' <param name="sName"></param>
    ''' <remarks></remarks>
    Private Sub DrawHex3D(ByVal sR As String, ByVal sH As String, ByVal sX As String, ByVal sY As String, ByVal sZ As String, ByVal sOrientation As String, ByVal sName As String)
        Dim sXR As String = sX, sYR As String = sY
        If sOrientation.Trim = "X" Then
            sXR = sX
            sYR = sY & "+" & sR & "*2/sqrt(3)"
        ElseIf sOrientation.Trim = "Y" Or sOrientation.Trim <> "X" Then
            sXR = sX & "+" & sR & "*2/sqrt(3)"
            sYR = sY
        End If
        Dim S1 As Object() = {"NAME:PolyhedronParameters", "XCenter:=", sX, "YCenter:=", _
            sY, "ZCenter:=", sZ, "XStart:=", sXR, "YStart:=", sYR, "ZStart:=", sZ, "Height:=", sH, "NumSides:=", "6", "WhichAxis:=", "Z"}

        'Dim S2 As Array = {"NAME:Attributes", "Name:=", sName, "Flags:=", _
        '    "", "Color:=", "(132 132 193)", "Transparency:=", 0.75, "PartCoordinateSystem:=", _
        '    "Global", "UDMId:=", "", "MaterialValue:=", "" & Chr(34) & "perfect conductor" & Chr(34) & "", "SolveInside:=", _
        '    False}
        Dim S2 As Array = {"NAME:Attributes", "Name:=", sName, "Flags:=", _
                           "", "Color:=", "(132 132 193)", "Transparency:=", 0.75, "PartCoordinateSystem:=", _
                           "Global", "UDMId:=", "", "MaterialValue:=", "" & Chr(34) & "vacuum" & Chr(34) & "", "SolveInside:=", _
                           True}
        oEditor.CreateRegularPolyhedron(S1, S2)
    End Sub

    Private Sub AddVariable(ByVal sName As String, ByVal sValue As String)
        Dim oArray1 As Object() = {"NAME:" & sName, "PropType:=", "VariableProp", "UserDef:=", True, "Value:=", sValue}
        Dim oArray2 As Object() = {"NAME:NewProps", oArray1}
        Dim oArray3 As Object() = {"NAME:PropServers", "LocalVariables"}
        Dim oArray4 As Array = {"NAME:LocalVariableTab", oArray3, oArray2}
        Dim oArray5 As Array = {"NAME:AllTabs", oArray4}
        If Not (strDesignVariableList.Contains(sName)) Then oDesign.ChangeProperty(oArray5)
    End Sub

    ''' <summary>
    ''' Change variable value
    ''' </summary>
    ''' <param name="sName"></param>
    ''' <param name="sValue"></param>
    ''' <remarks></remarks>
    Private Sub ChangeVariableValue(ByVal sName As String, ByVal sValue As String)
        Dim oArray1 As Object() = {"NAME:" & sName, "VALUE:=", sValue}
        Dim oArray2 As Object() = {"NAME:ChangedProps", oArray1}
        Dim oArray3 As Object() = {"NAME:PropServers", "LocalVariables"}
        Dim oArray4 As Object() = {"NAME:LocalVariableTab", oArray3, oArray2}
        Dim oArray5 As Object() = {"NAME:AllTabs", oArray4}
        oDesign.ChangeProperty(oArray5)
    End Sub

    Private Sub ChangeCylinderProperty(ByVal sObjectName As String, ByVal sPropertyName As String, ByVal sValue As String)
        Dim oArray1 As Object() = {"NAME:" & sPropertyName, "Value:=", sValue}
        Dim oArray2 As Object() = {"NAME:ChangedProps", oArray1}
        Dim oArray3 As Object() = {"NAME:PropServers", sObjectName & ":CreateCylinder:1"}
        Dim oArray4 As Array = {"NAME:Geometry3DCmdTab", oArray3, oArray2}
        Dim oArray5 = {"NAME:AllTabs", oArray4}
        oEditor.ChangeProperty(oArray5)
        '      oEditor.ChangeProperty(Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", _
        '"Cylinder1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "TX_Res11")))))
    End Sub

    Private Sub ChangeHex3DProperty(ByVal sObjectName As String, ByVal sPropertyName As String, ByVal sValue As String)
        Dim oArray1 As Object() = {"NAME:" & sPropertyName, "Value:=", sValue}
        Dim oArray2 As Object() = {"NAME:ChangedProps", oArray1}
        Dim oArray3 As Object() = {"NAME:PropServers", sObjectName & ":CreateRegularPolyhedron:1"}
        Dim oArray4 As Array = {"NAME:Geometry3DCmdTab", oArray3, oArray2}
        Dim oArray5 = {"NAME:AllTabs", oArray4}
        oEditor.ChangeProperty(oArray5)

        '      oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", _
        '"RegularPolyhedron1:CreateRegularPolyhedron:1"), Array("NAME:ChangedProps", Array("NAME:Height", "Value:=", _
        '"55mm"))))
    End Sub

    Private Sub ChangeRectangleproperty(ByVal sObjectName As String, ByVal sPropertyName As String, ByVal sValue As String)
        Dim oArray1 As Object() = {"NAME:" & sPropertyName, "Value:=", sValue}
        Dim oArray2 As Object() = {"NAME:ChangedProps", oArray1}
        Dim oArray3 As Object() = {"NAME:PropServers", sObjectName & ":CreateRectangle:1"}
        Dim oArray4 As Array = {"NAME:Geometry3DCmdTab", oArray3, oArray2}
        Dim oArray5 As Array = {"NAME:AllTabs", oArray4}
        oEditor.ChangeProperty(oArray5)
    End Sub

    Private Sub Move3DSolid(ByVal sObjectName As String, ByVal sX As String, ByVal sY As String, ByVal sZ As String)
        Dim oArray1 As Object() = {"NAME:Selections", "Selections:=", sObjectName, "NewPartsModelFlag:=", "Model"}
        Dim oArray2 As Object() = {"NAME:TranslateParameters", "TranslateVectorX:=", sX, "TranslateVectorY:=", sY, "TranslateVectorZ:=", sZ}
        oEditor.Move(oArray1, oArray2)
    End Sub

    Private Sub RotateObject(ByVal sName As String, ByVal sAngle As String)
        Dim oArray1 As Object() = {"NAME:RotateParameters", "RotateAxis:=", "Z", "RotateAngle:=", sAngle}
        Dim oArray2 As Object() = {"NAME:Selections", "Selections:=", sName, "NewPartsModelFlag:=", "Model"}
        oEditor.Rotate(oArray2, oArray1)
        'oEditor.ChangeProperty(Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", _
        '  "Box1:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "ATAN(Cav_H)")))))
    End Sub

    Private Sub ChangeMoveProperty()

        'oEditor.ChangeProperty(Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", _
        '  "TX_Res11:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "TX_Res11_X", "Y:=", _
        '  "TX_Res11_Y", "Z:=", "0mm")))))

    End Sub

    ''' <summary>
    ''' Draw lumped port on a sheet
    ''' </summary>
    ''' <param name="sName">Name of the sheet</param>
    ''' <remarks></remarks>
    Private Sub DrawLumpedPort(ByVal sName As String)

        Dim excite_name_array As Object
        excite_name_array = oModule.GetExcitationsOfType("Lumped Port")
        For i As Integer = 0 To UBound(excite_name_array)
            If excite_name_array(i).ToString = sName Then Throw New Exception("Lumped port: " & sName & " already exist.")
        Next
        Dim oArray1 As Object() = {"0mm", "0mm", "-10mm"}
        Dim oArray2 As Object() = {"0mm", "0mm", "0mm"}
        Dim oArray3 As Object() = {"NAME:IntLine", "Start:=", oArray1, "End:=", oArray2}
        Dim oArray4 As Object() = {"NAME:Mode1", "ModeNum:=", 1, "UseIntLine:=", True, oArray3, "CharImp:=", "Zpi", "RenormImp:=", "50ohm"}
        Dim oArray5 As Object() = {True}
        Dim oArray6 As Object() = {"NAME:Modes", oArray4}
        Dim oArray7 As Object() = {sName}
        Dim oArray8 As Object() = {"NAME:" & sName, "Objects:=", oArray7, "RenormalizeAllTerminals:=", True, oArray6, "ShowReporterFilter:=", False, "ReporterFilter:=", _
                                   oArray5, "FullResistance:=", "50ohm", "FullReactance:=", "0ohm"}
        oModule.AssignLumpedPort(oArray8)

    End Sub

    ''' <summary>
    ''' Assign material to an object. 
    ''' </summary>
    ''' <param name="sName">Object name</param>
    ''' <param name="sMaterial">Material Name</param>
    ''' <remarks></remarks>
    Private Sub AssignMaterial(ByVal sName As String, ByVal sMaterial As String)
        Dim oArray1 As Object() = {"NAME:Attributes", "MaterialValue:=", "" & Chr(34) & sMaterial & Chr(34) & "", "SolveInside:=", False}
        Dim oArray2 As Object() = {"NAME:Selections", "Selections:=", sName}
        oEditor.AssignMaterial(oArray2, oArray1)
    End Sub

    ''' <summary>
    ''' Assistant tool to generate resonator list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnCreateResonatorList_Click_1(sender As Object, e As EventArgs) Handles BtnCreateResonatorList.Click

        Dim iCurrentRow As Integer
        Dim iNode1, iNode2 As Integer
        Dim iTemp As Integer = 0

        iCurrentRow = ResonatorGrid.Rows.Count
        iNode1 = Convert.ToInt32(txbNode1.Text)
        iNode2 = Convert.ToInt32(txbNode2.Text)

        ' Some simple error handling 
        If iNode1 = iNode2 Then MsgBox("Node 1 and Node 2 must be different!", vbExclamation) : Exit Sub
        If iNode1 > iNode2 Then
            iTemp = iNode1 : iNode1 = iNode2 : iNode2 = iTemp
            txbNode1.Text = iNode1.ToString
            txbNode2.Text = iNode2.ToString
            MsgBox("Node 1 and Node 2 reversed!", vbExclamation, vbOK)
        End If

        iTemp = Convert.ToSingle(txbResH.Text)
        For i As Integer = iNode1 To iNode2
            ResonatorGrid.Rows.Add(i, i * 10, i * 10, 0, iTemp)
        Next i
    End Sub


    ''' <summary>
    ''' Get HFSS file name and project names
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLoadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadFile.Click


        Dim strFullNameWithPath As String
        Me.Cursor = Cursors.WaitCursor
        Try

            oProject = Nothing

            OpenFileDialog1.Title = "Please Select a File"
            OpenFileDialog1.Filter = "HFSS files (*.hfss)|*.hfss|" & "All files|*.*"
            OpenFileDialog1.InitialDirectory = DefaultDirectory   ' "C:\"

            OpenFileDialog1.ShowDialog()
            txtFilename.Text = OpenFileDialog1.FileName
            strFullNameWithPath = Trim(txtFilename.Text)
            If strFullNameWithPath = "" Then Exit Sub
            ' Set global sPath variable to the path of loaded HFSS file.
            Dim i As Integer
            Dim sTemp As String
            i = strFullNameWithPath.LastIndexOf("\")
            sTemp = strFullNameWithPath.Substring(0, i)
            sPath = sTemp

            cProject = New clsHFSSProject(txtFilename.Text)

            Dim d As Integer
            cboDesigns.Items.Clear()

            For d = 0 To cProject.designCount - 1
                cboDesigns.Items.Add(cProject.getDesign(d).name)
            Next

            ' cboDesigns point to the first in the list
            cboDesigns.SelectedIndex = 0
            cboDesigns.Text = cboDesigns.SelectedItem.ToString

            'btnOpenFile.PerformClick()
            OpenDesign()
        Catch ex As Exception
            ' Needs handling of any caught errors
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    ' set the reference to the project and design
    'Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
    Private Sub OpenDesign()

        Try

            If txtFilename.Text = "" Then
                Throw New Exception("No project file")
            End If

            InitializeHFSS()    ' if not initialized, initialize HFSS desktop object.

            getProjList()
            If projList.Contains(cProject.FileName) Then
                oProject = oMyDesktop.SetActiveProjectByPath(txtFilename.Text)

                cboDesigns.Items.Clear()
                If IsNothing(oProject) Then MsgBox("Project " & txtFilename.Text & " Do not exist", vbOKOnly) : Exit Sub
                For Each omyDesign In oProject.GetDesigns()
                    cboDesigns.Items.Add(omyDesign.GetName())
                Next
            Else
                oProject = oMyDesktop.OpenProject(txtFilename.Text)
            End If
            oMyDesktop.RestoreWindow()

            If cProject.getDesignNames().Contains(cboDesigns.Text) Then
                oDesign = oProject.SetActiveDesign(cboDesigns.Text)
            Else
                oDesign = oProject.SetActiveDesign(cProject.getDesign(0).name)
                cboDesigns.Text = oDesign.GetName()
                ' Need to add if there is no design in the project, a new design will be created.
            End If

            oDesign = oProject.GetActiveDesign()
            oMyDesktop.RestoreWindow()

            ' get variable list of the design
            Dim oTemp As Object
            oTemp = oDesign.GetVariables()
            For i As Integer = 0 To UBound(oTemp)
                strDesignVariableList.Add(oTemp(i).ToString)
            Next
            'strDesignVariableList = cProject.getDesign(cboDesigns.Text).VariableList

            ToolStripStatusLabel1.Text = "HFSS File Loaded"
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Load HFSS File Failed"
        End Try

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '' Add any initialization after the InitializeComponent() call.
        'oMyHFSS = New HfssAppComInterface
        'oMyDesktop = oMyHFSS.GetAppDesktop()
        'oMyDesktop.RestoreWindow()


        ' Load configuration file
        Dim sConfigFile As String
        Dim sErrMsg As String = ""
        Try
            sConfigFile = My.Application.Info.DirectoryPath & "\" & sConfigFileName
            If My.Computer.FileSystem.FileExists(sConfigFile) Then
                If LoadConfiguration(sConfigFile, sErrMsg) = False Then
                    Throw (New Exception("Load configure file failed!"))
                Else
                    ' Successful in loading configuration file. Do nothing. 
                End If
            Else

            End If
        Catch
            MsgBox("Initialization failed: " & Err.Description, vbOKOnly)
        End Try

        ' Default file name 
        sHFSSAutomationFileName = DefaultDirectory & "\New_File.csv"
        Me.Text = "AutoHFSS: - " & sHFSSAutomationFileName
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        oMyDesktop.closeproject(oProject.getname)
    End Sub

    Private Sub btnChangeVariableValues_Click(sender As Object, e As EventArgs) Handles btnChangeVariableValues.Click
        If IsNothing(oProject) Then Exit Sub
        Dim sDesign As String
        Me.Cursor = Cursors.WaitCursor
        sDesign = Trim(cboDesigns.Text)
        oDesign = oProject.SetActiveDesign(sDesign)
        oEditor = oDesign.SetActiveEditor("3D Modeler")
        oModule = oDesign.GetModule("BoundarySetup")

        Dim sName, sValue As String
        Dim iTotalVariables As Integer
        iTotalVariables = VariableGrid.RowCount
        For i As Integer = 0 To iTotalVariables - 2
            sName = (VariableGrid.Rows(i).Cells(0).Value.ToString)
            sValue = (VariableGrid.Rows(i).Cells(1).Value.ToString) & sUnit
            Call ChangeVariableValue(sName, sValue)
        Next
        Me.Cursor = Cursors.Default   ' indicate opt is runing
    End Sub

    Private Sub cboDesigns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDesigns.SelectedIndexChanged
        Dim sDesign As String
        sDesign = Trim(cboDesigns.Text)
        If Not IsNothing(oProject) Then
            oDesign = oProject.SetActiveDesign(sDesign)
            oMyDesktop.Restorewindow()
            '---
            ' This seems to be a bug of HFSS. SetActiveDesign is basically make this design active on modeler window. It is not really set this 
            ' oDesign object pointing to the active design. The oDesign object is still prointing to selected design in project manager window.
            ' A work around is click modeler window to make selected design in project manager window to be synced with the active design. 
            ' Now the oDesign object is pointing to the correct design. 
            ' **Found out use restorewindow of desktop object to sync it. -DJ 1/30/2013
            '----
        End If
    End Sub

    Private Sub btnScanVariables_Click(sender As Object, e As EventArgs) Handles btnScanVariables.Click

        Me.Cursor = Cursors.WaitCursor
        oDesign = Nothing
        If Not IsNothing(oProject) Then oDesign = oProject.GetActiveDesign()
        If Not IsNothing(oDesign) Then
            ScanedVariableGrid.Rows.Clear()
            ' get variable list of the design
            Dim oTemp As Object
            Dim sTemp As String = ""
            oTemp = oDesign.GetVariables()
            For i As Integer = 0 To UBound(oTemp)
                sTemp = oDesign.GetVariableValue(oTemp(i).ToString)
                ScanedVariableGrid.Rows.Add(oTemp(i).ToString, sTemp)
                For j As Integer = 0 To VariableGrid.Rows.Count - 1
                    If Trim(UCase(VariableGrid.Rows(j).Cells(0).Value)) = Trim(UCase(oTemp(i).ToString)) Then
                        VariableGrid.Rows(j).Cells(2).Value = sTemp
                    End If
                Next
            Next
        Else
            MsgBox("Please pick your design first.", vbOKOnly)
        End If
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub btnAddToChangeList_Click(sender As Object, e As EventArgs) Handles btnAddToChangeList.Click
        Dim sVariableName As String
        Dim sVariableValueString As String

        sVariableName = ScanedVariableGrid.CurrentRow.Cells(0).Value.ToString
        sVariableValueString = ScanedVariableGrid.CurrentRow.Cells(1).Value.ToString
        VariableGrid.Rows.Add(sVariableName, "", sVariableValueString)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            OpenFileDialog1.Title = "Please Select a File"
            OpenFileDialog1.Filter = "Variable Table files (*.csv)|*.csv|" & "All files|*.*"
            OpenFileDialog1.InitialDirectory = DefaultDirectory
            Dim strFileName As String = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            strFileName = OpenFileDialog1.FileName
            'sPath = Trim(txbFilename.Text)
            Dim strSplits As String()
            Using sr As StreamReader = New StreamReader(strFileName)
                Do While Not sr.EndOfStream
                    strSplits = sr.ReadLine.Split(",")
                    VariableGrid.Rows.Add(strSplits)
                Loop
            End Using
            Me.Text = "HFSS Automation: - " & strFileName
            sHFSSAutomationFileName = strFileName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SavAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavAsToolStripMenuItem.Click

        Try
            Dim strFileName As String = ""
            Dim intTotalLines As Integer = VariableGrid.RowCount
            SaveFileDialog1.Title = "Please Select a File"
            SaveFileDialog1.Filter = "Variable Table files (*.csv)|*.csv|" & "All files|*.*"
            SaveFileDialog1.InitialDirectory = DefaultDirectory   ' "C:\"
            If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            strFileName = SaveFileDialog1.FileName
            Using sw As StreamWriter = New StreamWriter(strFileName)
                For i As Integer = 0 To intTotalLines - 2
                    If IsNothing(VariableGrid.Rows(i).Cells(2).Value) Then
                        sw.WriteLine(VariableGrid.Rows(i).Cells(0).Value.ToString & "," & VariableGrid.Rows(i).Cells(1).Value.ToString)
                    Else
                        sw.WriteLine(VariableGrid.Rows(i).Cells(0).Value.ToString & "," & VariableGrid.Rows(i).Cells(1).Value.ToString & "," & VariableGrid.Rows(i).Cells(2).Value.ToString)
                    End If
                Next
                sw.Close()
            End Using
            Me.Text = "HFSS Automation: - " & strFileName
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        Dim intTotalLines As Integer = VariableGrid.RowCount

        Try
            If My.Computer.FileSystem.FileExists(sHFSSAutomationFileName) = True Then
                If MessageBox.Show("Save File: " & sHFSSAutomationFileName & "?", "Save HFSS Automation csv file: ", MessageBoxButtons.YesNo) = MsgBoxResult.No Then Exit Sub ' Make sure really want to save file
                Using sw As StreamWriter = New StreamWriter(sHFSSAutomationFileName)
                    For i As Integer = 0 To intTotalLines - 2
                        If IsNothing(VariableGrid.Rows(i).Cells(2).Value) Then
                            sw.WriteLine(VariableGrid.Rows(i).Cells(0).Value.ToString & "," & VariableGrid.Rows(i).Cells(1).Value.ToString)
                        Else
                            sw.WriteLine(VariableGrid.Rows(i).Cells(0).Value.ToString & "," & VariableGrid.Rows(i).Cells(1).Value.ToString & "," & VariableGrid.Rows(i).Cells(2).Value.ToString)
                        End If
                    Next
                    sw.Close()
                End Using
            Else
                SavAsToolStripMenuItem.PerformClick()  ' file saveas
            End If
        Catch
            MsgBox(Err.Description, vbOKOnly)
        End Try
    End Sub

    Public Property DefaultDirectory As String
        Get
            Return mstrDefaultDirectory
        End Get
        Set(ByVal value As String)
            mstrDefaultDirectory = value
        End Set
    End Property

    ''' <summary>
    ''' Show option window for change settings.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EnvOptionStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnvOptionStripMenuItem.Click

        frmOptions = New clsfrmOptions(Me)
        With frmOptions
            .txtDefaultDirectory.Text = DefaultDirectory
        End With
        frmOptions.Show()
    End Sub


    ' Save configuration file
    Friend Function SaveConfituration(ByVal sFileName As String, ByRef sErrMsg As String) As Boolean

        ''
        Dim settings As New XmlWriterSettings()
        settings.Indent = True

        ' Initialize the XmlWriter.
        Dim XmlWrt As XmlWriter = XmlWriter.Create(sFileName, settings)

        With XmlWrt
            ' Write the Xml declaration.
            .WriteStartDocument()
            ' Write a comment.
            .WriteComment("AutoHFSS Configuration File.")
            ' Write the root element.
            .WriteStartElement("Data")

            .WriteStartElement("OptDefaultDirectory")
            .WriteString(DefaultDirectory)
            .WriteEndElement()

            ' Close the XmlTextWriter.
            .WriteEndDocument()
            .Close()
        End With
        MessageBox.Show("Configuration File saved.")
        Return True

    End Function


    ''' <summary>
    ''' Load 
    ''' </summary>
    ''' <param name="sFileName"></param>
    ''' <param name="sErrMsg"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LoadConfiguration(ByVal sFileName As String, ByRef sErrMsg As String) As Boolean

        LoadConfiguration = False
        Try
            If (System.IO.File.Exists(sFileName)) Then
                Dim document As XmlReader = New XmlTextReader(sFileName)
                While (document.Read())
                    Dim type = document.NodeType
                    If (type = XmlNodeType.Element) Then
                        If (document.Name = "OptDefaultDirectory") Then
                            DefaultDirectory = document.ReadInnerXml.ToString()
                        End If
                    End If  ' End of element
                End While
                document.Close()
            End If
            Return True
        Catch
            sErrMsg = "Load Configuration file failed! " & Err.Description
            Return False
        End Try

    End Function

    Private Sub SyncWithHFSSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SyncWithHFSSToolStripMenuItem.Click

        Dim omyDesign As Object

        cboDesigns.Items.Clear()
        If IsNothing(oProject) Then MsgBox("No project to sync!", vbOKOnly) : Exit Sub

        For Each omyDesign In oProject.GetDesigns()
            cboDesigns.Items.Add(omyDesign.GetName())
        Next

    End Sub

    Private Sub ScanedVariableGrid_DoubleClick(sender As Object, e As EventArgs) Handles ScanedVariableGrid.DoubleClick
        btnAddToChangeList.PerformClick()
    End Sub

    Private Sub btnSaveTableToFile_Click(sender As Object, e As EventArgs) Handles btnSaveTableToFile.Click
        Try
            Dim strFileName As String = ""
            Dim intTotalLines As Integer = ResonatorGrid.RowCount
            SaveFileDialog1.Title = "Please Select a File"
            SaveFileDialog1.Filter = "Resonator Table files (*.csv)|*.csv|" & "All files|*.*"
            SaveFileDialog1.InitialDirectory = DefaultDirectory   ' "C:\"
            If SaveFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            strFileName = SaveFileDialog1.FileName
            Using sw As StreamWriter = New StreamWriter(strFileName)
                For i As Integer = 0 To intTotalLines - 2
                    sw.WriteLine(ResonatorGrid.Rows(i).Cells(0).Value.ToString & "," & ResonatorGrid.Rows(i).Cells(1).Value.ToString & "," & ResonatorGrid.Rows(i).Cells(2).Value.ToString & "," & _
                                 ResonatorGrid.Rows(i).Cells(3).Value.ToString & "," & ResonatorGrid.Rows(i).Cells(4).Value.ToString)
                Next
                sw.Close()
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLoadTableFromFile_Click(sender As Object, e As EventArgs) Handles btnLoadTableFromFile.Click

        Dim strFileName As String = ""
        Try
            OpenFileDialog1.Title = "Please Select a File"
            OpenFileDialog1.Filter = "Resonator Table files (*.csv)|*.csv|" & "All files|*.*"
            OpenFileDialog1.InitialDirectory = DefaultDirectory
            If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then Exit Sub
            strFileName = OpenFileDialog1.FileName
            'sPath = Trim(txbFilename.Text)
            Dim strSplits As String()
            Using sr As StreamReader = New StreamReader(strFileName)
                Do While Not sr.EndOfStream
                    strSplits = sr.ReadLine.Split(",")
                    ResonatorGrid.Rows.Add(strSplits)
                Loop
            End Using
        Catch ex As Exception
            MessageBox.Show("Load resonator table from file " & strFileName & " failed!")
        End Try
    End Sub
End Class
