namespace PersonManagement
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgPersons = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUpdateFirstname = new System.Windows.Forms.TextBox();
			this.txtUpdateLastname = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDeletePerson = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.txtInsertFirstname = new System.Windows.Forms.TextBox();
			this.txtInsertLastname = new System.Windows.Forms.TextBox();
			this.blagalwla = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgPersons)).BeginInit();
			this.SuspendLayout();
			// 
			// dgPersons
			// 
			this.dgPersons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPersons.Location = new System.Drawing.Point(12, 100);
			this.dgPersons.Name = "dgPersons";
			this.dgPersons.RowHeadersWidth = 51;
			this.dgPersons.RowTemplate.Height = 24;
			this.dgPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgPersons.Size = new System.Drawing.Size(1042, 276);
			this.dgPersons.TabIndex = 0;
			this.dgPersons.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DgPersons_RowStateChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Persons List";
			// 
			// txtUpdateFirstname
			// 
			this.txtUpdateFirstname.Location = new System.Drawing.Point(12, 413);
			this.txtUpdateFirstname.Name = "txtUpdateFirstname";
			this.txtUpdateFirstname.Size = new System.Drawing.Size(258, 22);
			this.txtUpdateFirstname.TabIndex = 2;
			// 
			// txtUpdateLastname
			// 
			this.txtUpdateLastname.Location = new System.Drawing.Point(12, 463);
			this.txtUpdateLastname.Name = "txtUpdateLastname";
			this.txtUpdateLastname.Size = new System.Drawing.Size(258, 22);
			this.txtUpdateLastname.TabIndex = 3;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(124, 502);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(146, 30);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// btnDeletePerson
			// 
			this.btnDeletePerson.Location = new System.Drawing.Point(908, 391);
			this.btnDeletePerson.Name = "btnDeletePerson";
			this.btnDeletePerson.Size = new System.Drawing.Size(146, 30);
			this.btnDeletePerson.TabIndex = 5;
			this.btnDeletePerson.Text = "Delete Person";
			this.btnDeletePerson.UseVisualStyleBackColor = true;
			this.btnDeletePerson.Click += new System.EventHandler(this.BtnDeletePerson_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(409, 502);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(146, 30);
			this.btnInsert.TabIndex = 6;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
			// 
			// txtInsertFirstname
			// 
			this.txtInsertFirstname.Location = new System.Drawing.Point(297, 413);
			this.txtInsertFirstname.Name = "txtInsertFirstname";
			this.txtInsertFirstname.Size = new System.Drawing.Size(258, 22);
			this.txtInsertFirstname.TabIndex = 7;
			// 
			// txtInsertLastname
			// 
			this.txtInsertLastname.Location = new System.Drawing.Point(297, 463);
			this.txtInsertLastname.Name = "txtInsertLastname";
			this.txtInsertLastname.Size = new System.Drawing.Size(258, 22);
			this.txtInsertLastname.TabIndex = 8;
			this.txtInsertLastname.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
			// 
			// blagalwla
			// 
			this.blagalwla.AutoSize = true;
			this.blagalwla.Location = new System.Drawing.Point(13, 383);
			this.blagalwla.Name = "blagalwla";
			this.blagalwla.Size = new System.Drawing.Size(74, 17);
			this.blagalwla.TabIndex = 9;
			this.blagalwla.Text = "First name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(294, 383);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "First name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(294, 443);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Last name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 443);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Last name";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1066, 666);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.blagalwla);
			this.Controls.Add(this.txtInsertLastname);
			this.Controls.Add(this.txtInsertFirstname);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.btnDeletePerson);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtUpdateLastname);
			this.Controls.Add(this.txtUpdateFirstname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgPersons);
			this.Name = "Form1";
			this.Text = "Person Management";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgPersons)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgPersons;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUpdateFirstname;
		private System.Windows.Forms.TextBox txtUpdateLastname;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDeletePerson;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.TextBox txtInsertFirstname;
		private System.Windows.Forms.TextBox txtInsertLastname;
		private System.Windows.Forms.Label blagalwla;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

