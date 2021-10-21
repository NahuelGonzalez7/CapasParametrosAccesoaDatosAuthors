using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Server;
using Datos.Models;
using System.Data;

namespace Datos.Admin
{
    public static class AdminPublisher
    {
        public static List<Publisher> listarPublishers()
        {
            string consultaSQLPubli = "SELECT pub_id , pub_name , city , state , country FROM dbo.publishers";

            SqlCommand command = new SqlCommand(consultaSQLPubli, AdminBD.conectarBase());

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Publisher> publishersList = new List<Publisher>();

            while (reader.Read())
            {
                publishersList.Add(
                    new Publisher
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    }
                );
            }


            AdminBD.conectarBase().Close();
            reader.Close();

            return publishersList;
        }

        public static List<Publisher> listarPublishers(string city)
        {
            string consultaSQLPubli = "SELECT pub_id , pub_name , city , state , country FROM dbo.publishers WHERE city = @city";

            SqlCommand command = new SqlCommand(consultaSQLPubli, AdminBD.conectarBase());

            command.Parameters.Add("@city", SqlDbType.VarChar).Value = city;

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Publisher> publishersList = new List<Publisher>();

            while (reader.Read())
            {
                publishersList.Add(
                    new Publisher
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    }
                );
            }


            AdminBD.conectarBase().Close();
            reader.Close();

            return publishersList;
        }

        public static List<Publisher> listarPublishers(string city,string state)
        {
            string consultaSQLPubli = "SELECT pub_id , pub_name , city , state , country FROM dbo.publishers WHERE city = @city AND state = @state";

            SqlCommand command = new SqlCommand(consultaSQLPubli, AdminBD.conectarBase());

            command.Parameters.Add("@city", SqlDbType.VarChar,20).Value = city;
            command.Parameters.Add("@state", SqlDbType.Char,2).Value = state;

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Publisher> publishersList = new List<Publisher>();

            while (reader.Read())
            {
                publishersList.Add(
                    new Publisher
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    }
                );
            }


            AdminBD.conectarBase().Close();
            reader.Close();

            return publishersList;
        }

        public static List<Publisher> listarPublishers(string city,string state,string country)
        {
            string consultaSQLPubli = "SELECT pub_id , pub_name , city , state , country FROM dbo.publishers WHERE city = @city AND state = @state AND country = @country";

            SqlCommand command = new SqlCommand(consultaSQLPubli, AdminBD.conectarBase());

            command.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = city;
            command.Parameters.Add("@state", SqlDbType.Char, 2).Value = state;
            command.Parameters.Add("@country", SqlDbType.VarChar, 30).Value = country;

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Publisher> publishersList = new List<Publisher>();

            while (reader.Read())
            {
                publishersList.Add(
                    new Publisher
                    {
                        Pub_id = reader["Pub_id"].ToString(),
                        Pub_name = reader["Pub_name"].ToString(),
                        City = reader["City"].ToString(),
                        State = reader["State"].ToString(),
                        Country = reader["Country"].ToString()
                    }
                );
            }


            AdminBD.conectarBase().Close();
            reader.Close();

            return publishersList;
        }
    }
}
