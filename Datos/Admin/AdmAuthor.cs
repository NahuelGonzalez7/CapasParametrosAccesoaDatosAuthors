﻿using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Server;
using System.Data;

namespace Datos.Admin
{
    public static class AdmAuthor
    {
        public static List<Author> listarAuthors()
        {
            string consultaSQL = "SELECT au_id , au_lname, au_fname, phone, address , city , state, zip, contract FROM dbo.authors";

            SqlCommand command = new SqlCommand(consultaSQL, AdminBD.conectarBase());

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Author> authorsList = new List<Author>();

            while (reader.Read())
            {
                authorsList.Add(
                    new Author()
                    {
                        Au_id = (string)(reader["au_id"]),
                        Au_lname = (string)(reader["Au_lname"]),
                        Au_fname = (string)(reader["Au_fname"]),
                        Phone = (string)(reader["Phone"]),
                        Address = (string)(reader["Address"]),
                        City = (string)(reader["City"]),
                        State = (string)(reader["State"]),
                        Zip = (string)(reader["Zip"]),
                        Contract = (bool)(reader["Contract"])
                    }
                    );
            }

            AdminBD.conectarBase().Close();
            reader.Close();

            return authorsList;
        }

        public static List<Author> listarAuthors(string City)
        {
            string consultaSQL = "SELECT au_id , au_lname, au_fname, phone, address , city , state, zip, contract FROM dbo.authors WHERE city = @city";

            SqlCommand command = new SqlCommand(consultaSQL, AdminBD.conectarBase());

            command.Parameters.Add("@city", SqlDbType.VarChar).Value = City;

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Author> authorsList = new List<Author>();

            while (reader.Read())
            {
                authorsList.Add(
                    new Author()
                    {
                        Au_id = (string)(reader["au_id"]),
                        Au_lname = (string)(reader["Au_lname"]),
                        Au_fname = (string)(reader["Au_fname"]),
                        Phone = (string)(reader["Phone"]),
                        Address = (string)(reader["Address"]),
                        City = (string)(reader["City"]),
                        State = (string)(reader["State"]),
                        Zip = (string)(reader["Zip"]),
                        Contract = (bool)(reader["Contract"])
                    }
                    );
            }

            AdminBD.conectarBase().Close();
            reader.Close();

            return authorsList;
        }

        public static List<Author> listarAuthors(string City,string State)
        {
            string consultaSQL = "SELECT au_id , au_lname, au_fname, phone, address , city , state, zip, contract FROM dbo.authors WHERE city = @city AND state = @state";

            SqlCommand command = new SqlCommand(consultaSQL, AdminBD.conectarBase());

            command.Parameters.Add("@city", SqlDbType.VarChar).Value = City;

            command.Parameters.Add("@state", SqlDbType.Char).Value = State;

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Author> authorsList = new List<Author>();

            while (reader.Read())
            {
                authorsList.Add(
                    new Author()
                    {
                        Au_id = (string)(reader["au_id"]),
                        Au_lname = (string)(reader["Au_lname"]),
                        Au_fname = (string)(reader["Au_fname"]),
                        Phone = (string)(reader["Phone"]),
                        Address = (string)(reader["Address"]),
                        City = (string)(reader["City"]),
                        State = (string)(reader["State"]),
                        Zip = (string)(reader["Zip"]),
                        Contract = (bool)(reader["Contract"])
                    }
                    );
            }

            AdminBD.conectarBase().Close();
            reader.Close();

            return authorsList;
        }
    }
}
