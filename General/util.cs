using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;



namespace AddressBook
{
	/// <summary>
	/// Summary description for util.
	/// </summary>
	public class util
	{
		public static bool LogError(Exception Ex,string Message)
		{
			try 
			{
				//string msg;
				if(Ex!=null)
				{
					
					//msg +=  "<BR><BR><b>Exception : </b><font color=RED>" + Ex.Message + "</font>";
				}
				//msg = msg + "<BR><BR><b>Description : </b><font color=RED>" + Message + "</font><BR><BR>";
			}
			catch
			{
			}
		
		return true;
	}


		public static string ReplaceEscapeChars(string str)
		{
			if(str=="")
				return str;

			str = str.Replace("'", "''");
            str = str.Replace(" ", "");
            return str;
		}
		
		public static bool PopulateCombo(ComboBox Combo,string ConnectionString,string TableName,string TextField,string ValueField,string DefaultValue)
		{
		Combo.DataSource = null;
		OleDbConnection myConnection = new OleDbConnection(ConnectionString);
		string Query="select * from " + TableName;
			   Query = Query + " order by " + TextField;
		OleDbDataAdapter myAdapter =new OleDbDataAdapter(Query,myConnection);
		DataSet ds = new DataSet();
		myAdapter.Fill(ds,TableName);
		DataTable Dt=ds.Tables[TableName];

		if(Dt.Rows.Count==0) return false;	
		
		Combo.DataSource = Dt;
        Combo.DisplayMember = TextField;
        Combo.ValueMember = ValueField;
        Combo.SelectedValue = DefaultValue;

        return true;
		}
	}
}
