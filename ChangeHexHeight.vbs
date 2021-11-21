' ----------------------------------------------
' Script Recorded by Ansoft HFSS Version 13.0.2
' 11:36:10 AM  Dec 05, 2012
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
Set oProject = oDesktop.SetActiveProject("Prj129_New")
Set oDesign = oProject.SetActiveDesign("HFSSDesign1")
Set oEditor = oDesign.SetActiveEditor("3D Modeler")
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers",  _
  "RegularPolyhedron1:CreateRegularPolyhedron:1"), Array("NAME:ChangedProps", Array("NAME:Height", "Value:=",  _
  "55mm"))))
