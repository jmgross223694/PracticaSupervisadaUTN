<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="PruebasPS.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <center>
        <img class="img-error" src="img/del-logo.png" width="10%"/>
        <h1>Hubo un problema</h1>
        Detalles: <asp:label text="" ID="lblMensaje" runat="server" />
    </center>

</asp:Content>
