<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="SchoolSystem.Aluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="server">
    
    
    <asp:Panel runat="server" ID="pnlShowData" Visible="true">
        <h1>Todos os Alunos Cadastrados</h1>
        <asp:GridView ID="gwDados" runat="server" EmptyDataText="Não Existem Aluno(s) Cadastrados..." AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="idAluno" HeaderText="Código" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Endereco" HeaderText="Endereco" />
                <asp:BoundField DataField="Cep" HeaderText="Cep" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                <asp:BoundField DataField="Celular" HeaderText="Celular" />
                <asp:BoundField DataField="dataNascimento" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Data de Nascimento" />
                <asp:BoundField DataField="dataCadastro" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Data de Cadastro" />
                <asp:HyperLinkField DataNavigateUrlFields="idAluno" DataNavigateUrlFormatString="Aluno_Edit.aspx?id={0}" Text="Editar" />
                <asp:HyperLinkField DataNavigateUrlFields="idAluno" DataNavigateUrlFormatString="Aluno_Excluir.aspx?id={0}" Text="Excluir" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel runat="server" ID="pnlSearch" Visible="true">
        <h1>Pesquisa de Aluno(s)</h1>
        <fieldset>
            <legend>Opções de Pesquisa</legend>
            <asp:RadioButtonList ID="rlbTypeSearch" CssClass="rlbTypeSearch" runat="server" RepeatLayout="UnorderedList">
                <asp:ListItem Value="ID" Selected="True">Código</asp:ListItem>
                <asp:ListItem>Nome</asp:ListItem>
                <asp:ListItem Value="Endereco">Endereço</asp:ListItem>
            </asp:RadioButtonList>
        </fieldset>
        <ul>

            
            <li>
                <asp:Label Text="Código" ID="label1" runat="server"></asp:Label>
                <asp:TextBox ID="tbPesqID" Text="" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>
            <li>
                <asp:Label Text="Nome" ID="label9" runat="server"></asp:Label>
                <asp:TextBox ID="tbPesqNome" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>

            <li>
                <asp:Label Text="Endereço" ID="label2" runat="server"></asp:Label>
                <asp:TextBox ID="tbEndereco" CssClass="radiusInput" runat="server"></asp:TextBox>
            </li>


            <li>
                <asp:Button ID="btnSearch" CssClass="btn btnSearch" runat="server" Text="Pesquisar" OnClick="btnSearch_Click" />
            </li>
            
            <li>
               <asp:Button ID="btnLimpaPesq" CssClass="btn btnSearchClear" runat="server" Text="Limpar Pesquisa" OnClick="btnLimpaPesq_Click" />
            </li>

        </ul>
    </asp:Panel>
    
    

</asp:Content>
