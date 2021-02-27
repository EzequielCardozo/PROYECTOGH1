Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ruta As String
        ruta = My.Application.Info.DirectoryPath

        Dim sonido As System.Media.SoundPlayer
        sonido = New System.Media.SoundPlayer(ruta + "\LoopyMusic.wav")

        'una manera sencilla y practica de hacer un reloj Digital
        Label1.Text = TimeOfDay

        'controlo el check si esta presionado
        If CheckBox1.Checked = True Then
            'controlo si la hora del label es igual al del textbox
            If Label1.Text = TextBox1.Text Then
                'en caso de ser correcto sueno la alarma
                sonido.Play()
            End If
        Else
            'en caso que haya sonado y por las duda que este activado
            'todavia el sonido lo apago
            sonido.Stop()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = TimeOfDay
    End Sub
End Class
