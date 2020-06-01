<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Report_general.aspx.cs" Inherits="Views.Report_general" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Reporte general
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conten" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
        <ol id="assss" class="breadcrumb">
        <li class="breadcrumb-item">
            <a href="Empleados.aspx">Home</a>
        </li>
        <li class="breadcrumb-item">Reportes General
        </li>
    </ol>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" BorderColor="Gray" BorderStyle="Double" BorderWidth="2px" ClientIDMode="AutoID" CssClass="dataTable" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="1055px">
        <LocalReport ReportPath="Reporte_general.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="Views.DataSet1TableAdapters.DataTable3TableAdapter"></asp:ObjectDataSource>
    <div class="container mt-2">
        <div class="d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0">
            <div class="input-group">
                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                <div style="margin-left:7px;">
                    <asp:Button ID="Button1" CssClass="btn btn-primary"  OnClick="Button1_Click" runat="server" Text="Button" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
