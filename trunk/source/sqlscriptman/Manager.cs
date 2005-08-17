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

			tempDB = new Database();
		}

		public static StringCollection dbObjectTypes;

		public const String subdirPattern = "*??s";
		public const String scriptPattern = "*.sql";

		public static Database tempDB;
	}

	public enum Slot : int
	{
		One = 0,
		Two = 1
	}
}
