
Partial Class Account_Default
    Inherits System.Web.UI.Page

    Private Sub choosesignup_Click(sender As Object, e As EventArgs) Handles choosesignup.Click
        Response.ReDirect("SignUp.aspx")
    End Sub

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        Dim A As Integer = 0
        If accountbox.Text = "" Then
            accounterrormessage.Text = "此欄必填"
            A = 1
        Else
            accounterrormessage.Text = ""
        End If
        If passwordbox.Text = "" Then
            passworderrormessage.Text = "此欄必填"
            A = 1
        Else
            passworderrormessage.Text = ""
        End If
        If A = 1 Then
            Exit Sub
        End If
        Dim setting As ConnectionStringSettings
        setting = ConfigurationManager.ConnectionStrings("CM_SQL")
        Dim MyCon As New SqlConnection(setting.ConnectionString)
        MyCon.Open()

        Dim MySQL As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        MySQL = "select * from Class_Manager where ID = @account "
        MySQL = MySQL + " and  password =@password"
        cmd = New SqlCommand(MySQL, MyCon)
        cmd.Parameters.Add("@account", SqlDbType.Char, 30).Value = accountbox.Text
        cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = passwordbox.Text

        dr = cmd.ExecuteReader()

        If dr.Read() Then
            Session("ID") = dr("ID")
            Session("au4a83") = dr("password")
            Session("Class") = dr("Class")
            Session("School") = dr("School")
            Dim functionallows = New String() {"Lunch", "Lunchedit", "Exam", "Examedit", "Register", "Registeredit", "Accountedit"}
            For Each functionallow In functionallows
                Session(functionallow) = dr(functionallow)
            Next
            dr.Close()
            Response.Redirect("User.aspx")
        Else
            dr.Close()
            passworderrormessage.Text = "密碼錯誤"
        End If
        MyCon.Close()
    End Sub
End Class

