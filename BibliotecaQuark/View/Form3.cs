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
    public partial class Form3 : Form, INewMemberView
    {
        NewMemberPresenter newMemberPresenter;

        public Form3()
        {
            InitializeComponent();
        }
        public string GetMemberID()
        {
            return txtMemberID.Text;
        }

        public string GetMemberName()
        {
            return txtMemberName.Text;
        }

        public string GetMemberSurname()
        {
            return txtMemberSurname.Text;
        }

        public bool GetVIPMember()
        {
            return radioMemberVIP.Checked;
        }

        public void ShowMessage(bool success, string result)
        {
            if (success)
            {
                MessageBox.Show(result);
            }
            else
            {

                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            newMemberPresenter = new NewMemberPresenter(this);
        }
    }
}
