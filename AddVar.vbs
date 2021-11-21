' ----------------------------------------------
' Script Recorded by Ansoft HFSS Version 13.0.2
' 12:09:22 PM  Jun 22, 2012
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
oDesign.ChangeProperty Array("NAME:AllTabs", Array("NAME:LocalVariableTab", Array("NAME:PropServers", "LocalVariables"), Array("NAME:NewProps", Array("NAME:NewVar", "PropType:=", "VariableProp", "UserDef:=", true, "Value:=", "0mm"))))
