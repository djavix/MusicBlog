<%@ Page Title="" Language="C#" MasterPageFile="~/MusicBlog.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Vista.Usuario.Login" EnableEventValidation="false" %>
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
                        <asp:TextBox ID="txtUser" runat="server" CssClass="form-control input-lg" placeholder="<%$ Resources:Text,TextUsuario %>" OnBlur="" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtPasword" TextMode="Password" runat="server" CssClass="form-control input-lg" placeholder="<%$ Resources:Text,TextPassword %>"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnEntrar" runat="server" Text="<%$ Resources:Text,TextEntrar %>" class="btn btn-primary btn-lg btn-block" OnClick="btnEntrar_OnClick"/>
                        <asp:HyperLink ID="hpRegister" runat="server" class="pull-right" Text="<%$ Resources:Text,TextRegistrarse %>" NavigateUrl="~/Usuario/Registro.aspx" />
                    </div>
                </asp:Panel>
            </div>
            <div class="modal-footer">
                <div class="col-md-12">
		        </div>	
            </div>
        </div>
    </div>
    <div>
        <asp:Button runat="server" ID="btnOculto" style="display:none"/>
        <asp:ModalPopupExtender ID="mpeMensaje" PopupControlID="pnlMensaje" TargetControlID="btnOculto" runat="server" OkControlID="btnAceptar" ></asp:ModalPopupExtender>
        <asp:Panel ID="pnlMensaje" runat="server">
            <div class="panel panel-danger">
                <div class="panel-heading">
                    <h3 class="panel-title">
                        <asp:Label ID="lblTitulo" runat="server"></asp:Label>
                    </h3>
                </div>
                <div class="panel-body">
                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </div>
                <div class="panel-footer" align="right">
                    <asp:Button runat="server" ID="btnCancelar" CssClass="btn btn-default" Text="<%$ Resources:Text,TextCancelar %>"/>
                    <asp:Button runat="server" ID="btnAceptar" CssClass="btn btn-primary" Text="<%$ Resources:Text,TextAceptar %>" />
                </div>
            </div>
        </asp:Panel>
    </div>
</asp:Content>
