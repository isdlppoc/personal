Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'check if a simular file doesnt exists so you can create a new file and deletes the file if it exists
        If File.Exists("C:\pathtoyourfile\yourfilename.txt") Then
            File.Delete("C:\pathtoyourfile\yourfilename.txt")
        End If

        'Type this before your download or hhtps request
        'ByPass SSL Certificate Validation Checking
        System.Net.ServicePointManager.ServerCertificateValidationCallback =
  Function(se As Object,
  cert As System.Security.Cryptography.X509Certificates.X509Certificate,
  chain As System.Security.Cryptography.X509Certificates.X509Chain,
  sslerror As System.Net.Security.SslPolicyErrors) True

        'Call web application/web service with HTTPS URL here
        '=========================================================================================
        'ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications
        Try
            My.Computer.Network.DownloadFile("https://176.53.78.22/filenameonserveryouwanttodownload", "C:\pathtoyourfile\yourfilename.txt", "Yourusername", "yourpassword")
            WebBrowser1.Refresh()
        Catch ex As Exception
            MessageBox.Show("message saying something didnt work")
            'exit sub if it worked
            Exit Sub
        End Try
        MessageBox.Show(" message saying it worked")
        '=========================================================================================
        'Restore SSL Certificate Validation Checking
        System.Net.ServicePointManager.ServerCertificateValidationCallback = Nothing
    End Sub