using System;

namespace sqlscriptman
{
	/// <summary>
	/// Summary description for Connection.
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

		public void Connect()
		{
			mSQLServer.Connect(mServerName, mLogin, mPassword);
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
			mSQLServer = new SQLDMO.SQLServer2Class();
		}

		private string mServerName;
		private string mLogin;
		private string mPassword;

        private SQLDMO.SQLServer2 mSQLServer;
	}
}
