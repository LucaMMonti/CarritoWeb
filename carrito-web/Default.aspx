<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="carrito_web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="row row-cols-1 row-cols-md-3 g-4">
    <asp:Repeater id="Repeater1" runat="server">
        <ItemTemplate>
            <div class="card" style="width: 18rem;">    
                <img src="<%#Eval("Imagen.ImagenUrl") %>" class="card-img-top" alt="...">
                 <div class="card-body">
                     <h5 class="card-title"><%#Eval("Nombre") %></h5>
                     <p class="card-text"><%#Eval("Descripcion") %></p>
                     <a href="#" class="btn btn-primary">Go somewhere</a>
                 </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
</asp:Content>


