<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Aluno_Excluir.aspx.cs" Inherits="SchoolSystem.Aluno_Excluir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    
   <asp:Panel runat="server" ID="pnlExcluir" Visible="true">
        <h1>Excluir Aluno</h1>
        <ul>
            <li>
                <asp:Label ID="Label8" runat="server" Text="Cód. Aluno"></asp:Label>
                <asp:TextBox ID="tbCodAluno" Text="2013" Enabled="false" CssClass="radiusInput disable" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Nome" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbNome" Text="" Enabled="False" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label ID="Label2" runat="server" Text="Endereço"></asp:Label>
                <asp:TextBox ID="tbEndereco" Enabled="False" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            
            <li>
                <asp:Label ID="Label4" runat="server" Text="CEP"></asp:Label>
                <asp:TextBox ID="tbCEP" Enabled="False" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            
            <li>
                <asp:Label ID="Label5" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="tbTelefone" Enabled="False" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Label ID="Label6" runat="server" Text="Celular"></asp:Label>
                <asp:TextBox ID="tbCelular" Enabled="False" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            
             <li>
                <asp:Label ID="Label7" runat="server" Text="Data de Nascimento"></asp:Label>
                <asp:TextBox ID="tbDataNasc" Enabled="False" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>           


            <li>
                <asp:Label ID="Label3" runat="server" Text="Data de Cadastro"></asp:Label>
                <asp:TextBox ID="tbDataCadastro" CssClass="disable radiusInput" Enabled="False" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Button ID="btnExcluir" CssClass="btnDelete btn" OnClick="btnExcluir_Click"  runat="server" Text="Excluir" />
            </li>
        </ul>
    </asp:Panel>
  
    
    

</asp:Content>
