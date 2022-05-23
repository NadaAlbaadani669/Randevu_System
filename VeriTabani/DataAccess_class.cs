using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace VeriTabani
{
    public class DataAccess_class
    {
        string baglanti;
        SqlConnection con;
        public DataAccess_class()
        {
            baglanti = @"Data Source=DESKTOP-SQGIPRQ\SQLEXPRESS;Initial Catalog=RandevuSystem;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            con = new SqlConnection(baglanti);
        }

        public DataAccess_class(string baglanti, SqlConnection con)
        {
            this.baglanti = baglanti;
            this.con = con;
        }

        public void connection()
        {
            try
            {
                con = new SqlConnection(baglanti);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
        }

        public SqlDataAdapter DataAdapter(String sorgu)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, con);
            return adapter;
        }

        public SqlCommand DbCommand(String sorgu)
        {
            SqlCommand command = new SqlCommand(sorgu, con);
            command.CommandTimeout = 3600;
            return command;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
