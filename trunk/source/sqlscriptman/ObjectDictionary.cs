using System;
using System.Collections;

namespace sqlscriptman
{
	/// <summary>
	/// Type safe dictionary for DBObjects.
	/// </summary>
	public class ObjectDictionary : DictionaryBase
	{
		public ObjectDictionary()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public DBObject this[String key]  
		{
			get  
			{
				return( (DBObject) Dictionary[key] );
			}
			set  
			{
				Dictionary[key] = value;
			}
		}

		public ICollection Keys  
		{
			get  
			{
				return( Dictionary.Keys );
			}
		}

		public ICollection Values  
		{
			get  
			{
				return( Dictionary.Values );
			}
		}

		public void Add(String key, DBObject value)  
		{
			Dictionary.Add(key, value);
		}

		public bool Contains(String key)  
		{
			return( Dictionary.Contains(key) );
		}

		public void Remove(String key)  
		{
			Dictionary.Remove(key);
		}
	}
}
