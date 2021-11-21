' ----------------------------------------------
' Script Recorded by Ansoft HFSS Version 13.0.2
' 12:57:40 PM  May 12, 2012
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
Set oProject = oDesktop.SetActiveProject("prj143WIP")
oProject.Save
Set oDesign = oProject.SetActiveDesign("Diplexer_62")
oDesktop.Sleep 5000
oDesign.AnalyzeAll

