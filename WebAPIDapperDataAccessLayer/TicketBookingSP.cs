using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace WebAPIDapperDataAccessLayer
{
    public class TicketBookingSP : ITicketBookingSP
    {
        public void InsertSP(TicketModelSP details)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var insertQuery = $"exec insertsp '{ details.TICKETNUMBER}','{details.PASSENGERNAME}' ,{ details.PHNUMBER} ,'{ details.EMAILID}' ,'{details.JOURNEYDATE}'";
                con.Execute(insertQuery);
                con.Close();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteSP(long passengerid)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var deleteQuery = $"exec deletesp {passengerid}";
                con.Execute(deleteQuery);
                con.Close();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<TicketModelSP> ReadSP()
        {
            try
            {
                var connectionString = "Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"exec selectsp";
                var ticket = con.Query<TicketModelSP>(selectQuery);

                con.Close();

                return ticket.ToList();
            }

            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<TicketModelSP> ReadbyIDSP(long passengerid)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"exec selectidsp  {passengerid} ";
                var products = con.Query<TicketModelSP>(selectQuery);

                con.Close();

                return products.ToList();
            }

            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void UpdateSP(int tktupdate, TicketModelSP details)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-BLBGEHJ\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";
                var con = new SqlConnection(connectionString);
                con.Open();
                var updateQuery = $"exec updatesp  {tktupdate} ,'{ details.TICKETNUMBER}','{details.PASSENGERNAME}' ,{details.PHNUMBER} ,'{ details.EMAILID}' ,'{details.JOURNEYDATE}'";
                con.Execute(updateQuery);

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}
