using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonManagement
{
	public partial class Form1 : Form
	{
		private DataReader reader = null;

		private Person selectedPerson = null;

		public Form1()
		{
			InitializeComponent();

			reader = new DataReader();

			btnDeletePerson.Enabled = false;

			FillList();
		}

		private void FillList()
		{
			dgPersons.DataSource = reader.ReadPersons();
			dgPersons.ClearSelection();
		}

		private void TextBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void FillUpdateFields(Person person)
		{
			if (person != null)
			{
				txtUpdateFirstname.Text = person.FirstName;
				txtUpdateLastname.Text = person.LastName;

			}
			else
			{
				ClearSelection();
			}
		}

		private void DgPersons_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			selectedPerson = e.Row.DataBoundItem as Person;

			if (selectedPerson != null)
			{
				btnDeletePerson.Enabled = true;
				FillUpdateFields(selectedPerson);
			}
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			Person updatedPerson = new Person()
			{
				FirstName = txtUpdateFirstname.Text,
				LastName = txtUpdateLastname.Text,
				Id = selectedPerson.Id
			};

			var result = reader.UpdatePerson(updatedPerson);

			if (result)
			{
				FillList();
				ClearSelection();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void BtnInsert_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtInsertFirstname.Text) && !String.IsNullOrEmpty(txtInsertLastname.Text))
			{
				Person insertPerson = new Person()
				{
					FirstName = txtInsertFirstname.Text.Trim(),
					LastName = txtInsertLastname.Text.Trim()
				};

				var result = reader.AddPerson(insertPerson);

				if (result)
				{
					txtInsertFirstname.Text = String.Empty;
					txtInsertLastname.Text = String.Empty;

					FillList();
					ClearSelection();
				}
			}
		}


		public void ClearSelection()
		{
			txtUpdateFirstname.Text = String.Empty;
			txtUpdateLastname.Text = String.Empty;
		}

		private void BtnDeletePerson_Click(object sender, EventArgs e)
		{
			if (selectedPerson != null)
			{
				var result = reader.DeletePerson(selectedPerson.Id);

				if (result)
				{
					FillList();
				}
			}
		}
	}
}
