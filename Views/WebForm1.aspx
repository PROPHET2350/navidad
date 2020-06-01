<%@ Page Title="" Language="C#" MasterPageFile="~/template.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Views.WebForm1" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Todo
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conten" runat="server">
    <asp:scriptmanager runat="server"></asp:scriptmanager>
            <ol id="assss" class="breadcrumb">
        <li class="breadcrumb-item">
            <a href="Empleados.aspx">Home</a>
        </li>
        <li class="breadcrumb-item">Reportes de cursos
        </li>
    </ol>
<rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" BorderColor="Gray" BorderStyle="Double" BorderWidth="2px" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="1055px">
    <LocalReport ReportPath="Report2.rdlc">
        <DataSources>
            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
        </DataSources>
    </LocalReport>
</rsweb:ReportViewer>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="Views.DataSet1TableAdapters.DataTable5TableAdapter"></asp:ObjectDataSource>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
