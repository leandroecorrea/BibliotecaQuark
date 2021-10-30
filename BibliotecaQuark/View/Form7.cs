using BibliotecaQuark.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaQuark.View
{
    public partial class Form7 : Form, IAvailableCopiesView
    {
        AvailableCopiesPresenter availableCopiesPresenter;

        public Form7()
        {
            InitializeComponent();
        }
        

        public void FillTable(List<Copy> copiesList)
        {
            if (copiesList != null)
            {
                for (int i = 0; i < copiesList.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = copiesList[i].Name;
                    dataGridView1.Rows[i].Cells[1].Value = copiesList[i].ISBN;
                    dataGridView1.Rows[i].Cells[2].Value = copiesList[i].IssueYear;
                    dataGridView1.Rows[i].Cells[3].Value = copiesList[i].Location;
                    dataGridView1.Rows[i].Cells[4].Value = copiesList[i].AuthorName;
                }
            }
        }

        public string GetISBN()
        {
            return txtIsbn.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            availableCopiesPresenter = new AvailableCopiesPresenter(this);
        }

        public void ShowMessage(string message)
        {
           MessageBox.Show(message);           
        }
    }
}
