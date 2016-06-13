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
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emotion.Machine;
namespace Emotion.Apps
{
    public partial class MainView : MetroForm
    {
        private Capture _capture = null;
        //private bool _captureInProgress;
        public Mat frame = new Mat();
        public MainView()
        {
            InitializeComponent();
            CvInvoke.UseOpenCL = false;
            try
            {
                _capture = new Capture();
                _capture.Start();
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcessFrame(object sender, EventArgs args)
        {
            _capture.Retrieve(frame, 0); imageBox1.Image = frame;
            //Run();
        }
        private void ReleaseDate()
        {
            if (_capture != null)
            {
                _capture.Dispose();
            }
        }

        private void Run()
        {
            /*
            long detectionTime;

            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> mouths = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            String faceFileName = "haarcascade_frontalface_default.xml";
            String mouthFileName = "haarcascade_mouth.xml";
            String eyeFileName = "haarcascade_eye.xml";

            DetectFace.Detect(frame, faceFileName, mouthFileName, eyeFileName, faces, mouths, eyes, out detectionTime);

            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(frame, face, new Bgr(Color.DeepSkyBlue).MCvScalar, 2);

            foreach (Rectangle mouth in mouths)
                CvInvoke.Rectangle(frame, mouth, new Bgr(Color.Red).MCvScalar, 2);

            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(frame, eye, new Bgr(Color.GreenYellow).MCvScalar, 2);
            imageBox1.Image = frame;
            */
        }
    }
}
