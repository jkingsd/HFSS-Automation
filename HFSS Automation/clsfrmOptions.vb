Imports System.Windows.Forms
Imports System
Imports System.IO
Imports System.Xml

Public Class clsfrmOptions

    '' All option variables
    'Dim mintLoopLimit As Double
    'Dim mdblTargetError As Double
    'Dim mdblDefaultWeightFactor As Double
    'Dim mdblDefaultEqualRippleWeightFactor As Double
    'Dim mintYINPort As Integer
    'Dim mblnAlwaysPD As Boolean
    'Dim mblnALwaysChkErr As Boolean
    '' - End of all options variables.

    Private mfrmHFSSAutomation As HFSSAutomation

    ''' <summary>
    ''' Give access to the parent form.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property HFSSAutomationForm As HFSSAutomation
        Set(ByVal value As HFSSAutomation)
            mfrmHFSSAutomation = value
        End Set
        Get
            Return mfrmHFSSAutomation
        End Get
    End Property


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        With HFSSAutomationForm
            .DefaultDirectory = txtDefaultDirectory.Text
        End With

        Dim sConfigFile As String
        Dim sErrMsg As String = ""
        Try
            sConfigFile = My.Application.Info.DirectoryPath & "\" & HFSSAutomationForm.sConfigFileName
            If Not My.Computer.FileSystem.FileExists(sConfigFile) Then
                ' Create XmlWriterSettings.
                Dim Xmlsettings As XmlWriterSettings = New XmlWriterSettings()
                Xmlsettings.Indent = True

                ' Create config file.
                Using writer As XmlWriter = XmlWriter.Create(sConfigFile, Xmlsettings)
                End Using
            End If
            If HFSSAutomationForm.SaveConfituration(sConfigFile, sErrMsg) = False Then
                Throw (New Exception(sErrMsg))
            Else
                ' Successful in saving configuration file. Do nothing. 
            End If
        Catch
            MsgBox(Err.Description, vbOKOnly)
        End Try
        HFSSAutomationForm.Enabled = True
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        HFSSAutomationForm.Enabled = True
        Me.Close()
    End Sub

    Public Sub New(ByVal Value As HFSSAutomation)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HFSSAutomationForm = Value
        HFSSAutomationForm.Enabled = False
        Me.Text = "Options: Saved in [AutoHFSS.ini] file."
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub btnSelectDefaultDirectory_Click(sender As Object, e As EventArgs) Handles btnSelectDefaultDirectory.Click
        Try
            FolderBrowserDialog1.SelectedPath = txtDefaultDirectory.Text
            Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()

            If (result = DialogResult.OK) Then
                txtDefaultDirectory.Text = FolderBrowserDialog1.SelectedPath
            Else
                ' do nothing
            End If
        Catch ex As Exception
            ' do nothing
        End Try
    End Sub
End Class
