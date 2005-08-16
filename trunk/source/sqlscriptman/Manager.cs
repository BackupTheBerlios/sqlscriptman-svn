using System;

namespace sqlscriptman
{
	/// <summary>
	/// <c>Manager</c> stores singletons and global data.
	/// </summary>
	public class Manager
	{
		// static constructor
		static Manager()
		{
			dbObjectTypes = new StringCollection();
			
			// the following strings should have at least 3 characters and end with "s"
			// otherwise, FSObjectView won't find the directories
			dbObjectTypes.Add("Functions");
			dbObjectTypes.Add("SPs");		// stored procedures
			dbObjectTypes.Add("Tables");
			dbObjectTypes.Add("Views");
		}

		public static StringCollection dbObjectTypes;
	}
}
