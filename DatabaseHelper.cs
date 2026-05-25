using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace PROIECT_PAW
{
    public class DatabaseHelper
    {
        private const string FISIER_DB = "hotel.accdb";
        private string ConnectionString =>
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FISIER_DB};";

        public void CreeazaTabel()
        {
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();
                string sql = @"
                    CREATE TABLE Rezervari (
                        Id          INTEGER PRIMARY KEY,
                        NumeClient  TEXT NOT NULL,
                        Sex         TEXT NOT NULL,
                        Telefon     TEXT NOT NULL,
                        NumarCamera INTEGER NOT NULL,
                        TipCamera   TEXT NOT NULL,
                        PretNoapte  DOUBLE NOT NULL,
                        Etaj        INTEGER NOT NULL,
                        CheckIn     TEXT NOT NULL,
                        CheckOut    TEXT NOT NULL,
                        Status      TEXT NOT NULL
                    )";
                try
                {
                    new OleDbCommand(sql, con).ExecuteNonQuery();
                }
                catch { /* tabela există deja */ }
            }
        }

        public void Adauga(Rezervare r)
        {
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();
                string sql = @"INSERT INTO Rezervari
                    (Id, NumeClient, Sex, Telefon,
                     NumarCamera, TipCamera, PretNoapte, Etaj,
                     CheckIn, CheckOut, Status)
                    VALUES (?,?,?,?,?,?,?,?,?,?,?)";

                using (var cmd = new OleDbCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("Id", r.Id);
                    cmd.Parameters.AddWithValue("NumeClient", r.Client.Nume);
                    cmd.Parameters.AddWithValue("Sex", r.Client.Sex.ToString());
                    cmd.Parameters.AddWithValue("Telefon", r.Client.NrTelefon);
                    cmd.Parameters.AddWithValue("NumarCamera", r.Camera.Numar);
                    cmd.Parameters.AddWithValue("TipCamera", r.Camera.Tip);
                    cmd.Parameters.AddWithValue("PretNoapte", r.Camera.PretNoapte);
                    cmd.Parameters.AddWithValue("Etaj", r.Camera.Etaj);
                    cmd.Parameters.AddWithValue("CheckIn", r.DataCheckIn.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("CheckOut", r.DataCheckOut.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("Status", r.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Rezervare> GetToate()
        {
            var lista = new List<Rezervare>();
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();
                string sql = "SELECT * FROM Rezervari ORDER BY Id";
                using (var reader = new OleDbCommand(sql, con).ExecuteReader())
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
                        lista.Add(new Rezervare(
                            Convert.ToInt32(reader["Id"]),
                            client, camera,
                            DateTime.Parse(reader["CheckIn"].ToString()),
                            DateTime.Parse(reader["CheckOut"].ToString()),
                            reader["Status"].ToString()
                        ));
                    }
                }
            }
            return lista;
        }

        public void Sterge(int id)
        {
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();
                using (var cmd = new OleDbCommand(
                    "DELETE FROM Rezervari WHERE Id = ?", con))
                {
                    cmd.Parameters.AddWithValue("Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void StergeToate()
        {
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();
                new OleDbCommand("DELETE FROM Rezervari", con).ExecuteNonQuery();
            }
        }
    }
}