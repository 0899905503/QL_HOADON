using System;
using System.Configuration;
using Microsoft.Data.SqlClient;
public class Database
{
    public static SqlConnection SQLConnect = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
}