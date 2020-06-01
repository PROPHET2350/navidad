<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="Reporte_curso.aspx.cs" Inherits="Views.Reporte_curso" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Reporte cursos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conten" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <ol id="assss" class="breadcrumb">
        <li class="breadcrumb-item">
            <a href="Empleados.aspx">Home</a>
        </li>
        <li class="breadcrumb-item">Reportes de cursos
        </li>
    </ol>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="1055px" BorderColor="Gray" BorderStyle="Double" BorderWidth="2px" Style="margin-top: 43px" CssClass="dataTable">
        <LocalReport ReportPath="Report_cur.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="Views.DataSet1TableAdapters.DataTable1TableAdapter"></asp:ObjectDataSource>
    <div class="container mt-2">
        <div class="d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0">
        <div class="input-group">
            <asp:DropDownList ID="DropDownList1" OnTextChanged="DropDownList1_TextChanged" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" DataSourceID="ObjectDataSource1" DataTextField="nombre" DataValueField="nombre" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
        </div>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
