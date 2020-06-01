<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="Views.Empleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Empleados
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conten" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <ol class="breadcrumb">
                <li class="breadcrumb-item">
                    <a href="Empleados.aspx">Home</a>
                </li>
                <li class="breadcrumb-item">Empleados
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
                                    <asp:TextBox  onkeypress="return soloLetras(event)" CssClass="form-control" placeholder="nombre" required autofocus="autofocus" ID="txt_nombre" runat="server">

                                    </asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox  onkeypress="return soloLetras(event)" CssClass="form-control" placeholder="Apellido" required ID="txt_apellido" runat="server">

                                    </asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox TextMode="Number" MaxLength="10" CssClass="form-control" placeholder="Cedula" required ID="txt_cedula" runat="server">

                                    </asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox TextMode="Email" CssClass="form-control" placeholder="Email" required ID="txt_mail" runat="server">

                                    </asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox TextMode="Number" CssClass="form-control" placeholder="Telefono" required ID="txt_telefono" runat="server">

                                    </asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox TextMode="Password" CssClass="form-control" placeholder="Contraseña" required ID="txt_pass" runat="server">

                                    </asp:TextBox>
                                </div>
                            </div>
                            <div class="card-footer">
                                <div class="text-center">
                                    <asp:LinkButton ID="btn_eliminar" runat="server" Visible="false" CssClass="btn btn-outline-danger" OnClick="btn_eliminar_Click">Eliminar</asp:LinkButton>
                                    <asp:LinkButton ID="mostrar" runat="server" CssClass="btn btn-outline-secondary" OnClick="mostrar_Click">Cerrar</asp:LinkButton>
                                    <asp:Button ID="btn_agregar" runat="server" Text="Agregar" CssClass="btn btn-outline-success" OnClick="btn_agregar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <div class="conteiner m-2 mx-auto">
                <asp:LinkButton ID="show" runat="server" CssClass="btn btn-primary" OnClick="show_Click">Ingresar empleado</asp:LinkButton>
            </div>
            <div class="card mb-3">
                <div class="card-header">
                    <i class="fa fa-users" aria-hidden="true"></i>
                    Empleados
                </div>
                <div class="card-body">
                    <div class="table-responsive" style="text-align: center;">
                        <asp:GridView CssClass="table table-bordered" ID="dataTable" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                <asp:BoundField DataField="cedula" HeaderText="Cedula" />
                                <asp:BoundField DataField="mail" HeaderText="Email" />
                                <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                                <asp:TemplateField HeaderText="Modificar">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnk_ver" runat="server"
                                            CommandArgument='<%#Eval ("id_empleado") %>' CssClass="fas fa-pen" ForeColor="Chartreuse" OnClick="lnk_ver_Click"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Familiares">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="delete" runat="server"
                                            CommandArgument='<%#Eval ("id_empleado") %>' CssClass="delet" OnClick="delete_Click">Familia</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Departamentos">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btn_cursos" runat="server"
                                            CommandArgument='<%#Eval ("id_empleado") %>' CssClass="delet" OnClick="btn_cursos_Click">Departamentos</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Cursos">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btn_dep" runat="server"
                                            CommandArgument='<%#Eval ("id_empleado") %>' CssClass="delet" OnClick="btn_dep_Click">Cursos</asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Info">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btn_info" runat="server"
                                            CommandArgument='<%#Eval ("id_empleado") %>' CssClass="delet" OnClick="btn_info_Click">Info</asp:LinkButton>
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
    <%--<script src="dist/js/Empleados.js"></script>--%>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <script>
        function soloLetras(e) {
            key = e.keyCode || e.which;
            tecla = String.fromCharCode(key).toLowerCase();
            letras = " áéíóúabcdefghijklmnñopqrstuvwxyz";
            especiales = "8-37-39-46";

            tecla_especial = false
            for (var i in especiales) {
                if (key == especiales[i]) {
                    tecla_especial = true;
                    break;
                }
            }

            if (letras.indexOf(tecla) == -1 && !tecla_especial) {
                return false;
            }
        }
    </script>
</asp:Content>
