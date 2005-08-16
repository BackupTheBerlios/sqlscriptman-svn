using System;
using System.IO;

namespace sqlscriptman
{
	/// <summary>
	/// Summary description for FSObjectView.
	/// </summary>
	public class FSObjectView : ObjectView
	{
		// constructor
		public FSObjectView(string fsPath)
		{
			mFSPath = fsPath;
		}

		/// <summary>
		/// Finds and stores all SQL scripts in mFSPath directory.
		/// Expected directory layout is:
		///		Functions
		///		SPs
		///		Tables
		///		Views
		/// </summary>
		public void LoadObjects()
		{
			DirectoryInfo fsDatabaseDir = new DirectoryInfo(mFSPath);

			if( fsDatabaseDir.Exists )
			{
				foreach( DirectoryInfo subDir in fsDatabaseDir.GetDirectories("*??s") )
					// candidate for subdirectory name must have at least 3 characters 
					// and end with small "s", case is ignored hereafter
				{
					// have we found stored procedures, tables, ... ?
					foreach( String objectType in Manager.dbObjectTypes )
					{
						if( subDir.Name.ToLower() == objectType.ToLower() )
						{
							LoadSpecificObjects(
								subDir,
								Manager.dbObjectTypes.IndexOf(objectType)
							);
						}
					} // for each object type							  
				} // for each found dir
			} // if directory exists
			else
				throw new Exception("Invalid FS database path");
            
		} // LoadObjects

		private void LoadSpecificObjects(DirectoryInfo subdirectory, int typeIndex)
		{
			System.Windows.Forms.MessageBox.Show(
				subdirectory.Name + ", index: " + typeIndex);
		}

		private string mFSPath;
		//private ObjectDictionary dbObjects;
	}
}
