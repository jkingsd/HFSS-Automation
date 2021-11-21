' ----------------------------------------------
' Script Recorded by Ansoft HFSS Version 13.0.2
' 3:12:48 PM  Apr 01, 2012
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
Set oDesign = oProject.SetActiveDesign("HFSSDesign1")
Set oEditor = oDesign.SetActiveEditor("3D Modeler")
oEditor.Unite Array("NAME:Selections", "Selections:=",  _
  "IRIS_RB_23,IRIS_RB_34,IRIS_RB_45,RB_Cav2,RB_Cav3,RB_Cav4,RB_Cav5"), Array("NAME:UniteParameters", "KeepOriginals:=",  _
  false)
Set oModule = oDesign.GetModule("AnalysisSetup")
oModule.EditFrequencySweep "Setup1", "Sweep", Array("NAME:Sweep", "IsEnabled:=",  _
  true, "SetupType:=", "LinearStep", "StartValue:=", "1.65GHz", "StopValue:=",  _
  "2.3GHz", "StepSize:=", "0.1GHz", "Type:=", "Interpolating", "SaveFields:=",  _
  false, "InterpTolerance:=", 0.5, "InterpMaxSolns:=", 250, "InterpMinSolns:=",  _
  0, "InterpMinSubranges:=", 1, "ExtrapToDC:=", false, "InterpUseS:=", true, "InterpUsePortImped:=",  _
  false, "InterpUsePropConst:=", true, "UseDerivativeConvergence:=", false, "InterpDerivTolerance:=",  _
  0.2, "UseFullBasis:=", true)
oProject.Save
oDesign.AnalyzeAll
oModule.EditSetup "Setup1", Array("NAME:Setup1", "Frequency:=", "2.5GHz", "PortsOnly:=",  _
  false, "MaxDeltaS:=", 0.02, "UseMatrixConv:=", false, "MaximumPasses:=", 20, "MinimumPasses:=",  _
  2, "MinimumConvergedPasses:=", 2, "PercentRefinement:=", 30, "IsEnabled:=",  _
  true, "BasisOrder:=", 1, "UseIterativeSolver:=", false, "DoLambdaRefine:=",  _
  true, "DoMaterialLambda:=", true, "SetLambdaTarget:=", false, "Target:=",  _
  0.3333, "UseMaxTetIncrease:=", false, "PortAccuracy:=", 2, "UseABCOnPort:=",  _
  false, "SetPortMinMaxTri:=", false, "EnableSolverDomains:=", false, "ThermalFeedback:=",  _
  false, "NoAdditionalRefinementOnImport:=", false)
oProject.Save
oDesign.AnalyzeAll
Set oModule = oDesign.GetModule("Solutions")
oModule.ExportNetworkData  _
  "Cav_H=" & Chr(39) & "35mm" & Chr(39) & " Cav_R=" & Chr(39) & "18mm" & Chr(39) & "" & _ 
  " IRIS_RB_23_W=" & Chr(39) & "24mm" & Chr(39) & " IRIS_RB_34_W=" & Chr(39) & "2" & _ 
  "4mm" & Chr(39) & " IRIS_RB_45_W=" & Chr(39) & "24mm" & Chr(39) & " RB_Res2_H=" & Chr(39) & "" & _ 
  "30mm" & Chr(39) & " RB_Res2_X=" & Chr(39) & "20mm" & Chr(39) & " RB_Res2_Y=" & Chr(39) & "" & _ 
  "20mm" & Chr(39) & " RB_Res3_H=" & Chr(39) & "29mm" & Chr(39) & " RB_Res3_X=" & Chr(39) & "" & _ 
  "30mm" & Chr(39) & " RB_Res3_Y=" & Chr(39) & "50mm" & Chr(39) & " RB_Res4_H=" & Chr(39) & "" & _ 
  "31mm" & Chr(39) & " RB_Res4_X=" & Chr(39) & "60mm" & Chr(39) & " RB_Res4_Y=" & Chr(39) & "" & _ 
  "60mm" & Chr(39) & " RB_Res5_H=" & Chr(39) & "30mm" & Chr(39) & " RB_Res5_X=" & Chr(39) & "" & _ 
  "80mm" & Chr(39) & " RB_Res5_Y=" & Chr(39) & "40mm" & Chr(39) & " Res_R=" & Chr(39) & "" & _ 
  "6mm" & Chr(39) & "", Array("Setup1:Sweep"), 3,  _
  "C:/Users/djing/Desktop/Project1_HFSSDesign1.s4p", Array(1650000000,  _
  1750000000, 1850000000, 1950000000, 2050000000, 2150000000, 2250000000), true,  _
  50, "S", -1, 0, 15
oModule.ExportNetworkData  _
  "Cav_H=" & Chr(39) & "35mm" & Chr(39) & " Cav_R=" & Chr(39) & "18mm" & Chr(39) & "" & _ 
  " IRIS_RB_23_W=" & Chr(39) & "24mm" & Chr(39) & " IRIS_RB_34_W=" & Chr(39) & "2" & _ 
  "4mm" & Chr(39) & " IRIS_RB_45_W=" & Chr(39) & "24mm" & Chr(39) & " RB_Res2_H=" & Chr(39) & "" & _ 
  "30mm" & Chr(39) & " RB_Res2_X=" & Chr(39) & "20mm" & Chr(39) & " RB_Res2_Y=" & Chr(39) & "" & _ 
  "20mm" & Chr(39) & " RB_Res3_H=" & Chr(39) & "29mm" & Chr(39) & " RB_Res3_X=" & Chr(39) & "" & _ 
  "30mm" & Chr(39) & " RB_Res3_Y=" & Chr(39) & "50mm" & Chr(39) & " RB_Res4_H=" & Chr(39) & "" & _ 
  "31mm" & Chr(39) & " RB_Res4_X=" & Chr(39) & "60mm" & Chr(39) & " RB_Res4_Y=" & Chr(39) & "" & _ 
  "60mm" & Chr(39) & " RB_Res5_H=" & Chr(39) & "30mm" & Chr(39) & " RB_Res5_X=" & Chr(39) & "" & _ 
  "80mm" & Chr(39) & " RB_Res5_Y=" & Chr(39) & "40mm" & Chr(39) & " Res_R=" & Chr(39) & "" & _ 
  "6mm" & Chr(39) & "", Array("Setup1:Sweep"), 3, "C:/Users/djing/Desktop/xxx.s4p", Array( _
  1650000000, 1750000000, 1850000000, 1950000000, 2050000000, 2150000000,  _
  2250000000), true, 50, "S", -1, 0, 15
