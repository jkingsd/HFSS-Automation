
Partial Class HFSSAutomation


    ''' <summary>
    ''' Draw a rectangular box
    ''' </summary>
    ''' <param name="sName"></param>
    ''' <param name="sMaterial"></param>
    ''' <param name="sXSize"></param>
    ''' <param name="sYSize"></param>
    ''' <param name="sZSize"></param>
    ''' <remarks></remarks>
    Private Sub DrawBox(ByVal sName As String, ByVal sMaterial As String, ByVal sXSize As String, ByVal sYSize As String, ByVal sZSize As String)
        Dim oArray1 As Object() = {"NAME:Attributes", "Name:=", sName, "Flags:=", "", "Color:=", _
                                    "(132 132 193)", "Transparency:=", 0.75, "PartCoordinateSystem:=", "Global", "UDMId:=", _
                                    "", "MaterialValue:=", "" & Chr(34) & sMaterial & Chr(34) & "", "SolveInside:=", _
                                  True}
        Dim oArray2 As Object() = {"NAME:BoxParameters", "XPosition:=", "-" & sXSize & "/2", "YPosition:=", _
                                    "-" & sYSize & "/2", "ZPosition:=", "0mm", "XSize:=", sXSize, "YSize:=", sYSize, "ZSize:=", sZSize}
        oEditor.CreateBox(oArray2, oArray1)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sName"></param>
    ''' <remarks></remarks>
    Private Sub DrawRetangle(ByVal sName As String)
        Dim oArray1 As Object() = {"NAME:Attributes", "Name:=", sName, "Flags:=", _
            "", "Color:=", "(132 132 193)", "Transparency:=", 0, "PartCoordinateSystem:=", _
            "Global", "UDMId:=", "", "MaterialValue:=", "" & Chr(34) & "vacuum" & Chr(34) & "", "SolveInside:=", _
            True}
        Dim oArray2 As Object() = {"NAME:RectangleParameters", "IsCovered:=", True, "XStart:=", _
            "0mm", "YStart:=", "-0.25mm", "ZStart:=", "0mm", "Width:=", "0.5mm", "Height:=", _
            "-10mm", "WhichAxis:=", "X"}
        oEditor.CreateRectangle(oArray2, oArray1)
    End Sub

    Private Sub DrawUDP(ByVal sR As String, ByVal sH As String, ByVal sX As String, ByVal sY As String, ByVal sZ As String, ByVal sName As String)


        'Dim sXR As String = sX, sYR As String = sY
        'If sOrientation.Trim = "X" Then
        '    sXR = sX
        '    sYR = sY & "+" & sR & "*2/sqrt(3)"
        'ElseIf sOrientation.Trim = "Y" Or sOrientation.Trim <> "X" Then
        '    sXR = sX & "+" & sR & "*2/sqrt(3)"
        '    sYR = sY
        'End If
        'Dim S1 As Object() = {"NAME:PolyhedronParameters", "XCenter:=", sX, "YCenter:=", _
        '    sY, "ZCenter:=", sZ, "XStart:=", sXR, "YStart:=", sYR, "ZStart:=", sZ, "Height:=", sH, "NumSides:=", "6", "WhichAxis:=", "Z"}

        'Dim S2 As Array = {"NAME:Attributes", "Name:=", sName, "Flags:=", _
        '    "", "Color:=", "(132 132 193)", "Transparency:=", 0.75, "PartCoordinateSystem:=", _
        '    "Global", "UDMId:=", "", "MaterialValue:=", "" & Chr(34) & "perfect conductor" & Chr(34) & "", "SolveInside:=", _
        '    False}

        '      oEditor.CreateUserDefinedPart(Array("NAME:UserDefinedPrimitiveParameters", "DllName:=", _
        '"ResonatorHex", "Version:=", "1.0", "NoOfParameters:=", 12, "Library:=", _
        '"userlib", Array("NAME:ParamVector", Array("NAME:Pair", "Name:=", "InnerRad", "Value:=", _
        '"ResRad"), Array("NAME:Pair", "Name:=", "OuterRad", "Value:=", "0mm"), Array("NAME:Pair", "Name:=", _
        '"ResHeight", "Value:=", "Rx1Ht"), Array("NAME:Pair", "Name:=", "TopRadius", "Value:=", _
        '"TopRad"), Array("NAME:Pair", "Name:=", "EdgeRadius", "Value:=", "EdgeRad"), Array("NAME:Pair", "Name:=", _
        '"Face1Ext", "Value:=", "Rx1_2Ext"), Array("NAME:Pair", "Name:=", "Face2Ext", "Value:=", _
        '"0mm"), Array("NAME:Pair", "Name:=", "Face3Ext", "Value:=", "0mm"), Array("NAME:Pair", "Name:=", _
        '"Face4Ext", "Value:=", "0mm"), Array("NAME:Pair", "Name:=", "Face5Ext", "Value:=", _
        '"0mm"), Array("NAME:Pair", "Name:=", "Face6Ext", "Value:=", "0mm"), Array("NAME:Pair", "Name:=", _
        '"BotRadius", "Value:=", "BotRad"))), Array("NAME:Attributes", "Name:=", _
        '"HexagonalResonator1", "Flags:=", "", "Color:=", "(132 132 193)", "Transparency:=", _
        '0, "PartCoordinateSystem:=", "Global", "UDMId:=", "", "MaterialValue:=", _
        '"" & Chr(34) & "vacuum" & Chr(34) & "", "SolveInside:=", True))

    End Sub

End Class
