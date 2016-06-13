using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Windows.Forms;
#if !(__IOS__ || NETFX_CORE)
using Emgu.CV.Cuda;
#endif
namespace Emotion.Machine
{
    public class DetectFace
    {
       

        #region DETECT FACE TESTING
        public static void FaceTest(Mat image, string faceFileName, string eyeFileName, string mouthFileName, List<Rectangle> faces, List<Rectangle> eyes, List<Rectangle> mouths,
             ref int x1, ref int y1, ref int x2, ref int y2,
            ref int[] mataX1, ref int[] mataY1, ref int[] mataX2, ref int[] mataY2,
            ref int[] alisX1, ref int[] alisY1, ref int[] alisX2, ref int[] alisY2)
        {
            using (CascadeClassifier face = new CascadeClassifier(faceFileName))
            using (CascadeClassifier mouth = new CascadeClassifier(mouthFileName))
            using (CascadeClassifier eye = new CascadeClassifier(eyeFileName))
            {
                using (UMat ugray = new UMat())
                {
                    CvInvoke.CvtColor(image, ugray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(ugray, ugray);
                    Rectangle[] facesDetected = face.DetectMultiScale(
                       ugray,
                       1.1,
                       10,
                       new Size(20, 20));

                    faces.AddRange(facesDetected);

                    foreach (Rectangle f in facesDetected)
                    {
                        using (UMat faceRegion = new UMat(ugray, f))
                        {
                            Rectangle[] eyesDetected = eye.DetectMultiScale(
                               faceRegion,
                               1.1,
                               10,
                               new Size(20, 20));
                            int i = 1;
                            foreach (Rectangle e in eyesDetected)
                            {
                                Rectangle eyeRect = e;
                                eyeRect.Offset(f.X, f.Y);
                                if (i == 1)
                                {
                                    mataX1[1] = f.X; mataY1[1] = f.Y;
                                    mataX1[2] = (f.X + eyeRect.Width); mataY1[2] = (f.Y + eyeRect.Height);

                                    alisX1[1] = (f.X - eyeRect.Height); alisY1[1] = (f.Y - eyeRect.Height);
                                    alisX1[2] = ((f.X + eyeRect.Width) - eyeRect.Height); alisY1[2] = ((f.Y + eyeRect.Height) - eyeRect.Height);
                                }
                                if (i == 2)
                                {
                                    mataX2[1] = f.X; mataY2[1] = f.Y;
                                    mataX2[2] = (f.X + eyeRect.Width); mataY2[2] = (f.Y + eyeRect.Height);

                                    alisX2[1] = (f.X - eyeRect.Height); alisY2[1] = (f.Y - eyeRect.Height);
                                    alisX2[2] = ((f.X + eyeRect.Width) - eyeRect.Height); alisY2[2] = ((f.Y + eyeRect.Height) - eyeRect.Height);
                                }
                                i++;
                                eyes.Add(eyeRect);
                            }

                            Rectangle[] mouthsDetected = mouth.DetectMultiScale(faceRegion,
                               1.1,
                               10,
                               new Size(20, 20));

                            foreach (Rectangle m in mouthsDetected)
                            {
                                Rectangle mouthRect = m;
                                mouthRect.Offset(f.X,f.Y);
                                x1 = f.X;
                                y1 = f.Y;
                                x2 = (f.X + mouthRect.Width);
                                y2 = (f.Y + mouthRect.Height);
                                mouths.Add(mouthRect);
                            }
                        }
                    }
                }

            }//end using haar
            /*
            foreach (Rectangle face in faces)
                CvInvoke.Rectangle(image, face, new Bgr(Color.Red).MCvScalar, 2);
            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Blue).MCvScalar, 2);
            */
        }
        #endregion
    }
}
