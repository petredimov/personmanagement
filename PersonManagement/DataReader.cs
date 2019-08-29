using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace PersonManagement
{
	public class DataReader
	{
		public bool DeletePerson(int personId)
		{
			SqlConnection connection = new SqlConnection("Server=127.0.0.1\\SENSE;Database=TestDatabase;User Id=sa;Password=Sense17*;");

			using (connection)
			{
				connection.Open();

				SqlCommand selectCmd = new SqlCommand();
				selectCmd.Connection = connection;
				selectCmd.CommandType = CommandType.Text;
				selectCmd.CommandText = $"DELETE FROM dbo.Persons WHERE Id={personId}";

				int deleted = selectCmd.ExecuteNonQuery();

				return deleted > 0;
			}
		}

		public bool UpdatePerson(Person person)
		{
			SqlConnection connection = new SqlConnection("Server=127.0.0.1\\SENSE;Database=TestDatabase;User Id=sa;Password=Sense17*;");

			using (connection)
			{
				connection.Open();

				SqlCommand selectCmd = new SqlCommand();
				selectCmd.Connection = connection;
				selectCmd.CommandType = CommandType.Text;
				selectCmd.CommandText = $"UPDATE dbo.Persons SET FirstName='{person.FirstName}', LastName='{person.LastName}' WHERE Id={person.Id}";

				int updated = selectCmd.ExecuteNonQuery();

				return updated > 0;
			}
		}

		public bool AddPerson(Person person)
		{
			SqlConnection connection = new SqlConnection("Server=127.0.0.1\\SENSE;Database=TestDatabase;User Id=sa;Password=Sense17*;");

			using (connection)
			{
				connection.Open();

				SqlCommand selectCmd = new SqlCommand();
				selectCmd.Connection = connection;
				selectCmd.CommandType = CommandType.Text;
				selectCmd.CommandText = $"INSERT INTO dbo.Persons VALUES ('{person.FirstName}', '{person.LastName}')";

				int inserted = selectCmd.ExecuteNonQuery();

				return inserted > 0;
			}
		}

		public List<Person> ReadPersons()
		{
			SqlConnection connection = new SqlConnection("Server=127.0.0.1\\SENSE;Database=TestDatabase;User Id=sa;Password=Sense17*;");

			List<Person> persons = new List<Person>();

			using (connection)
			{
				SqlCommand selectCmd = new SqlCommand();
				selectCmd.Connection = connection;
				selectCmd.CommandType = CommandType.Text;
				selectCmd.CommandText = "select FirstName as fn, LastName as ln, id as identifier from dbo.Persons";
				SqlDataAdapter da = new SqlDataAdapter();

				DataSet ds = new DataSet();

				da.SelectCommand = selectCmd;
				da.Fill(ds);

				if (ds.Tables != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow row in ds.Tables[0].Rows)
					{
						persons.Add(FromDataRowToPerson(row));
					}
				}
			}

			return persons;
		}

		public Person FromDataRowToPerson(DataRow row)
		{
			return new Person
			{
				FirstName =  (row["fn"] != DBNull.Value) ? row["fn"].ToString() : String.Empty,
				LastName = row["ln"].ToString(),
				Id = Convert.ToInt32(row["identifier"])
			};
		}
	}
}
