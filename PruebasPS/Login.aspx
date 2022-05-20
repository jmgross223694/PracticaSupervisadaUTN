<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PruebasPS.Login1" %>
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

        <h1 class="login-h1">Login</h1>

        <br />

        <div>  
            
            <div class="form-group stl-frm-log">
                <label for="exampleInputEmail1">Usuario</label>
                <asp:TextBox ID="txtUser" runat="server" CssClass="form-control" placeholder="Usuario" MaxLength="10" />
            </div>

            <div class="form-group">
                <label for="exampleInputPassword1">Contraseña</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="*****" type="password" MaxLength="20" />
            </div>

            <asp:Button ID="btnIngresar" runat="server" CssClass="btn btn-primary" Text="Iniciar Sesión" OnClick="BtnIngresar_Click" />
                            
        </div>
    </center>

</asp:Content>
