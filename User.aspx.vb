Imports System.IO
Partial Class Account_Default
    Inherits System.Web.UI.Page
    Sub Show_Calendar(caltype As String)
        Dim caldate(6, 7) As Integer
        Dim setting As ConnectionStringSettings
        setting = ConfigurationManager.ConnectionStrings("CM_SQL")
        Dim MyCon As New SqlConnection(setting.ConnectionString)
        MyCon.Open()
        For ww As Integer = 1 To 6
            For dd As Integer = 1 To 7
                Dim calcmdd As String = "select Date from Calendar where Year=" & Session("NowYear") & " And Month=" & Session("NowMonth") & " And Week=" & ww & " And Day=" & dd & " order by Date"
                Dim calcmd As New SqlCommand(calcmdd, MyCon)
                Dim reader2 As SqlDataReader = calcmd.ExecuteReader()
                Dim tabelcell As TableCell = DirectCast(Me.FindControl(caltype & "w" & ww.ToString() & "d" & dd.ToString()), TableCell)
                If reader2.Read() Then
                    caldate(ww, dd) = Int(reader2("Date"))
                    Dim datelab As New Label()
                    datelab.Text = Int(reader2("Date"))
                    tabelcell.Text = caldate(ww, dd)
                Else
                    tabelcell.Text = ""
                End If
                calcmd.Cancel()
                reader2.Close()
            Next
        Next
        MyCon.Close()
        Dim dfmonth As Integer = Session("nowmonth")
        Dim monthtext As Label = DirectCast(Me.FindControl(caltype & "monthtext"), Label)
        monthtext.Text = Session("nowyear") & "年" & Session("nowmonth") & "月"
    End Sub

    Sub Show_Lunch_Order_On_Calendar(caltype As String)
        Try
            Dim ii As Integer = 0
            Dim menuclass As Integer = Session("Class")
            Dim setting2 As ConnectionStringSettings
            setting2 = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon2 As New SqlConnection(setting2.ConnectionString)
            MyCon2.Open()
            While True
                Dim C As String = "select * from Menu where Year=" & Session("NowYear") & " And Month=" & Session("NowMonth") & " And Class=" & menuclass & " And School=" & "'" & Session("School") & "'" & " order by Date offset " & ii & " row fetch next 1 rows only"
                ii += 1
                Dim cmd2 As New SqlCommand(C, MyCon2)
                Dim reader2 As SqlDataReader = cmd2.ExecuteReader()
                If reader2.Read() Then
                    For ww As Integer = 1 To 6
                        For dd As Integer = 1 To 7
                            Dim tabelcell As TableCell = DirectCast(Me.FindControl(caltype & "w" & ww.ToString() & "d" & dd.ToString()), TableCell)
                            If tabelcell.Text.ToString() = reader2("Date").ToString() Then
                                Dim button As New Button()
                                Dim callabel As New Label()
                                button.Text = "訂餐"
                                callabel.Text = tabelcell.Text
                                button.ID = "LunchButtonY" & reader2("Year") & "M" & reader2("Month") & "D" & reader2("Date") & "E"
                                button.CssClass = "CalendarEvent"
                                button.BorderColor = Drawing.Color.DodgerBlue
                                button.BackColor = Drawing.Color.White
                                'mycss.Attributes.Add("href", "succeed.css")
                                AddHandler button.Click, AddressOf Lunch_Order_button_Click
                                tabelcell.Controls.Add(callabel)
                                tabelcell.Controls.Add(New LiteralControl("<br>"))
                                tabelcell.Controls.Add(button)
                            End If
                        Next
                    Next
                    cmd2.Cancel()
                    reader2.Close()
                Else
                    cmd2.Cancel()
                    reader2.Close()
                    MyCon2.Close()
                    Exit While
                End If
            End While
        Catch
        End Try
    End Sub
    Sub Show_Lunch_Order_Ans_On_Calendar(caltype As String)
        Try
            Dim ii As Integer = 0
            Dim menuclass As Integer = Session("Class")
            Dim setting2 As ConnectionStringSettings
            setting2 = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon2 As New SqlConnection(setting2.ConnectionString)
            MyCon2.Open()
            While True
                Dim C As String = "select * from Menu where Year=" & Session("NowYear") & " And Month=" & Session("NowMonth") & " And Class=" & menuclass & " And School=" & "'" & Session("School") & "'" & " order by Date offset " & ii & " row fetch next 1 rows only"
                ii += 1
                Dim cmd2 As New SqlCommand(C, MyCon2)
                Dim reader2 As SqlDataReader = cmd2.ExecuteReader()
                If reader2.Read() Then
                    For ww As Integer = 1 To 6
                        For dd As Integer = 1 To 7
                            Dim tabelcell As TableCell = DirectCast(Me.FindControl(caltype & "w" & ww.ToString() & "d" & dd.ToString()), TableCell)
                            If tabelcell.Text.ToString() = reader2("Date").ToString() Then
                                Dim button As New Button()
                                Dim callabel As New Label()
                                button.Text = "查看訂單"
                                callabel.Text = tabelcell.Text
                                button.ID = "LunchAnsButtonY" & reader2("Year") & "M" & reader2("Month") & "D" & reader2("Date") & "E"
                                button.CssClass = "CalendarEvent"
                                'mycss.Attributes.Add("href", "succeed.css")
                                AddHandler button.Click, AddressOf Lunch_Order_Ans_button_Click
                                tabelcell.Controls.Add(callabel)
                                tabelcell.Controls.Add(New LiteralControl("<br>"))
                                tabelcell.Controls.Add(button)
                            End If
                        Next
                    Next
                    cmd2.Cancel()
                    reader2.Close()
                Else
                    cmd2.Cancel()
                    reader2.Close()
                    MyCon2.Close()
                    Exit While
                End If
            End While
        Catch
        End Try
    End Sub

    Sub Show_Exam_On_Calendar(caltype As String)
        Try
            Dim ii As Integer = 0
            Dim examclass As String = Session("Class")
            Dim setting2 As ConnectionStringSettings
            setting2 = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon2 As New SqlConnection(setting2.ConnectionString)
            MyCon2.Open()
            Dim checkyear As Integer = 0
            Dim checkmonth As Integer = 0
            Dim checkdate As Integer = 0
            Dim isfind As Integer = 0
            Dim mypanel As New Panel()
            mypanel.CssClass = "mypanel"
            While True
                Dim C As String = "select * from Exam where Year=" & Session("NowYear") & " And Month=" & Session("NowMonth") & " And Class=" & examclass & " And School=" & "'" & Session("School") & "'" & " order by Date, Code offset " & ii & " row fetch next 1 rows only"
                ii += 1
                Dim cmd2 As New SqlCommand(C, MyCon2)
                Dim reader2 As SqlDataReader = cmd2.ExecuteReader()
                If reader2.Read() Then
                    For ww As Integer = 1 To 6
                        For dd As Integer = 1 To 7
                            Dim tabelcell As TableCell = DirectCast(Me.FindControl(caltype & "w" & ww.ToString() & "d" & dd.ToString()), TableCell)
                            If tabelcell.Text.ToString() = reader2("Date").ToString() Then
                                Dim button As New Button()
                                button.Text = reader2("Name")
                                button.ID = "examY" & reader2("Year") & "M" & reader2("Month") & "D" & reader2("Date") & "C" & reader2("Code") & "E" & ii
                                button.CssClass = "CalendarEventSmall"
                                AddHandler button.Click, AddressOf Exam_button_Click
                                If checkyear = reader2("Year") And checkmonth = reader2("Month") And checkdate = reader2("Date") Then
                                    Dim mypanel2 As Panel = DirectCast(Me.FindControl("PanelY" & reader2("Year") & "M" & reader2("Month") & "D" & reader2("Date") & "E"), Panel)
                                    mypanel2.Controls.Add(New LiteralControl("<br/>"))
                                    mypanel2.Controls.Add(button)
                                    isfind = 1
                                    Exit For
                                Else
                                    Dim callabel As New Label()
                                    callabel.Text = tabelcell.Text
                                    tabelcell.Controls.Add(callabel)
                                    tabelcell.Controls.Add(New LiteralControl("<br/>"))
                                    mypanel = New Panel()
                                    mypanel.ID = "PanelY" & reader2("Year") & "M" & reader2("Month") & "D" & reader2("Date") & "E"
                                    mypanel.Height = 60%
                                    mypanel.ScrollBars = ScrollBars.Vertical
                                    tabelcell.Controls.Add(mypanel)
                                    mypanel.Controls.Add(button)
                                    checkyear = reader2("Year")
                                    checkmonth = reader2("Month")
                                    checkdate = reader2("Date")
                                    isfind = 1
                                    Exit For
                                End If
                            End If
                        Next
                        If isfind = 1 Then
                            isfind = 0
                            Exit For
                        End If
                    Next
                    cmd2.Cancel()
                    reader2.Close()
                Else
                    cmd2.Cancel()
                    reader2.Close()
                    Exit While ' Exit loop when there are no more exam records to process
                End If
            End While
            MyCon2.Close() ' Close the database connection after processing all exam records
        Catch
        End Try
    End Sub

    Sub Show_Examedit_On_Calendar(caltype As String)
        Try
            Dim ii As Integer = 0
            Dim examclass As Integer = Session("Class")
            Dim setting2 As ConnectionStringSettings
            setting2 = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon2 As New SqlConnection(setting2.ConnectionString)
            MyCon2.Open()
            Dim checkyear As Integer = 0
            Dim checkmonth As Integer = 0
            Dim checkdate As Integer = 0
            Dim isfind As Integer = 0
            Dim mypanel As New Panel()
            mypanel.CssClass = "mypanel"
            While True
                Dim C As String = "select * from Exam where Year=" & Session("NowYear") & " And Month=" & Session("NowMonth") & " And Class=" & "'" & Session("Class") & "'" & " And Sender=" & "'" & Session("ID") & "'" & " And School=" & "'" & Session("School") & "'" & " order by Date, Code offset " & ii & " row fetch next 1 rows only"
                ii += 1
                Dim cmd2 As New SqlCommand(C, MyCon2)
                Dim reader2 As SqlDataReader = cmd2.ExecuteReader()
                If reader2.Read() Then
                    For ww As Integer = 1 To 6
                        For dd As Integer = 1 To 7
                            Dim tabelcell As TableCell = DirectCast(Me.FindControl(caltype & "w" & ww.ToString() & "d" & dd.ToString()), TableCell)
                            If tabelcell.Text.ToString() = reader2("Date").ToString() Then
                                Dim button As New Button()
                                button.Text = reader2("Name")
                                button.ID = "ExamY" & reader2("Year") & "M" & reader2("Month") & "D" & reader2("Date") & "T" & reader2("Name") & "E" & ii
                                button.CssClass = "CalendarEventSmall"
                                AddHandler button.Click, AddressOf Exam_button_Click
                                If checkyear = reader2("Year") And checkmonth = reader2("Month") And checkdate = reader2("Date") Then
                                    Dim mypanel2 As Panel = DirectCast(Me.FindControl("Panel2Y" & reader2("Year") & "M" & reader2("Month") & "D" & reader2("Date") & "E"), Panel)
                                    mypanel2.Controls.Add(New LiteralControl("<br/>"))
                                    mypanel2.Controls.Add(button)
                                    isfind = 1
                                    Exit For
                                Else
                                    Dim callabel As New Label()
                                    callabel.Text = tabelcell.Text
                                    tabelcell.Controls.Add(callabel)
                                    tabelcell.Controls.Add(New LiteralControl("<br/>"))
                                    mypanel = New Panel()
                                    mypanel.ID = "Panel2Y" & reader2("Year") & "M" & reader2("Month") & "D" & reader2("Date") & "E"
                                    mypanel.Height = 60%
                                    mypanel.ScrollBars = ScrollBars.Vertical
                                    tabelcell.Controls.Add(mypanel)
                                    mypanel.Controls.Add(button)
                                    checkyear = reader2("Year")
                                    checkmonth = reader2("Month")
                                    checkdate = reader2("Date")
                                    isfind = 1
                                    Exit For
                                End If
                            End If
                        Next
                        If isfind = 1 Then
                            isfind = 0
                            Exit For
                        End If
                    Next
                    cmd2.Cancel()
                    reader2.Close()
                Else
                    cmd2.Cancel()
                    reader2.Close()
                    Exit While ' Exit loop when there are no more exam records to process
                End If
            End While
            MyCon2.Close() ' Close the database connection after processing all exam records
        Catch
        End Try
    End Sub
    Sub Set_All_Invisible()
        Try
            hometool.Visible = False
            lunchcal.Visible = False
            lunchans.Visible = False
            resistdiv.Visible = False
            resiseditdiv.Visible = False
            neworder.Visible = False
            LunchEditdiv.Visible = False
            ViewLunchOrder.Visible = False
            orderans.Visible = False
            Examsch.Visible = False
            Examschedit.Visible = False
            Examwindow.Visible = False
            Accountedittool.Visible = False
            Settingtool.Visible = False
        Catch
        End Try
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Session("au4a83") = "" Or Session("ID") = "" Then
                Response.Redirect("Default.aspx")
            Else
                If Not Page.IsPostBack Then
                    '初始化
                    Session("NowYear") = Year(Now())
                    Session("NowMonth") = Month(Now())
                    '只展示home
                    Set_All_Invisible()
                    hometool.Visible = True
                    'Show_Class()
                End If
                'do this everytime
                My_Control()
                Dim functionallows = New String() {"Lunch", "Lunchedit", "Exam", "Examedit", "Register", "Registeredit", "Accountedit"}
                For Each functionallow In functionallows
                    Dim myfunction As Panel = DirectCast(Me.FindControl("Panel" & functionallow.ToString()), Panel)
                    If Session(functionallow) = 1 Then
                        myfunction.Visible = True
                    Else
                        myfunction.Visible = False
                    End If
                Next
            End If
        Catch
        End Try
    End Sub

    Sub My_Control()
        Try
            If lunchcal.Visible Then
                Show_Calendar("L")
                Show_Lunch_Order_On_Calendar("L")
            End If
            If ViewLunchOrder.Visible Then
                Show_Calendar("V")
                Show_Lunch_Order_Ans_On_Calendar("V")
            End If
            If Examsch.Visible Then
                Show_Calendar("E")
                Show_Exam_On_Calendar("E")
            End If
            If Examschedit.Visible Then
                Show_Calendar("A")
                Show_Examedit_On_Calendar("A")
            End If
            If classeditpanel.Visible Then
                Panel14.Controls.Clear()
                Show_Class()
            End If
            If Panel15.Visible Then
                Panel18.Controls.Clear()
                Panel19.Controls.Clear()
                Panel20.Controls.Clear()
                Show_Class_Members(Session("Classchange"))
            End If
        Catch
        End Try
    End Sub
    Private Sub Nextmonth_Click(sender As Object, e As ImageClickEventArgs) Handles nextmonth.Click
        Try
            Session("NowMonth") += 1
            If Session("NowMonth") > 12 Then
                Session("NowMonth") = 1
                Session("NowYear") += 1
            End If
            My_Control()
        Catch
        End Try
    End Sub

    Private Sub Lastmonth_Click(sender As Object, e As ImageClickEventArgs) Handles lastmonth.Click
        Try
            Session("NowMonth") -= 1
            If Session("Nowmonth") < 1 Then
                Session("NowMonth") = 12
                Session("NowYear") -= 1
                If Session("NowYear") < 2023 Then
                    Session("NowYear") = 2023
                    Session("NowMonth") = 1
                End If
            End If
            My_Control()
        Catch
        End Try
    End Sub

    Private Sub VLastmonth_Click(sender As Object, e As ImageClickEventArgs) Handles VLastmonth.Click
        Try
            Session("NowMonth") -= 1
            If Session("Nowmonth") < 1 Then
                Session("NowMonth") = 12
                Session("NowYear") -= 1
                If Session("NowYear") < 2023 Then
                    Session("NowYear") = 2023
                    Session("NowMonth") = 1
                End If
            End If
            My_Control()
        Catch
        End Try
    End Sub

    Private Sub VNextmonth_Click(sender As Object, e As ImageClickEventArgs) Handles VNextmonth.Click
        Try
            Session("NowMonth") += 1
            If Session("NowMonth") > 12 Then
                Session("NowMonth") = 1
                Session("NowYear") += 1
            End If
            My_Control()
        Catch
        End Try
    End Sub
    Private Sub ELastmonth_Click(sender As Object, e As ImageClickEventArgs) Handles ELastmonth.Click
        Try
            Session("NowMonth") -= 1
            If Session("Nowmonth") < 1 Then
                Session("NowMonth") = 12
                Session("NowYear") -= 1
                If Session("NowYear") < 2023 Then
                    Session("NowYear") = 2023
                    Session("NowMonth") = 1
                End If
            End If
            My_Control()
        Catch
        End Try
    End Sub
    Private Sub ENextmonth_Click(sender As Object, e As ImageClickEventArgs) Handles ENextmonth.Click
        Try
            Session("NowMonth") += 1
            If Session("NowMonth") > 12 Then
                Session("NowMonth") = 1
                Session("NowYear") += 1
            End If
            My_Control()
        Catch
        End Try
    End Sub
    Private Sub ALastmonth_Click(sender As Object, e As ImageClickEventArgs) Handles ALastmonth.Click
        Try
            Session("NowMonth") -= 1
            If Session("Nowmonth") < 1 Then
                Session("NowMonth") = 12
                Session("NowYear") -= 1
                If Session("NowYear") < 2023 Then
                    Session("NowYear") = 2023
                    Session("NowMonth") = 1
                End If
            End If
            My_Control()
        Catch
        End Try
    End Sub
    Private Sub ANextmonth_Click(sender As Object, e As ImageClickEventArgs) Handles ANextmonth.Click
        Try
            Session("NowMonth") += 1
            If Session("NowMonth") > 12 Then
                Session("NowMonth") = 1
                Session("NowYear") += 1
            End If
            My_Control()
        Catch
        End Try
    End Sub
    Private Sub Lunch_Click(sender As Object, e As ImageClickEventArgs) Handles Lunch.Click
        Try
            Set_All_Invisible()
            lunchcal.Visible = True
            My_Control()
        Catch
        End Try
    End Sub


    Private Sub Register_Click(sender As Object, e As ImageClickEventArgs) Handles Register.Click
        Try
            Set_All_Invisible()
            resistdiv.Visible = True
        Catch
        End Try
    End Sub

    Private Sub Registeredit_Click(sender As Object, e As ImageClickEventArgs) Handles Registeredit.Click
        Try
            Set_All_Invisible()
            resiseditdiv.Visible = True
            newscore.Visible = False
            editscore.Visible = False
            neworder.Visible = False
        Catch
        End Try
    End Sub

    Private Sub Addnewscorecal_Click(sender As Object, e As EventArgs) Handles Addnewscorecal.Click
        Try
            newscore.Visible = True
            editscore.Visible = False
        Catch
        End Try
    End Sub

    Private Sub Addnewscorecalbtn_Click(sender As Object, e As EventArgs) Handles Addnewscorecalbtn.Click
        Try
            Dim myclasss As Integer = Session("Class")
            If scorenametextbox.Text = "" Then
                addnewscorecalerror2.Text = "名稱不可空白"
            Else
                Try
                    Dim setting As ConnectionStringSettings
                    setting = ConfigurationManager.ConnectionStrings("CM_SQL")
                    Dim MyCon As New SqlConnection(setting.ConnectionString)
                    Dim C As String = "Select top 1 id from Score where Class=" & myclasss & " And School=" & "'" & Session("School") & "'" & " order by id desc"
                    MyCon.Open()
                    Dim cmd2 As New SqlCommand(C, MyCon)
                    Dim reader As SqlDataReader = cmd2.ExecuteReader()
                    Dim scoreid As Integer = 0
                    If reader.Read() Then
                        scoreid = Int(reader("id")) + 1
                    Else
                        scoreid = 1
                    End If
                    cmd2.Cancel()
                    reader.Close()
                    Dim B As String = "Select * from Lunch where ID = @account"
                    Dim D As String = "Insert Into Score (scorename,class, ID) Values ("
                    D = D & "'" & scorenametextbox.Text & "','" & myclasss & "','" & scoreid & "')"
                    Dim cmd As New SqlCommand(D, MyCon)
                    cmd.ExecuteNonQuery()
                    MyCon.Close()
                    newscore.Visible = False
                Catch
                    addnewscorecalerror.Text = "錯誤"
                End Try
            End If
        Catch
        End Try
    End Sub

    Private Sub Lunchedit_Click(sender As Object, e As ImageClickEventArgs) Handles Lunchedit.Click
        Try
            Set_All_Invisible()
            LunchEditdiv.Visible = True
            My_Control()
        Catch
        End Try
    End Sub

    Private Sub menubutton_Click(sender As Object, e As EventArgs) Handles menubutton.Click
        Try
            If menuyear.Text = "" Or menumonth.Text = "" Or menudate.Text = "" Or twomenu.Text = "" Or threemenu.Text = "" Or fourmenu.Text = "" Or fivemenu.Text = "" Or sevenmenu.Text = "" Then
                newordererrortext.Text = "所有欄位皆須填寫"

            Else
                Dim menuclass As Integer = Session("Class")
                Dim setting As ConnectionStringSettings
                setting = ConfigurationManager.ConnectionStrings("CM_SQL")
                Dim MyCon As New SqlConnection(setting.ConnectionString)
                Dim C As String = "select * from Menu where Year=" & menuyear.Text & " And Month=" & menumonth.Text & " And Date=" & menudate.Text & " And Class=" & menuclass & " And School=" & "'" & Session("School") & "'"
                MyCon.Open()
                Dim cmd2 As New SqlCommand(C, MyCon)
                Dim reader As SqlDataReader = cmd2.ExecuteReader()
                If reader.Read() Then
                    cmd2.Cancel()
                    reader.Close()
                    Dim editmenu As String = "Update Menu Set TwoMenu=" & twomenu.Text & ", ThreeMenu=" & threemenu.Text & ", FourMenu=" & fourmenu.Text & ", FiveMenu=" & fivemenu.Text & ", SevenMenu=" & sevenmenu.Text & " Where Year=" & menuyear.Text & " And Month=" & menumonth.Text & " And Date=" & menudate.Text & menuclass & " And School=" & "'" & Session("School") & "'"
                    Dim menueditcmd As New SqlCommand(editmenu, MyCon)
                    menueditcmd.ExecuteNonQuery()
                    menueditcmd.Cancel()
                    MyCon.Close()
                Else
                    cmd2.Cancel()
                    reader.Close()
                    Dim newmenu As String = "Insert Into Menu (Year,Month,Date,Class,TwoMenu,ThreeMenu,FourMenu,FiveMenu,SevenMenu,School) Values ("
                    newmenu = newmenu & "'" & menuyear.Text & "','" & menumonth.Text & "','" & menudate.Text & "','" & menuclass & "','" & twomenu.Text & "','" & threemenu.Text & "','" & fourmenu.Text & "','" & fivemenu.Text & "','" & sevenmenu.Text & "','" & Session("School") & "')"
                    Dim menucmd As New SqlCommand(newmenu, MyCon)
                    menucmd.ExecuteNonQuery()
                    menucmd.Cancel()
                    MyCon.Close()
                End If
                Set_All_Invisible()
                LunchEditdiv.Visible = True
            End If
        Catch
        End Try
    End Sub

    Private Sub Lunch_Order_button_Click(sender As Button, e As EventArgs)
        Try
            label17.Text = ""
            button2.BackColor = Drawing.Color.White
            button3.BackColor = Drawing.Color.White
            button4.BackColor = Drawing.Color.White
            button5.BackColor = Drawing.Color.White
            button7.BackColor = Drawing.Color.White
            lunchans.Visible = True
            Dim button As Button = CType(sender, Button)
            Session("lyy") = button.ID.Substring(button.ID.IndexOf("Y") + 1, button.ID.IndexOf("M") - button.ID.IndexOf("Y") - 1)
            Session("lmm") = button.ID.Substring(button.ID.IndexOf("M") + 1, button.ID.IndexOf("D") - button.ID.IndexOf("M") - 1)
            Session("ldd") = button.ID.Substring(button.ID.IndexOf("D") + 1, button.ID.IndexOf("E") - button.ID.IndexOf("D") - 1)
            Dim menuclass As Integer = Session("Class")
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("cm_sql")
            Dim mycon As New SqlConnection(setting.ConnectionString)
            Dim c As String = "select * from Menu where year=" & Session("lyy") & " and month=" & Session("lmm") & " and date=" & Session("ldd") & " and class=" & menuclass & " And School=" & "'" & Session("School") & "'"
            mycon.Open()
            Dim cmd2 As New SqlCommand(c, mycon)
            Dim reader As SqlDataReader = cmd2.ExecuteReader()
            If reader.Read() Then
                label1.Text = Session("lyy") & "年" & Session("lmm") & "月" & Session("ldd") & "日"
                button2.Text = "2.正園:" & reader("TwoMenu")
                button3.Text = "3.大稻理:" & reader("ThreeMenu")
                button4.Text = "4.御饌坊:" & reader("FourMenu")
                button5.Text = "5.太師傅:" & reader("FiveMenu")
                button7.Text = "7.吉樂米:" & reader("SevenMenu")
                cmd2.Cancel()
                reader.Close()
                Dim A As String = "select * from [Order] where ID=" & "'" & Session("ID") & "'" & " And Class=" & menuclass & " And year=" & Session("lyy") & " and month=" & Session("lmm") & " and date=" & Session("ldd") & " And School=" & "'" & Session("School") & "'"
                Dim cmd As New SqlCommand(A, mycon)
                Dim reader2 As SqlDataReader = cmd.ExecuteReader()
                If reader2.Read() Then
                    Dim choosenbutton As Button = DirectCast(Me.FindControl("Button" & reader2("Lunch")), Button)
                    choosenbutton.BackColor = Drawing.Color.DodgerBlue
                End If
                cmd.Cancel()
                reader2.Close()
            End If
            cmd2.Cancel()
            reader.Close()
            mycon.Close()
        Catch
        End Try
    End Sub

    Private Sub Lunch_Ans_Click(sender As Object, e As EventArgs) Handles button2.Click, button3.Click, button4.Click, button5.Click, button7.Click
        Try
            Dim currentDate As DateTime = Date.Now
            Dim scheduledDate As DateTime = New DateTime(Session("lyy"), Session("lmm"), Session("ldd"), 11, 0, 0)
            If currentDate > scheduledDate Then
                label17.Text = "超過當天11點後無法再更改訂餐"
            Else
                button2.BackColor = Drawing.Color.White
                button3.BackColor = Drawing.Color.White
                button4.BackColor = Drawing.Color.White
                button5.BackColor = Drawing.Color.White
                button7.BackColor = Drawing.Color.White
                Dim button As Button = CType(sender, Button)
                button.BackColor = Drawing.Color.DodgerBlue
                Dim myclasss As Integer = Session("Class")
                Dim myid As String = Session("ID")
                Dim setting As ConnectionStringSettings
                setting = ConfigurationManager.ConnectionStrings("CM_SQL")
                Dim MyCon As New SqlConnection(setting.ConnectionString)
                Dim checkdate As String = "Select * From [Order] Where ID=" & "'" & myid & "'" & " And Class=" & myclasss & " And Year=" & Session("lyy") & " And Month=" & Session("lmm") & " And Date=" & Session("ldd") & " And School=" & "'" & Session("School") & "'"
                MyCon.Open()
                Dim cmd2 As New SqlCommand(checkdate, MyCon)
                Dim reader As SqlDataReader = cmd2.ExecuteReader()
                If reader.Read() Then
                    cmd2.Cancel()
                    reader.Close()
                    Dim SaveOrder As String = "Update [Order] Set Lunch=" & button.ID.Substring(button.ID.IndexOf("n") + 1, 1) & " Where ID=" & "'" & myid & "'" & " And Class=" & myclasss & " And Year=" & Session("lyy") & " And Month=" & Session("lmm") & " And Date=" & Session("ldd") & " And School='" & Session("School") & "'"
                    Dim cmd As New SqlCommand(SaveOrder, MyCon)
                    cmd.ExecuteNonQuery()
                Else
                    cmd2.Cancel()
                    reader.Close()
                    Dim SaveOrder As String = "Insert Into [Order] (ID,Class,Year,Month,Date,Lunch,School) Values (" & "'" & myid & "'" & "," & myclasss & "," & Session("lyy") & "," & Session("lmm") & "," & Session("ldd") & "," & button.ID.Substring(button.ID.IndexOf("n") + 1, 1) & ",'" & Session("School") & "')"
                    Dim cmd As New SqlCommand(SaveOrder, MyCon)
                    cmd.ExecuteNonQuery()
                End If
                cmd2.Cancel()
                reader.Close()
                MyCon.Close()
            End If
        Catch
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Set_All_Invisible()
            ViewLunchOrder.Visible = True
            My_Control()
        Catch
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Set_All_Invisible()
            neworder.Visible = True
            My_Control()
        Catch
        End Try
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            lunchans.Visible = False
            Show_Calendar("L")
            Show_Lunch_Order_On_Calendar("L")
        Catch
        End Try
    End Sub
    Private Sub Lunch_Order_Ans_button_Click(sender As Button, e As EventArgs)
        Try
            orderans.Visible = True
            Dim button As Button = CType(sender, Button)
            Session("Vyy") = button.ID.Substring(button.ID.IndexOf("Y") + 1, button.ID.IndexOf("M") - button.ID.IndexOf("Y") - 1)
            Session("Vmm") = button.ID.Substring(button.ID.IndexOf("M") + 1, button.ID.IndexOf("D") - button.ID.IndexOf("M") - 1)
            Session("Vdd") = button.ID.Substring(button.ID.IndexOf("D") + 1, button.ID.IndexOf("E") - button.ID.IndexOf("D") - 1)
            lunchansdate.Text = Session("Vyy") & "年" & Session("Vmm") & "月" & Session("Vdd") & "日訂單"
            Dim menuclass As Integer = Session("Class")
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("cm_sql")
            Dim mycon As New SqlConnection(setting.ConnectionString)
            mycon.Open()
            Dim A As String = "select count(*) from [Order] where Year=" & Session("Vyy") & " and Month=" & Session("Vmm") & " and Date=" & Session("Vdd") & " and class=" & menuclass & " and Lunch=2" & " And School=" & "'" & Session("School") & "'"
            Dim B As String = "select count(*) from [Order] where Year=" & Session("Vyy") & " and Month=" & Session("Vmm") & " and Date=" & Session("Vdd") & " and class=" & menuclass & " and Lunch=3" & " And School=" & "'" & Session("School") & "'"
            Dim C As String = "select count(*) from [Order] where Year=" & Session("Vyy") & " and Month=" & Session("Vmm") & " and Date=" & Session("Vdd") & " and class=" & menuclass & " and Lunch=4" & " And School=" & "'" & Session("School") & "'"
            Dim D As String = "select count(*) from [Order] where Year=" & Session("Vyy") & " and Month=" & Session("Vmm") & " and Date=" & Session("Vdd") & " and class=" & menuclass & " and Lunch=5" & " And School=" & "'" & Session("School") & "'"
            Dim F As String = "select count(*) from [Order] where Year=" & Session("Vyy") & " and Month=" & Session("Vmm") & " and Date=" & Session("Vdd") & " and class=" & menuclass & " and Lunch=7" & " And School=" & "'" & Session("School") & "'"
            Dim cmdA As New SqlCommand(A, mycon)
            count2orderlable.Text = "正園數量:" & CInt(cmdA.ExecuteScalar())
            cmdA.Cancel()
            Dim cmdB As New SqlCommand(B, mycon)
            count3orderlable.Text = "大稻理數量:" & CInt(cmdB.ExecuteScalar())
            cmdB.Cancel()
            Dim cmdC As New SqlCommand(C, mycon)
            count4orderlable.Text = "御饌坊數量:" & CInt(cmdC.ExecuteScalar())
            cmdC.Cancel()
            Dim cmdD As New SqlCommand(D, mycon)
            count5orderlable.Text = "太師傅數量:" & CInt(cmdD.ExecuteScalar())
            cmdD.Cancel()
            Dim cmdF As New SqlCommand(F, mycon)
            count7orderlable.Text = "吉樂米數量:" & CInt(cmdF.ExecuteScalar())
            cmdF.Cancel()
            'Dim G As String = "SELECT ID,Lunch FROM [Order] WHERE Year=" & Session("Vyy") & " and Month=" & Session("Vmm") & " and Date=" & Session("Vdd") & " and class=" & menuclass
            'Dim cmdG As New SqlCommand(G, mycon)
            'Dim readerG As SqlDataReader = cmdG.ExecuteReader()
            'lunchansGridView.DataSource = readerG
            'lunchansGridView.DataBind()
            'readerG.Close()
            'cmdG.Cancel()
            mycon.Close()
        Catch
        End Try
    End Sub

    Private Sub Exam_button_Click(sender As Button, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Session("Eyy") = button.ID.Substring(button.ID.IndexOf("Y") + 1, button.ID.IndexOf("M") - button.ID.IndexOf("Y") - 1)
        Session("Emm") = button.ID.Substring(button.ID.IndexOf("M") + 1, button.ID.IndexOf("D") - button.ID.IndexOf("M") - 1)
        Session("Edd") = button.ID.Substring(button.ID.IndexOf("D") + 1, button.ID.IndexOf("C") - button.ID.IndexOf("D") - 1)
        Session("Ecc") = button.ID.Substring(button.ID.IndexOf("C") + 1, button.ID.IndexOf("E") - button.ID.IndexOf("C") - 1)
        Examwindow.Visible = True
        Dim setting As ConnectionStringSettings
        setting = ConfigurationManager.ConnectionStrings("CM_SQL")
        Dim MyCon As New SqlConnection(setting.ConnectionString)
        MyCon.Open()
        Dim readexamif As String = "select * from Exam where Year=" & Session("Eyy") & " And Month=" & Session("Emm") & " And Date=" & Session("Edd") & " And Code=" & Session("Ecc") & " And School=" & "'" & Session("School") & "'"
        Dim cmd As New SqlCommand(readexamif, MyCon)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Examwindowtitle.Text = reader("Name")
            Examshowsubject.Text = "科目:" & reader("Subject")
            Examshowdate.Text = "日期:" & reader("Year") & "年" & reader("Month") & "月" & reader("Date") & "日"
            Examshowrange.Text = "範圍:" & reader("Range")
            Examshowoi.Text = "備註:" & reader("OtherInformation")
        End If
        reader.Close()
        cmd.Cancel()
        MyCon.Close()
        'Show_Exam_On_Calendar("E")
    End Sub

    Private Sub Home_Click(sender As Object, e As ImageClickEventArgs) Handles Home.Click
        Try
            Set_All_Invisible()
        Catch
        End Try
    End Sub

    Private Sub Setting_Click(sender As Object, e As ImageClickEventArgs) Handles Setting.Click
        'Try
        Set_All_Invisible()
        Settingtool.Visible = True
        SettingPanelEditPIWindow.Visible = False
        ShowPI()
        'Catch
        'End Try
    End Sub

    Sub ShowPI()
        Dim setting As ConnectionStringSettings
        setting = ConfigurationManager.ConnectionStrings("CM_SQL")
        Dim MyCon As New SqlConnection(setting.ConnectionString)
        MyCon.Open()
        Dim C As String = "Select * From [Class_Manager] Where ID=" & "'" & Session("ID") & "'"
        Dim cmd As New SqlCommand(C, MyCon)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.Read() Then
            Label62.Text = reader("Name")
            Label63.Text = reader("ID")
            Dim doctype As String = reader("Headshot").TrimEnd()
            If doctype = ".jpg" Or doctype = ".png" Or doctype = ".gif" Or doctype = ".jpeg" Then
                SettingImageHeadshot.ImageUrl = "~/picture/" & Session("ID") & "headshot" & reader("Headshot")
            Else
                SettingImageHeadshot.ImageUrl = "~/picture/user.png"
            End If
        End If
        cmd.Cancel()
        reader.Close()
        MyCon.Close()
    End Sub

    Private Sub Exam_Click(sender As Object, e As ImageClickEventArgs) Handles Exam.Click
        Set_All_Invisible()
        Examsch.Visible = True
        My_Control()
    End Sub

    Private Sub Examedit_Click(sender As Object, e As ImageClickEventArgs) Handles Examedit.Click
        Set_All_Invisible()
        Examschedit.Visible = True
        newexamdiv.Visible = False
        newexambutton.Visible = True
        My_Control()
    End Sub

    Private Sub Buttonclose_Click(sender As Object, e As EventArgs) Handles Buttonclose.Click
        Try
            orderans.Visible = False
            My_Control()
        Catch
        End Try
    End Sub

    Private Sub newexambutton_Click(sender As Object, e As EventArgs) Handles newexambutton.Click
        newexamdiv.Visible = True
        newexambutton.Visible = False
        My_Control()
    End Sub

    Private Sub newexamsentbutton_Click(sender As Object, e As EventArgs) Handles newexamsentbutton.Click
        Dim examclass As Integer = Session("Class")
        Dim examsub As String = "資訊"
        Dim setting As ConnectionStringSettings
        setting = ConfigurationManager.ConnectionStrings("CM_SQL")
        Dim MyCon As New SqlConnection(setting.ConnectionString)
        MyCon.Open()
        Dim checkcode As String = "select * from Exam where Year=" & Session("NowYear") & " And Month=" & Session("NowMonth") & " And Date=" & newexamdate.Text & " And Class=" & examclass & " And School=" & "'" & Session("School") & "'" & " order by Code desc offset 0 row fetch next 1 rows only"
        Dim cmd2 As New SqlCommand(checkcode, MyCon)
        Dim reader2 As SqlDataReader = cmd2.ExecuteReader()
        Dim code As Integer = 1
        If reader2.Read() Then
            code = Int(reader2("Code")) + 1
        End If
        Dim C As String = "Insert Into Exam (Code,Class,Subject,Name,Sender,Year,Month,Date,Range,OtherInformation,School) Values (" & code & "," & examclass & "," & "'" & examsub & "'" & "," & "'" & newexamname.Text & "'" & "," & "'" & Session("ID") & "'" & "," & newexamyear.Text & "," & newexammonth.Text & "," & newexamdate.Text & "," & "'" & newexamrange.Text & "'" & "," & "'" & newexaminformation.Text & "','" & Session("School") & "')"
        Dim cmd As New SqlCommand(C, MyCon)
        cmd2.Cancel()
        reader2.Close()
        cmd.ExecuteNonQuery()
        cmd.Cancel()
        MyCon.Close()
        newexamdiv.Visible = False
        newexambutton.Visible = True
        'Show_Examedit_On_Calendar("A")
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        Dim currentDate As DateTime = Date.Now
        Dim scheduledDate As DateTime = New DateTime(Session("lyy"), Session("lmm"), Session("ldd"), 11, 0, 0)
        If currentDate > scheduledDate Then
            label17.Text = "超過當天11點後無法再更改訂餐"
        Else
            button2.BackColor = Drawing.Color.White
            button3.BackColor = Drawing.Color.White
            button4.BackColor = Drawing.Color.White
            button5.BackColor = Drawing.Color.White
            button7.BackColor = Drawing.Color.White
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon As New SqlConnection(setting.ConnectionString)
            Dim deleteorder As String = "DELETE FROM [Order] WHERE ID=" & "'" & Session("ID") & "'" & " and Year=" & Session("lyy") & " and Month=" & Session("lmm") & " and Date=" & Session("ldd")
            MyCon.Open()
            Dim cmd As New SqlCommand(deleteorder, MyCon)
            cmd.ExecuteNonQuery()
            cmd.Cancel()
            MyCon.Close()
        End If
    End Sub

    Private Sub Examwindowclosebutton_Click(sender As Object, e As EventArgs) Handles Examwindowclosebutton.Click
        Examwindow.Visible = False
    End Sub

    Private Sub Accountedit_Click(sender As Object, e As ImageClickEventArgs) Handles Accountedit.Click
        Set_All_Invisible()
        Accountedittool.Visible = True
        accounteditoptions.Visible = True
        accounteditpanel.Visible = False
        passwordeditpanel.Visible = False
        classeditpanel.Visible = False
        accesseditpanel.Visible = False
    End Sub

    Private Sub editaccount_Click(sender As Object, e As ImageClickEventArgs) Handles editaccount.Click
        accounteditoptions.Visible = False
        accounteditpanel.Visible = True
        wordpanel1.Visible = False
        wordpanel2.Visible = False
        wordpanel3.Visible = False
        wordpanel4.Visible = False
        wordpanel5.Visible = False
        wordpanel6.Visible = False
        wordpanel7.Visible = False
        wordpanel8.Visible = False
        wordpanel9.Visible = False
        wordpanel10.Visible = False
        Label38.Text = ""
        Label36.Text = ""
        Label91.Text = ""
        Label93.Text = ""
        Session("fixxxtimes") = 0
        Session("floattimes") = 0
        Session("totaltimes") = 0
        Session("fixxxfloat") = "0000000000"
    End Sub
    Private Sub editpassword_Click(sender As Object, e As ImageClickEventArgs) Handles editpassword.Click
        accounteditoptions.Visible = False
        passwordeditpanel.Visible = True
    End Sub
    Private Sub editaccess_Click(sender As Object, e As ImageClickEventArgs) Handles editaccess.Click
        accounteditoptions.Visible = False
        accesseditpanel.Visible = True
        Panel13.Visible = False
    End Sub
    Private Sub editclass_Click(sender As Object, e As ImageClickEventArgs) Handles editclass.Click
        accounteditoptions.Visible = False
        newclasswindow.Visible = False
        Panel15.Visible = False
        classeditpanel.Visible = True
        changememberpanel.Visible = False
        DeleteMemberPanel.Visible = False
        My_Control()
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim account As String = TextBox1.Text
        Dim newpassword As String = TextBox2.Text
        Dim checkpassowrd As String = TextBox3.Text
        If newpassword = checkpassowrd Then
            Label26.Text = ""
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon As New SqlConnection(setting.ConnectionString)
            MyCon.Open()
            Dim readaccount As String = "select * from Class_Manager where ID=" & "'" & account & "'"
            Dim cmd As New SqlCommand(readaccount, MyCon)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                Label25.Text = ""
                cmd.Cancel()
                reader.Close()
                Dim changepass As String = "UPDATE Class_Manager SET password=" & "'" & newpassword & "'" & " WHERE ID=" & "'" & account & "'"
                Dim cmd2 As New SqlCommand(changepass, MyCon)
                cmd2.ExecuteNonQuery()
                cmd2.Cancel()
            Else
                Label25.Text = "查無此帳號"
                cmd.Cancel()
                reader.Close()
            End If
            MyCon.Close()
        Else
            Label26.Text = "與新密碼不符"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click '固定字串
        'Session("accountwordscount") += 1 '動態控件的總數
        'Session("accountwords") = Session("accountwords") & "fixxx" '紀錄為固定字串、遞增數字的順序
        'newaccountformcon()
        Dim fixfloat As String = Session("fixxxfloat")
        For i As Integer = 0 To 4
            Dim posit As Integer = i * 2 + 1
            Dim isfull As Integer = 0
            For i2 As Integer = posit To 10
                Dim full As String = Mid(fixfloat, i2, 1)
                If full = "0" Then
                Else
                    isfull = 1
                    Exit For
                End If
            Next
            If isfull = 0 Then
                Dim slice1 As String = Mid(fixfloat, 1, posit - 1)
                Dim slice2 As String = Mid(fixfloat, posit + 1, 10 - posit)
                Session("fixxxfloat") = slice1 & "1" & slice2
                Exit For
            End If
        Next
        newaccountformcon()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click '遞增數字
        'Session("accountwordscount") += 1 '動態控件的總數
        'Session("accountwords") = Session("accountwords") & "float" '紀錄為固定字串、遞增數字的順序
        'newaccountformcon()
        Dim fixfloat As String = Session("fixxxfloat")
        For i As Integer = 0 To 4
            Dim posit As Integer = i * 2 + 2
            Dim isfull As Integer = 0
            For i2 As Integer = posit To 10
                Dim full As String = Mid(fixfloat, i2, 1)
                If full = "0" Then
                Else
                    isfull = 1
                    Exit For
                End If
            Next
            If isfull = 0 Then
                Dim slice1 As String = Mid(fixfloat, 1, posit - 1)
                Dim slice2 As String = Mid(fixfloat, posit + 1, 10 - posit)
                Session("fixxxfloat") = slice1 & "1" & slice2
                Exit For
            End If
        Next
        newaccountformcon()
    End Sub

    Sub newaccountformcon() '顯示動態控件
        If Mid(Session("fixxxfloat"), 1, 1) = "1" Then
            Label48.Visible = False
        Else
            Label49.Visible = False
        End If
        For i As Integer = 1 To 10
            If Mid(Session("fixxxfloat"), i, 1) = "1" Then
                Dim panel As Panel = DirectCast(Me.FindControl("wordpanel" & i), Panel)
                panel.Visible = True
            End If
        Next
        'If accounteditpanel.Visible = True Then
        '    For i As Integer = 0 To Session("accountwordscount") - 1
        '        Dim inputtype As String = Mid(Session("accountwords"), i * 5 + 1, 5) '每五個字取出字串
        '        If inputtype = "fixxx" Then
        '            Dim textbox As New TextBox()
        '            textbox.CssClass = "accounttextbox"
        '            textbox.ID = "accounttextboxTfix" & i
        '            Dim panel As Panel = DirectCast(Me.FindControl("newaccountform"), Panel)
        '            If i = 0 Then
        '            Else
        '                panel.Controls.Add(New LiteralControl("+"))
        '            End If
        '            panel.Controls.Add(textbox)
        '        ElseIf inputtype = "float" Then
        '            Dim textbox1 As New TextBox()
        '            textbox1.CssClass = "accounttextbox"
        '            textbox1.ID = "accounttextboxTfloatform" & i
        '            Dim textbox2 As New TextBox()
        '            textbox2.CssClass = "accounttextbox"
        '            textbox2.ID = "accounttextboxTfloatto" & i
        '            Dim panel As Panel = DirectCast(Me.FindControl("newaccountform"), Panel)
        '            If i = 0 Then
        '            Else
        '                panel.Controls.Add(New LiteralControl("+"))
        '            End If
        '            panel.Controls.Add(New LiteralControl("從"))
        '            panel.Controls.Add(textbox1)
        '            panel.Controls.Add(New LiteralControl("到"))
        '            panel.Controls.Add(textbox2)
        '        End If
        '    Next
        'End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click '送出按鈕
        Label36.Text = ""
        Label38.Text = ""
        Label91.Text = ""
        Label93.Text = ""
        Dim iserror As Boolean = False
        For i As Integer = 1 To 10 '959~1005 排除未正確填寫的情況
            Dim checkfull As String = Mid(Session("fixxxfloat"), i, 1)
            If checkfull = "1" Then
                If i Mod 2 = 0 Then
                    Dim checktextbox1 As TextBox = DirectCast(Me.FindControl("floatwordtextboxfrom" & i), TextBox)
                    Dim checktextbox2 As TextBox = DirectCast(Me.FindControl("floatwordtextboxtooo" & i), TextBox)
                    If checktextbox1.Text = "" Or checktextbox2.Text = "" Then
                        Label38.Text = "請勿留白"
                    End If
                    Try
                        Dim test1 As Integer = Int(checktextbox1.Text)
                        Dim test2 As Integer = Int(checktextbox2.Text)
                    Catch
                        Label38.Text = "遞增內容必須為數字"
                    End Try
                Else
                    Dim checktextbox1 As TextBox = DirectCast(Me.FindControl("fixxxwordtextbox" & i), TextBox)
                    If checktextbox1.Text = "" Then
                        Label38.Text = "請勿留白"
                        iserror = True
                    End If
                End If
            End If
        Next
        If CheckBox1.Checked = True And CheckBox2.Checked = True Then
            Label36.Text = "只能選取一個"
            iserror = True
            newaccountformcon()
            Exit Sub
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            Label36.Text = "必須選取一個"
            iserror = True
            newaccountformcon()
            Exit Sub
        ElseIf CheckBox2.Checked = True And CheckBox1.Checked = False And TextBox4.Text = "" Then
            Label36.Text = "如選取「統一密碼」則必須指定密碼"
        End If
        If CheckBox7.Checked And CheckBox8.Checked Then
            Label93.Text = "只能有一種身份"
            iserror = True
        ElseIf (Not CheckBox7.Checked) And (Not CheckBox8.Checked) Then
            Label93.Text = "必須有一種身份"
            iserror = True
            'If TextBox7.Text = "" And CheckBox8.Checked Then
            '    Label91.Text = "學生帳號必須指定班級"
            'End If
        End If
        If iserror = False Then '建立帳號的字串陣列
            Dim arrlen As Integer = 1 '陣列長度(帳號總數)(固定)
            Dim newarrlen As Integer = 1  '陣列長度(帳號總數)(變動)
            For i As Integer = 1 To 10 '將所有遞增數字的數量相乘 就是帳號總數
                If i Mod 2 = 0 And Mid(Session("fixxxfloat"), i, 1) = "1" Then
                    Dim textbox1 As TextBox = DirectCast(Me.FindControl("floatwordtextboxfrom" & i), TextBox)
                    Dim textbox2 As TextBox = DirectCast(Me.FindControl("floatwordtextboxtooo" & i), TextBox)
                    arrlen *= (Int(textbox2.Text) - Int(textbox1.Text) + 1)
                    newarrlen *= (Int(textbox2.Text) - Int(textbox1.Text) + 1)
                End If
            Next
            Dim accounts(arrlen + 1) As String
            For i As Integer = 1 To 10 '新增帳號到account() 以輸入為smhs+從1到3+從1到3 為例
                Dim inputtype As String = Mid(Session("fixxxfloat"), i, 1)
                If inputtype = "1" And Not (i Mod 2 = 0) Then
                    Dim textbox1 As TextBox = DirectCast(Me.FindControl("fixxxwordtextbox" & i), TextBox)
                    For i2 As Integer = 1 To arrlen
                        accounts(i2) = accounts(i2) & textbox1.Text '將固定字串smhs加入account()中的每一項
                    Next
                End If
                If inputtype = "1" And (i Mod 2 = 0) Then
                    Dim textbox1 As TextBox = DirectCast(Me.FindControl("floatwordtextboxfrom" & i), TextBox)
                    Dim textbox2 As TextBox = DirectCast(Me.FindControl("floatwordtextboxtooo" & i), TextBox)
                    Dim currentnumber As Integer = 0
                    For i0 As Integer = 1 To arrlen / newarrlen '第一次執行一次(i0=0) 第二次執行三次(i0=0 1 2)
                        For i2 As Integer = Int(textbox1.Text) To Int(textbox2.Text) '實際加入的數字
                            For i3 As Integer = currentnumber + 1 To currentnumber + (newarrlen / (Int(textbox2.Text) - Int(textbox1.Text) + 1)) '加入的地方(account()中的第幾項)
                                accounts(i3 - Int(textbox1.Text) + 1) = accounts(i3 - Int(textbox1.Text) + 1) & i2.ToString
                                currentnumber = i3
                            Next
                        Next
                    Next
                    newarrlen = newarrlen / (Int(textbox2.Text) - Int(textbox1.Text) + 1)
                End If
            Next
            Dim lunch As Integer = 0 '權限
            Dim lunchedit As Integer = 0
            Dim exam As Integer = 0
            Dim examedit As Integer = 0
            Dim pass As String = ""
            If CheckBox3.Checked = True Then
                lunch = 1
            End If
            If CheckBox4.Checked = True Then
                lunchedit = 1
            End If
            If CheckBox5.Checked = True Then
                exam = 1
            End If
            If CheckBox6.Checked = True Then
                examedit = 1
            End If
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon As New SqlConnection(setting.ConnectionString)
            MyCon.Open()
            For i As Integer = 1 To arrlen
                If CheckBox1.Checked = True Then
                    pass = accounts(i)
                ElseIf CheckBox2.Checked = True Then
                    pass = TextBox4.Text
                End If
                Dim who As String = ""
                Dim classname As String = ""
                If CheckBox7.Checked Then
                    who = "Teacher"
                    classname = "None"
                ElseIf CheckBox8.Checked And TextBox7.Text = "" Then
                    who = "Student"
                    classname = "None"
                ElseIf CheckBox8.Checked And (Not TextBox7.Text = "") Then
                    who = "Student"
                    classname = TextBox7.Text
                Else
                    who = "None"
                    classname = "None"
                End If
                Dim B As String = "Select * From [Class] Where Class_Name=" & "'" & classname & "'" & " And Funder=" & "'" & Session("ID") & "'"
                Dim cmd3 As New SqlCommand(B, MyCon)
                Dim reader2 As SqlDataReader = cmd3.ExecuteReader
                If reader2.Read Or classname = "None" Then
                    reader2.Close()
                    cmd3.Cancel()
                    Dim checkaccount As String = "Select * From [Class_Manager] Where ID=" & "'" & accounts(i) & "'"
                    Dim cmd1 As New SqlCommand(checkaccount, MyCon)
                    Dim reader As SqlDataReader = cmd1.ExecuteReader
                    If reader.Read() Then
                        cmd1.Cancel()
                        reader.Close()
                        Dim A As String = "Update [Class_Manager] Set Password=" & "'" & pass & "'" & ",Name='default',Headshot='0',TeachClass='None',School='" & Session("ID") & "',Class=" & "'" & classname & "'" & ",Who=" & "'" & who & "'" & ",Lunch=" & lunch & ",Lunchedit=" & lunchedit & ",Exam=" & exam & ",Examedit=" & examedit & ",Register=0,Registeredit=0,Accountedit=0" & " where ID=" & "'" & accounts(i) & "'"
                        Dim cmd2 As New SqlCommand(A, MyCon)
                        cmd2.ExecuteNonQuery()
                        cmd2.Cancel()
                    Else
                        cmd1.Cancel()
                        reader.Close()
                        Dim A As String = "Insert Into [Class_Manager] (ID,Password,Name,Headshot,School,Class,Who,Lunch,Lunchedit,Exam,Examedit,Register,Registeredit,Accountedit,TeachClass) Values (" & "'" & accounts(i) & "'" & "," & "'" & pass & "'" & ",'default','0','" & Session("ID") & "','" & classname & "','" & who & "'," & lunch & "," & lunchedit & "," & exam & "," & examedit & ",0,0,0,'None')"
                        Dim cmd2 As New SqlCommand(A, MyCon)
                        cmd2.ExecuteNonQuery()
                        cmd2.Cancel()
                    End If
                Else
                    reader2.Close()
                    cmd3.Cancel()
                    Label91.Text = "查無此班級"
                End If
            Next
            MyCon.Close()
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Panel13.Visible = False
        If TextBox5.Text = "" Then
            Label45.Text = "不可為空白"
        Else
            Dim account As String = TextBox5.Text
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon As New SqlConnection(setting.ConnectionString)
            MyCon.Open()
            Dim A As String = "Select * From [Class_Manager] Where ID=" & "'" & account & "'"
            Session("accesseditaccount") = account
            Dim cmd1 As New SqlCommand(A, MyCon)
            Dim reader As SqlDataReader = cmd1.ExecuteReader
            If reader.Read() Then
                Panel13.Visible = True
                Dim functionallows = New String() {"Lunch", "Lunchedit", "Exam", "Examedit"}
                For Each functionallow In functionallows
                    If reader(functionallow) = 1 Then
                        Dim chckbox As CheckBox = DirectCast(Me.FindControl("checkbox" & functionallow), CheckBox)
                        chckbox.Checked = True
                    Else
                        Dim chckbox As CheckBox = DirectCast(Me.FindControl("checkbox" & functionallow), CheckBox)
                        chckbox.Checked = False
                    End If
                Next
                cmd1.Cancel()
                reader.Close()
            Else
                cmd1.Cancel()
                reader.Close()
                Label45.Text = "查無此帳號"
            End If
            MyCon.Close()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim lunch As Integer = 0
        Dim lunchedit As Integer = 0
        Dim exam As Integer = 0
        Dim examedit As Integer = 0
        If checkboxLunch.Checked = True Then
            lunch = 1
        End If
        If checkboxLunchedit.Checked = True Then
            lunchedit = 1
        End If
        If checkboxExam.Checked = True Then
            exam = 1
        End If
        If checkboxExamedit.Checked = True Then
            examedit = 1
        End If
        Dim setting As ConnectionStringSettings
        setting = ConfigurationManager.ConnectionStrings("CM_SQL")
        Dim MyCon As New SqlConnection(setting.ConnectionString)
        MyCon.Open()
        Dim A As String = "Update [Class_Manager] Set Lunch=" & lunch & ",Lunchedit=" & lunchedit & ",Exam=" & exam & ",Examedit=" & examedit & " where ID=" & "'" & Session("accesseditaccount") & "'"
        Dim cmd1 As New SqlCommand(A, MyCon)
        cmd1.ExecuteNonQuery()
        cmd1.Cancel()
        MyCon.Close()
        Panel13.Visible = False
    End Sub

    Private Sub SettingImgbuttonEditPassword_Click(sender As Object, e As ImageClickEventArgs) Handles SettingImgbuttonEditPassword.Click
        Label78.Text = ""
        Label79.Text = ""
        Label77.Text = ""
        Label73.Text = "更改密碼"
        Label74.Text = "舊密碼"
        Label75.Text = "新密碼"
        Label76.Text = "確認密碼"
        'SettingTextbox1.TextMode = "password"
        'SettingTextbox2.TextMode = "password"
        'SettingTextbox3.TextMode = "password"
        Label73.Visible = True
        Label74.Visible = True
        Label75.Visible = True
        Label76.Visible = True
        Label77.Visible = True
        Label78.Visible = True
        Label79.Visible = True
        SettingTextbox1.Visible = True
        SettingTextbox2.Visible = True
        SettingTextbox3.Visible = True
        SettingFileploadHeadshot.Visible = False
        Session("SettingType") = "password"
        SettingPanelEditPIWindow.Visible = True
    End Sub

    Private Sub SettingImgbuttonEditName_Click(sender As Object, e As ImageClickEventArgs) Handles SettingImgbuttonEditName.Click
        Label78.Text = ""
        Label79.Text = ""
        Label77.Text = ""
        Label73.Text = "更改姓名"
        Label74.Text = "新姓名"
        'SettingTextbox1.TextMode = "singleline"
        'SettingTextbox2.TextMode = "singleline"
        'SettingTextbox3.TextMode = "singleline"
        Label73.Visible = True
        Label74.Visible = True
        Label75.Visible = False
        Label76.Visible = False
        Label77.Visible = True
        Label78.Visible = False
        Label79.Visible = False
        SettingTextbox1.Visible = True
        SettingTextbox2.Visible = False
        SettingTextbox3.Visible = False
        SettingFileploadHeadshot.Visible = False
        Session("SettingType") = "name"
        SettingPanelEditPIWindow.Visible = True
    End Sub

    Private Sub SettingImgbuttonEditHeadshot_Click(sender As Object, e As ImageClickEventArgs) Handles SettingImgbuttonEditHeadshot.Click
        Label78.Text = ""
        Label79.Text = ""
        Label77.Text = ""
        Label73.Text = "更改大頭照"
        Label74.Text = "新大頭照"
        'SettingTextbox1.TextMode = "singleline"
        'SettingTextbox2.TextMode = "singleline"
        'SettingTextbox3.TextMode = "singleline"
        Label73.Visible = True
        Label74.Visible = True
        Label75.Visible = False
        Label76.Visible = False
        Label77.Visible = True
        Label78.Visible = False
        Label79.Visible = False
        SettingTextbox1.Visible = False
        SettingTextbox2.Visible = False
        SettingTextbox3.Visible = False
        SettingFileploadHeadshot.Visible = True
        Session("SettingType") = "headshot"
        SettingPanelEditPIWindow.Visible = True
    End Sub

    Private Sub SettingButtonEditWindowSend_Click(sender As Object, e As EventArgs) Handles SettingButtonEditWindowSend.Click
        Label78.Text = ""
        Label79.Text = ""
        Label77.Text = ""
        If Session("SettingType") = "password" Then
            Dim oldpass As String = SettingTextbox1.Text
            Dim newpass As String = SettingTextbox2.Text
            Dim checkpass As String = SettingTextbox3.Text
            Dim iserror As Integer = 0
            If newpass = "" Then
                Label78.Text = "密碼不可空白"
                iserror = 1
            End If
            If Not (newpass = checkpass) Then
                Label79.Text = "與新密碼不同"
                iserror = 1
            End If
            If iserror = 0 Then
                Dim setting As ConnectionStringSettings
                setting = ConfigurationManager.ConnectionStrings("CM_SQL")
                Dim MyCon As New SqlConnection(setting.ConnectionString)
                MyCon.Open()
                Dim A As String = "Select ID from [Class_Manager] where ID=" & "'" & Session("ID") & "'" & " And password=" & "'" & oldpass & "'"
                Dim cmd1 As New SqlCommand(A, MyCon)
                Dim reader As SqlDataReader = cmd1.ExecuteReader
                If reader.Read() Then
                    reader.Close()
                    cmd1.Cancel()
                    Dim B As String = "Update [Class_Manager] Set password=" & "'" & newpass & "'" & " where ID=" & "'" & Session("ID") & "'"
                    Dim cmd2 As New SqlCommand(B, MyCon)
                    cmd2.ExecuteNonQuery()
                    cmd2.Cancel()
                    SettingPanelEditPIWindow.Visible = False
                Else
                    reader.Close()
                    cmd1.Cancel()
                    Label77.Text = "密碼錯誤"
                End If
                MyCon.Close()
            End If
        ElseIf Session("SettingType") = "name" Then
            Label77.Text = ""
            Dim newname As String = SettingTextbox1.Text
            If newname = "" Then
                Label77.Text = "名稱不可空白"
            Else
                Dim setting As ConnectionStringSettings
                setting = ConfigurationManager.ConnectionStrings("CM_SQL")
                Dim MyCon As New SqlConnection(setting.ConnectionString)
                MyCon.Open()
                Dim A As String = "Update [Class_Manager] Set Name=" & "'" & newname & "'" & " where ID=" & "'" & Session("ID") & "'"
                Dim cmd1 As New SqlCommand(A, MyCon)
                cmd1.ExecuteNonQuery()
                cmd1.Cancel()
                MyCon.Close()
                SettingPanelEditPIWindow.Visible = False
            End If
        ElseIf Session("SettingType") = "headshot" Then
            Label77.Text = ""
            If SettingFileploadHeadshot.HasFile Then
                Dim filename As String = Path.GetFileName(SettingFileploadHeadshot.FileName)
                Dim fileExtension As String = Path.GetExtension(filename).ToLower()
                Dim allowedExtensions As String() = {".jpg", ".jpeg", ".png", ".gif"}
                If allowedExtensions.Contains(fileExtension) Then
                    Dim savePath As String = Server.MapPath("~/picture/") + (Session("ID") & "headshot" & fileExtension)
                    SettingFileploadHeadshot.SaveAs(savePath)
                    Dim setting As ConnectionStringSettings
                    setting = ConfigurationManager.ConnectionStrings("CM_SQL")
                    Dim MyCon As New SqlConnection(setting.ConnectionString)
                    MyCon.Open()
                    Dim A As String = "Update [Class_Manager] Set Headshot=" & "'" & Session("ID") & "'" & "'" & "headshot" & "'" & "'" & fileExtension & "'" & " where ID=" & "'" & Session("ID") & "'"
                    Dim cmd1 As New SqlCommand(A, MyCon)
                    cmd1.ExecuteNonQuery()
                    cmd1.Cancel()
                    MyCon.Close()
                Else
                    Label77.Text = "只允許上傳 jpg、jpeg、png、gif 文件"
                End If
            Else
                Label77.Text = "未上傳大頭照"
            End If
        End If
        ShowPI()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        newclasswindow.Visible = True
        Label84.Text = ""
        'Show_Class()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim newclassname As String = TextBox6.Text
        If newclassname = "" Then
            Label84.Text = "班級名稱不可空白"
        Else
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon As New SqlConnection(setting.ConnectionString)
            MyCon.Open()
            Dim A As String = "Select * from [Class] where Class_Name=" & "'" & newclassname & "'"
            Dim cmd1 As New SqlCommand(A, MyCon)
            Dim reader As SqlDataReader = cmd1.ExecuteReader
            If reader.Read() Then
                reader.Close()
                cmd1.Cancel()
                Label84.Text = "該班級已經存在"
            Else
                reader.Close()
                cmd1.Cancel()
                Dim B As String = "INSERT INTO [Class] (Class_Name, Funder) VALUES ('" & newclassname & "','" & Session("ID") & "')"
                Dim cmd2 As New SqlCommand(B, MyCon)
                cmd2.ExecuteNonQuery()
                cmd2.Cancel()
            End If
            MyCon.Close()
        End If
        Panel14.Controls.Clear()
        Show_Class()
        newclasswindow.Visible = False
    End Sub

    Sub Show_Class()
        Dim setting As ConnectionStringSettings
        setting = ConfigurationManager.ConnectionStrings("CM_SQL")
        Dim MyCon As New SqlConnection(setting.ConnectionString)
        MyCon.Open()
        Dim i As Integer = 0
        While True
            Dim A As String = "Select * from [Class] where Funder=" & "'" & Session("ID") & "' order by Class_Name offset " & i & " row fetch next 1 rows only"
            Dim cmd As New SqlCommand(A, MyCon)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            If reader.Read() Then
                Dim showclasspanel As New Panel
                showclasspanel.CssClass = "showclasspanel"
                Panel14.Controls.Add(showclasspanel)
                Dim showclasslabel As New Label
                showclasslabel.Text = reader("Class_Name").TrimEnd()
                showclasspanel.Controls.Add(showclasslabel)
                Dim panel2 As New Panel
                showclasspanel.Controls.Add(panel2)
                Dim button As New Button
                button.Text = "編輯班級"
                button.ID = "ClassNameis" & reader("Class_Name").TrimEnd()
                Session("Class_Name") = button.ID
                button.CssClass = "Classbutton"
                AddHandler button.Click, AddressOf Class_Button_Click
                panel2.Controls.Add(button)
                Dim button2 As New Button
                button2.Text = "刪除班級"
                button2.ID = "ClassssDeleteButton" & reader("Class_Name").TrimEnd()
                button2.CssClass = "Classbutton"
                AddHandler button2.Click, AddressOf Class_And_Member_Delete
                panel2.Controls.Add(button2)
                reader.Close()
            Else
                reader.Close()
                Exit While
            End If
            i += 1
        End While
        MyCon.Close()
    End Sub

    Sub Class_Button_Click(ByVal sender As Button, ByVal e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Dim senderclass As String = Mid(button.ID, 12, button.ID.Length - 11)
        Panel15.Visible = True
        Session("Classchange") = senderclass
        Show_Class_Members(Session("Classchange"))
    End Sub

    Sub Show_Class_Members(senderclass As String)
        Try
            Label85.Text = senderclass
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon As New SqlConnection(setting.ConnectionString)
            MyCon.Open()
            Dim A As String = "Select * from [Class_Manager] where Class=" & "'" & senderclass & "'" & " And Who='Teacher'"
            Dim cmd1 As New SqlCommand(A, MyCon)
            Dim reader1 As SqlDataReader = cmd1.ExecuteReader
            If reader1.Read Then
                Dim LeaderPanel As New Panel
                LeaderPanel.CssClass = "ShoeMemberPanel"
                Panel18.Controls.Add(LeaderPanel)
                Dim LeaderLabel As New Label
                LeaderLabel.Text = reader1("Name").TrimEnd() & "(" & reader1("ID").TrimEnd() & ")"
                LeaderPanel.Controls.Add(LeaderLabel)
            End If
            reader1.Close()
            cmd1.Cancel()
            Dim i As Integer = 0
            While True
                Dim B As String = "Select * from [Class_Manager] where Who='Teacher' order by ID offset " & i & " row fetch next 1 rows only"
                Dim cmd2 As New SqlCommand(B, MyCon)
                Dim reader2 As SqlDataReader = cmd2.ExecuteReader
                If reader2.Read Then
                    If reader2("TeachClass").Contains(senderclass.ToString) Then
                        Dim teacherpanel As New Panel
                        teacherpanel.CssClass = "ShoeMemberPanel"
                        Panel19.Controls.Add(teacherpanel)
                        Dim teacherLabel As New Label
                        teacherLabel.Text = reader2("Name") & "(" & reader2("ID") & ")"
                        teacherpanel.Controls.Add(teacherLabel)
                        Dim teacherDeletebutton As New Button
                        teacherDeletebutton.Text = "移除老師"
                        teacherDeletebutton.ID = "TeacherDeleteButton" & reader2("ID").TrimEnd()
                        teacherDeletebutton.CssClass = "DeleteTeacherPanel"
                        AddHandler teacherDeletebutton.Click, AddressOf Class_And_Member_Delete
                        teacherpanel.Controls.Add(teacherDeletebutton)
                        reader2.Close()
                        cmd2.Cancel()
                    End If
                Else
                    reader2.Close()
                    cmd2.Cancel()
                    Exit While
                End If
                reader2.Close()
                cmd2.Cancel()
                i += 1
            End While
            i = 0
            While True
                Dim B As String = "Select * from [Class_Manager] where Who='Student' And Class=" & "'" & senderclass & "'" & " order by ID offset " & i & " row fetch next 1 rows only"
                Dim cmd3 As New SqlCommand(B, MyCon)
                Dim reader3 As SqlDataReader = cmd3.ExecuteReader
                If reader3.Read Then
                    Dim studentpanel As New Panel
                    studentpanel.CssClass = "ShoeMemberPanel"
                    Panel20.Controls.Add(studentpanel)
                    Dim studentLabel As New Label
                    studentLabel.Text = reader3("Name") & "(" & reader3("ID") & ")"
                    studentpanel.Controls.Add(studentLabel)
                    Dim studentDeletebutton As New Button
                    studentDeletebutton.Text = "移除學生"
                    studentDeletebutton.ID = "StudentDeleteButton" & reader3("ID").TrimEnd()
                    studentDeletebutton.CssClass = "DeleteStudentPanel"
                    AddHandler studentDeletebutton.Click, AddressOf Class_And_Member_Delete
                    studentpanel.Controls.Add(studentDeletebutton)
                    reader3.Close()
                    cmd3.Cancel()
                Else
                    reader3.Close()
                    cmd3.Cancel()
                    Exit While
                End If
                i += 1
                reader3.Close()
                cmd3.Cancel()
            End While
            MyCon.Close()
            Panel15.Visible = True
        Catch
        End Try
    End Sub
    Private Sub Close_Panel(sender As Object, e As EventArgs) Handles closenewclasswindow.Click, closePanel15.Click, closechangememberpanel.Click, closeDeleteMemberPanel.Click
        Dim button As Button = CType(sender, Button)
        Dim closeid As String = Mid(button.ID, 6, button.ID.Length - 5)
        Dim closepanel As Panel = DirectCast(Me.FindControl(closeid), Panel)
        closepanel.Visible = False
        My_Control()
    End Sub

    Private Sub Button192021_Click(sender As Object, e As EventArgs) Handles Button19.Click, Button20.Click, Button21.Click
        Dim button As Button = CType(sender, Button)
        Dim buttonid As String = button.ID
        If buttonid = "Button19" Then
            Label97.Text = "更換導師"
            Label98.Text = "導師帳號"
            Session("MemberType") = "Teacher"
            Session("NewMemberType") = "Leader"
        ElseIf buttonid = "Button20" Then
            Label97.Text = "新增老師"
            Label98.Text = "老師帳號"
            Session("MemberType") = "Teacher"
            Session("NewMemberType") = "Teacher"
        ElseIf buttonid = "Button21" Then
            Label97.Text = "新增學生"
            Label98.Text = "學生帳號"
            Session("MemberType") = "Student"
            Session("NewMemberType") = "Student"
        End If
        changememberpanel.Visible = True
        Label99.Text = ""
        My_Control()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim userid As String = TextBox8.Text
        If userid = "" Then
            Label99.Text = "請勿留白"
        Else
            Dim setting As ConnectionStringSettings
            setting = ConfigurationManager.ConnectionStrings("CM_SQL")
            Dim MyCon As New SqlConnection(setting.ConnectionString)
            MyCon.Open()
            Dim A As String = "Select * from [Class_Manager] where id=" & "'" & userid & "'"
            Dim cmd1 As New SqlCommand(A, MyCon)
            Dim reader As SqlDataReader = cmd1.ExecuteReader
            If reader.Read Then
                Dim teachclass As String = reader("TeachClass").TrimEnd()
                If reader("Who").TrimEnd() = Session("MemberType") Then
                    Label99.Text = ""
                    If Session("NewMemberType") = "Leader" Then
                        reader.Close()
                        cmd1.Cancel()
                        Dim C As String = "Update [Class_Manager] Set Class='None' Where Class=" & "'" & Session("Classchange") & "'" & " And ID=" & "'" & userid & "'"
                        Dim cmd3 As New SqlCommand(C, MyCon)
                        cmd3.ExecuteNonQuery()
                        cmd3.Cancel()
                        Dim B As String = "Update [Class_Manager] Set Class=" & "'" & Session("Classchange") & "'" & " Where ID=" & "'" & userid & "'"
                        Dim cmd2 As New SqlCommand(B, MyCon)
                        cmd2.ExecuteNonQuery()
                        cmd2.Cancel()
                    ElseIf Session("NewMemberType") = "Teacher" Then
                        Dim B As String = "Update [Class_Manager] Set TeachClass=" & "'" & teachclass & "," & Session("Classchange") & "'" & " Where ID=" & "'" & userid & "'"
                        reader.Close()
                        cmd1.Cancel()
                        Dim cmd2 As New SqlCommand(B, MyCon)
                        cmd2.ExecuteNonQuery()
                        cmd2.Cancel()
                    ElseIf Session("NewMemberType") = "Student" Then
                        reader.Close()
                        cmd1.Cancel()
                        Dim B As String = "Update [Class_Manager] Set Class=" & "'" & Session("Classchange") & "'" & " Where ID=" & "'" & userid & "'"
                        Dim cmd2 As New SqlCommand(B, MyCon)
                        cmd2.ExecuteNonQuery()
                        cmd2.Cancel()
                    End If
                    reader.Close()
                    cmd1.Cancel()
                    changememberpanel.Visible = False
                Else
                    reader.Close()
                    cmd1.Cancel()
                    Label99.Text = "非" & Session("MemberType") & "帳號"
                End If
            Else
                reader.Close()
                cmd1.Cancel()
                Label99.Text = "查無此帳號"
            End If
            MyCon.Close()
            My_Control()
        End If
    End Sub

    Sub Class_And_Member_Delete(ByVal sender As Button, ByVal e As EventArgs)
        Session("Deleteid") = Mid(sender.ID, 20, sender.ID.Length - 19)
        Session("Deletetype") = Mid(sender.ID, 1, 7)
        If Session("Deletetype") = "Classss" Then
            Label100.Text = "珊除班級"
            Label101.Text = "按下「確定」後該班級將會被刪除，如需保某留些資料，請選取下方選項。如決定不刪除班級請點選「取消」或是「X」"
        ElseIf Session("Deletetype") = "Teacher" Then
            Label100.Text = "移除老師"
            Label101.Text = "按下「確定」後該老師將會被移出該班級，但老師的帳號不會被刪除，如需保某留些資料，請選取下方選項。如決定不刪除班級請點選「取消」或是「X」"
            My_Control()
        ElseIf Session("Deletetype") = "Student" Then
            Label100.Text = "移除學生"
            Label101.Text = "按下「確定」後該學生將會被移出該班級，但學生的帳號不會被刪除，如需保某留些資料，請選取下方選項。如決定不刪除班級請點選「取消」或是「X」"
            My_Control()
        End If
        DeleteMemberPanel.Visible = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Show_Class_Members(Session("Classchange"))
        Dim setting As ConnectionStringSettings
        setting = ConfigurationManager.ConnectionStrings("CM_SQL")
        Dim MyCon As New SqlConnection(setting.ConnectionString)
        MyCon.Open()
        If Session("Deletetype") = "Classss" Then
            Dim A As String = "DELETE FROM [Class] WHERE Class_Name=" & "'" & Session("Deleteid") & "'"
            Dim cmd1 As New SqlCommand(A, MyCon)
            cmd1.ExecuteNonQuery()
            cmd1.Cancel()
            If Not CheckBox9.Checked Then
                Dim C As String = "DELETE FROM [Order] WHERE Class=" & "'" & Session("Deleteid") & "'"
                Dim cmd3 As New SqlCommand(C, MyCon)
                cmd3.ExecuteNonQuery()
                cmd3.Cancel()
            End If
            If Not CheckBox10.Checked Then
                Dim D As String = "DELETE FROM [Menu] WHERE Class=" & "'" & Session("Deleteid") & "'"
                Dim cmd4 As New SqlCommand(D, MyCon)
                cmd4.ExecuteNonQuery()
                cmd4.Cancel()
            End If
            If Not CheckBox11.Checked Then
                Dim F As String = "DELETE FROM [Exam] WHERE Class=" & "'" & Session("Deleteid") & "'"
                Dim cmd5 As New SqlCommand(F, MyCon)
                cmd5.ExecuteNonQuery()
                cmd5.Cancel()
            End If
        ElseIf Session("Deletetype") = "Teacher" Then
            Dim A As String = "Select * from [Class_Manager] where ID=" & "'" & Session("Deleteid") & "'"
            Dim cmd1 As New SqlCommand(A, MyCon)
            Dim reader As SqlDataReader = cmd1.ExecuteReader
            If reader.Read Then
                Dim parts As String() = reader("TeachClass").Split(","c)
                Dim result As New StringBuilder()
                For Each part As String In parts
                    If part = Session("Classchange") Then
                    Else
                        result.Append(part)
                        result.Append(",")
                    End If
                Next
                If result.Length > 0 Then
                    result.Length -= 1
                End If
                Dim finalResult As String = result.ToString()
                reader.Close()
                cmd1.Cancel()
                Dim B As String = "Update [Class_Manager] Set TeachClass=" & "'" & finalResult & "'" & " where ID=" & "'" & Session("Deleteid") & "'"
                Dim cmd2 As New SqlCommand(B, MyCon)
                cmd2.ExecuteNonQuery()
                cmd2.Cancel()
            End If
            If Not CheckBox9.Checked Then
                Dim C As String = "DELETE FROM [Order] WHERE ID=" & "'" & Session("Deleteid") & "'"
                Dim cmd3 As New SqlCommand(C, MyCon)
                cmd3.ExecuteNonQuery()
                cmd3.Cancel()
            End If
            'If Not CheckBox10.Checked Then
            '    Dim D As String = "DELETE FROM [Menu] WHERE Class=" & "'" & Session("Deleteid") & "'"
            '    Dim cmd4 As New SqlCommand(D, MyCon)
            '    cmd4.ExecuteNonQuery()
            '    cmd4.Cancel()
            'End If
            'If Not CheckBox11.Checked Then
            '    Dim F As String = "DELETE FROM [Exam] WHERE Class=" & "'" & Session("Deleteid") & "'"
            '    Dim cmd5 As New SqlCommand(F, MyCon)
            '    cmd5.ExecuteNonQuery()
            '    cmd5.Cancel()
            'End If
            'Show_Class_Members(Session("Classchange"))
        ElseIf Session("Deletetype") = "Student" Then
            Dim A As String = "Update [Class_Manager] Set Class=" & "'None'" & " where ID=" & "'" & Session("Deleteid") & "'"
            Dim cmd1 As New SqlCommand(A, MyCon)
            cmd1.ExecuteNonQuery()
            cmd1.Cancel()
            If Not CheckBox9.Checked Then
                Dim C As String = "DELETE FROM [Order] WHERE ID=" & "'" & Session("Deleteid") & "'"
                Dim cmd3 As New SqlCommand(C, MyCon)
                cmd3.ExecuteNonQuery()
                cmd3.Cancel()
            End If
            'If Not CheckBox10.Checked Then
            '    Dim D As String = "DELETE FROM [Menu] WHERE Class=" & "'" & Session("Deleteid") & "'"
            '    Dim cmd4 As New SqlCommand(D, MyCon)
            '    cmd4.ExecuteNonQuery()
            '    cmd4.Cancel()
            'End If
            'If Not CheckBox11.Checked Then
            '    Dim F As String = "DELETE FROM [Exam] WHERE Class=" & "'" & Session("Deleteid") & "'"
            '    Dim cmd5 As New SqlCommand(F, MyCon)
            '    cmd5.ExecuteNonQuery()
            '    cmd5.Cancel()
            'End If
            'Show_Class_Members(Session("Classchange"))
        End If
        DeleteMemberPanel.Visible = False
        My_Control()
        MyCon.Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        DeleteMemberPanel.Visible = False
        My_Control()
    End Sub

End Class