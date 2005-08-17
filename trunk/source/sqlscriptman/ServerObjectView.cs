using System;

namespace sqlscriptman
{
	/// <summary>
	/// <c>ServerObjectView</c> manages DB objects originaly stored at a server.
	/// It provides methods for reading the structure from the server, saving it back,
	/// viewing, adding and removing of the objects.
	/// </summary>
	public class ServerObjectView : ObjectView
	{
		public ServerObjectView(
			ref Connection connection,
			string dbName,
			string dbOwner
			): base()
		{
			mDatabase = (SQLDMO.Database2)connection.GetDatabase(dbName, dbOwner);

			mDBName = dbName;
		}

		public override void LoadObjects()
		{
		}

		// temp
		public void AddStoredProcedure(string text)
		{
			if( text == "" | text == null )
				throw new Exception("Empty procedure text");

			SQLDMO.StoredProcedure2 newSP = new SQLDMO.StoredProcedure2Class();
			newSP.Text = text;

            mDatabase.StoredProcedures.Add((SQLDMO._StoredProcedure)newSP);
		}

		private string mDBName;
		private SQLDMO.Database2 mDatabase;
	}
}
