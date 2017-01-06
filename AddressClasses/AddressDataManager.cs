using System;
using System.Data;
using System.Data.OleDb;
namespace AddressBook
{
	public class AddressDataManager
	{
		public static void DeleteAddressData( System.Int32 RecId )
		{
			String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["AddressDB"]; 
			OleDbConnection myConnection = new OleDbConnection(ConnectionString);
			String query = "delete from AddressData where RecId = " + RecId;
			DataManager.ExecuteNonQuery(ConnectionString, query);
		}

		public static void CreateAddressData( AddressData addressData )
		{
			String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["AddressDB"]; 
			String query = "insert into ADDRESSDATA ( RecId, Name, Address, Desig, DOB, Quali, Remarks, Nationality, Phone, Email, Father, Status ) values ( " + addressData.RecId + ", " + "'" + addressData.Name + "', " + "'" + addressData.Address + "', " + "'" + addressData.Desig + "', " + "'" + addressData.DOB + "', '" + addressData.Quali + "', " + "'" + addressData.Remarks + "', " + "'" + addressData.Nationality + "', " + "'" + addressData.Phone + "', " + "'" + addressData.Email + "', " + "'" + addressData.Father + "', " + (int) addressData.Status + " ) ";

			DataManager.ExecuteNonQuery(ConnectionString, query);
		}

		public static void UpdateAddressData( AddressData addressData )
		{
			String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["AddressDB"]; 
			String query = "update ADDRESSDATA set RecId = " + addressData.RecId + ", Name = '" + addressData.Name + "', Address = '" + addressData.Address + "', Desig = '" + addressData.Desig + "', DOB = '" + addressData.DOB + "', Quali = '" + addressData.Quali + "', Remarks = '" + addressData.Remarks + "', Nationality = '" + addressData.Nationality + "', Phone = '" + addressData.Phone + "', Email = '" + addressData.Email + "', Father = '" + addressData.Father + "', Status = " + (int)addressData.Status + " where RecId = " + addressData.RecId; 

			DataManager.ExecuteNonQuery(ConnectionString, query);
		}

		public static AddressData GetAddressData( System.Int32 RecId )
		{
			String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["AddressDB"]; 
			String query = "select * from ADDRESSDATA where RecId = " + RecId; 

			DataTable Dt = DataManager.ExecuteQuery(ConnectionString, query, "AddressDB" );
			if (Dt.Rows.Count == 0) 
			{
				return null;
			}

			return new AddressData(Dt.Rows[0]);
		}

		public static DataTable GetAddressDatass()
		{

			string ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["AddressDB"];
		
			string query= "select * from AddressData where Status = " + (int)eStatus.Approved + "";
			string tableName= "AddressData";
			
			DataTable Dt = DataManager.ExecuteQuery(ConnectionString,query,tableName);
			return Dt;
		}

		public static DataTable GetAddressess( String criteria ) 
		{
			String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["AddressDB"]; 
			String query = "select * from ADDRESSDATA";

			if ( criteria != "" )
			{
				query = query + " where " + criteria;
			}

			DataTable Dt = DataManager.ExecuteQuery(ConnectionString, query, "AddressDB" );
			return Dt;
		}
	}
}