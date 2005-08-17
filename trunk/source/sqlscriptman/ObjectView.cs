using System;

namespace sqlscriptman
{
	/// <summary>
	/// It is an abstraction of DB structure viewer for one DB,
	/// it can be either FSObjectView or DBObjectView.
	/// </summary>
	public abstract class ObjectView
	{
		public ObjectView()
		{
			dbObjectsArray = new ObjectDictionary[Manager.dbObjectTypes.Count];

			for(int i = 0; i < Manager.dbObjectTypes.Count; i++)
			{
                dbObjectsArray[i] = new ObjectDictionary();				
			}
		}

		public abstract void LoadObjects();

		// temp
		public ObjectDictionary GetDictionary(int typeIndex)
		{
            return dbObjectsArray[typeIndex];
		}

		protected ObjectDictionary[] dbObjectsArray;
	}
}
