using System;
using System.IO;


namespace sqlscriptman
{	
	/// <summary>
	/// <c>FSObjectView</c> manages DB objects originaly stored at a filesystem.
	/// It provides methods for reading the structure from the FS, saving it back,
	/// viewing, adding and removing of the objects.
	/// </summary>
	public class FSObjectView : ObjectView
	{
		// constructor
		public FSObjectView(string fsPath): base()
		{
			mFSPath = fsPath;
		}

		/// <summary>
		/// Finds and stores all SQL scripts in mFSPath directory.
		/// Expected directory layout is specified in Manager.dbObjectTypes.
		/// It can, for example, be the following:
		///		Functions
		///		SPs
		///		Tables
		///		Views
		/// </summary>
		public override void LoadObjects()
		{
			DirectoryInfo fsDatabaseDir = new DirectoryInfo(mFSPath);

			if( fsDatabaseDir.Exists )
			{
				foreach( DirectoryInfo subDir 
							in fsDatabaseDir.GetDirectories(Manager.subdirPattern) )
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
							break;
						}
					} // for each object type							  
				} // for each found dir
			} // if directory exists
			else
				throw new Exception("Invalid FS database path");
            
		} // LoadObjects

		private void LoadSpecificObjects(DirectoryInfo subdirectory, int typeIndex)
		{
			//System.Windows.Forms.MessageBox.Show(
			//	subdirectory.Name + ", index: " + typeIndex);

			foreach( FileInfo scriptFile 
						 in subdirectory.GetFiles(Manager.scriptPattern) )
			{
				DBObject dbObject = new DBObject();
				dbObject.Name = scriptFile.Name;

				dbObjectsArray[typeIndex].Add(scriptFile.Name, dbObject);
			}
		} // LoadSpecificObjects

		private string mFSPath;
	}
}
