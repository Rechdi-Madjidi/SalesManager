using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManager
{
    internal class DB
    {
        //static string cs = @"Data Source =.\SQLEXPRESS;Initial Catalog = SDB; Integrated Security = True";
        static string cs = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\sdb.mdf;Integrated Security=True;User Instance=True";
        public static SqlConnection conn = new SqlConnection(cs);
        public static SqlCommand cmd = new SqlCommand("",conn);
        public static void ChangeDBFileName(string NewDBFileName)
        {
            //if(conn.State == ConnectionState.Closed)
            //{
            //    conn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+NewDBFileName+";Integrated Security=True;User Instance=True";
            //}
        }

        public static void Open()
        {
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
        }
        public static void Close()
        {
            if (conn.State == ConnectionState.Open) { conn.Close(); }
        }
        public static DataTable GetData(string Select)
        {
            DataTable tbl = new DataTable();
            cmd.CommandText = Select;
            tbl.Load(cmd.ExecuteReader());
            return tbl;
        }
        public static void Run(string SQL)
        {
            cmd.CommandText = SQL;
            cmd.ExecuteNonQuery();
        }
        public static void setColorandFont()
        {
            // this is 
            DataTable dt = GetData("select * from bg_font_Setting");
            if (dt.Rows.Count<1)
            {
                DB.Run("insert into bg_font_Setting values(13,255,255,12)");
            }
            variables.r = Convert.ToInt32(dt.Rows[0][0]);
            variables.g = Convert.ToInt32(dt.Rows[0][1]);
            variables.b = Convert.ToInt32(dt.Rows[0][2]);
            variables.fs = Convert.ToInt32(dt.Rows[0][3]);

        }

    }
}
