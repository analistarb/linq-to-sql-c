<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Curso_Add.aspx.cs" Inherits="SchoolSystem.Curso_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    
    <asp:Panel runat="server" ID="pnlCadastro" Visible="true">
        <h1>Cadastro de Curso</h1>
        <ul>
            <li>
                <asp:Label Text="Nome" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label2" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="tbDescricao" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label3" runat="server" Text="Data de Cadastro"></asp:Label>
                <asp:TextBox ID="tbDataCadastro" CssClass="disable radiusInput" Enabled="False" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Button ID="btnCadastrar" CssClass="btnAdd btn" OnClick="btnCadastrar_Click" runat="server" Text="Cadastrar" />
            </li>
        </ul>
    </asp:Panel>
    

</asp:Content>
