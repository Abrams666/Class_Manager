<%@ Page Language="VB" AutoEventWireup="false" CodeFile="User.aspx.vb"  Inherits="Account_Default" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta charset="utf-8" />
    <link id="mycss" href="User2.css" rel="stylesheet" type="text/css" runat="server" />
    <title>Class Manager</title>    
    </head>
    <body>
        <form id="form1" runat="server">   
            <asp:Panel CssClass="tools" ID="hometool" runat="server">
            </asp:Panel>

            <asp:panel id="lunchcal" cssclass="tools" runat="server">
                <div class="changemonth">
                <asp:imagebutton id="lastmonth" cssclass="monthbutton" runat="server" imageurl="\picture\imageedit_4_4082552734.png"/>
                <asp:label id="lmonthtext" runat="server" text="" CssClass="monthtext"></asp:label>
                <asp:imagebutton id="nextmonth" cssclass="monthbutton" runat="server" imageurl="\picture\imageedit_3_4003242935.png"/>
                </div>

                <asp:table cssclass="table, lunchtable" id="lunchtable" runat="server" imageurl="\picture\imageedit_3_4003242935.png">
                    <asp:tableheaderrow runat="server" cssclass="table, lunchtable" id="header">
                        <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="sun">日</asp:tableheadercell>
                        <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="mon">一</asp:tableheadercell>
                        <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="two">二</asp:tableheadercell>
                        <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="wen">三</asp:tableheadercell>
                        <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="thr">四</asp:tableheadercell>
                        <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="fri">五</asp:tableheadercell>
                        <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="sat">六</asp:tableheadercell>
                    </asp:tableheaderrow>
                    <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="lunchtablew1">
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw1d1">test1</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw1d2">test2</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw1d3">test3</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw1d4">test4</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw1d5">test5</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw1d6">test6</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw1d7">test7</asp:tablecell>
                    </asp:tablerow>
                    <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="lunchtablew2">
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw2d1">test1</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw2d2">test2</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw2d3">test3</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw2d4">test4</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw2d5">test5</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw2d6">test6</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw2d7">test7</asp:tablecell>
                    </asp:tablerow>
                    <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="lunchtablew3">
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw3d1">test1</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw3d2">test2</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw3d3">test3</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw3d4">test4</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw3d5">test5</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw3d6">test6</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw3d7">test7</asp:tablecell>
                    </asp:tablerow>
                    <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="lunchtablew4">
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw4d1">test1</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw4d2">test2</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw4d3">test3</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw4d4">test4</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw4d5">test5</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw4d6">test6</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw4d7">test7</asp:tablecell>
                    </asp:tablerow>
                    <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="lunchtablew5">
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw5d1">test1</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw5d2">test2</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw5d3">test3</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw5d4">test4</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw5d5">test5</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw5d6">test6</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="lw5d7">test7</asp:tablecell>
                    </asp:tablerow>
                    <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="lunchtablew6">
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="lw6d1">test1</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="lw6d2">test2</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="lw6d3">test3</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="lw6d4">test4</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="lw6d5">test5</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="lw6d6">test6</asp:tablecell>
                        <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="lw6d7">test7</asp:tablecell>
                    </asp:tablerow>
                </asp:table>
            </asp:panel>

            <asp:panel id="lunchans" cssclass="tools" runat="server">
                <div class="dateclose">
                <div>
                <asp:label id="label1" runat="server" text="date"/>
                <asp:label id="label17" runat="server" text="" ForeColor="Red"/>
                </div>
                <asp:Button ID="Button8" runat="server" Text="X" />
                </div>

                <asp:button id="button2" backcolor="white" cssclass="orderbutton" runat="server" text="2、正園" />
                <asp:button id="button3" backcolor="white" cssclass="orderbutton" runat="server" text="3、大稻理" />
                <asp:button id="button4" backcolor="white" cssclass="orderbutton" runat="server" text="4、御饌坊" />
                <asp:button id="button5" backcolor="white" cssclass="orderbutton" runat="server" text="5、大大大師傅" />
                <asp:button id="button7" backcolor="white" cssclass="orderbutton" runat="server" text="7、吉樂米" />
                <asp:button id="button9" backcolor="white" cssclass="orderbutton" runat="server" text="取消訂餐" />
            </asp:panel>

            <asp:Panel ID="resistdiv" CssClass="tools" runat="server">
            </asp:Panel>

            <asp:Panel ID="resiseditdiv" CssClass="tools" runat="server">
                <asp:Panel ID="scores" CssClass="scoreedit" runat="server">
                    <asp:Button ID="Addnewscorecal" runat="server" Text="新增成績項目" />
                </asp:Panel>

                <asp:Panel ID="newscore" CssClass="scoreedit" runat="server">
                    <asp:Label ID="Label2" runat="server" Text="新增成績項目"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Text="項目名稱(考卷名稱)"></asp:Label>
                    <asp:Label ID="addnewscorecalerror2" runat="server" Text="" ForeColor="Red"></asp:Label>
                    <asp:TextBox ID="scorenametextbox" runat="server"></asp:TextBox>
                    <asp:Button ID="Addnewscorecalbtn" runat="server" Text="建立" />
                    <asp:Label ID="addnewscorecalerror" runat="server" Text="" ForeColor="Red"></asp:Label>
                </asp:Panel>

                <asp:Panel ID="editscore" CssClass="scoreedit" runat="server">
                    
                </asp:Panel>
            </asp:Panel>

            <asp:Panel ID="LunchEditdiv" runat="server">
                <asp:Button ID="Button1" runat="server" CssClass="luncheditbutton" Text="查看訂單" />
                <asp:Button ID="Button6" runat="server" CssClass="luncheditbutton" Text="新增/修改菜單" />
            </asp:Panel>

            <asp:Panel ID="ViewLunchOrder" runat="server">
                <asp:Panel ID="Vlunchcal" CssClass="tools" runat="server">
                    <div class="changemonth">
                        <asp:ImageButton ID="VLastmonth" CssClass="monthbutton" runat="server" ImageUrl="\picture\imageedit_4_4082552734.png"/>
                        <asp:Label ID="Vmonthtext" runat="server" Text="" CssClass="monthtext"></asp:Label>
                        <asp:ImageButton ID="VNextmonth" CssClass="monthbutton" runat="server" ImageUrl="\picture\imageedit_3_4003242935.png"/>
                    </div>
                    <asp:Table CssClass="table, lunchtable" ID="Vlunchtable" runat="server" ImageUrl="\picture\imageedit_3_4003242935.png">
                        <asp:TableHeaderRow runat="server" CssClass="table, lunchtable" ID="TableHeaderRow1">
                            <asp:TableHeaderCell runat="server" CssClass="table, lunchtable, lunchtabledate" id="TableHeaderCell1">日</asp:TableHeaderCell>
                            <asp:TableHeaderCell runat="server" CssClass="table, lunchtable, lunchtabledate" id="TableHeaderCell2">一</asp:TableHeaderCell>
                            <asp:TableHeaderCell runat="server" CssClass="table, lunchtable, lunchtabledate" id="TableHeaderCell3">二</asp:TableHeaderCell>
                            <asp:TableHeaderCell runat="server" CssClass="table, lunchtable, lunchtabledate" id="TableHeaderCell4">三</asp:TableHeaderCell>
                            <asp:TableHeaderCell runat="server" CssClass="table, lunchtable, lunchtabledate" id="TableHeaderCell5">四</asp:TableHeaderCell>
                            <asp:TableHeaderCell runat="server" CssClass="table, lunchtable, lunchtabledate" id="TableHeaderCell6">五</asp:TableHeaderCell>
                            <asp:TableHeaderCell runat="server" CssClass="table, lunchtable, lunchtabledate" id="TableHeaderCell7">六</asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                        <asp:TableRow runat="server" CssClass="table, lunchtable, lunchtablew1, weekweek" id="TableRow1">
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw1d1">test1</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw1d2">test2</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw1d3">test3</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw1d4">test4</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw1d5">test5</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw1d6">test6</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw1d7">test7</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server" CssClass="table, lunchtable, lunchtablew1, weekweek" id="TableRow2">
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw2d1">test1</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw2d2">test2</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw2d3">test3</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw2d4">test4</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw2d5">test5</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw2d6">test6</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw2d7">test7</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server" CssClass="table, lunchtable, lunchtablew1, weekweek" id="TableRow3">
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw3d1">test1</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw3d2">test2</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw3d3">test3</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw3d4">test4</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw3d5">test5</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw3d6">test6</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw3d7">test7</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server" CssClass="table, lunchtable, lunchtablew1, weekweek" id="TableRow4">
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw4d1">test1</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw4d2">test2</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw4d3">test3</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw4d4">test4</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw4d5">test5</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw4d6">test6</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw4d7">test7</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server" CssClass="table, lunchtable, lunchtablew1, weekweek" id="TableRow5">
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw5d1">test1</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw5d2">test2</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw5d3">test3</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw5d4">test4</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw5d5">test5</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw5d6">test6</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1" id="Vw5d7">test7</asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow runat="server" CssClass="table, lunchtable, lunchtablew1, weekweek" id="TableRow6">
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1, w6noborder" id="Vw6d1">test1</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1, w6noborder" id="Vw6d2">test2</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1, w6noborder" id="Vw6d3">test3</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1, w6noborder" id="Vw6d4">test4</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1, w6noborder" id="Vw6d5">test5</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1, w6noborder" id="Vw6d6">test6</asp:TableCell>
                            <asp:TableCell runat="server" CssClass="table, lunchtable, lunchtablew1, w6noborder" id="Vw6d7">test7</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:Panel>
            </asp:Panel>

            <asp:Panel runat="server" ID="orderans">
                <div class="dateclose">
                    <asp:Label ID="lunchansdate" runat="server" Text=""></asp:Label>
                    <asp:Button ID="Buttonclose" runat="server" Text="X" />
                </div>

                <!--<asp:GridView ID="lunchansGridView" runat="server"></asp:GridView>-->
                <asp:Label ID="count2orderlable" runat="server" Text="" CssClass="countorder"></asp:Label>
                <asp:Label ID="count3orderlable" runat="server" Text="" CssClass="countorder"></asp:Label>
                <asp:Label ID="count4orderlable" runat="server" Text="" CssClass="countorder"></asp:Label>
                <asp:Label ID="count5orderlable" runat="server" Text="" CssClass="countorder"></asp:Label>
                <asp:Label ID="count7orderlable" runat="server" Text="" CssClass="countorder"></asp:Label>

                <div id="countblock"></div>
            </asp:Panel>

            <asp:Panel ID="neworder" runat="server">
                <asp:Label ID="Label4" runat="server" Text="新增/修改菜單"></asp:Label>
                <asp:Label id="newordererrortext" runat="server" Text="" ForeColor="Red"></asp:Label>
                <br/>
                <div>
                    <asp:TextBox ID="menuyear" runat="server" CssClass="newordertextbox"></asp:TextBox>
                    <asp:Label ID="Label6" runat="server" Text="年" CssClass="neworderword"></asp:Label>
                    <asp:TextBox ID="menumonth" runat="server" CssClass="newordertextbox"></asp:TextBox>
                    <asp:Label ID="Label7" runat="server" Text="月" CssClass="neworderword"></asp:Label>
                    <asp:TextBox ID="menudate" runat="server" CssClass="newordertextbox"></asp:TextBox>
                    <asp:Label ID="Label8" runat="server" Text="日" CssClass="neworderword"></asp:Label>
                </div>
                <br/>
                <div>
                    <asp:Label ID="Label5" runat="server" Text="2.正       園" CssClass="neworderword"></asp:Label>
                    <asp:TextBox ID="twomenu" runat="server" CssClass="newordertextbox"></asp:TextBox>
                </div>
                <br/>
                <div>
                    <asp:Label ID="L3" runat="server" Text="3.大稻理" CssClass="neworderword"></asp:Label>
                    <asp:TextBox ID="threemenu" runat="server" CssClass="newordertextbox"></asp:TextBox>
                </div>
                <br/>
                <div>
                    <asp:Label ID="L4" runat="server" Text="4.御饌坊" CssClass="neworderword"></asp:Label>
                    <asp:TextBox ID="fourmenu" runat="server" CssClass="newordertextbox"></asp:TextBox>
                </div>
                <br/>
                <div>
                    <asp:Label ID="L5" runat="server" Text="5.太師傅" CssClass="neworderword"></asp:Label>
                    <asp:TextBox ID="fivemenu" runat="server" CssClass="newordertextbox"></asp:TextBox>
                </div>
                <br/>
                <div>
                    <asp:Label ID="L6" runat="server" Text="7.極樂米" CssClass="neworderword"></asp:Label>
                    <asp:TextBox ID="sevenmenu" runat="server" CssClass="newordertextbox"></asp:TextBox>
                </div>
                <br/>
                <asp:Button ID="menubutton" runat="server" Text="送出菜單" />
            </asp:Panel>

            <asp:Panel runat="server" ID="Examsch">
            <asp:panel id="Elunchcal" cssclass="tools" runat="server">
            <div class="changemonth">
            <asp:imagebutton id="ELastmonth" cssclass="monthbutton" runat="server" imageurl="\picture\imageedit_4_4082552734.png"/>
            <asp:label id="Emonthtext" runat="server" text="" CssClass="monthtext"></asp:label>
            <asp:imagebutton id="ENextmonth" cssclass="monthbutton" runat="server" imageurl="\picture\imageedit_3_4003242935.png"/>
            </div>
            <asp:table cssclass="table, lunchtable" id="Table1" runat="server" imageurl="\picture\imageedit_3_4003242935.png">
            <asp:tableheaderrow runat="server" cssclass="table, lunchtable" id="Tableheaderrow2">
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell8">日</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell9">一</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell10">二</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell11">三</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell12">四</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell13">五</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell14">六</asp:tableheadercell>
            </asp:tableheaderrow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow7">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew1d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew1d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew1d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew1d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew1d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew1d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Ew1d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow8">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew2d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew2d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew2d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew2d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew2d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew2d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Ew2d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow9">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew3d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew3d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew3d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew3d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew3d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew3d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Ew3d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow10">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew4d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew4d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew4d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew4d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew4d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew4d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Ew4d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow11">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew5d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew5d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew5d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew5d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew5d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Ew5d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Ew5d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow12">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Ew6d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Ew6d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Ew6d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Ew6d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Ew6d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Ew6d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder, d7noborder" id="Ew6d7">test7</asp:tablecell>
            </asp:tablerow>
            </asp:table>
            </asp:panel>
            <asp:Panel ID="Examwindow" runat="server" CssClass="windows">
            <asp:Panel ID="Examshowheader" runat="server">
            <asp:Label ID="Examwindowtitle" CssClass="headertitle" runat="server" Text="test"></asp:Label>
            <asp:Button ID="Examwindowclosebutton" CssClass="headerclosebutton" runat="server" Text="X" />
            </asp:Panel>
            <asp:Label ID="Examshowsubject" CssClass="windowsif" runat="server" Text="科目:"></asp:Label>
            <asp:Label ID="Examshowdate" CssClass="windowsif" runat="server" Text="日期:"></asp:Label>
            <asp:Label ID="Examshowrange" CssClass="windowsif" runat="server" Text="範圍:"></asp:Label>
            <asp:Label ID="Examshowoi" CssClass="windowsif" runat="server" Text="備註:"></asp:Label>
            <div class="Examshowbox"></div>
            </asp:Panel>
            </asp:Panel>

            <asp:Panel runat="server" ID="Examschedit">
            <asp:panel id="Alunchcal" cssclass="tools" runat="server">
            <div class="changemonth">
            <asp:imagebutton id="ALastmonth" cssclass="monthbutton" runat="server" imageurl="\picture\imageedit_4_4082552734.png"/>
            <asp:label id="Amonthtext" runat="server" text="" CssClass="monthtext"></asp:label>
            <asp:imagebutton id="ANextmonth" cssclass="monthbutton" runat="server" imageurl="\picture\imageedit_3_4003242935.png"/>
            </div>
            <asp:table cssclass="table, lunchtable" id="Table2" runat="server" imageurl="\picture\imageedit_3_4003242935.png">
            <asp:tableheaderrow runat="server" cssclass="table, lunchtable" id="Tableheaderrow3">
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell15">日</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell16">一</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell17">二</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell18">三</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell19">四</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell20">五</asp:tableheadercell>
            <asp:tableheadercell runat="server" cssclass="table, lunchtable, lunchtabledate" id="Tableheadercell21">六</asp:tableheadercell>
            </asp:tableheaderrow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow100">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw1d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw1d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw1d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw1d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw1d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw1d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Aw1d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow101">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw2d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw2d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw2d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw2d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw2d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw2d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Aw2d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow102">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw3d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw3d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw3d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw3d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw3d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw3d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Aw3d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow103">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw4d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw4d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw4d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw4d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw4d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw4d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Aw4d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow104">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw5d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw5d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw5d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw5d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw5d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1" id="Aw5d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, d7noborder" id="Aw5d7">test7</asp:tablecell>
            </asp:tablerow>
            <asp:tablerow runat="server" cssclass="table, lunchtable, lunchtablew1, weekweek" id="Tablerow105">
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Aw6d1">test1</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Aw6d2">test2</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Aw6d3">test3</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Aw6d4">test4</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Aw6d5">test5</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder" id="Aw6d6">test6</asp:tablecell>
            <asp:tablecell runat="server" cssclass="table, lunchtable, lunchtablew1, w6noborder, d7noborder" id="Aw6d7">test7</asp:tablecell>
            </asp:tablerow>
            </asp:table>
            </asp:panel>
            <asp:Button ID="newexambutton" runat="server" Text="+新增考試" />
            <asp:Panel runat="server" ID="newexamdiv">
            <asp:Label ID="Label9" runat="server" Text="新增考試"></asp:Label>
            <div>
            <asp:TextBox ID="newexamyear" runat="server" CssClass="newexamday"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="年" CssClass="newexamtext"></asp:Label>
            <asp:TextBox ID="newexammonth" runat="server" CssClass="newexamday"></asp:TextBox>
            <asp:Label ID="Label11" runat="server" Text="月" CssClass="newexamtext"></asp:Label>
            <asp:TextBox ID="newexamdate" runat="server" CssClass="newexamday"></asp:TextBox>
            <asp:Label ID="Label15" runat="server" Text="日" CssClass="newexamtext"></asp:Label>
            </div>
            <div>
            <asp:Label ID="Label16" runat="server" Text="名稱" CssClass="newexamtext"></asp:Label>
            <asp:TextBox ID="newexamname" runat="server" CssClass="newexamtextbox"></asp:TextBox>
            </div>
            <div>
            <asp:Label ID="Label12" runat="server" Text="班級" CssClass="newexamtext"></asp:Label>
            <asp:TextBox ID="newexamclass" runat="server" CssClass="newexamtextbox"></asp:TextBox>
            </div>
            <div>
            <asp:Label ID="Label13" runat="server" Text="範圍" CssClass="newexamtext"></asp:Label>
            <asp:TextBox ID="newexamrange" runat="server" CssClass="newexamtextbox"></asp:TextBox>
            </div>
            <div>
            <asp:Label ID="Label14" runat="server" Text="備註" CssClass="newexamtext"></asp:Label>
            <asp:TextBox ID="newexaminformation" runat="server" CssClass="newexamtextbox"></asp:TextBox>
            </div>
            <asp:Button ID="newexamsentbutton" runat="server" Text="送出"/>
            </asp:Panel>
            </asp:Panel>

            <asp:Panel ID="Accountedittool" runat="server">
                <asp:Panel ID="accounteditoptions" runat="server">
                    <asp:Panel ID="editaccountpanel" CssClass="accountbuttonpanels" runat="server">
                        <asp:ImageButton ID="editaccount" runat="server" CssClass="editaccountbutton" ImageUrl="picture/account.png"/>
                        <asp:Label ID="Label18" CssClass="accountlable" runat="server" Text="創建帳戶"></asp:Label>
                    </asp:Panel>

                    <asp:Panel ID="editpasswordpanel" CssClass="accountbuttonpanels" runat="server">
                        <asp:ImageButton ID="editpassword" runat="server" CssClass="editaccountbutton" ImageUrl="picture/key.png"/>
                        <asp:Label ID="Label19" CssClass="accountlable" runat="server" Text="更改密碼"></asp:Label>
                    </asp:Panel>

                    <asp:Panel ID="editaccesspanel" CssClass="accountbuttonpanels" runat="server">
                        <asp:ImageButton ID="editaccess" runat="server" CssClass="editaccountbutton" ImageUrl="picture/access.png"/>
                        <asp:Label ID="Label20" CssClass="accountlable" runat="server" Text="更改權限"></asp:Label>
                    </asp:Panel>

                    <asp:Panel ID="editclasspanel" CssClass="accountbuttonpanels" runat="server">
                        <asp:ImageButton ID="editclass" runat="server" CssClass="editaccountbutton" ImageUrl="picture/presentation.png"/>
                        <asp:Label ID="Label80" CssClass="accountlable" runat="server" Text="編輯班級"></asp:Label>
                    </asp:Panel>
                </asp:Panel>

                <asp:Panel ID="accounteditpanel" runat="server">
                    <asp:Label ID="Label27" runat="server" Text="創建帳戶"></asp:Label>

                    <asp:Panel ID="Panel8" runat="server">
                        <asp:Label ID="Label37" runat="server" Text="帳號" cssclass="labelofchangeaccount"></asp:Label>
                        <asp:Label ID="Label38" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </asp:Panel>

                    <div class="newaccountwordsdiv">
                    <asp:Button ID="Button11" CssClass="newaccountwords" runat="server" Text="新增固定字元" />
                    <asp:Button ID="Button12" CssClass="newaccountwords" runat="server" Text="新增遞增字元" />
                    </div>

                    <asp:Panel ID="newaccountform" runat="server">
                        <asp:Panel ID="wordpanel1" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label48" runat="server" Text="+"></asp:Label>
                            <asp:TextBox ID="fixxxwordtextbox1" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>
                        
                        <asp:Panel ID="wordpanel2" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label49" runat="server" Text="+"></asp:Label>
                            <asp:Label ID="Label46" runat="server" Text="從"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxfrom2" Cssclass="textboxs" runat="server"></asp:TextBox>
                            <asp:Label ID="Label47" runat="server" Text="到"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxtooo2" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>

                        <asp:Panel ID="wordpanel3" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label65" runat="server" Text="+"></asp:Label>
                            <asp:TextBox ID="fixxxwordtextbox3" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>

                        <asp:Panel ID="wordpanel4" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label50" runat="server" Text="+"></asp:Label>
                            <asp:Label ID="Label51" runat="server" Text="從"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxfrom4" Cssclass="textboxs" runat="server"></asp:TextBox>
                            <asp:Label ID="Label52" runat="server" Text="到"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxtooo4" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>

                        <asp:Panel ID="wordpanel5" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label66" runat="server" Text="+"></asp:Label>
                            <asp:TextBox ID="fixxxwordtextbox5" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>

                        <asp:Panel ID="wordpanel6" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label53" runat="server" Text="+"></asp:Label>
                            <asp:Label ID="Label54" runat="server" Text="從"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxfrom6" Cssclass="textboxs" runat="server"></asp:TextBox>
                            <asp:Label ID="Label55" runat="server" Text="到"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxtooo6" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>

                        <asp:Panel ID="wordpanel7" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label67" runat="server" Text="+"></asp:Label>
                            <asp:TextBox ID="fixxxwordtextbox7" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>

                        <asp:Panel ID="wordpanel8" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label56" runat="server" Text="+"></asp:Label>
                            <asp:Label ID="Label57" runat="server" Text="從"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxfrom8" Cssclass="textboxs" runat="server"></asp:TextBox>
                            <asp:Label ID="Label58" runat="server" Text="到"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxtooo8" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>

                        <asp:Panel ID="wordpanel9" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label68" runat="server" Text="+"></asp:Label>
                            <asp:TextBox ID="fixxxwordtextbox9" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>

                        <asp:Panel ID="wordpanel10" Cssclass="wordpanel" runat="server">
                            <asp:Label ID="Label59" runat="server" Text="+"></asp:Label>
                            <asp:Label ID="Label60" runat="server" Text="從"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxfrom10" Cssclass="textboxs" runat="server"></asp:TextBox>
                            <asp:Label ID="Label61" runat="server" Text="到"></asp:Label>
                            <asp:TextBox ID="floatwordtextboxtooo10" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>
                    </asp:Panel>


                    <asp:Panel ID="Panel1" runat="server">
                        <asp:Label ID="Label35" runat="server" Text="密碼" cssclass="labelofchangeaccount"></asp:Label>
                        <asp:Label ID="Label36" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </asp:Panel>

                    <div>
                        <asp:Panel ID="Panel2" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="CheckBox1"  CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label28" CssClass="checklable" runat="server" Text="與帳號相同"></asp:Label>
                        </asp:Panel>

                        <asp:Panel ID="Panel3" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="CheckBox2" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label29" CssClass="checklable" runat="server" Text="統一密碼:"></asp:Label>
                            <asp:TextBox ID="TextBox4" Cssclass="textboxs" runat="server"></asp:TextBox>
                        </asp:Panel>
                    </div>

                    <asp:Panel ID="Panel24" runat="server">
                        <asp:Panel ID="Panel25" runat="server">
                            <asp:Label ID="Label92" runat="server" Text="身份"></asp:Label>
                            <asp:Label ID="Label93" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel26" runat="server">
                            <asp:Panel ID="Panel27" runat="server">
                                <asp:CheckBox ID="CheckBox7" runat="server" />
                                <asp:Label ID="Label94" runat="server" Text="教師"></asp:Label>
                            </asp:Panel>
                            <asp:Panel ID="Panel28" runat="server">
                                <asp:CheckBox ID="CheckBox8" runat="server" />
                                <asp:Label ID="Label95" runat="server" Text="學生"></asp:Label>
                            </asp:Panel>
                        </asp:Panel>
                    </asp:Panel>

                    <asp:Panel ID="Panel21" runat="server">
                        <asp:Panel ID="Panel23" runat="server">
                            <asp:Label ID="Label89" runat="server" Text="班級"></asp:Label>
                            <asp:Label ID="Label96" runat="server" Text="(老師帳號的班級需再設定，不需填寫。)"></asp:Label>
                            <asp:Label ID="Label91" runat="server" Text="" ForeColor="Red"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel22" runat="server">
                            <asp:Label ID="Label90" runat="server" Text="班級名稱:"></asp:Label>
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        </asp:Panel>
                    </asp:Panel>

                    <asp:Label ID="Label30" runat="server" Text="權限"  cssclass="labelofchangeaccount"></asp:Label>
                    <div>
                        <asp:Panel ID="Panel4" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="CheckBox3" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label31" CssClass="checklable" runat="server" Text="訂餐"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel5" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="CheckBox4" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label32" CssClass="checklable" runat="server" Text="菜單編輯"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel6" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="CheckBox5" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label33" CssClass="checklable" runat="server" Text="查看考試"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel7" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="CheckBox6" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label34" CssClass="checklable" runat="server" Text="考試編輯"></asp:Label>
                        </asp:Panel>
                    </div>
                    <asp:Button ID="Button13" runat="server" Text="創建" />
                </asp:Panel>

                <asp:Panel ID="passwordeditpanel" runat="server">
                    <asp:Label ID="Label21" runat="server" Text="更改密碼"></asp:Label>

                    <div>
                        <asp:Label ID="Label22" runat="server" CssClass="labelofchangeaccount" Text="帳號"></asp:Label>
                        <asp:Label ID="Label25" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    
                    <asp:Label ID="Label23" runat="server" CssClass="labelofchangeaccount" Text="新密碼"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>

                    <div>
                        <asp:Label ID="Label24" runat="server" CssClass="labelofchangeaccount" Text="確認密碼"></asp:Label>
                        <asp:Label ID="Label26" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>

                    <asp:Button ID="Button10" runat="server" Text="更改" />
                </asp:Panel>

                <asp:Panel ID="accesseditpanel" runat="server">
                    <asp:Label ID="Lable" runat="server" Text="編輯權限"></asp:Label>
                        <asp:Label ID="Label44" runat="server" CssClass="labelofchangeaccount" Text="帳號"></asp:Label>
                        <asp:Label ID="Label45" runat="server" Text="" ForeColor="Red"></asp:Label>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                    <asp:Button ID="Button14" runat="server" Text="尋找" />

                    <asp:Panel ID="Panel13" runat="server">
                        <asp:Label ID="Label39" runat="server" CssClass="labelofchangeaccount" Text="權限"></asp:Label>
                        <asp:Panel ID="Panel9" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="checkboxLunch" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label40" CssClass="checklable" runat="server" Text="訂餐"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel10" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="checkboxLunchedit" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label41" CssClass="checklable" runat="server" Text="菜單編輯"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel11" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="checkboxExam" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label42" CssClass="checklable" runat="server" Text="查看考試"></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="Panel12" CssClass="checkboxpanel" runat="server">
                            <asp:CheckBox ID="checkboxExamedit" CssClass="checkbox" runat="server" />
                            <asp:Label ID="Label43" CssClass="checklable" runat="server" Text="考試編輯"></asp:Label>
                        </asp:Panel>
                        <asp:Button ID="Button15" runat="server" Text="更改" />
                    </asp:Panel>
                </asp:Panel>

                <asp:Panel ID="classeditpanel" runat="server">
                    <asp:Label ID="Label81" runat="server" Text="編輯班級"></asp:Label>
                    <asp:Button ID="Button16" runat="server" Text="+新增班級" />

                    <asp:Panel ID="Panel14" runat="server"></asp:Panel>

                    <asp:Panel ID="newclasswindow" runat="server">
                        <div>
                            <div>
                                <asp:Label ID="Label82" runat="server" Text="新增班級"></asp:Label>
                                <asp:Label ID="Label84" runat="server" Text="Label" ForeColor="Red"></asp:Label>
                            </div>
                            <asp:Button ID="closenewclasswindow" CssClass="closebutton" runat="server" Text="X" />
                        </div>
                        <asp:Label ID="Label83" runat="server" Text="班級名稱"></asp:Label>
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        <asp:Button ID="Button17" runat="server" Text="新增" />
                    </asp:Panel>

                    <asp:Panel ID="Panel15" runat="server">
                        <asp:Panel ID="Panel16" runat="server">
                            <asp:Label ID="Label85" runat="server" Text=""></asp:Label>
                            <asp:Button ID="closePanel15" CssClass="closebutton" runat="server" Text="X" />
                        </asp:Panel>

                        <asp:Panel ID="Panel17" runat="server">
                            <div class="hhh">
                                <asp:Label ID="Label86" runat="server" Text="導師"></asp:Label>
                                <asp:Button ID="Button19" runat="server" Text="+更換導師" />
                            </div>
                            <asp:Panel ID="Panel18" runat="server"></asp:Panel>

                            <div class="hhh">
                                <asp:Label ID="Label87" runat="server" Text="老師"></asp:Label>
                                <asp:Button ID="Button20" runat="server" Text="+新增老師" />
                            </div>
                            <asp:Panel ID="Panel19" runat="server"></asp:Panel>

                            <div class="hhh">
                                <asp:Label ID="Label88" runat="server" Text="學生"></asp:Label>
                                <asp:Button ID="Button21" runat="server" Text="+新增學生" />
                            </div>
                            <asp:Panel ID="Panel20" runat="server"></asp:Panel>
                        </asp:Panel>
                    </asp:Panel>

                    <asp:Panel ID="changememberpanel" runat="server">
                        <asp:Panel ID="Panel30" runat="server">
                            <asp:Label ID="Label97" runat="server" Text=""></asp:Label>
                            <asp:Button ID="closechangememberpanel" runat="server" CssClass="closebutton" Text="X" />
                        </asp:Panel>

                        <asp:Label ID="Label98" runat="server" Text=""></asp:Label>
                        <asp:Label ID="Label99" runat="server" Text="" ForeColor="Red"></asp:Label>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        <asp:Button ID="Button18" runat="server" Text="確認" />
                    </asp:Panel>

                    <asp:Panel ID="DeleteMemberPanel" runat="server">
                        <asp:Panel ID="Panel31" runat="server">
                            <asp:Label ID="Label100" runat="server" Text=""></asp:Label>
                            <asp:Button ID="closeDeleteMemberPanel" runat="server" CssClass="closebutton" Text="X" />
                        </asp:Panel>

                        <asp:Label ID="Label101" runat="server" Text=""></asp:Label>

                        <asp:Panel ID="Panel29" runat="server">
                            <asp:Panel ID="Panel33" runat="server">
                                <asp:CheckBox ID="CheckBox9" runat="server" />
                                <asp:Label ID="Label102" runat="server" Text="保留訂餐"></asp:Label>
                            </asp:Panel>

                            <asp:Panel ID="Panel34" runat="server">
                                <asp:CheckBox ID="CheckBox10" runat="server" />
                                <asp:Label ID="Label103" runat="server" Text="保留菜單"></asp:Label>
                            </asp:Panel>

                            <asp:Panel ID="Panel35" runat="server">
                                <asp:CheckBox ID="CheckBox11" runat="server" />
                                <asp:Label ID="Label104" runat="server" Text="保留考試編輯"></asp:Label>
                            </asp:Panel>
                        </asp:Panel>

                        <asp:Panel ID="Panel32" runat="server">
                            <asp:Button ID="Button23" runat="server" Text="確認" />
                            <asp:Button ID="Button24" runat="server" Text="取消" />
                        </asp:Panel>
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>

            <asp:Panel ID="Settingtool" runat="server">
                <asp:Panel ID="SettingPanelSetting" runat="server">
                    <asp:Panel ID="SettingPanelHeadshot" runat="server">
                        <asp:Image ID="SettingImageHeadshot" runat="server" />
                        <asp:ImageButton ID="SettingImgbuttonEditHeadshot" CssClass="SettingImgbuttons" ImageUrl="picture/editing.png" runat="server" />
                    </asp:Panel>
                    <asp:Panel ID="SettingPanelContainPI" runat="server">
                        <asp:Panel ID="SettingPanelName" runat="server" CssClass="SettingPanelPIs">
                            <asp:Label ID="Label69" runat="server" CssClass="SettingLabels" Text="姓名:"></asp:Label>
                            <asp:Label ID="Label62" runat="server" CssClass="SettingLabels, SettingShowLabels" Text=""></asp:Label>
                            <asp:ImageButton ID="SettingImgbuttonEditName" CssClass="SettingImgbuttons" ImageUrl="picture/editing.png"  runat="server" />
                        </asp:Panel>
                        <asp:Panel ID="SettingPanelAccount" runat="server" CssClass="SettingPanelPIs">
                            <asp:Label ID="Label70" runat="server" CssClass="SettingLabels" Text="帳號:"></asp:Label>
                            <asp:Label ID="Label63" runat="server" CssClass="SettingLabels, SettingShowLabels" Text=""></asp:Label>
                        </asp:Panel>
                        <asp:Panel ID="SettingPanelPassword" runat="server" CssClass="SettingPanelPIs">
                            <asp:Label ID="Label71" runat="server" CssClass="SettingLabels" Text="密碼:"></asp:Label>
                            <asp:Label ID="Label64" runat="server" CssClass="SettingLabels, SettingShowLabels" Text="***********"></asp:Label>
                            <asp:ImageButton ID="SettingImgbuttonEditPassword" CssClass="SettingImgbuttons" ImageUrl="picture/editing.png" runat="server" />
                        </asp:Panel>
                    </asp:Panel>
                    <asp:Panel ID="SettingPanelAccess" runat="server">
                        <asp:Label ID="Label72" runat="server" Text="權限"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
                    </asp:Panel>
                </asp:Panel>

                <asp:Panel ID="SettingPanelEditPIWindow" runat="server">
                    <asp:Label ID="Label73" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label74" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label77" runat="server" Text="" ForeColor="Red"></asp:Label>
                    <asp:TextBox ID="SettingTextbox1" runat="server"></asp:TextBox>
                    <asp:FileUpload ID="SettingFileploadHeadshot" Accept=".jpg, .jpeg, .png, .gif" runat="server" />
                    <asp:Label ID="Label75" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label78" runat="server" Text="" ForeColor="Red"></asp:Label>
                    <asp:TextBox ID="SettingTextbox2" runat="server"></asp:TextBox>
                    <asp:Label ID="Label76" runat="server" Text=""></asp:Label>
                    <asp:Label ID="Label79" runat="server" Text="" ForeColor="Red"></asp:Label>
                    <asp:TextBox ID="SettingTextbox3" runat="server"></asp:TextBox>
                    <asp:Button ID="SettingButtonEditWindowSend" runat="server" Text="更改" />
                </asp:Panel>
            </asp:Panel>

            <div class="fixfix">
                <div class="dock">
                    <div class="block"></div>
                    <asp:Panel ID="leftleft" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Home" CssClass="dockicon" runat="server" ImageUrl="picture/imageedit_3_2306233959.png"/>
                        <p class="dockname">Home</p>
                    </asp:Panel>
                    <asp:Panel ID="PanelLunch" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Lunch" CssClass="dockicon" runat="server" ImageUrl="picture/breakfast-removebg-preview.png"/>
                        <p class="dockname">Lunch</p>
                    </asp:Panel>
                    <asp:Panel ID="PanelLunchedit" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Lunchedit" CssClass="dockicon" runat="server" ImageUrl="picture/breakfast-removebg-preview.png"/>
                        <p class="dockname">Lunch Edit</p>
                    </asp:Panel>
                    <asp:Panel ID="PanelExam" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Exam" CssClass="dockicon" runat="server" ImageUrl="picture/exam.png"/>
                        <p class="dockname">Exam</p>
                    </asp:Panel>
                    <asp:Panel ID="PanelExamedit" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Examedit" CssClass="dockicon" runat="server" ImageUrl="picture/exam.png"/>
                        <p class="dockname">Exam Edit</p>
                    </asp:Panel>
                    <asp:Panel ID="PanelRegister" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Register" CssClass="dockicon" runat="server" ImageUrl="picture/resis.png"/>
                        <p class="dockname">Score</p>
                    </asp:Panel>
                    <asp:Panel ID="PanelRegisteredit" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Registeredit" CssClass="dockicon" runat="server" ImageUrl="picture/resis.png"/>
                        <p class="dockname">Score Edit</p>
                    </asp:Panel>
                    <asp:Panel ID="PanelAccountedit" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Accountedit" CssClass="dockicon" runat="server" ImageUrl="picture/user.png"/>
                        <p class="dockname">Account Edit</p>
                    </asp:Panel>
                    <asp:Panel ID="PanelSetting" CssClass="dockitem" runat="server">
                        <asp:ImageButton ID="Setting" CssClass="dockicon" runat="server" ImageUrl="picture/gear.png"/>
                        <p class="dockname">Setting</p>
                    </asp:Panel>
                    <div class="block" id="rightright"></div>
                </div>
            </div>
        </form>
    </body>
</html>
