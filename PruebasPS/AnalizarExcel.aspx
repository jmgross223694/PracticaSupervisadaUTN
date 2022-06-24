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

                <asp:Label Text="(Sólo se permiten archivos '.xls / .xlsx')" runat="server" />

                <br /><br />

                <asp:FileUpload ID="CargarArchivo" runat="server" accept=".xls,.xlsx" ToolTip="Seleccione un archivo Excel" />
            </div>

            <br />

            <div>
                <asp:Button ID="BtnProcesarArchivo" Text="Procesar archivo" class="excel-btn-procesar-archivo" runat="server" OnClick="BtnProcesarArchivo_Click" />

                <br /><br />

                <asp:Label ID="LblMensaje" Visible="false" Text="" runat="server" CssClass="lbl-mensaje" />

                <br /><br />

                <asp:DataGrid ID="dgvRegistrosActualizados" runat="server" Visible="False" CellPadding="3" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" Mode="NumericPages" />
                    <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />

                </asp:DataGrid>

            </div>
        </div>
    </center>

</asp:Content>
