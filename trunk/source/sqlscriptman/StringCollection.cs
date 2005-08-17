using System;
using System.Collections;

namespace sqlscriptman
{
	/// <summary>
	/// <c>StringCollection</c> specializes <c>CollectionBase</c> to String.
	/// Some other overrides may be appropriate to copy from help.
	/// </summary>
	// note: string is just an alias for System.String so it doesn't matter.
	public class StringCollection : CollectionBase
	{
		public StringCollection()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public String this[ int index ]  
		{
			get  
			{
				return( (String) List[index] );
			}
			set  
			{
				List[index] = value;
			}
		}

		public int Add(String value)  
		{
			return( List.Add( value ) );
		}

		public int IndexOf(String value)  
		{
			return( List.IndexOf(value) );
		}

		public void Insert(int index, String value)  
		{
			List.Insert(index, value);
		}

		public void Remove(String value)  
		{
			List.Remove(value);
		}

		public bool Contains(String value)  
		{
			// If value is not of type String, this will return false.
			return( List.Contains(value) );
		}
	}
}
