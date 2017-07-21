<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="CalculateNumbers.Calculator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>Calculator</h3>
        <p>Please enter a positive number in the text box provided and click the 'Results' button to show the calculations.</p>
        <div>
            <asp:TextBox ID="numberTb" runat="server"></asp:TextBox>
            <asp:Button ID="calBtn" runat="server" Text="Results" OnClick="CalculateResults" />
            <asp:RegularExpressionValidator ID="regexpName" runat="server"     
                                    ErrorMessage="Only positive whole numbers allowed" 
                                    ControlToValidate="numberTb"     
                                    ValidationExpression="^[1-9]([0-9]*,?)*$" ForeColor="red" />
        </div>

        <%--  <asp:ScriptManager id="ScriptManager1" runat="server">
        </asp:ScriptManager>--%>
        <div id="ResultsDiv" style="display: none" runat="server">
            <asp:UpdatePanel ID="CalculateUP" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <fieldset>
                        <legend>Here are the results:</legend>
                        <asp:Label ID="AllNumLbl" Text="All Numbers" runat="server"></asp:Label><br />
                        <asp:Label ID="AllNumLbl_Res" runat="server"></asp:Label><br /><br />
                        <asp:Label ID="OddLbl" Text="Odd" runat="server"></asp:Label><br />
                        <asp:Label ID="OddLbl_res" runat="server"></asp:Label><br /><br />
                        <asp:Label ID="EvenLbl" Text="Even" runat="server"></asp:Label><br />
                        <asp:Label ID="EvenLbl_res" runat="server"></asp:Label><br /><br />
                        <asp:Label ID="LettersLbl" Text="Numbers divisible by 3 shows C, divisible by 5 shows E, divisible by 3 & 5 shows Z. Otherwise show number" runat="server"></asp:Label><br />
                        <asp:Label ID="LettersLbl_res" runat="server"></asp:Label><br /><br />
                        <asp:Label ID="FibLbl" Text="Fibonacci" runat="server"></asp:Label><br />
                        <asp:Label ID="FibLbl_results" runat="server"></asp:Label><br /><br />
                    </fieldset>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
