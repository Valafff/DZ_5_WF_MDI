using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Common;
using System.Resources;

namespace DZ_5_MDI
{
	internal class DB_Using
	{
		OleDbConnection DBConnection;
		public bool Connect(string pass)
		{
			try
			{
				string connectString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DB_Buses.mdb; Jet OLEDB:Database Password = {pass};";
				DBConnection = new OleDbConnection(connectString);
				DBConnection.Open();
				return true;
			}
			catch (Exception)
			{
				return false;
			}

		}

		public void reWriteDB(List<Bus> _buses)
		{
			string query = "DELETE FROM DB_buses WHERE key > 0 ";
			// создаем объект OleDbCommand для выполнения запроса к БД MS Access
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			// выполняем запрос к MS Access
			command.ExecuteNonQuery();

			//Записываем данные в базу Access
			command = new OleDbCommand(query, DBConnection);
			command.ExecuteNonQuery();
			foreach (Bus bus in _buses)
			{
				// текст запроса
				query = $"INSERT INTO DB_buses (Bus_number, Bus_type, Destenation, DepartureDate, DepartureTime, ArrivalDate, ArrivalTime) VALUES ({bus.BusNumber}, '{bus.BusType}', '{bus.Destination}', '{bus.DepartureDate}', '{bus.TimeDeparture}', '{bus.ArrivalDate}', '{bus.ArrivalTime}')";
				command = new OleDbCommand(query, DBConnection);
				command.ExecuteNonQuery();
			}
		}

		public List<Bus> readFromDB()
		{
			List<Bus> busesList = new List<Bus>();
			string query = "SELECT Bus_number, Bus_type, Destenation, DepartureDate, DepartureTime, ArrivalDate, ArrivalTime FROM DB_buses";
			// создаем объект OleDbCommand для выполнения запроса к БД MS Access
			OleDbCommand command = new OleDbCommand(query, DBConnection);
			// получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
			OleDbDataReader reader = command.ExecuteReader();
			// в цикле построчно читаем ответ от БД
			while (reader.Read())
			{
				Bus temp = new Bus();
				temp.BusNumber = Convert.ToInt32( reader[0]);
                temp.BusType = reader[1].ToString();
                temp.Destination = reader[2].ToString();
				temp.DepartureDate = Convert.ToDateTime(reader[3]);
				temp.TimeDeparture = Convert.ToDateTime(reader[4]);
				temp.ArrivalDate = Convert.ToDateTime(reader[5]);
				temp.ArrivalTime = Convert.ToDateTime(reader[6]);
				busesList.Add(temp);
			}
			return busesList;
		}

		public void Disconnect()
		{
			DBConnection.Close();
		}

	}
}
