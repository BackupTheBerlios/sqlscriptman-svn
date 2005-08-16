using System;

namespace sqlscriptman
{
	/// <summary>
	/// <c>DBObject</c> reprents a stored procedure, table, etc.
	/// It can actualy be stored in a SQL Server Database (server DBObject),
	/// or in a file system (FS DBObject).
	/// </summary>
	public class DBObject
	{
		public DBObject()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public string Name
		{
			get	
			{
				return mName;
			}
			set
			{
				mName = value;
			}
		}

		public string Script
		{
			get	
			{
				return mScript;
			}
			set
			{
				mScript = value;
			}
		}

		private string mName;
		private string mScript;
	}
}
