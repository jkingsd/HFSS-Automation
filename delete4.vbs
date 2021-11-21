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
Set oProject = oDesktop.SetActiveProject("Project1")
oProject.Save
Set oDesign = oProject.SetActiveDesign("2 Res Hex Ellipse Cap Coupling")
oDesign.AnalyzeAll
Set oModule = oDesign.GetModule("Solutions")
oModule.ExportEigenmodes "Setup1 : LastAdaptive",  _
  "Angle_L=" & Chr(39) & "30deg" & Chr(39) & " Angle_S=" & Chr(39) & "30deg" & Chr(39) & "" & _ 
  " AWSH_R1_X=" & Chr(39) & "93.09mm" & Chr(39) & " AWSH_R1_Y=" & Chr(39) & "10.2" & _ 
  "7mm" & Chr(39) & " AWSH_R3_X=" & Chr(39) & "119.57mm" & Chr(39) & " AWSH_R3_Y=" & _ 
  "" & Chr(39) & "29.77mm" & Chr(39) & " BroadsideWidth=" & Chr(39) & "10mm" & Chr(39) & "" & _ 
  " CapXCplH=" & Chr(39) & "1.95mm" & Chr(39) & " CapxCplLen=" & Chr(39) & "12mm" & Chr(39) & "" & _ 
  " CapXCplR=" & Chr(39) & "4mm" & Chr(39) & " CapXCplZ=" & Chr(39) & "0mm" & Chr(39) & "" & _ 
  " Cav_H=" & Chr(39) & "35mm" & Chr(39) & " Cav_R=" & Chr(39) & "15.5mm" & Chr(39) & "" & _ 
  " CavW=" & Chr(39) & "31mm" & Chr(39) & " Circle_R=" & Chr(39) & "9mm" & Chr(39) & "" & _ 
  " ClipThickness=" & Chr(39) & "0.5mm" & Chr(39) & " ComCav_H=" & Chr(39) & "32m" & _ 
  "m" & Chr(39) & " Delta=" & Chr(39) & "0mm" & Chr(39) & " ElevatorHeight=" & Chr(39) & "" & _ 
  "4mm" & Chr(39) & " ElevatorWidth=" & Chr(39) & "15.5mm" & Chr(39) & " Ellipse_" & _ 
  "Angle=" & Chr(39) & "15deg" & Chr(39) & " Ellipse_Ratio=" & Chr(39) & "0.95" & Chr(39) & "" & _ 
  " Ellipse_Thk=" & Chr(39) & "4mm" & Chr(39) & " IRI=" & Chr(39) & "13mm" & Chr(39) & "" & _ 
  " iTol=" & Chr(39) & "0" & Chr(39) & " iTolerance=" & Chr(39) & "0mm" & Chr(39) & "" & _ 
  " LBIris1_4Ht=" & Chr(39) & "16mm" & Chr(39) & " Major_R=" & Chr(39) & "0.00922" & _ 
  "773628531829" & Chr(39) & " Major_R2=" & Chr(39) & "8.97773628531829mm" & Chr(39) & "" & _ 
  " Move_UP=" & Chr(39) & "0" & Chr(39) & " Res_Scw_H=" & Chr(39) & "2mm" & Chr(39) & "" & _ 
  " Res_Scw_R=" & Chr(39) & "2.5mm" & Chr(39) & " ResD=" & Chr(39) & "6mm" & Chr(39) & "" & _ 
  " ResH=" & Chr(39) & "30mm" & Chr(39) & " ResXTol=" & Chr(39) & "0mm" & Chr(39) & "" & _ 
  " Ridge_AWSH_13_H=" & Chr(39) & "23.5mm" & Chr(39) & " Ridge_H=" & Chr(39) & "3" & _ 
  "mm" & Chr(39) & " Ring_W=" & Chr(39) & "8mm" & Chr(39) & " Scw_L=" & Chr(39) & "" & _ 
  "9mm" & Chr(39) & " TX_Raise_H=" & Chr(39) & "5mm" & Chr(39) & " TXR10_X=" & Chr(39) & "" & _ 
  "0" & Chr(39) & " TXR10_Y=" & Chr(39) & "0" & Chr(39) & " TXR12_X=" & Chr(39) & "" & _ 
  "35mm" & Chr(39) & " WalT=" & Chr(39) & "5mm" & Chr(39) & " XCpl_Rdg_H=" & Chr(39) & "" & _ 
  "11mm" & Chr(39) & "", "C:\Users\djing\Desktop\ddd.eig"
