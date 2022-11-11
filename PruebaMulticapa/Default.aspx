<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PruebaMulticapa._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <div class="row">
            <div class="col-md-4">
                 <asp:Button ID="btnMostrarNombre" runat="server" Text="Obtener Empleado" OnClick="btnMostrarNombre_Click" />
            </div>
    
            <div class="col-md-4">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre Empleado"></asp:Label><br /> 
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
                <hr />
                <br />
                <asp:Label ID="lblEdad" runat="server" Text="Edad Empleado"></asp:Label><br />  
                <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            </div>
      </div>
</asp:Content>
