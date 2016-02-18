<%@ Page Title="" Language="C#" MasterPageFile="~/MusicBlog.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Vista.Usuario.Registro" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-horizontal">
        <div class="modal-content">
            <div class="modal-header">
                <h1 class="text-center">Registro de Clientes</h1>
            </div>
            <div class="modal-body">
                <asp:Panel ID="pRegistro" runat="server" CssClass="form col-md-12 center-block">
                    <asp:Panel ID="pDatosPersonales" runat="server" CssClass="form col-md-12 center-block">
                        <div class="form-group col-md-12 pull-left">
                            <h2 class="text-left">Datos Personales</h2>
                        </div>

                        <div class="form-group col-md-6 pull-left">
                            <asp:Label ID="lblNombre" runat="server" Text="<%$ Resources:Text,TextNombre %>"></asp:Label> 
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            
                        </div>

                        <div class="form-group col-md-6 pull-right">
                            <asp:Label ID="lblApellido" runat="server" Text="<%$ Resources:Text,TextApellido %>"></asp:Label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            
                        </div>

                        <div class="form-group col-md-6">
                            <asp:Label ID="lblFechaNacimiento" runat="server" Text="<%$ Resources:Text,TextFechaNacimiento %>" ></asp:Label>
                            <asp:TextBox ID="txtFechaNacimiento" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            <asp:CalendarExtender ID="CalendarExtender1" runat="server" CssClass="glyphicon-calendar" TargetControlID="txtFechaNacimiento" Format="dd/MM/yyyy"  Animated="true" PopupPosition="BottomRight"/>
                            
                        </div>

                        <div class="form-group col-md-6 pull-right">
                            <asp:Label ID="lblCorreo" runat="server" Text="<%$ Resources:Text,TextCorreo %>"></asp:Label>
                            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            
                        </div>
                        <div class="form-group col-md-12">
                            <asp:Label ID="lblSexo" runat="server" Text="<%$ Resources:Text,TextSexo %>"></asp:Label>
                            <asp:RadioButtonList ID="rblSexo" runat="server"  CssClass="radio-inline">
                                <asp:ListItem Text="<%$ Resources:Text,TextSexoM %>" Value="M" ></asp:ListItem>
                                <asp:ListItem Text="<%$ Resources:Text,TextSexoF %>" Value="F" ></asp:ListItem>
                            </asp:RadioButtonList>
                            
                        </div>
                    </asp:Panel>
                    <asp:Panel runat="server" ID="pDatosUsuario" CssClass="form col-md-12 center-block">
                        <div class="form-group col-md-12 pull-left">
                            <h2 class="text-left">Datos del Usuario</h2>
                        </div>

                        <div class="form-group col-md-6 pull-left">
                            <asp:Label ID="lblUsuario" runat="server" Text="<%$ Resources:Text,TextUsuario %>"></asp:Label>
                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                            
                        </div>

                        <div class="form-group col-md-6 pull-right">
                            <asp:Label ID="lblPassword" runat="server" Text="<%$ Resources:Text,TextPassword %>"></asp:Label>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control input-sm" TextMode="Password"></asp:TextBox>
                            
                        </div>

                        <div class="form-group col-md-6 pull-left">
                            <asp:Label ID="lblRepetirPassword" runat="server" Text="<%$ Resources:Text,TextRepetirPassword %>"></asp:Label>
                            <asp:TextBox ID="txtRepetirPassword" runat="server" CssClass="form-control input-sm" TextMode="Password"></asp:TextBox>
                            
                        </div>
                        <div class="form-group col-md-6 pull-right">
                            <asp:PasswordStrength ID="PasswordStrength1" runat="server" TargetControlID="txtPassword" DisplayPosition="BelowLeft"/>
                        </div>
                        <div class="form-group col-md-12">
                            <div class="col-lg-10 col-lg-offset-2 pull-right">
                                <asp:Button ID="btnCancelar" runat="server" Text="<%$ Resources:Text,TextCancelar %>" CssClass="btn btn-default" OnClick="btnCancelar_OnClick"/>
                                <asp:Button ID="btnRegistrar" runat="server" Text="<%$ Resources:Text,TextAceptar %>" CssClass="btn btn-primary" OnClick="btnRegistrar_OnClick"/>
                            </div>
                        </div>
                    </asp:Panel>
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
                    <asp:Button runat="server" ID="btnCancelar2" CssClass="btn btn-default" Text="<%$ Resources:Text,TextCancelar %>"/>
                    <asp:Button runat="server" ID="btnAceptar" CssClass="btn btn-primary" Text="<%$ Resources:Text,TextAceptar %>" />
                </div>
            </div>
        </asp:Panel>
    </div>
</asp:Content>
