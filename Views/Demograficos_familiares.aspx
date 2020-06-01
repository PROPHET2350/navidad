<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Demograficos_familiares.aspx.cs" Inherits="Views.Demograficos_familiares" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conten" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <ol class="breadcrumb">
                <li class="breadcrumb-item">
                    <a href="Empleados.aspx">Home</a>
                </li>
                <li class="breadcrumb-item">Datos demograficos
                </li>
            </ol>
            <asp:HiddenField runat="server" ID="idEmp" />
            <div class="conteiner p-2">
                <asp:HiddenField ID="hf_ContactoId" runat="server" />
                <div class="container mt-5">
                    <div class="card card-login mx-auto mt-5">
                        <div class="card-header">Login</div>
                        <div class="card-body">
                            <div class="form-group">
                                <asp:TextBox onkeypress="return soloLetras(event)" CssClass="form-control" placeholder="Sexo" required ID="txt_sexo" runat="server">

                                </asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox onkeypress="return soloLetras(event)" CssClass="form-control" placeholder="Estado Civil" required ID="txt_estado" runat="server">

                                </asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" placeholder="Canton" required ID="txt_canton" runat="server">

                                </asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:TextBox onkeypress="return soloLetras(event)" CssClass="form-control" placeholder="Provincia" required ID="txt_provincia" runat="server">

                                </asp:TextBox>
                            </div>
                        </div>
                        <div class="card-footer">
                            <div class="text-center">
                                <asp:LinkButton ID="btn_back" runat="server" CssClass="btn btn-outline-warning" OnClick="btn_back_Click">Back</asp:LinkButton>
                                <asp:Button ID="btn_agregar" runat="server" Text="Agregar" CssClass="btn btn-outline-success" OnClick="btn_agregar_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
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
