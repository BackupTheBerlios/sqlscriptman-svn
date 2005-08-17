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

		// my temp vars
		private Connection connection;
		private System.Windows.Forms.ComboBox cboObjectType;
		private System.Windows.Forms.Button btnList;

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
			this.SuspendLayout();
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(200, 16);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(160, 20);
			this.txtServer.TabIndex = 0;
			this.txtServer.Text = "ROCKET\\PRGCMESA040DV";
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(200, 48);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(160, 20);
			this.txtLogin.TabIndex = 1;
			this.txtLogin.Text = "";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(200, 80);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(160, 20);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(272, 112);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(88, 24);
			this.btnConnect.TabIndex = 3;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(96, 200);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(264, 20);
			this.txtPath.TabIndex = 4;
			this.txtPath.Text = "txtPath";
			// 
			// btnCheckPath
			// 
			this.btnCheckPath.Location = new System.Drawing.Point(248, 232);
			this.btnCheckPath.Name = "btnCheckPath";
			this.btnCheckPath.Size = new System.Drawing.Size(112, 24);
			this.btnCheckPath.TabIndex = 5;
			this.btnCheckPath.Text = "Load FSView";
			this.btnCheckPath.Click += new System.EventHandler(this.btnCheckPath_Click);
			// 
			// lstTest
			// 
			this.lstTest.Location = new System.Drawing.Point(376, 200);
			this.lstTest.Name = "lstTest";
			this.lstTest.Size = new System.Drawing.Size(224, 186);
			this.lstTest.TabIndex = 6;
			// 
			// cboObjectType
			// 
			this.cboObjectType.Location = new System.Drawing.Point(248, 272);
			this.cboObjectType.Name = "cboObjectType";
			this.cboObjectType.Size = new System.Drawing.Size(112, 21);
			this.cboObjectType.TabIndex = 7;
			this.cboObjectType.Text = "comboBox1";
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(248, 304);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(112, 24);
			this.btnList.TabIndex = 8;
			this.btnList.Text = "List Objects";
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 405);
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

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			connection = new Connection(
				txtServer.Text, 
				txtLogin.Text,
				txtPassword.Text);

			try
			{
				connection.Connect();
	            
				MessageBox.Show("Connected");
			}
			catch(Exception exp)
			{
                MessageBox.Show("Not connected: " + exp.Message);
			}
		}

		private void btnCheckPath_Click(object sender, System.EventArgs e)
		{
			try
			{
				Manager.tempDB.OpenFSView(Slot.One, txtPath.Text);
			}
			catch(Exception exc)
			{
                MessageBox.Show("Error '" + exc.Message + "' occured at " + exc.Source);
			}
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			foreach( String objectTypeName in Manager.dbObjectTypes )
			{
				cboObjectType.Items.Add(objectTypeName);
			}
		}

		private void btnList_Click(object sender, System.EventArgs e)
		{
			try
			{
				lstTest.Items.Clear();
				Manager.tempDB.ShowObjects(Slot.One,
					Manager.dbObjectTypes.IndexOf(cboObjectType.Text), lstTest);
			}
			catch(Exception exc)
			{
				MessageBox.Show("Error '" + exc.Message + "' occured at " + exc.Source);
			}
		}
	}
}
