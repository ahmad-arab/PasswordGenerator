
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System;

namespace PasswordGenerator
{
 
    public static class Data
    {
        public static string DataSource = "data source=PGDB.db";

        public static bool CreateNewDatabase(string file)
        {
            try
            {
                SQLiteConnection.CreateFile(file);

                using(SQLiteConnection connection = new SQLiteConnection("data source="+file))
                {
                    connection.Open();

                    string s =  "CREATE TABLE [Records] ("+
                                "[Id] INTEGER NOT NULL "+
                                ", [Username] TEXT NOT NULL "+
                                ", [Password] TEXT NOT NULL "+
                                ", [Note] TEXT NULL "+
                                ", CONSTRAINT[PK_Records] PRIMARY KEY([Id])); ";
                    SQLiteCommand command = new SQLiteCommand(s, connection);
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                MessageBox.Show("Failed to creat a new database file");
                return false;
            }
        }

        public static List<Entry> Entries = new List<Entry>();

        public static bool AddToDataBase(List<Entry> values)
        {
            try
            {
                using(SQLiteConnection connection = new SQLiteConnection(DataSource))
                {
                    connection.Open();

                    for(int i = 0;i<values.Count;i++)
                    {
                        string s = "INSERT INTO Records (Username , Password , Note) VALUES ( @User , @Pass , @Note)";
                        var command = connection.CreateCommand();
                        command.CommandText = s;
                        command.Parameters.AddWithValue("@User", values[i].Username);
                        command.Parameters.AddWithValue("@Pass", values[i].Password);
                        command.Parameters.AddWithValue("@Note", values[i].Note);

                        command.ExecuteNonQuery();                        
                    }

                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
                return false;
            }
            MessageBox.Show(values.Count.ToString() + " Entries Added");
            ImportFromDataBase();
            return true;
        }

        public static List<Entry> ImportFromDataBase()
        {
            List<Entry> ans = new List<Entry>();
            try
            {
               
                using (SQLiteConnection connection = new SQLiteConnection(DataSource))
                {
                    connection.Open();

                    string s = "SELECT* FROM Records";
                    var command = connection.CreateCommand();
                    command.CommandText = s;

                    SQLiteDataReader r = command.ExecuteReader();
                    Entries.Clear();

                    while (r.Read())
                    {
                        ans.Add(new Entry { Id = r.GetInt32(0), Username = r.GetString(1), Password = r.GetString(2), Note = r.GetString(3) });
                        Entries.Add(new Entry { Id = r.GetInt32(0), Username = r.GetString(1), Password = r.GetString(2), Note = r.GetString(3) });
                    }

                }
                return ans;
            }
            catch
            {
                MessageBox.Show("Connection Failed");
                return ans;
            }
        }

        public static bool DeleteFromDataBase(List<int> ids)
        {
            try
            {

                using (SQLiteConnection connection = new SQLiteConnection(DataSource))
                {
                    connection.Open();

                    for (int i = 0; i < ids.Count; i++)
                    {
                        string s = "DELETE FROM Records WHERE Id = @Id";
                        var command = connection.CreateCommand();
                        command.CommandText = s;
                        command.Parameters.AddWithValue("@Id", ids[i]);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
                return false;
            }

            MessageBox.Show(ids.Count.ToString() + " Entries Deleted");
            ImportFromDataBase();
            return true;
        }

        public static bool ClearDataBase()
        {
            try
            {

                using (SQLiteConnection connection = new SQLiteConnection(DataSource))
                {
                    connection.Open();

                    string s = "DELETE FROM Records";
                    var command = connection.CreateCommand();
                    command.CommandText = s;

                    command.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
                return false;
            }

            MessageBox.Show("DataBase has been cleared");
            ImportFromDataBase();
            return true;
        }

        public static bool UpdateDataBase(List<Entry> values)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(DataSource))
                {
                    connection.Open();

                    for (int i = 0; i < values.Count; i++)
                    {
                        string s = "UPDATE Records SET Username  = @User, Password = @Pass, Note = @Note WHERE Id = @Id";
                        var command = connection.CreateCommand();
                        command.CommandText = s;
                        command.Parameters.AddWithValue("@Id", values[i].Id);
                        command.Parameters.AddWithValue("@User", values[i].Username);
                        command.Parameters.AddWithValue("@Pass", values[i].Password);
                        command.Parameters.AddWithValue("@Note", values[i].Note);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
                return false;
            }

            MessageBox.Show(values.Count.ToString() + " Entries Updated");
            ImportFromDataBase();
            return true;
        }
    }   
}
