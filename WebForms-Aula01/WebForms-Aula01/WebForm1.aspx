<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForms_Aula01.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Nome
                    </td>
                    <td>
                        <asp:TextBox ID="TextNome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        Sobrenome
                    </td>
                    <td>
                        <asp:TextBox ID="TextSobrenome" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                   
                    <td>
                        <asp:Button ID="BtnCanvelar" runat="server" Text="Cancelar" OnClick="BtnCanvelar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="BtnOk" runat="server" Text="OK" OnClick="BtnOk_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblNomeCompleto" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
