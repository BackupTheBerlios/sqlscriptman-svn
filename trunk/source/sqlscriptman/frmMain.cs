using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace sqlscriptman
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnCheckPath;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.ListBox lstTest;
		private System.Windows.Forms.ComboBox cboObjectType;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtDBOwner;
		private System.Windows.Forms.TextBox txtDBName;
		private System.Windows.Forms.Button btnOpenDB;
		private System.Windows.Forms.Button btnUploadSP;
		private System.Windows.Forms.Button btnUploadAllSPs;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtServer = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnCheckPath = new System.Windows.Forms.Button();
			this.lstTest = new System.Windows.Forms.ListBox();
			this.cboObjectType = new System.Windows.Forms.ComboBox();
			this.btnList = new System.Windows.Forms.Button();
			this.btnOpenDB = new System.Windows.Forms.Button();
			this.txtDBOwner = new System.Windows.Forms.TextBox();
			this.txtDBName = new System.Windows.Forms.TextBox();
			this.btnUploadSP = new System.Windows.Forms.Button();
			this.btnUploadAllSPs = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(24, 16);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(160, 20);
			this.txtServer.TabIndex = 0;
			this.txtServer.Text = "ROCKET\\PRGCMESA040DV";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(24, 48);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(160, 20);
			this.txtLogin.TabIndex = 1;
			this.txtLogin.Text = "ssmtest";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(24, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(160, 20);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "pwd";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(72, 112);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(112, 24);
			this.btnConnect.TabIndex = 3;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(96, 168);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(264, 20);
			this.txtPath.TabIndex = 7;
			this.txtPath.Text = "D:\\2P\\projects\\job\\ZBA\\SourceCodes\\SQL";
			// 
			// btnCheckPath
			// 
			this.btnCheckPath.Location = new System.Drawing.Point(248, 200);
			this.btnCheckPath.Name = "btnCheckPath";
			this.btnCheckPath.Size = new System.Drawing.Size(112, 24);
			this.btnCheckPath.TabIndex = 8;
			this.btnCheckPath.Text = "Load FSView";
			this.btnCheckPath.Click += new System.EventHandler(this.btnCheckPath_Click);
			// 
			// lstTest
			// 
			this.lstTest.Location = new System.Drawing.Point(376, 168);
			this.lstTest.Name = "lstTest";
			this.lstTest.Size = new System.Drawing.Size(224, 212);
			this.lstTest.TabIndex = 11;
			// 
			// cboObjectType
			// 
			this.cboObjectType.Location = new System.Drawing.Point(248, 240);
			this.cboObjectType.Name = "cboObjectType";
			this.cboObjectType.Size = new System.Drawing.Size(112, 21);
			this.cboObjectType.TabIndex = 9;
			this.cboObjectType.Text = "comboBox1";
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(248, 272);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(112, 24);
			this.btnList.TabIndex = 10;
			this.btnList.Text = "List Objects";
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnOpenDB
			// 
			this.btnOpenDB.Location = new System.Drawing.Point(248, 112);
			this.btnOpenDB.Name = "btnOpenDB";
			this.btnOpenDB.Size = new System.Drawing.Size(112, 24);
			this.btnOpenDB.TabIndex = 6;
			this.btnOpenDB.Text = "Open DB";
			this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
			// 
			// txtDBOwner
			// 
			this.txtDBOwner.Location = new System.Drawing.Point(200, 80);
			this.txtDBOwner.Name = "txtDBOwner";
			this.txtDBOwner.Size = new System.Drawing.Size(160, 20);
			this.txtDBOwner.TabIndex = 5;
			this.txtDBOwner.Text = "<DATABASE OWNER>";
			// 
			// txtDBName
			// 
			this.txtDBName.Location = new System.Drawing.Point(200, 48);
			this.txtDBName.Name = "txtDBName";
			this.txtDBName.Size = new System.Drawing.Size(160, 20);
			this.txtDBName.TabIndex = 4;
			this.txtDBName.Text = "<DATABASE NAME>";
			// 
			// btnUploadSP
			// 
			this.btnUploadSP.Location = new System.Drawing.Point(376, 400);
			this.btnUploadSP.Name = "btnUploadSP";
			this.btnUploadSP.Size = new System.Drawing.Size(224, 24);
			this.btnUploadSP.TabIndex = 12;
			this.btnUploadSP.Text = "Upload Stored Procedure";
			this.btnUploadSP.Click += new System.EventHandler(this.btnUploadSP_Click);
			// 
			// btnUploadAllSPs
			// 
			this.btnUploadAllSPs.Location = new System.Drawing.Point(376, 432);
			this.btnUploadAllSPs.Name = "btnUploadAllSPs";
			this.btnUploadAllSPs.Size = new System.Drawing.Size(224, 24);
			this.btnUploadAllSPs.TabIndex = 13;
			this.btnUploadAllSPs.Text = "Upload All Stored Procedures";
			this.btnUploadAllSPs.Click += new System.EventHandler(this.btnUploadAllSPs_Click);
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 477);
			this.Controls.Add(this.btnUploadAllSPs);
			this.Controls.Add(this.btnUploadSP);
			this.Controls.Add(this.txtDBOwner);
			this.Controls.Add(this.txtDBName);
			this.Controls.Add(this.btnOpenDB);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.cboObjectType);
			this.Controls.Add(this.lstTest);
			this.Controls.Add(this.btnCheckPath);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.txtServer);
			this.Name = "frmMain";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			foreach( String objectTypeName in Manager.dbObjectTypes )
			{
				cboObjectType.Items.Add(objectTypeName);
			}
		}

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			Manager.connection = new Connection(
				txtServer.Text, 
				txtLogin.Text,
				txtPassword.Text);

			try
			{
				Manager.connection.Connect();
	            
				MessageBox.Show("Connected");
			}
			catch(Exception exc)
			{
                MessageBox.Show("Not connected: " + exc.Message);
			}
		}

		private void btnOpenDB_Click(object sender, System.EventArgs e)
		{
			try
			{
				Manager.tempDB.OpenServerView(Slot.One,
					ref Manager.connection,
					txtDBName.Text, txtDBOwner.Text);
				
				MessageBox.Show("Opened");
			}
			catch(Exception exc)
			{
                MessageBox.Show("Error '" + exc.Message + "' occured at " + exc.Source);
			}
		
		}

		private void btnCheckPath_Click(object sender, System.EventArgs e)
		{
			try
			{
				Manager.tempDB.OpenFSView(Slot.Two, txtPath.Text);
			}
			catch(Exception exc)
			{
                MessageBox.Show("Error '" + exc.Message + "' occured at " + exc.Source);
			}
		}

		private void btnList_Click(object sender, System.EventArgs e)
		{
			try
			{
				lstTest.Items.Clear();
				Manager.tempDB.ShowObjects(Slot.Two,
					Manager.dbObjectTypes.IndexOf(cboObjectType.Text), lstTest);
			}
			catch(Exception exc)
			{
				MessageBox.Show("Error '" + exc.Message + "' occured at " + exc.Source);
			}
		}

		private void btnUploadSP_Click(object sender, System.EventArgs e)
		{
			try
			{
				Manager.tempDB.AddServerProcedure(Slot.Two, Slot.One, lstTest.Text);
			}
			catch(Exception exc)
			{
				MessageBox.Show("Error '" + exc.Message + "' occured at " + exc.Source);
			}
		}

		private void btnUploadAllSPs_Click(object sender, System.EventArgs e)
		{
			try
			{
				Manager.tempDB.AddAllServerProcedures(Slot.Two, Slot.One);
			}
			catch(Exception exc)
			{
				MessageBox.Show("Error '" + exc.Message + "' occured at " + exc.Source);
			}
		}
	}
}
