<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WebForms_Aula01.Paginas.Montadora.Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h1>Montadora</h1>
        <h2>Cadastrar novas montadoras</h2>
    </div>

    <div class="content">
        <div class="pure-form pure-form-stacked">
            <fieldset>
                <legend>Formulário de cadastro</legend>

                <label for="email">Nome Montadora</label>
                <asp:TextBox ID="txtNomeMontadora" runat="server" />

                <asp:RequiredFieldValidator ID="rfvNomeMontadora"
                    runat="server"
                    ErrorMessage="Campo obrigatório"
                    ControlToValidate="txtNomeMontadora">

                </asp:RequiredFieldValidator>

                <asp:Button ID="btnCadastrar"
                    runat="server"
                    Text="Salvar"
                    CssClass="pure-button pure-button-primary"  />

                <asp:Button ID="btnCancelar"
                    runat="server"
                    Text="Cancelar"
                    CssClass="pure-button pure-button-primary"  />
            </fieldset>
        </div>
    </div>
</asp:Content>
