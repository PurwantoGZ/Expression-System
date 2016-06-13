using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using System.IO;
using System.Windows.Media.Imaging;
using System.Drawing.Imaging;

namespace Emotion.Machine
{
    public class BaseMachine
    {

        #region KONSTRUKTOR
        public BaseMachine()
        {

        }
        #endregion

        #region Fungsi Mencari Nilai Tertinggi
        public double getHeightsValue(double[]nilai,int elemen)
        {
            int temp = 0;
            for (int j = 0; j < (elemen - 1); j += 1)
            {
                for (int i = 0; i < (elemen - 1); i += 1)
                {
                    if (nilai[i] < nilai[(i + 1)])
                    {
                        temp = Convert.ToInt32(nilai[i]);
                        nilai[i] = Convert.ToInt32(nilai[(i + 1)]);
                        nilai[(i + 1)] = Convert.ToInt32(temp);
                    }
                }
            }
            return nilai[0];
        }
        #endregion

        #region Fungsi Validasi Email
        public bool IsValidEmail(string email)
        {
            try
            {
                string expresion;
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(email, expresion))
                {
                    if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Accuracy Output
        public void accuracyOutput(double yValues,out int sad,out int happy)
        {
            int accuracy = 0;
            try
            {
                 accuracy= Convert.ToInt32(Math.Round(yValues,2)*100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            sad = 100 - accuracy;
            happy = 100 - sad;
        }
        #endregion

        #region Convert Image to Byte
        public byte[] ConvertToBytes(BitmapImage bitmapImage)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
            using (MemoryStream ms=new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        public BitmapImage byteToImage()
        {
            using (MemoryStream ms=new MemoryStream())
            {
                var imageSource = new BitmapImage();
                imageSource.BeginInit();
                imageSource.StreamSource = ms;
                imageSource.CacheOption = BitmapCacheOption.OnLoad;
                imageSource.EndInit();
                return imageSource;
            }
        }

        public byte[] imageToByteArray(PictureBox image)
        {

            byte[] data;
            if (image.Image!=null)
            {
                MemoryStream ms = new MemoryStream();
                image.Image.Save(ms, image.Image.RawFormat);
                data = ms.GetBuffer();
            }
            else
            {
                data = null;
            }
            
            return data;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        #endregion

    }
}
