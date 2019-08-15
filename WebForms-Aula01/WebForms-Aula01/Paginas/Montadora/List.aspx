<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebForms_Aula01.Paginas.Montadora.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="header">
        <h1>Lista de Montadora</h1>
        <h2>Tabela das Montadoras</h2>
    </div>

    <div class="content">
        <div class="pure-form pure-form-stacked">
          <table class="pure-table">
    <thead>
        <tr>
            <th>ID</th>
            <th>Marca</th>
            <th>Modelo</th>
            <th>Ano</th>
        </tr>
    </thead>

    <tbody>
        <tr class="pure-table-odd">
            <td>1</td>
            <td>Honda</td>
            <td>Accord</td>
            <td>2009</td>
        </tr>

        <tr>
            <td>2</td>
            <td>Toyota</td>
            <td>Camry</td>
            <td>2012</td>
        </tr>

        <tr class="pure-table-odd">
            <td>3</td>
            <td>Hyundai</td>
            <td>Elantra</td>
            <td>2010</td>
        </tr>

        <tr>
            <td>4</td>
            <td>Ford</td>
            <td>Focus</td>
            <td>2008</td>
        </tr>

        <tr class="pure-table-odd">
            <td>5</td>
            <td>Nissan</td>
            <td>Sentra</td>
            <td>2011</td>
        </tr>

        <tr>
            <td>6</td>
            <td>BMW</td>
            <td>M3</td>
            <td>2009</td>
        </tr>

        <tr class="pure-table-odd">
            <td>7</td>
            <td>Honda</td>
            <td>Civic</td>
            <td>2010</td>
        </tr>

        <tr>
            <td>8</td>
            <td>Kia</td>
            <td>Soul</td>
            <td>2010</td>
        </tr>
    </tbody>
</table>
        </div>
    </div>
</asp:Content>
