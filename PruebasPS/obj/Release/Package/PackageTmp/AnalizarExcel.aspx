<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AnalizarExcel.aspx.cs" Inherits="PruebasPS.AnalizarExcel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        body {            
            background-image: url("../img/fondo-body.jpg");
            background-color: #FFFFFF4D !important;
            width: 100%;
            height: 100vh;
            background-size: cover;
            background-position: center;
        }        
    </style>

    <center>
        <h1 class="index-h1">Analizar Excel</h1>

        <br /><br />

        <div>
            <div class="excel-cargar-archivo">
                <asp:FileUpload ID="CargarArchivo" runat="server" ToolTip="Cargar archivo Excel aquí" />
            </div>

            <br />

            <div>
                <asp:Button ID="BtnProcesarArchivo" Text="Procesar archivo" class="excel-btn-procesar-archivo" runat="server" OnClick="BtnProcesarArchivo_Click" />

                <br /><br />

                <asp:Label ID="LblMensaje" Visible="false" Text="" runat="server" CssClass="lbl-mensaje" />
            </div>
        </div>
    </center>

</asp:Content>
