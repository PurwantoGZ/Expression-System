using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emotion.Machine;
using System.Threading;
using System.Windows.Media.Imaging;

namespace Emotion.Apps
{
    public partial class TestingView : MetroForm
    {
        #region PROPERTIES
        public int sad=0, happy=0;
        public string idUser = null,_pass=null;
        Dashboard dView = null;
        SearchingView sView = null;
        EditView eView = null;
        string[] favoriteName = new string[6];
        int[] idFavorite = new int[6];
        int[] priority = new int[6];

        LoginView lView = null;
        Mat frame = new Mat();
        MySQL db = new MySQL();
        BaseMachine baseMachine = new BaseMachine();
        private Capture _capture = null;

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
        double _f1 = 0, _f2 = 0, _f3 = 0, _f4 = 0, _f5 = 0, _f6 = 0;
        ComputeFiturValue compute = new ComputeFiturValue();

        double[] weight = new double[25];
        double[] oldWeight = new double[25];
        double cerebrofit = 0;
        double[] maxF = new double[6];
        double yValues = 0;
        string Expression = null,key=null;

        Bitmap extractedFace;
        Graphics FaceCanvas;
        Bitmap ExtFace;
        Random r = new Random();
        #endregion

        #region Function SadOrHappy
        private void sadOrHappy()
        {
            try
            {
                if (db.getWeightByUser(out weight, out cerebrofit, idUser))
                {
                    Backpropagation bp = new Backpropagation(cerebrofit);
                    compute.Mouth(x1, y1, x2, y2, ref f3);
                    compute.Eye(mataX1, mataY1, mataX2, mataY2, ref f2, ref f5);
                    compute.EyeBrow(alisX1, alisY1, alisX2, alisY2, ref f1, ref f4, ref f6);
                    db.getMaxValues(out maxF);
                    _f1 = f1; _f2 = f2; _f3 = f3; _f4 = f4; _f5 = f5; _f6 = f6;
                    f1 = f1 / maxF[0];
                    f2 = f2 / maxF[1];
                    f3 = f3 / maxF[2];
                    f4 = f4 / maxF[3];
                    f5 = f5 / maxF[4];
                    f6 = f6 / maxF[5];
                    bp.Test(f1, f2, f3, f4, f5, f6, ref yValues, weight);
                    f1 = Math.Round(f1, 3); f2 = Math.Round(f2, 3); f3 = Math.Round(f3, 3);
                    f4 = Math.Round(f4, 3); f5 = Math.Round(f5, 3); f6 = Math.Round(f6, 3);

                    statusF1.Text = "F1: "+ f1.ToString();
                    statusF2.Text = "F2: " + f2.ToString();
                    statusF3.Text = "F3: " + f3.ToString();
                    statusF4.Text = "F4: " + f4.ToString();
                    statusF5.Text = "F5: " + f5.ToString();
                    statusF6.Text = "F6: " + f6.ToString();

                    key = decimal.Round(Convert.ToDecimal(yValues)).ToString();
                    yValuesText.Text =" Output: "+ yValues.ToString();

                    baseMachine.accuracyOutput(yValues, out sad, out happy);

                    Kesedihan.Text = "0%";
                    Kesenangan.Text = "0%";
                    Kesedihan.Text = sad.ToString() + "%";
                    Kesenangan.Text = happy.ToString() + "%";
                    db.getFinallyOutput(key, ref Expression);
                    /*Save Data Testing*/
                    if ((f1!=0) && (f2!=0) && (f3!=0)&& (f4!=0) &&(f5!=0)&&(f6!=0))
                    {
                        string folder = @"E:\EmotionApps\CroppingImage\";
                        string iName = r.NextDouble().ToString()+".JPEG";
                        Bitmap imgSave = new Bitmap(ExtFace);
                        imgSave.Save(folder + iName);
                        string dataImage =iName;
                        db.saveTesting(Convert.ToInt32(key), _f1, _f2, _f3, _f4, _f5, _f6, idUser, sad, happy,dataImage);
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region KONSTRUKTOR
        public TestingView()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            PanelSaran.Hide();
            label3.Hide();
            Terminal.Hide();
        }
        #endregion

        #region MAIN FUNCTION
        /*1. Fungsi Capture using Camera*/
        private void runCapture()
        {
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> mouths = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            String faceFileName = "haarcascade_frontalface_default.xml";
            String mouthFileName = "haarcascade_mcs_mouth.xml";
            String eyeFileName = "haarcascade_eye.xml";

            DetectFace.FaceTest(frame, faceFileName, mouthFileName, eyeFileName, faces, mouths, eyes,
                ref x1, ref y1, ref x2, ref y2,
                ref mataX1, ref mataY1, ref mataX2, ref mataY2,
                ref alisX1, ref alisY1, ref alisX2, ref alisY2);

            compute.Mouth(x1, y1, x2, y2, ref f3);
            compute.Eye(mataX1, mataY1, mataX2, mataY2, ref f2, ref f5);
            compute.EyeBrow(alisX1, alisY1, alisX2, alisY2, ref f1, ref f4, ref f6);

            foreach (Rectangle face in faces)
            {
                CvInvoke.Rectangle(frame, face, new Bgr(Color.DeepSkyBlue).MCvScalar, 2);
                extractedFace = new Bitmap(face.Width,face.Height);
                FaceCanvas = Graphics.FromImage(extractedFace);
                FaceCanvas.DrawImage(frame.ToImage<Bgr,Byte>().ToBitmap(), 0, 0, face, GraphicsUnit.Pixel);
                ExtFace = extractedFace;
            }
                
            /*
            foreach (Rectangle mouth in mouths)
            {
                CvInvoke.Rectangle(frame, mouth, new Bgr(Color.Aquamarine).MCvScalar, 2);
            }
                

            foreach (Rectangle eye in eyes)
            {
                CvInvoke.Rectangle(frame, eye, new Bgr(Color.GreenYellow).MCvScalar, 2);
            }
              */  
             
            captureImageBox.Image = frame;  
        }

        /*2. Process Frame Webcam*/
        private void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                _capture.Retrieve(frame, 0); runCapture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*3. Fungsi Release Data */
        private void ReleaseData()
        {
            try
            {
                if (_capture != null)
                    _capture.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /*4. Fungsi Enable Training*/
        private void checkUser()
        {
            try
            {
                string fileLoc = @"session.pur";
                if (File.Exists(fileLoc))
                {
                    using (TextReader tr = new StreamReader(fileLoc))
                    {
                        idUser = tr.ReadLine();
                        _pass = tr.ReadLine();
                        UserInfo.Text = db.getUser(idUser);
                        string nama = UserInfo.Text;
                        // NamaFull.Text = nama.Substring(0,8);
                        NamaFull.Text = nama;
                        db.getFavorite(idUser,out favoriteName,out priority,out idFavorite);
                        PanelPreview.Enabled = true;
                        PanelInfo.Enabled = true;
                        PanelSaran.Enabled = true;
                        allowCamera();
                        timer1.Start();
                        tr.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Anda belum terdaftar, Silahkan daftar dahulu.");
                    UserInfo.Text = "Login";
                    timer1.Stop();
                    PanelPreview.Enabled = false;
                    PanelInfo.Enabled = false;
                    PanelSaran.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /*5. Fungsi Threading Splash Screen*/
        public void SplashStart()
        {
            Application.Run(new SplashScreen());
        }

        /*6. Fungsi Allow Using Camera*/
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
                    btnStart.ImageIndex = 9;
                    btnStart.Text = "Stop";
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
            
        }

        /*9. Fungsi Training Data*/
        private void trainDataUser()
        {
           
                int numDataTraining = db.countTrain(idUser);
                double[] _f1 = new double[numDataTraining];
                double[] _f2 = new double[numDataTraining];
                double[] _f3 = new double[numDataTraining];
                double[] _f4 = new double[numDataTraining];
                double[] _f5 = new double[numDataTraining];
                double[] _f6 = new double[numDataTraining];
                double[] tValues = new double[numDataTraining];
                db.populateDataTrainingbyUser(out _f1, out _f2, out _f3, out _f4, out _f5, out _f6, out tValues, idUser, numDataTraining);
                db.getWeightByUser(out oldWeight, out cerebrofit, idUser);
                Backpropagation bp = new Backpropagation(cerebrofit);
                string result=null;
                bp.TrainByUser(numDataTraining, _f1, _f2, _f3, _f4, _f5, _f6, tValues, ref weight, oldWeight,ref result);
                ErrorText.Text = result;
                db.UpdateWeightbyUser(weight, cerebrofit, idUser);
            
        }

        /*10. Fungsi Thread Login View*/
        private void _loginView()
        {
            try
            {
                lView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /*11. Fungsi Tampil Kontent*/
        /*
        private void viewKontent()
        {
            
            int epoch = 0;
            do
            {
                sadOrHappy();
                if (emotion.Equals("Sedih"))
                {
                    Terminal.Items.Clear();
                    Terminal.Items.Add(favoriteName[epoch]);
                }
                epoch++;
            } while (emotion.Equals("Sedih")&&epoch<favoriteName.Length);
        }
        */

        #endregion

        #region EVENT
        private void TestingView_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.ExitThread();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        delegate void searchinGviewLoaded(object sender, FormClosedEventArgs e);
        void searchingViewClosed(object sender, FormClosedEventArgs e)
        {
            if (Terminal.InvokeRequired)
            {
                loginUnloaded f = new loginUnloaded(searchingViewClosed);
                this.Invoke(f, new object[] { sender, e });
            }
            else
            {
                sView = null;
            }
        }

        private void Terminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            sView = new SearchingView(Terminal.Text);
            sView.FormClosed += new FormClosedEventHandler(searchingViewClosed);
            sView.Show();
        }

        private void TestingView_Load(object sender, EventArgs e)
        {
            try
            {
                checkUser();trainDataUser();
                timer1.Interval = 300;
                timer1.Tick += timer1_Tick;
                cerebrofit = db.setCerebrofit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        delegate void dashViewLoaded(object sender, FormClosedEventArgs e);
        void dashViewClosed(object sender,FormClosedEventArgs e)
        {
            if (btnTraining.InvokeRequired)
            {
                dashViewLoaded f = new dashViewLoaded(dashViewClosed);
                this.Invoke(f, new object[] { sender, e });
            }else
            {
                dView = null;
            }
        }

        delegate void editViewLoaded(object sender, FormClosedEventArgs e);
        void editViewClosed(object sender,FormClosedEventArgs e)
        {
            if (btnTraining.InvokeRequired)
            {
                editViewLoaded f = new editViewLoaded(editViewClosed);
                this.Invoke(f, new object[] { sender, e });
            }else
            {
                eView = null;
            }
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            try
            {
                _capture.Dispose();
                if (idUser.Equals("admin@gmail.com"))
                {
                    dView = new Dashboard();
                    dView.FormClosed += new FormClosedEventHandler(dashViewClosed);
                    dView.ShowDialog();
                }
                else
                {
                    eView = new EditView(idUser);
                    eView.FormClosed += new FormClosedEventHandler(editViewClosed);
                    eView.ShowDialog();
                }
                checkUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void UserInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserInfo.Text!="Login")
                {
                    #region Log out Konfirmasi
                    DialogResult dialogResult = MessageBox.Show("Yakin Keluar?", "Logout Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _capture.Dispose();
                        timer1.Stop();
                        PanelPreview.Enabled = false;
                        captureImageBox.Image = null;
                        //EmotionText.Text = "";
                        UserInfo.Text = "Login";
                        btnStart.ImageIndex = 8;
                        btnStart.Text = "Start";
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                    #endregion
                }
                else
                {
                    #region Login Form
                    lView = new LoginView();
                    lView.FormClosed += new FormClosedEventHandler(loginFormClosed);
                    lView.ShowDialog();
                    checkUser();trainDataUser();
                    timer1.Interval = 300;
                    timer1.Tick += timer1_Tick;
                    _capture.Start();
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        int epoch = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Now.Second % 2 == 0)
                {
                    sadOrHappy();
                    string ket = "Ekspresi anda dominan menunjukkan ekspresi";
                    string emotion = Expression;
                    if (emotion.Equals("Sedih"))
                    {
                        if (epoch==6)
                        {
                            epoch = 0;
                        }

                        Keterangan.Text = ket + " sedih";
                        PanelSaran.Show();
                        label3.Show();
                        Terminal.Show();

                        Terminal.Items.Clear();
                        Terminal.Items.Add(favoriteName[epoch]);
                        epoch++;
                    }else
                    {
                        Keterangan.Text = ket + " senang, silahkan gunakan waktu anda dengan baik.";
                        PanelSaran.Hide();
                        label3.Hide();
                        Terminal.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnStart.Text.Equals("Start"))
                {
                    checkUser();
                }
                else
                {
                    _capture.Dispose();
                    timer1.Stop();
                    PanelPreview.Enabled = false;
                    captureImageBox.Image = null;
                    //EmotionText.Text = "";
                    UserInfo.Text = "Login";
                    btnStart.ImageIndex = 8;
                    btnStart.Text = "Start";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        delegate void loginUnloaded(object sender,FormClosedEventArgs e);
        void loginFormClosed(object sender,FormClosedEventArgs e)
        {
            if (UserInfo.InvokeRequired)
            {
                loginUnloaded f = new loginUnloaded(loginFormClosed);
                this.Invoke(f, new object[] {sender,e });
            }else
            {
                lView = null;
            }
        }

        private void LoadLoginView()
        {
            lView = new LoginView();
            lView.FormClosed += new FormClosedEventHandler(loginFormClosed);
            lView.ShowDialog();
        }
        #endregion
    }
}
