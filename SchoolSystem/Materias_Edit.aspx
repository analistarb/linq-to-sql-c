<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Materias_Edit.aspx.cs" Inherits="SchoolSystem.Materias_Edit" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    
    <asp:Panel runat="server" ID="pnlUpdate" Visible="true">
        <h1>Atualizar Matérias</h1>
        <ul>
            <li>
                <asp:Label ID="Label6" runat="server" Text="Cód. Matéria"></asp:Label>
                <asp:TextBox ID="tbCodMateria" Text="2013" Enabled="false" CssClass="radiusInput disable" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Nome" ID="label4" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label5" runat="server" Text="Descrição"></asp:Label>
                <asp:TextBox ID="tbDescricao" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Button ID="bntAtualizar" CssClass="btn btnEdit" runat="server" Text="Atualizar" OnClick="bntAtualizar_Click" />
            </li>
        </ul>
    </asp:Panel>

</asp:Content>
