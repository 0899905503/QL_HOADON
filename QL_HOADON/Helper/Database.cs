using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
public class Database
{
    public static SqlConnection SQLConnect = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connectionString"]);
    public static SqlCommand SQLCommand = new SqlCommand("", SQLConnect);
}