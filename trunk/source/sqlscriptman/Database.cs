using System;

namespace sqlscriptman
{
	/// <summary>
	/// Summary description for Database.
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

		protected ObjectView[] Views;
	}
}
