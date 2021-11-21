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
oEditor.Copy Array("NAME:Selections", "Selections:=", "Rx1_2Iris")
oEditor.Paste
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", "Rx1_2Iris1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "Rx2_5Iris"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx2_5Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:Position", "X:=", "0mm", "Y:=","-Rx2_5Wid/2", "Z:=", "0mm"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx2_5Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:YSize", "Value:=", "Rx2_5Wid"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx2_5Iris:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "Rx2_5Ang"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx2_5Iris:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "Rx2X", "Y:=", "Rx2Y", "Z:=", "0mm"))))
oEditor.Copy Array("NAME:Selections", "Selections:=", "Rx1_2Iris")
oEditor.Paste
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", "Rx1_2Iris1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "Rx3_4Iris"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx3_4Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:Position", "X:=", "0mm", "Y:=","-Rx3_4Wid/2", "Z:=", "0mm"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx3_4Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:YSize", "Value:=", "Rx3_4Wid"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx3_4Iris:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "Rx3_4Ang"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx3_4Iris:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "Rx3X", "Y:=", "Rx3Y", "Z:=", "0mm"))))
oEditor.Copy Array("NAME:Selections", "Selections:=", "Rx1_2Iris")
oEditor.Paste
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", "Rx1_2Iris1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "Rx3_5Iris"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx3_5Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:Position", "X:=", "0mm", "Y:=","-Rx3_5Wid/2", "Z:=", "0mm"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx3_5Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:YSize", "Value:=", "Rx3_5Wid"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx3_5Iris:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "Rx3_5Ang"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx3_5Iris:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "Rx3X", "Y:=", "Rx3Y", "Z:=", "0mm"))))
oEditor.Copy Array("NAME:Selections", "Selections:=", "Rx1_2Iris")
oEditor.Paste
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", "Rx1_2Iris1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "Rx4_5Iris"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx4_5Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:Position", "X:=", "0mm", "Y:=","-Rx4_5Wid/2", "Z:=", "0mm"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx4_5Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:YSize", "Value:=", "Rx4_5Wid"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx4_5Iris:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "Rx4_5Ang"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx4_5Iris:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "Rx4X", "Y:=", "Rx4Y", "Z:=", "0mm"))))
oEditor.Copy Array("NAME:Selections", "Selections:=", "Rx1_2Iris")
oEditor.Paste
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", "Rx1_2Iris1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "Rx5_6Iris"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx5_6Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:Position", "X:=", "0mm", "Y:=","-Rx5_6Wid/2", "Z:=", "0mm"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx5_6Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:YSize", "Value:=", "Rx5_6Wid"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx5_6Iris:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "Rx5_6Ang"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx5_6Iris:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "Rx5X", "Y:=", "Rx5Y", "Z:=", "0mm"))))
oEditor.Copy Array("NAME:Selections", "Selections:=", "Rx1_2Iris")
oEditor.Paste
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", "Rx1_2Iris1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "Rx6_7Iris"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx6_7Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:Position", "X:=", "0mm", "Y:=","-Rx6_7Wid/2", "Z:=", "0mm"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx6_7Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:YSize", "Value:=", "Rx6_7Wid"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx6_7Iris:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "Rx6_7Ang"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx6_7Iris:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "Rx6X", "Y:=", "Rx6Y", "Z:=", "0mm"))))
oEditor.Copy Array("NAME:Selections", "Selections:=", "Rx1_2Iris")
oEditor.Paste
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", "Rx1_2Iris1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "Rx6_8Iris"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx6_8Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:Position", "X:=", "0mm", "Y:=","-Rx6_8Wid/2", "Z:=", "0mm"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx6_8Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:YSize", "Value:=", "Rx6_8Wid"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx6_8Iris:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "Rx6_8Ang"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx6_8Iris:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "Rx6X", "Y:=", "Rx6Y", "Z:=", "0mm"))))
oEditor.Copy Array("NAME:Selections", "Selections:=", "Rx1_2Iris")
oEditor.Paste
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DAttributeTab", Array("NAME:PropServers", "Rx1_2Iris1"), Array("NAME:ChangedProps", Array("NAME:Name", "Value:=", "Rx7_8Iris"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx7_8Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:Position", "X:=", "0mm", "Y:=","-Rx7_8Wid/2", "Z:=", "0mm"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx7_8Iris:CreateBox:1"), Array("NAME:ChangedProps", Array("NAME:YSize", "Value:=", "Rx7_8Wid"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx7_8Iris:Rotate:1"), Array("NAME:ChangedProps", Array("NAME:Angle", "Value:=", "Rx7_8Ang"))))
oEditor.ChangeProperty Array("NAME:AllTabs", Array("NAME:Geometry3DCmdTab", Array("NAME:PropServers", "Rx7_8Iris:Move:1"), Array("NAME:ChangedProps", Array("NAME:Move Vector", "X:=", "Rx7X", "Y:=", "Rx7Y", "Z:=", "0mm"))))
