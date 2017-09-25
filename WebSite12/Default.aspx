<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" Height="16px" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" Width="306px">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="Eid" HeaderText="Eid" SortExpression="Eid" />
                <asp:BoundField DataField="salary" HeaderText="salary" 
                    SortExpression="salary" />
                <asp:BoundField DataField="depid" HeaderText="depid" SortExpression="depid" />
                <asp:BoundField DataField="dof" HeaderText="dof" SortExpression="dof" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:KJcollegeConnectionStringconn %>" 
            onselecting="SqlDataSource1_Selecting" 
            SelectCommand="SELECT [name], [Eid], [salary], [depid], [dof] FROM [emp2] WHERE ([salary] &gt;= @salary) ORDER BY [Eid]">
            <SelectParameters>
                <asp:Parameter DefaultValue="1000" Name="salary" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="did" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowSelectButton="True" />
                <asp:BoundField DataField="did" HeaderText="did" ReadOnly="True" 
                    SortExpression="did" />
                <asp:BoundField DataField="dname" HeaderText="dname" SortExpression="dname" />
            </Columns>
        </asp:GridView>
        a<asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:KJcollegeConnectionStringconn %>" 
            DeleteCommand="DELETE FROM [dept] WHERE [did] = @did" 
            InsertCommand="INSERT INTO [dept] ([did], [dname]) VALUES (@did, @dname)" 
            SelectCommand="SELECT [did], [dname] FROM [dept] WHERE ([did] &gt;= @did) ORDER BY [did]" 
            UpdateCommand="UPDATE [dept] SET [dname] = @dname WHERE [did] = @did">
            <DeleteParameters>
                <asp:Parameter Name="did" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="did" Type="Int32" />
                <asp:Parameter Name="dname" Type="String" />
            </InsertParameters>
            <SelectParameters>
                <asp:Parameter DefaultValue="1" Name="did" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="dname" Type="String" />
                <asp:Parameter Name="did" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
            DataKeyNames="did" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="did" HeaderText="did" ReadOnly="True" 
                    SortExpression="did" />
                <asp:BoundField DataField="dname" HeaderText="dname" SortExpression="dname" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                    ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
