using System;
using System.Data;
using System.Data.OleDb;
namespace AddressBook
{
	public class AddressData
	{
		// Public Attributes
		public Int32 RecId;
		public String Name;
		public String Address;
		public String Desig;
		public DateTime DOB;
		public String Quali;
		public String Remarks;
		public String Nationality;
		public String Phone;
		public String Email;
		public String Father;
		public eStatus Status= eStatus.Approved;


		// Default constructor
		public AddressData()
		{
		}

		// Constructor
		public AddressData( DataRow dr )
		{
			if ( dr["RecId"] != DBNull.Value )
			{
				this.RecId = Int32.Parse(dr["RecId"].ToString());
			}

			if ( dr["Name"] != DBNull.Value )
			{
				this.Name = dr["Name"].ToString();
			}

			if ( dr["Address"] != DBNull.Value )
			{
				this.Address = dr["Address"].ToString();
			}

			if ( dr["Desig"] != DBNull.Value )
			{
				this.Desig = dr["Desig"].ToString();
			}

			if ( dr["DOB"] != DBNull.Value )
			{
				this.DOB = DateTime.Parse(dr["DOB"].ToString());
			}

			if ( dr["Quali"] != DBNull.Value )
			{
				this.Quali = dr["Quali"].ToString();
			}

			if ( dr["Remarks"] != DBNull.Value )
			{
				this.Remarks = dr["Remarks"].ToString();
			}

			if ( dr["Nationality"] != DBNull.Value )
			{
				this.Nationality = dr["Nationality"].ToString();
			}

			if ( dr["Phone"] != DBNull.Value )
			{
				this.Phone = dr["Phone"].ToString();
			}

			if ( dr["Email"] != DBNull.Value )
			{
				this.Email = dr["Email"].ToString();
			}

			if ( dr["Father"] != DBNull.Value )
			{
				this.Father = dr["Father"].ToString();
			}

			if ( dr["Status"] != DBNull.Value )
			{
				this.Status = (eStatus)int.Parse(dr["Status"].ToString());
			}
		}
	} 
}
