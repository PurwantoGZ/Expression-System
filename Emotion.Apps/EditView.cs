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
    public partial class EditView : MetroForm
    {
        private string idUser;
        string[] favoriteName = new string[6];
        int[] idFavorite = new int[6];
        int[] priority = new int[6];
        private string nama;
        MySQL db = new MySQL();
        public EditView()
        {
            InitializeComponent();
        }
        public EditView(string id)
        {
            this.idUser = id;
            InitializeComponent();
        }

        #region getUser
        private void getUser()
        {
            try
            {
                db.getFullUser(idUser, ref nama);
                fullName.Text = nama;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region getFavorite
        private void getFavorite()
        {
            try
            {
                db.getFavorite(idUser, out favoriteName, out priority, out idFavorite);
                txtMusic.Text = favoriteName[0];
                txtMovie.Text = favoriteName[1];
                txtVideo.Text = favoriteName[2];
                txtGambar.Text = favoriteName[3];
                txtBook.Text = favoriteName[4];
                txtWarna.Text = favoriteName[5];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            favoriteName[0] = txtMusic.Text;
            favoriteName[1] = txtMovie.Text;
            favoriteName[2] = txtVideo.Text;
            favoriteName[3] = txtGambar.Text;
            favoriteName[4] = txtBook.Text;
            favoriteName[5] = txtWarna.Text;
            
            try
            {
                bool notif1=false,notif2=false;
                for (int i = 0; i < favoriteName.Length; i++)
                {
                    notif1 = (db.updateFavorite(idFavorite[i], favoriteName[i])) ?true :false;
                }

                notif2 = (db.updateUserData(fullName.Text,idUser)) ? true : false;
                if ((notif1&&notif2)==false)
                {
                    MessageBox.Show("Gagal Menyimpan perubahan.");
                }else
                {
                    MessageBox.Show("Data telah disimpan.");
                }
                getUser();getFavorite();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EditView_Load(object sender, EventArgs e)
        {
            getUser();getFavorite();
        }

        private void cbConfirm_CheckedChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
        }
    }
}
