' ----------------------------------------------
' Script Recorded by Ansoft HFSS Version 13.0.2
' 2:51:23 PM  Jun 25, 2012
' ----------------------------------------------
Dim oAnsoftApp
Dim oDesktop
Dim oProject
Dim oDesign
Dim oEditor
Dim oModule
Set oAnsoftApp = CreateObject("AnsoftHfss.HfssScriptInterface")
Set oDesktop = oAnsoftApp.GetAppDesktop()
oDesktop.RestoreWindow
Set oProject = oDesktop.SetActiveProject("P145 Filter")
Set oDesign = oProject.SetActiveDesign("P145_FullAlpha")
Set oEditor = oDesign.SetActiveEditor("3D Modeler")
oEditor.CreateUserDefinedPart Array("NAME:UserDefinedPrimitiveParameters", "DllName:=",  _
  "ResonatorHex", "Version:=", "1.0", "NoOfParameters:=", 12, "Library:=",  _
  "userlib", Array("NAME:ParamVector", Array("NAME:Pair", "Name:=", "InnerRad", "Value:=",  _
  "ResRad"), Array("NAME:Pair", "Name:=", "OuterRad", "Value:=", "0mm"), Array("NAME:Pair", "Name:=",  _
  "ResHeight", "Value:=", "Rx1Ht"), Array("NAME:Pair", "Name:=", "TopRadius", "Value:=",  _
  "TopRad"), Array("NAME:Pair", "Name:=", "EdgeRadius", "Value:=", "EdgeRad"), Array("NAME:Pair", "Name:=",  _
  "Face1Ext", "Value:=", "Rx1_2Ext"), Array("NAME:Pair", "Name:=", "Face2Ext", "Value:=",  _
  "0mm"), Array("NAME:Pair", "Name:=", "Face3Ext", "Value:=", "0mm"), Array("NAME:Pair", "Name:=",  _
  "Face4Ext", "Value:=", "0mm"), Array("NAME:Pair", "Name:=", "Face5Ext", "Value:=",  _
  "0mm"), Array("NAME:Pair", "Name:=", "Face6Ext", "Value:=", "0mm"), Array("NAME:Pair", "Name:=",  _
  "BotRadius", "Value:=", "BotRad"))), Array("NAME:Attributes", "Name:=",  _
  "HexagonalResonator1", "Flags:=", "", "Color:=", "(132 132 193)", "Transparency:=",  _
  0, "PartCoordinateSystem:=", "Global", "UDMId:=", "", "MaterialValue:=",  _
  "" & Chr(34) & "vacuum" & Chr(34) & "", "SolveInside:=", true)
oEditor.Move Array("NAME:Selections", "Selections:=", "HexagonalResonator1", "NewPartsModelFlag:=",  _
  "Model"), Array("NAME:TranslateParameters", "TranslateVectorX:=", "0mm", "TranslateVectorY:=",  _
  "0mm", "TranslateVectorZ:=", "0mm")
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers",  _
  "HexagonalResonator1:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=",  _
  "Rx1X", "Y:=", "Rx1Y", "Z:=", "0mm"))))
