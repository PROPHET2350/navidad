<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Departamentos.aspx.cs" Inherits="Views.Departamentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Departamentos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conten" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
      <ContentTemplate>
              <ol class="breadcrumb">
                <li class="breadcrumb-item">
                    <a href="Empleados.aspx">Home</a>
                </li>
                <li class="breadcrumb-item">Departamentos
                </li>
            </ol>
          <div class="conteiner p-2">
                <asp:HiddenField ID="hf_ContactoId" runat="server" />
                <asp:Panel ID="panelagregar" runat="server" Visible="False">
                    <div class="container mt-5">
                        <div class="card card-login mx-auto mt-5">
                            <div class="card-header">Login</div>
                            <div class="card-body">
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" placeholder="Nombre" onkeypress="return soloLetras(event)" required autofocus="autofocus" ID="txt_nombre" runat="server">

                                    </asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" placeholder="Cargo" onkeypress="return soloLetras(event)" required ID="txt_cargo" runat="server">

                                    </asp:TextBox>
                                </div>
                            </div>
                            <div class="card-footer">
                                <div class="text-center">
                                    <asp:LinkButton ID="btn_eliminar" runat="server" Visible="false" CssClass="btn btn-outline-danger" OnClick="btn_eliminar_Click">Eliminar</asp:LinkButton>
                                    <asp:LinkButton ID="close" runat="server" CssClass="btn btn-outline-secondary" OnClick="close_Click">Cerrar</asp:LinkButton>
                                    <asp:Button ID="btn_agregar" runat="server" Text="Agregar" CssClass="btn btn-outline-success" OnClick="btn_agregar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </div>
          <div class="conteiner m-2 mx-auto">
                <asp:LinkButton ID="show" runat="server" CssClass="btn btn-primary" OnClick="show_Click">Ingresar departamento</asp:LinkButton>
            </div>
            <div class="card mb-3">
                <div class="card-header">
                    <i class="fa fa-users" aria-hidden="true"></i>
                    Departamentos
                </div>
                <div class="card-body">
                    <div class="table-responsive" style="text-align:center;">
                        <asp:GridView CssClass="table table-bordered"  ID="dataTable" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="cargo" HeaderText="Cargo" />
                                <asp:TemplateField HeaderText="Modificar">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnk_ver" runat="server"
                                            CommandArgument='<%#Eval ("id_departamento") %>' CssClass="fas fa-pen" ForeColor="Chartreuse" OnClick="lnk_ver_Click"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <div class="card-footer small text-muted">Updated yesterday at 11:59 PM</div>
            </div>
      </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <script>
    function soloLetras(e){
       key = e.keyCode || e.which;
       tecla = String.fromCharCode(key).toLowerCase();
       letras = " áéíóúabcdefghijklmnñopqrstuvwxyz";
       especiales = "8-37-39-46";

       tecla_especial = false
       for(var i in especiales){
            if(key == especiales[i]){
                tecla_especial = true;
                break;
            }
        }

        if(letras.indexOf(tecla)==-1 && !tecla_especial){
            return false;
        }
    }
</script>
</asp:Content>
