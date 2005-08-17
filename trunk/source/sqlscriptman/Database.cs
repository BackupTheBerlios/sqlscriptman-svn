using System;

namespace sqlscriptman
{
	/// <summary>
	/// <c>Database</c> represents merged view of two sources (server and FS ones).
	/// It provides facilities to view the differences and to synchronize the sources.
	/// </summary>
	public class Database
	{
		public Database()
		{
			Views = new ObjectView[2];
			Views[0] = null;
			Views[1] = null;
		}

		public void OpenFSView(Slot slot, String fsPath)
		{
			Views[(int)slot] = null;
			Views[(int)slot] = new FSObjectView(fsPath);
			Views[(int)slot].LoadObjects();
		}

		public void OpenServerView(Slot slot, ref Connection connection,
			string dbName, string dbOwner)
		{
			Views[(int)slot] = null;
			Views[(int)slot] = new ServerObjectView(ref connection, dbName, dbOwner);
			//Views[(int)slot].LoadObjects();
		}

		//temp
		public void ShowObjects(Slot slot, int typeIndex,
			System.Windows.Forms.ListBox listBox)
		{
			ObjectDictionary dict = Views[(int)slot].GetDictionary(typeIndex);

			foreach( DBObject dbObj in dict.Values )
			{
				listBox.Items.Add(dbObj.Name);
			}
		}

		// temp
		public void AddServerProcedure(Slot from, Slot to, string procedureName)
		{
			if( !(Views[(int)to] is ServerObjectView) )
			{
				throw new Exception("Target slot must be ServerObjectView");
			}
			
			ServerObjectView targetServer = (ServerObjectView)Views[(int)to];
			ObjectDictionary sourceSPs =
				Views[(int)from].GetDictionary(Manager.dbObjectTypes.IndexOf("SPs"));

			targetServer.AddStoredProcedure(sourceSPs[procedureName].Script);
				
		}

		// temp
		public void AddAllServerProcedures(Slot from, Slot to)
		{
			if( !(Views[(int)to] is ServerObjectView) )
			{
				throw new Exception("Target slot must be ServerObjectView");
			}
			
			ServerObjectView targetServer = (ServerObjectView)Views[(int)to];
			ObjectDictionary sourceSPs =
				Views[(int)from].GetDictionary(Manager.dbObjectTypes.IndexOf("SPs"));

			foreach( DBObject dbObject in sourceSPs.Values )
			{
				try
				{
					targetServer.AddStoredProcedure(dbObject.Script);
				}
				catch(Exception e)
				{
					System.Windows.Forms.MessageBox.Show("Error adding SP: \"" +
						e.Message + "\" at " + e.Source);
				}
			}	
		}

		protected ObjectView[] Views;
	}
}
