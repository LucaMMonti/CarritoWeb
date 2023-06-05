<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="carrito_web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" class="pb-2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Catalogo de Productos</h1>
        
    <div class="row my-2">
        <div class="col-md-2">   
            <asp:TextBox ID="txtFiltro" runat="server" class="form-control me-2" OnTextChanged="Filtro_textChanged"/>
        </div>
        <div class="col-md-1">    
            <button class="btn btn-outline-success" type="submit">Search</button>
        </div>

       <div class="col-4" style="display:flex; flex-direction:column; justify-content:flex-end">
            <div class="mb-1">
                <asp:CheckBox Text="Filtro avanzado" runat="server" id="swtAvanzado" 
                 AutoPostBack="true" OnCheckedChanged="swtAvanzado_CheckedChanged" />
            </div>
        </div>
    </div>

   <%if (FiltroAvanzado)
     { %>
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:label text="Campo" runat="server" />
                <asp:DropDownList runat="server" id="ddlCampo" AutoPostBack="true" CssClass="form-control"  OnSelectedIndexChange ="ddlCampo_SelectedIndexChanged" >
                    <asp:ListItem Text="Código" />
                    <asp:ListItem Text="Nombre" /> 
                    <asp:ListItem Text="Marca" />
                    <asp:ListItem Text="Categoria" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:label Text="Criterio" runat="server" />
                <asp:DropDownList runat="server" ID="ddlCriterio" CssClass="form-control"></asp:DropDownList>

            </div>
        </div>
    </div>
   <%} %>



    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater id="Repeater1" runat="server">
            <ItemTemplate>
                 <div class="card mx-2 " style="width: 18rem">    
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


