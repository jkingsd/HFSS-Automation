
   Dim oAnsoftApp

   Dim oDesktop

   Dim oProject

   Dim oDesign

   Dim oEditor

   Dim oModule

   Set oAnsoftApp = CreateObject("AnsoftHfss.HfssScriptInterface")

   Set oDesktop = oAnsoftApp.GetAppDesktop()

   set oProject = oDesktop.GetActiveProject

   set oDesign = oProject.GetActiveDesign()

   Dim oFS,ofile,x,y,z,path,range

   Dim arr2,del_f,freq,cfreq,val,temp,stn,stw,i,line

   path = inputbox("Input the file name" &chr(13) & _
   "Note: If you do not specify a path the file will " & _
   "be placed in the script directory", _
   "File","C:\djing\HFSS.txt",50,50)
   If path <>"" then
Set oFS = CreateObject("Scripting.FileSystemObject")

Set ofile = oFS.CreateTextFile (path)

line = "Freq" & chr(9) & "RE(S11)" & chr(9) & "IMG(S11)"

ofile.WriteLine line

msgbox("For the following input make sure it matches " & _
"the frequencies defined in your sweep")
range = inputbox("Input the range of frequencies in GHz " & _
"and number of points",_
"Frequency","8,12,10",50,50)
oDesign.AddOutputVariable "re_S", "re(S(port1,port1))"

oDesign.AddOutputVariable "im_S", "im(S(port1,port1))"

arr = split (range, ",")

arr(0) = Trim(arr(0))

arr(1) = Trim(arr(1))

arr(2) = Trim(arr(2))

if cint(arr(2)) <> 1 then

del_f = (arr(1)-arr(0))/(arr(2)-1) 

else

del_f = 0

end if

temp = InputBox("Input the Setup and Sweep number to use:"_
& chr(13) & "(e.g. input 1,2 for Setup1 and Sweep2)", _
"Solution Data","1,1",50,50)
arr2 = split(temp,",")
stn = arr2(0)
swn = arr2(1)

stn = Trim(stn)

swn = Trim(swn)


for i=1 to arr(2) step 1

freq = arr(0) + (cint(i)-1)*del_f

x=freq

cfreq="Freq='" & freq & "Ghz'"
val = oDesign.GetOutputVariableValue("re_S","Setup" & _
stn & " :Sweep" & swn,cfreq, "")
y = val
val = oDesign.GetOutputVariableValue("im_S","Setup" & _
stn & " : Sweep" & swn,cfreq, "")
z = val
line = x & chr(9) & y & chr(9) & z
ofile.WriteLine line
Next
oDesign.DeleteOutputVariable "re_S"
oDesign.DeleteOutputVariable "im_S"
ofile.close
   End if

 

