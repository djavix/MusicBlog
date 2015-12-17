<%@ Page Title="" Language="C#" MasterPageFile="~/MusicBlog.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vista.Usuario.Login" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h1 class="text-center">Login</h1>
            </div>
            <div class="modal-body">
                <asp:Panel ID="pLogin" runat="server" CssClass="form col-md-12 center-block">
                    <div class="form-group">
                        <asp:TextBox ID="txtUser" runat="server" CssClass="form-control input-lg" placeholder="<%$ Resources:Text,TextUsuario %>"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtPasword" TextMode="Password" runat="server" CssClass="form-control input-lg" placeholder="<%$ Resources:Text,TextPassword %>"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnEntrar" runat="server" Text="<%$ Resources:Text,TextEntrar %>" class="btn btn-primary btn-lg btn-block" OnClick="btnEntrar_OnClick"/>
                        <asp:HyperLink ID="hpRegister" runat="server" class="pull-right" Text="<%$ Resources:Text,TextRegistrarse %>" NavigateUrl="#"></asp:HyperLink>
                    </div>
                </asp:Panel>
            </div>
            <div class="modal-footer">
                <div class="col-md-12">
		        </div>	
            </div>
        </div>
    </div>
</asp:Content>
