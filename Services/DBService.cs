using Countries.Services;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Models
{
    public class DBService
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private DialogService dialogService;

        //public DBService()
        //{
        //    dialogService = new DialogService();

        //    if (!Directory.Exists("Data"))
        //    {
        //        Directory.CreateDirectory("Data");
        //    }

        //    var path = @"Data\Rates.sqlite";

        //    try
        //    {
        //        connection = new SQLiteConnection("Data Source=" + path);
        //        connection.Open();

        //        string sqlcommand = "create table if not exists Rates (RateId int, Code varchar(5), TaxRate real, Name varchar(250))";

        //        command = new SQLiteCommand(sqlcommand, connection);
        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {

        //        //dialogService.ShowMessage("Erro", ex.Message);
        //    }
        //}

        public void SaveData(List<Country> Countries)
        {
            try
            {
                //foreach (var rate in Countries)
                //{
                //    string sql = $"INSERT INTO Rates (RateId, Code, TaxRate, Name) values ({rate.RateId}, '{rate.Code}', {rate.TaxRate}, '{rate.Name}')";

                //    command = new SQLiteCommand(sql, connection);
                //    command.ExecuteNonQuery();
                //}
                //connection.Close();
            }
            catch (Exception ex)
            {

                //dialogService.ShowMessage("Erro", ex.Message);
            }
        }

        //public List<Country> GetData()
        //{
        //    List<Country> Countries = new List<Country>();

        //    try
        //    {
        //        //string sql = "SELECT RateId, Code, TaxRate, Name from Rates";
        //        //command = new SQLiteCommand(sql, connection);

        //        //// Lê cada registo
        //        //SQLiteDataReader reader = command.ExecuteReader();
        //        //while (reader.Read())
        //        //{
        //        //    rates.Add(new Rate
        //        //    {
        //        //        RateId = (int)reader["RateId"],
        //        //        Code = reader["Code"].ToString(),
        //        //        Name = reader["Name"].ToString(),
        //        //        TaxRate = (double)reader["TaxRate"]
        //        //    });
        //        //}
        //        //connection.Close();
        //        //return rates;
        //    }
        //    catch (Exception ex)
        //    {
        //        //dialogService.ShowMessage("Erro", ex.Message);
        //        return null;
        //    }
        //}

        public void DeleteData()
        {
            try
            {
                string sql = "DELETE from Rates";
                command = new SQLiteCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //dialogService.ShowMessage("Erro", ex.Message);
            }
        }
    }
}
