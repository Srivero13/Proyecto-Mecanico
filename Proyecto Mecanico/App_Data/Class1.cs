using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Proyecto_Mecanico.App_Data
{
    internal class Class1
    {
    }
    public class CreateDatabase
    {
        public static void CreateDatabaseAndTable()
        {
            string connectionString = "Data Source=VINDatabase.db;Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Crear la tabla si no existe
                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS VINDatabase (
                WMI TEXT PRIMARY KEY, 
                Manufacturer TEXT,
                YearCode TEXT, 
                Year INTEGER, 
                Model TEXT, 
                Engine TEXT
            );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
                string insertDataQuery = @"
INSERT OR REPLACE INTO VINDatabase (WMI, Manufacturer, YearCode, Year, Model, Engine)
VALUES
('1HG', 'Honda', 'G', 2016, 'Civic', '1.8L'),
('1FAD', 'Ford', 'C', 2018, 'Focus', '2.0L'),
('1N4', 'Nissan', 'T', 2020, 'Altima', '2.5L'),
('3VW', 'Volkswagen', 'W', 2019, 'Jetta', '1.4L'),
('2G1', 'Chevrolet', 'D', 2015, 'Malibu', '2.5L'),
('1G1', 'Chevrolet', 'F', 2020, 'Cruze', '1.4L'),
('JHM', 'Honda', 'M', 2017, 'Accord', '2.4L'),
('5TD', 'Toyota', '1', 2020, 'Highlander', '3.5L'),
('1G6', 'Cadillac', 'B', 2018, 'CTS', '3.6L'),
('1J4', 'Jeep', 'P', 2019, 'Cherokee', '2.4L'),
('2HK', 'Honda', 'K', 2021, 'CR-V', '1.5L'),
('WBA', 'BMW', 'L', 2020, 'X5', '3.0L'),
('WA1', 'Audi', 'J', 2021, 'Q7', '3.0L'),
('3FA', 'Ford', 'A', 2018, 'Fusion', '2.5L'),
('1FT', 'Ford', 'E', 2019, 'F-150', '3.5L');";



                using (var command = new SQLiteCommand(insertDataQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
