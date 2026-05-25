using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace PROIECT_PAW
{
    public class DatabaseHelper
    {
        private const string FISIER_DB = "hotel.db";
        private string ConnectionString =>
            $"Data Source={FISIER_DB};";
        public void CreeazaTabel()
        {
            using (var con = new SqliteConnection(ConnectionString))
            {
                con.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Rezervari (
                        Id          INTEGER PRIMARY KEY,
                        NumeClient  TEXT    NOT NULL,
                        Sex         TEXT    NOT NULL,
                        Telefon     TEXT    NOT NULL,
                        NumarCamera INTEGER NOT NULL,
                        TipCamera   TEXT    NOT NULL,
                        PretNoapte  REAL    NOT NULL,
                        Etaj        INTEGER NOT NULL,
                        CheckIn     TEXT    NOT NULL,
                        CheckOut    TEXT    NOT NULL,
                        Status      TEXT    NOT NULL
                    );";
                new SqliteCommand(sql, con).ExecuteNonQuery();
            }
        }

        public void Adauga(Rezervare r)
        {
            using (var con = new SqliteConnection(ConnectionString))
            {
                con.Open();
                string sql = @"
                    INSERT OR REPLACE INTO Rezervari
                        (Id, NumeClient, Sex, Telefon,
                         NumarCamera, TipCamera, PretNoapte, Etaj,
                         CheckIn, CheckOut, Status)
                    VALUES
                        (@id, @nume, @sex, @tel,
                         @numar, @tip, @pret, @etaj,
                         @ci, @co, @status);";

                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", r.Id);
                    cmd.Parameters.AddWithValue("@nume", r.Client.Nume);
                    cmd.Parameters.AddWithValue("@sex", r.Client.Sex.ToString());
                    cmd.Parameters.AddWithValue("@tel", r.Client.NrTelefon);
                    cmd.Parameters.AddWithValue("@numar", r.Camera.Numar);
                    cmd.Parameters.AddWithValue("@tip", r.Camera.Tip);
                    cmd.Parameters.AddWithValue("@pret", r.Camera.PretNoapte);
                    cmd.Parameters.AddWithValue("@etaj", r.Camera.Etaj);
                    cmd.Parameters.AddWithValue("@ci", r.DataCheckIn.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@co", r.DataCheckOut.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@status", r.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Rezervare> GetToate()
        {
            var lista = new List<Rezervare>();

            using (var con = new SqliteConnection(ConnectionString))
            {
                con.Open();
                string sql = "SELECT * FROM Rezervari ORDER BY Id;";
                using (var reader = new SqliteCommand(sql, con).ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var client = new Client(
                            reader["NumeClient"].ToString(),
                            reader["Sex"].ToString()[0],
                            reader["Telefon"].ToString()
                        );
                        var camera = new Camera(
                            Convert.ToInt32(reader["NumarCamera"]),
                            reader["TipCamera"].ToString(),
                            Convert.ToSingle(reader["PretNoapte"]),
                            Convert.ToInt32(reader["Etaj"])
                        );
                        var rez = new Rezervare(
                            Convert.ToInt32(reader["Id"]),
                            client, camera,
                            DateTime.Parse(reader["CheckIn"].ToString()),
                            DateTime.Parse(reader["CheckOut"].ToString()),
                            reader["Status"].ToString()
                        );
                        lista.Add(rez);
                    }
                }
            }
            return lista;
        }


        public void Sterge(int id)
        {
            using (var con = new SqliteConnection(ConnectionString))
            {
                con.Open();
                string sql = "DELETE FROM Rezervari WHERE Id = @id;";
                using (var cmd = new SqliteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void StergeToate()
        {
            using (var con = new SqliteConnection(ConnectionString))
            {
                con.Open();
                new SqliteCommand("DELETE FROM Rezervari;", con).ExecuteNonQuery();
            }
        }

    }
}
