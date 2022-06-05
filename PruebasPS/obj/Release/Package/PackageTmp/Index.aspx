<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PruebasPS.Index" %>
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

        <h1 class="index-h1">Inicio</h1>

        <br /><br />

        <div class="index-botonera">  
            
            <div class="index-div-btn-excel">
                <center>
                    <asp:Button ID="BtnExcel" runat="server" Visible="false" CssClass="btn btn-primary index-btn" Text="Analizar Excel" OnClick="BtnExcel_Click" />
                </center>
            </div>

            <div class="index-div-btn-reporte1">
                <center>
                    <asp:Button ID="BtnReporte1" runat="server" Visible="false" CssClass="btn btn-primary index-btn" Text="Reporte 1" OnClick="BtnReporte1_Click" />
                </center>
            </div>

            <div class="index-div-btn-reporte2">
                <center>
                    <asp:Button ID="BtnReporte2" runat="server" Visible="false" CssClass="btn btn-primary index-btn" Text="Reporte 2" Onclick="BtnReporte2_Click" />
                </center>
            </div>
            
        </div>
    </center>

</asp:Content>
