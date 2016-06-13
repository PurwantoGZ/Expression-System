using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emotion.Machine;
using DirectShowLib;
using System.Globalization;
using System.Windows.Threading;
namespace Emotion.Apps
{
    public partial class Dashboard : MetroForm
    {
        //int CameraDevice = 0; //Variable to track camera device selected
        Video_Device[] WebCams; //List containing all the camera available
        detailTestingView detailView = null;
        GraphicsView grapicsView = null;
        MySQL db = new MySQL();

        int numDataTraining = 0;
        double[] _f1;
        double[] _f2;
        double[] _f3;
        double[] _f4;
        double[] _f5;
        double[] _f6;
        double[] tValues;

        #region PROPERTIES FEATURES
        int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
        int[] mataX1 = new int[3];
        int[] mataX2 = new int[3];
        int[] mataY1 = new int[3];
        int[] mataY2 = new int[3];

        int[] alisX1 = new int[3];
        int[] alisX2 = new int[3];
        int[] alisY1 = new int[3];
        int[] alisY2 = new int[3];
        double f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, f6 = 0;
        ComputeFiturValue compute = new ComputeFiturValue();
        #endregion

        #region Capture Properties
        Mat frame = new Mat();
        private Capture _capture = null;
        #endregion

        string idOutput = null;
        OpenFileDialog ofd = new OpenFileDialog();

        #region Allow Camera
        private void allowCamera()
        {
            DialogResult dialogResult = MessageBox.Show("Ijin Akses Camera \n Anda Mengijinkan ?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CvInvoke.UseOpenCL = false;
                try
                {
                    _capture = new Capture();
                    _capture.ImageGrabbed += ProcessFrame;
                    _capture.Start();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        #endregion


        #region KONSTRUKTOR
        public Dashboard()
        {
            InitializeComponent();
            db.getOutput(ref cbOutput);
            db.getUserID(ref cbUserId);
            db.getUserID(ref cbidUser);
            txtMusic.Enabled = false;
            txtMovie.Enabled = false;
            txtVideo.Enabled = false;
            txtGambar.Enabled = false;
            txtBook.Enabled = false;
            txtWarna.Enabled = false;

            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new Video_Device[_SystemCamereas.Length];

            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                WebCams[i] = new Video_Device(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID); //fill web cam array
                cbListCam.Items.Add(WebCams[i].ToString());
            }
            if (cbListCam.Items.Count > 0)
            {
                cbListCam.SelectedIndex = 0; //Set the selected device the default
                cbListCam.Enabled = true; //Enable the start
            }
        }
        #endregion

        #region EVENT

        private void ProcessFrame(object sender, EventArgs arg)
        {
            _capture.Retrieve(frame, 0);runCapture();
        }

        private void runCapture()
        {
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> mouths = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            String faceFileName = "haarcascade_frontalface_default.xml";
            String mouthFileName = "haarcascade_mcs_mouth.xml";
            String eyeFileName = "haarcascade_eye.xml";

            DetectFace.FaceTest(frame, faceFileName, mouthFileName, eyeFileName,
                faces, mouths, eyes, ref x1, ref y1, ref x2, ref y2,
                ref mataX1, ref mataY1, ref mataX2, ref mataY2,
                ref alisX1, ref alisY1, ref alisX2, ref alisY2);

            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(frame, face, new Bgr(Color.DeepSkyBlue).MCvScalar, 2);

            foreach (Rectangle mouth in mouths)
                CvInvoke.Rectangle(frame, mouth, new Bgr(Color.Aquamarine).MCvScalar, 2);

            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(frame, eye, new Bgr(Color.GreenYellow).MCvScalar, 2);
            PreviewImage.Image = frame;
        }

        private void ComputeFeature()
        {
            compute.Mouth(x1, y1, x2, y2, ref f3);
            compute.Eye(mataX1, mataY1, mataX2, mataY2, ref f2, ref f5);
            compute.EyeBrow(alisX1, alisY1, alisX2, alisY2, ref f1, ref f4, ref f6);

            F1.Text = f1.ToString("#.##");
            F2.Text = f2.ToString("#.##");
            F3.Text = f3.ToString("#.##");
            F4.Text = f4.ToString("#.##");
            F5.Text = f5.ToString("#.##");
            F6.Text = f6.ToString("#.##");
        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private void PreviewImage_BackgroundImageChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void SettingCamera_Click(object sender, EventArgs e)
        {
            if (SettingCamera.Text.Equals("Start"))
            {
                allowCamera(); LiveBtn.Enabled = true;
                SettingCamera.ImageIndex = 11;
                SettingCamera.Text = "Stop";
            }else
            {
                _capture.Dispose();
                LiveBtn.Enabled = false;
                SettingCamera.ImageIndex = 10;
                SettingCamera.Text = "Start";
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.saveTrainingData("pur",idOutput, F1.Text, F2.Text, F3.Text, F4.Text, F5.Text, F6.Text);
        }

        private void cbCerebrofit_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTraining.Enabled = true;
        }

        private void btnViewTesting_Click(object sender, EventArgs e)
        {
            db.viewDataTesting(ref dataTesting);
            int countTesting = 0, countsad = 0, countHappy = 0;
            db.getCountTesting(ref countTesting, ref countsad, ref countHappy);
            countDataTesting.Text = countTesting.ToString() + " Data Testing, "
                + countsad.ToString() + " data sedih, " + countHappy.ToString() + " data senang";
        }

        delegate void detailViewLoaded(object sender, FormClosedEventArgs e);
        void detailViewClosed(object sender,FormClosedEventArgs e)
        {
            if (dataTesting.InvokeRequired)
            {
                detailViewLoaded f = new detailViewLoaded(detailViewClosed);
                this.Invoke(f, new object[] { sender, e });
            }else
            {
                detailView = null;
            }
        }

        private void dataTesting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idTesting = int.Parse(dataTesting.Rows[e.RowIndex].Cells[0].Value.ToString());
            detailView = new detailTestingView(idTesting.ToString());
            detailView.FormClosed += new FormClosedEventHandler(detailViewClosed);
            detailView.ShowDialog(); 
        }

        private void btnViewDataUser_Click(object sender, EventArgs e)
        {
            db.viewDataUser(ref userTable);
            int cUser = 0;
            db.getCountUser(ref cUser);
            countUser.Text = cUser.ToString() + " User";
        }

        private void userTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idUser = userTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            string[] favoriteName = new string[6];
            int[] priority = new int[6];
            int[] idFavorite=new int[6];
            db.getFavorite(idUser, out favoriteName, out priority, out idFavorite);
            txtMusic.Text = favoriteName[0];
            txtMovie.Text = favoriteName[1];
            txtVideo.Text = favoriteName[2];
            txtGambar.Text = favoriteName[3];
            txtBook.Text = favoriteName[4];
            txtWarna.Text = favoriteName[5];
        }

        delegate void graphicsViewLoaded(object sender,FormClosedEventArgs e);
        void grapicsViewClosed(object sender, FormClosedEventArgs e)
        {
            if (btnGrafik.InvokeRequired)
            {
                graphicsViewLoaded f = new graphicsViewLoaded(grapicsViewClosed);
                this.Invoke(f,new object[] { sender,e});
            }
            else
            {
                grapicsView = null;
            }
        }
        private void btnGrafik_Click(object sender, EventArgs e)
        {
            grapicsView = new GraphicsView();
            grapicsView.FormClosed += new FormClosedEventHandler(grapicsViewClosed);
            grapicsView.ShowDialog();
        }

        private void cbidUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.viewDataTraining(ref dataTraining,cbidUser.Text);
            numDataTraining = 0;
            numDataTraining = dataTraining.RowCount; cbCerebrofit.Enabled = true;
        }

        private void LiveBtn_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                _capture.Pause(); ComputeFeature();
                DialogResult dialogResult = MessageBox.Show("Ambil Ekspresi Lagi ?", "Berhasil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _capture.Start();
                    F1.Clear();
                    F2.Clear();
                    F3.Clear();
                    F4.Clear();
                    F5.Clear();
                    F6.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    _capture.Dispose();
                    SettingCamera.Text = "Start";SettingCamera.ImageIndex = 10;
                }
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            using (ofd)
            {
                ofd.Title = "Open Image Training";
                ofd.Filter = "Jpg Files (*.jpg)|*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    frame = new Mat(ofd.FileName, LoadImageType.Color);
                    runCapture(); ComputeFeature();
                }
            }
        }

        private void cbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {   
            db.getIdOutput(cbOutput.Text,ref idOutput);// GET ID OUTPUT
            saveBtn.Enabled = true;
        }
  
        private void metroTabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            Terminal.Items.Clear();
            double[] weights = new double[25];
            double[] oldWeight = new double[25];
            double cerebrofit = 0;
            _f1 = new double[numDataTraining];
            _f2 = new double[numDataTraining];
            _f3 = new double[numDataTraining];
            _f4 = new double[numDataTraining];
            _f5 = new double[numDataTraining];
            _f6 = new double[numDataTraining];
            tValues = new double[numDataTraining];

            /* Ambil Data Training by User*/
            db.populateDataTraining(out _f1,out _f2,out _f3,out _f4,out _f5,out _f6,
                out tValues,numDataTraining, cbidUser.Text);

            /* Ambil Bobot Optimal Terakhir*/
            db.getWeightByUser(out oldWeight, out cerebrofit, cbidUser.Text);

            /* Membuat Objek Backpropagation*/
            Backpropagation bp = new Backpropagation(Convert.ToDouble(cbCerebrofit.Text));

            /*Train Backpropagation */
            bp.Train(numDataTraining, _f1, _f2, _f3, _f4, _f5, _f6, tValues, 
                ref Terminal, ref weights,oldWeight);
            
            /*Update BOBOT Optimal*/
            db.UpdateWeightbyUser(weights,Convert.ToDouble(cbCerebrofit.Text),cbidUser.Text);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

    }
}
