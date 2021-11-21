' ----------------------------------------------
' Script Recorded by Ansoft HFSS Version 14.0.1
' 10:35:08 AM  Dec 05, 2012
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
Set oDesign = oProject.SetActiveDesign("Diplexer_37_New")
oDesign.ChangeProperty Array("NAME:AllTabs", Array("NAME:LocalVariableTab", Array("NAME:PropServers",  _
  "LocalVariables"), Array("NAME:ChangedProps", Array("NAME:Res_R", "Value:=", "6.2mm"))))
