using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace PROIECT_PAW
{
    public class DatabaseHelper
    {
        private const string FISIER_DB = "hotel.accdb";
        private string ConnectionString =>$"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FISIER_DB};";

        public void CreeazaTabel()
        {
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();
                string sql = @"CREATE TABLE Rezervari (
                    Id INTEGER PRIMARY KEY,
                    NumeClient TEXT NOT NULL,
                    Sex TEXT NOT NULL,
                    Telefon TEXT NOT NULL,
                    NumarCamera INTEGER NOT NULL,
                    TipCamera TEXT NOT NULL,
                    PretNoapte DOUBLE NOT NULL,
                    Etaj INTEGER NOT NULL,
                    CheckIn TEXT NOT NULL,
                    CheckOut TEXT NOT NULL,
                    Status TEXT NOT NULL )";
                try
                {
                    new OleDbCommand(sql, con).ExecuteNonQuery();
                }
                catch {}
            }
        }

        public List<Rezervare> GetToate()
        {
            var lista = new List<Rezervare>();

            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();

                OleDbDataAdapter adaptor = new OleDbDataAdapter(
                    "SELECT * FROM Rezervari ORDER BY Id", con);

                DataSet dataSet = new DataSet();
                adaptor.Fill(dataSet, "Rezervari");

                DataTable tabela = dataSet.Tables["Rezervari"];

              
                DataView dv = new DataView(tabela);
                dv.Sort = "Id";

                foreach (DataRowView randView in dv)
                {
                    DataRow rand = randView.Row;

                    var client = new Client(
                        rand["NumeClient"].ToString(),
                        rand["Sex"].ToString()[0],
                        rand["Telefon"].ToString()
                    );
                    var camera = new Camera(
                        Convert.ToInt32(rand["NumarCamera"]),
                        rand["TipCamera"].ToString(),
                        Convert.ToSingle(rand["PretNoapte"]),
                        Convert.ToInt32(rand["Etaj"])
                    );
                    lista.Add(new Rezervare(
                        Convert.ToInt32(rand["Id"]),
                        client, camera,
                        DateTime.Parse(rand["CheckIn"].ToString()),
                        DateTime.Parse(rand["CheckOut"].ToString()),
                        rand["Status"].ToString()
                    ));
                }
            }
            return lista;
        }

        public void Adauga(Rezervare r)
        {
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = con;
                comanda.Transaction = con.BeginTransaction();

                try
                {
                    comanda.CommandText = @"INSERT INTO Rezervari
                        (Id, NumeClient, Sex, Telefon, NumarCamera, TipCamera, PretNoapte, Etaj, CheckIn, CheckOut, Status) 
                                            VALUES (?,?,?,?,?,?,?,?,?,?,?)";

                    comanda.Parameters.Add("Id", OleDbType.Integer).Value = r.Id;
                    comanda.Parameters.Add("NumeClient", OleDbType.VarChar).Value = r.Client.Nume;
                    comanda.Parameters.Add("Sex", OleDbType.VarChar).Value = r.Client.Sex.ToString();
                    comanda.Parameters.Add("Telefon", OleDbType.VarChar).Value = r.Client.NrTelefon;
                    comanda.Parameters.Add("NumarCamera", OleDbType.Integer).Value = r.Camera.Numar;
                    comanda.Parameters.Add("TipCamera", OleDbType.VarChar).Value = r.Camera.Tip;
                    comanda.Parameters.Add("PretNoapte", OleDbType.Double).Value = r.Camera.PretNoapte;
                    comanda.Parameters.Add("Etaj", OleDbType.Integer).Value = r.Camera.Etaj;
                    comanda.Parameters.Add("CheckIn", OleDbType.VarChar).Value = r.DataCheckIn.ToString("yyyy-MM-dd");
                    comanda.Parameters.Add("CheckOut", OleDbType.VarChar).Value = r.DataCheckOut.ToString("yyyy-MM-dd");
                    comanda.Parameters.Add("Status", OleDbType.VarChar).Value = r.Status;

                    comanda.ExecuteNonQuery();
                    comanda.Transaction.Commit(); 
                }
                catch
                {
                    comanda.Transaction.Rollback();  
                    throw;
                }
            }
        }
        public void Sterge(int id)
        {
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = con;
                comanda.Transaction = con.BeginTransaction();

                try
                {
                    comanda.CommandText = "DELETE FROM Rezervari WHERE Id = ?";
                    comanda.Parameters.Add("Id", OleDbType.Integer).Value = id;
                    comanda.ExecuteNonQuery();
                    comanda.Transaction.Commit();
                }
                catch
                {
                    comanda.Transaction.Rollback();
                    throw;
                }
            }
        }
        public void StergeToate()
        {
            using (var con = new OleDbConnection(ConnectionString))
            {
                con.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = con;
                comanda.Transaction = con.BeginTransaction();

                try
                {
                    comanda.CommandText = "DELETE FROM Rezervari";
                    comanda.ExecuteNonQuery();
                    comanda.Transaction.Commit();
                }
                catch
                {
                    comanda.Transaction.Rollback();
                    throw;
                }
            }
        }
    }
}