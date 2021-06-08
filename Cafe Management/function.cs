using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management
{
    class function
    {
        protected SqlConnection getConnection()
            SqlConnection con = new SqlConnection();
        con.ConnectionString="data source =DESKTOP-63U0I8N\\SQLEXPRESS;database = restro;integrated security = True";
            return con;
    }
    public DataSet getData(String query)
    {
        SqlConnection con = getConnection();
        SqlCommand cmd = new SqlCommand();
        cmd.Command = con;
        cmd.CommandText = query;
        SqlDataAdaptor da = new SqlDataAdaptor(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public void setData(String query)
    {
        SqlConnection con = getConnection();
        SqlCommand cmd = new SqlCommand();
        cmd.ConnectionText = query;
        cmd.ExecuteNonQuery();
        con.Close();

        MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButton.OK, MessageBoxIcon.Information);
    }
    }

}
