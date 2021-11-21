' ----------------------------------------------
' Script Recorded by Ansoft HFSS Version 13.0.2
' 9:56:58 AM  May 16, 2012
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
Set oProject = oDesktop.SetActiveProject("Project1")
oProject.Save
oProject.AnalyzeAll
