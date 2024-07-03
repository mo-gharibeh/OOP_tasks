<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="forms.Form1" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personal Information Form</title>
    <style>
        .form-container {
            width: 300px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
        }
        .form-container h2 {
            text-align: center;
        }
        .form-container div {
            margin-bottom: 10px;
        }
        .info-container {
            width: 300px;
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
        }
        .info-container h2 {
            text-align: center;
        }
        .info-container div {
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Personal Information</h2>
            <div>
                <asp:Label ID="lblName" runat="server" Text="Name:" ></asp:Label><br />
                <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label><br />
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label><br />
                <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label><br />
                <asp:RadioButton ID="rblMale" runat="server" GroupName="Gender" Text="Male" /><br />
                <asp:RadioButton ID="rblFemale" runat="server" GroupName="Gender" Text="Female" />
            </div>
            <div>
                <asp:Label ID="lblLanguages" runat="server" Text="Programming Languages:"></asp:Label><br />
                <asp:CheckBox ID="chkC" runat="server" Text="C" /><br />
                <asp:CheckBox ID="chkCSharp" runat="server" Text="C#" /><br />
                <asp:CheckBox ID="chkCpp" runat="server" Text="C++" />
            </div>
            <div>
                <asp:Label ID="lblAdditionalInfo" runat="server" Text="Additional Information:"></asp:Label><br />
                <asp:TextBox ID="txtAdditionalInfo" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            </div>
        </div>
    
    <br />
    <br />
    <hr />
    <br />
     
      <div class="info-container">
          <h2>Personal Information</h2>
          <div>
              <asp:Label ID="lblDisplayName" runat="server" Text="Name: "></asp:Label>
          </div>
          <div>
              <asp:Label ID="lblDisplayEmail" runat="server" Text="Email: "></asp:Label>
          </div>
          <div>
              <asp:Label ID="lblDisplayID" runat="server" Text="ID: "></asp:Label>
          </div>
          <div>
              <asp:Label ID="lblDisplayGender" runat="server" Text="Gender: "></asp:Label>
          </div>
          <div>
              <asp:Label ID="lblDisplayLanguages" runat="server" Text="Languages: "></asp:Label>
          </div>
          <div>
              <asp:Label ID="lblDisplayAdditionalInfo" runat="server" Text="Additional Information: "></asp:Label>
          </div>
      </div>
  </form>
</body>
</html>

