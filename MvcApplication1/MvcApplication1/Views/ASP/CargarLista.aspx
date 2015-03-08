<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargarLista.aspx.cs" Inherits="MvcApplication1.Views.ASP.CargarLista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload Championships</title>
</head>
<body>
    <br />     
            <table>
                <tr>
                    <td align="center">
                        <asp:Label id="lblTitulo" runat="server"></asp:Label> <br />
                        <asp:fileupload  id="fuSubirArchivo" runat="server" onclick="btnAddArvhicos_Click"></asp:fileupload>                                                             
                    </td>
                </tr>                                           
            </table>
</body>
</html>
