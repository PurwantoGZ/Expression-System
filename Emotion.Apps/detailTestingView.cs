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
    public partial class detailTestingView : MetroForm
    {
        #region PROPERTIES
        public string idTesting;
        public string folder = @"E:\EmotionApps\CroppingImage\";
        MySQL db = new MySQL();
        string[] dataTesting = new string[12];
        #endregion

        public detailTestingView()
        {
            InitializeComponent();
        }
        public detailTestingView(string id)
        {
            InitializeComponent();
            idTesting = id;
        }

        private void detailTestingView_Load(object sender, EventArgs e)
        {
            db.getDetailTesting(idTesting, out dataTesting);
            previewCitra.ImageLocation = folder + dataTesting[11];
            TestingId.Text ="ID Testing: "+ dataTesting[0];
            NamaUser.Text ="Nama User: "+ dataTesting[10];
            F1.Text = dataTesting[1]; F2.Text = dataTesting[2];
            F3.Text = dataTesting[3]; F4.Text = dataTesting[4];
            F5.Text = dataTesting[5]; F6.Text = dataTesting[6];
            ekspresi.Text = dataTesting[7];
            if (dataTesting[7].Equals("Sedih"))
            {
                percentase.Text = dataTesting[8]+"%";
            }else
            {
                percentase.Text = dataTesting[9] + "%";
            }
        }
    }
}
