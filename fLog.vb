Public Class fLogin
    Dim _cConn As cConn
    Dim _clogin As cLogin

    Private Sub fLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = New Icon(respath & "dmpicon.ico")

        ThemeResolutionService.ApplyThemeToControlTree(Me, My.Settings.theme)
        RadMessageBox.SetThemeName(My.Settings.theme)

        If Me.ThemeName.ToString = "VisualStudio2012Dark" Then
            btnSetting.Image = Image.FromFile(respath & "sd.png")
        Else
            btnSetting.Image = Image.FromFile(respath & "sl.png")
        End If

        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        _cConn = New cConn

        _cConn.opendb()
        If _conn Then
            RadMessageBox.Show("Connect")
        End If

    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        fSetting.ShowDialog(Me)
    End Sub
End Class
