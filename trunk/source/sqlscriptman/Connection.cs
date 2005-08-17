using System;

namespace sqlscriptman
{
	/// <summary>
	/// <c>Connection</c> manages a connection to a server.
	/// Servername is specified in constructor and doesn't change.
	/// Login and Password are public properties.
	/// </summary>
	public class Connection
	{
		// constructor
		public Connection(string serverName)
		{
			mServerName = serverName;

			InitMembers();
		}

		// constructor
		public Connection(string serverName, string login, string password)
		{
			mServerName = serverName;
			mLogin = login;
			mPassword = password;

			InitMembers();
		}

		/// <summary>
		/// Connects to an SQL server using its properties serverName, login and password
		/// </summary>
		public void Connect()
		{
			mSQLServer.Connect(mServerName, mLogin, mPassword);
		}

		/// <summary>
		/// Returns database object from the connected server.
		/// </summary>
		/// <param name="dbName">database/catalog name</param>
		/// <param name="dbOwner">username of the databes owner</param>
		/// <returns></returns>
		public object GetDatabase(string dbName, string dbOwner)
		{
			return (object)mSQLServer.Databases.Item(dbName, dbOwner);
		}

		public string Login
		{
			get
			{
				return mLogin;
			}
			set
			{
				mLogin = value;
			}
		}

		public string Password
		{
			get
			{
				return mPassword;
			}
			set
			{
				mPassword = value;
			}
		}

		// constructor tool
		private void InitMembers()
		{
			mSQLServer = new SQLDMO.SQLServer2();
		}

		private string mServerName;
		private string mLogin;
		private string mPassword;

        private SQLDMO.SQLServer2 mSQLServer;
	}
}
