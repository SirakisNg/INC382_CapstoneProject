using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using MvcMovie.Models;


namespace MvcMovie.Models
{
    public class DbContext
    {
        // Connection string
        public string ConnectionString { get; set; }
        public DbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }






        public virtual DbSet<UserModels> Users { get; set; }





        //Database connect
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }





// Seprate context -------------------------------------------------------------------------------
        public List<UserModels> GetAllUsers()
        {

            List<UserModels> list = new List<UserModels>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from User where id < 10", conn);
                Console.WriteLine("info : "+ DateTime.Today + " : Connect to Database ... ");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserModels()
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            FirstName = reader["first_name"].ToString(),
                            LastName = reader["last_name"].ToString(),
                            Age = Convert.ToInt32(reader["age"]),
                            Password = reader["password"].ToString()
                        });
                    }
                }
            }
            return list;
        }


        public List<Album> GetAllAlbums()
        {

            List<Album> list = new List<Album>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from Music where id < 10", conn);
                Console.WriteLine("info : "+ DateTime.Today + " : Connect to Database ... ");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Album()
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Name = reader["Name"].ToString(),
                            ArtistName = reader["ArtistName"].ToString(),
                            Price = Convert.ToInt32(reader["Price"]),
                            Genre = reader["genre"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public List<Album> GetAlbumsByID(int ID)
        {

            List<Album> list = new List<Album>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = "select * from Music where id = " + ID;

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine("info : "+ DateTime.Today + " : Connect to the Database ... ");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Album()
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Name = reader["Name"].ToString(),
                            ArtistName = reader["ArtistName"].ToString(),
                            Price = Convert.ToInt32(reader["Price"]),
                            Genre = reader["genre"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public void deleteAlbum(int deleteID)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string sql = "delete from Music where id = " + deleteID;

                MySqlCommand cmd = new MySqlCommand(sql , conn);
                using (var reader = cmd.ExecuteReader());
                Console.WriteLine("info : "+ DateTime.Today + " : delete id : " + deleteID);
            }
            return ;
        }

        public void addAlbum(string name, string artist, int price, string genre)
        {
            using (MySqlConnection conn = GetConnection())
            {

                
                conn.Open();

                string sql = $"INSERT INTO Music (Name, ArtistName, Price, genre) VALUES ('{name}', '{artist}', '{price}', '{genre}');" ;

                MySqlCommand cmd = new MySqlCommand(sql , conn);
                using (var reader = cmd.ExecuteReader());
                Console.WriteLine("info : "+ DateTime.Today + " : add id : ");
            }
            return ;
        }
        

	


        
    }
}
