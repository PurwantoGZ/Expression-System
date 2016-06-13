using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Emotion.Machine;
namespace Emotion.Apps
{
    public partial class LoginView : MetroForm
    {
        MySQL db = new MySQL();
        Formulir fView = null;
        private string idUser=null;
        
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.loginCheck(txtUser.Text,txtPassword.Text, ref idUser) == true)
                {
                    var writer = new System.IO.StreamWriter("session.pur");
                    writer.WriteLine(idUser);
                    writer.WriteLine(txtPassword.Text);
                    writer.Close();
                    txtPassword.Clear();
                    txtUser.Clear();
                    txtUser.Focus();
                    this.Hide();
                }
                else
                {
                    txtPassword.Clear();
                    txtUser.Clear();
                    txtUser.Focus();
                    notif.Text = "Password/User Id tidak ditemukan !";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Hide();
        }

        delegate void loginUnloaded(object sender, FormClosedEventArgs e);
        void formulirFormClosed(object sender, FormClosedEventArgs e)
        {
            if (RegisterLabel.InvokeRequired)
            {
                loginUnloaded f = new loginUnloaded(formulirFormClosed);
                this.Invoke(f, new object[] { sender, e });
            }
            else
            {
                fView = null;
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            fView = new Formulir();
            fView.FormClosed += new FormClosedEventHandler(formulirFormClosed);
            fView.ShowDialog();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            notif.Text = "";
        }
    }
}
