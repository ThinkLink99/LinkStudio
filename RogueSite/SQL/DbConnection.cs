using System.Data.Sql;
using System.Data.SqlClient;
public class dbConnection
{
    public SqlConnection conn;
    public SqlTransaction transaction;
    public dbConnection()  // constructor Function
    {
        string strProject = "localdb"; //Enter your SQL server instance name
        string strDatabase = "ROUGEDB"; //Enter your database name
        string strUserID = ""; // Enter your SQL Server User Name
        string strPassword = ""; // Enter your SQL Server Password
        string strconn = "data source=" + strProject + ";Persist Security Info=false;database=" + strDatabase + ";user id=" + strUserID + ";password=" + strPassword + ";Connection Timeout = 0";
        conn = new SqlConnection(strconn);
    }
    public void openConnection() // Open database Connection
    {
        conn.Close();
        conn.Open();
        transaction = conn.BeginTransaction();
    }
    public void closeConnection() // database connection close
    {
        transaction.Commit();
        conn.Close();
    }
}
