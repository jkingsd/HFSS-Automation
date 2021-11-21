' ----------------------------------------------
' Script Recorded by Ansoft HFSS Version 13.0.2
' 4:50:53 PM  Apr 06, 2012
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
Set oProject = oDesktop.SetActiveProject("Prj143_Filter")
Set oDesign = oProject.SetActiveDesign("Diplexer_7")
Set oEditor = oDesign.SetActiveEditor("3D Modeler")
oEditor.CreateRegularPolyhedron Array("NAME:PolyhedronParameters", "XCenter:=",  _
  "100mm", "YCenter:=", "-220mm", "ZCenter:=", "0mm", "XStart:=", "100mm", "YStart:=",  _
  "-200mm", "ZStart:=", "0mm", "Height:=", "40mm", "NumSides:=", "6", "WhichAxis:=",  _
  "Z"), Array("NAME:Attributes", "Name:=", "RegularPolyhedron1", "Flags:=", "", "Color:=",  _
  "(132 132 193)", "Transparency:=", 0, "PartCoordinateSystem:=", "Global", "UDMId:=",  _
  "", "MaterialValue:=", "" & Chr(34) & "vacuum" & Chr(34) & "", "SolveInside:=",  _
  true)
