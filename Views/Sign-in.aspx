﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign-in.aspx.cs" Inherits="Views.Sign_in" %>

<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>SB Admin - Login</title>

    <!-- Custom fonts for this template-->
    <link href="dist/vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">

    <!-- Custom styles for this template-->
    <link href="dist/css/sb-admin.css" rel="stylesheet">
</head>

<body class="bg-dark">

    <div class="container mt-5">
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            <div class="alert alert-danger alert-dismissible fade show" role="alert">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
              <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
        </asp:Panel>
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">Login</div>
            <div class="card-body">
                <form id="formlog" method="post" runat="server">
                    <asp:HiddenField ID="contador" runat="server" Value="0"/>
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:TextBox TextMode="Email" CssClass="form-control" placeholder="Email address" required autofocus="autofocus" ID="inputEmail" runat="server">

                            </asp:TextBox>
                            <label for="inputEmail">Email address</label>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:TextBox TextMode="Password" CssClass="form-control" placeholder="Password" required ID="inputPassword" runat="server">

                            </asp:TextBox>
                            <label for="inputPassword">Password</label>
                        </div>
                    </div>
                    <asp:Button CssClass="btn btn-primary btn-block" Text="Sign in" ID="btn_login" runat="server" OnClick="btn_login_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="#">Register an Account</a>
                </div>
            </div>
        </div>
    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="dist/vendor/jquery/jquery.min.js"></script>
    <script src="dist/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="dist/vendor/jquery-easing/jquery.easing.min.js"></script>

</body>

</html>