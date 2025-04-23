<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Github_Demo.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mexicola Final Project</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .team-section {
            margin-top: 40px;
        }
        .solution-buttons .btn {
            margin: 5px;
        }
        .results-section {
            margin-top: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container text-center">
            <h1 class="mt-5 fw-bold">We are Mexicola!</h1>
            <h4 class="team-section">Team Members: Gabe Galiatsatos, Blake Miller, Co Nguyen, Brad Caldwell</h4>

            <div class="solution-buttons mt-4">
                <asp:Button ID="btnClear" runat="server" Text="Clear Leetcode Solution" CssClass="btn btn-outline-secondary" OnClick="btnClear_Click" />
                <asp:Button ID="btnSolution68" runat="server" Text="Solution #68" CssClass="btn btn-success" OnClick="btnSolution68_Click" />
                <asp:Button ID="btnSolution123" runat="server" Text="Solution #123" CssClass="btn btn-info" OnClick="btnSolution123_Click" />
                <asp:Button ID="btnSolution3382" runat="server" Text="Solution #3382" CssClass="btn btn-warning" OnClick="btnSolution3382_Click" />
                <asp:Button ID="btnSolution420" runat="server" Text="Solution #420" CssClass="btn btn-danger" OnClick="btnSolution420_Click" />
                
            </div>

            <div class="results-section text-left">
                <asp:Label ID="lblSolutionText" runat="server" CssClass="mt-4 d-block fs-5 text-dark"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
