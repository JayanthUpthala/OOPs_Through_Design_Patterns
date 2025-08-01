﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStudentApp_1216098.DataLayer
{
    internal class DataAccess : IDataAccess
    {
        string connstr = ConfigurationManager.ConnectionStrings["STUDENTDBCONN"].ConnectionString;
        public DataTable GetManyRowsCols(string sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw; // send error back to caller
            }
            finally { conn.Close(); }
            return dt;
        }

        public object GetSingleAnswer(string sql)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw; // send error back to caller
            }
            finally { conn.Close(); }
            return obj;
        }

        public int InsertUpdateDelete(string sql)
        {
            int rowsModified = 0;
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rowsModified = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw; // send error back to caller
            }
            finally { conn.Close(); }
            return rowsModified;
        }
    }
}
