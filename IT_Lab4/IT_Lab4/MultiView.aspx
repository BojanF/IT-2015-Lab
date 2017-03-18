<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiView.aspx.cs" Inherits="IT_Lab4.MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 138px;
        }
        .auto-style3 {
            width: 529px;
        }
        .auto-style4 {
            width: 200px;
        }
        .auto-style6 {
            margin-left: 0px;
        }
        .auto-style7 {
            width: 155px;
        }
        .auto-style8 {
            width: 224px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
            width: 310px;
        }
        .auto-style11 {
            width: 310px;
        }
    </style>
    
</head>

<body>
    <form id="form1" runat="server">
    <div>
        <asp:multiview ID="mwReg" runat="server">
            <asp:View ID="View1" runat="server">
                <div> 
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style1">Име</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="ime" runat="server" Width="207px" EnableTheming="True"></asp:TextBox>
                            </td>
                            <td class="auto-style3">
                                <asp:RequiredFieldValidator ID="imeValid" runat="server" ControlToValidate="ime" ErrorMessage="внесете име" Font-Bold="True" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">Презиме</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="prezime" runat="server" Width="208px"></asp:TextBox>
                            </td>
                            <td class="auto-style3">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="prezime" Display="None" ErrorMessage="внесете презиме" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">ФИНКИ ID</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="fid" runat="server" Width="208px"></asp:TextBox>@finki.ukim.mk
                            </td>
                            <td class="auto-style3">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="fid" Display="None" ErrorMessage="внесете ID" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="fid" Display="None" ErrorMessage="ID не е во зададениот формат" Font-Bold="True" ForeColor="Red" ValidationExpression="[A-Z]+[A-Z0-9]*_*[0-9][0-9][0-9]*"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" class="auto-style1">
                                <asp:Label ID="Label1" runat="server" Text="
                                    се состојат од големи букви, цифри и евентуално една _ после која ќе има барем две цифри
                                " Font-Size="Small"></asp:Label></td>
                            
                        </tr>
                        <tr>
                            <td class="auto-style1">Лозинка</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="pw1" runat="server" TextMode="Password" Width="206px"></asp:TextBox>
                            </td>
                            <td class="auto-style3">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="pw1" Display="None" ErrorMessage="внеси лозинка" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pw2" ControlToValidate="pw1" Display="None" ErrorMessage="лозниките се различни" Font-Bold="True" ForeColor="Red"></asp:CompareValidator>
                            </td>
                        </tr>                        
                        <tr>
                            <td class="auto-style1">Потврда</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="pw2" runat="server" TextMode="Password" Width="206px"></asp:TextBox>
                            </td>
                            <td class="auto-style3">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="pw2" Display="None" ErrorMessage="внеси ја лозинката пак" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" ForeColor="Red" />
                    <br />
                    <asp:Button ID="v1D" runat="server" OnClick="v1D_Click" Text="&gt;&gt;&gt;" />
                </div>
            </asp:View>
             <asp:View ID="View2" runat="server">
                 <div> 
                     <table style="width:100%;">
                         <tr>
                             <td class="auto-style7">Адреса</td>
                             <td class="auto-style8">
                                 <asp:TextBox ID="adr" runat="server" Width="205px"></asp:TextBox>
                             </td>
                             <td>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="adr" ErrorMessage="внесете адреса" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style7">Телефон</td>
                             <td class="auto-style8">
                                 <asp:TextBox ID="tel" runat="server" Width="201px" CssClass="auto-style6"></asp:TextBox>
                             </td>
                             <td>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tel" ErrorMessage="внесете телефонски број" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator> <br />
                                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tel" ErrorMessage="телефонот не го задоволува форматот" Font-Bold="True" ForeColor="Red" ValidationExpression="[+]389\s2\s[0-9]{4,4}\s[0-9]{3,3}|[+]389\s7[0-2,4-8]\s[0-9]{3,3}\s[0-9]{3,3}"></asp:RegularExpressionValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style7">Пол</td>
                             <td class="auto-style8">
                                 <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                                     <asp:ListItem>M</asp:ListItem>
                                     <asp:ListItem>Ж</asp:ListItem>
                                 </asp:RadioButtonList>
                             </td>
                             <td>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="изберете пол" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style7">Датум на раѓање</td>
                             <td class="auto-style8">
                                 <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                                 
                                 
                             </td>
                             <td>                                 
                                 &nbsp;</td>
                         </tr>
                     </table>
                     <br />
                     <asp:Button ID="v2L" runat="server" OnClick="v2L_Click" Text="&lt;&lt;&lt;" />
                     <asp:Button ID="v2D" runat="server" OnClick="v2D_Click" Text="&gt;&gt;&gt;" />
                 </div>
            </asp:View>
             <asp:View ID="View3" runat="server">
                 <div> 
                     <table style="width:100%;">
                         <tr>
                             <td class="auto-style10">Занимање</td>
                             <td class="auto-style9"></td>
                         </tr>
                         <tr>
                             <td class="auto-style11">
                                 <asp:DropDownList ID="DropDownList1" runat="server">
                                     <asp:ListItem>-занимање-</asp:ListItem>
                                     <asp:ListItem>-водоинсталатер-</asp:ListItem>
                                     <asp:ListItem>-плочкар-</asp:ListItem>
                                     <asp:ListItem>-инженер-</asp:ListItem>
                                     <asp:ListItem>-доктор-</asp:ListItem>
                                 </asp:DropDownList>
                             </td>
                             <td>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DropDownList1" ErrorMessage="изберете занимање" Font-Bold="True" ForeColor="Red" InitialValue="-занимање-"></asp:RequiredFieldValidator>
                             </td>
                         </tr>
                         <tr>
                             <td class="auto-style11">Години на вршење на избраната дејност</td>
                             <td>&nbsp;</td>
                         </tr>
                         <tr>
                             <td class="auto-style11">
                                 <asp:TextBox ID="iskustvo" runat="server" TextMode="Number" Width="131px"></asp:TextBox>
                             </td>
                             <td>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="iskustvo" ErrorMessage="внесете работно искуство" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                                 <br />
                                 <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="iskustvo" ErrorMessage="недозволена вредност" Font-Bold="True" ForeColor="Red" MaximumValue="100" MinimumValue="5" Type="Integer"></asp:RangeValidator>
                             </td>
                         </tr>                         
                     </table>
                     <br />
                     <asp:Button ID="v3L" runat="server" OnClick="v3L_Click" Text="&lt;&lt;&lt;" />
                     <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Поднеси" />
                 </div>
            </asp:View>
             <asp:View ID="View4" runat="server">
                 <div> Креиран е корисникот
                     <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
                     <br />
                     <asp:Button ID="start" runat="server" OnClick="start_Click" Text="Врати се на почеток" />
                 </div>
            </asp:View>
        </asp:multiview>
    </div>
    </form>
</body>
</html>
