using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Emotion.Machine
{
    public class ComputeFiturValue
    {
        public  ComputeFiturValue()
        {

        }
        #region Properties
        private double centerMulutX,centerMulutY;
        private double centerMataX1, centerMataY1, centerMataX2, centerMataY2;
        private double centerMataX, centerMataY;
        private double centerAlisX1, centerAlisY1, centerAlisX2, centerAlisY2;
        private double centerDuaAlisX, centerDuaAlisY;
        #endregion

        #region ComputerMouthFeature
        public  void Mouth(int x1, int y1, int x2, int y2,ref double F3) {
            
            centerMulutX = ((x2 - x1) / 2) + x1;
            centerMulutY = ((y2 - y1) / 2) + y1;
            F3= (y2 - y1)*1.0;
        }
        #endregion

        #region ComputeEyeFeature
        public void Eye(int[] mataX1, int[] mataY1, int[] mataX2, int[] mataY2,ref double F2, ref double F5) {
            
            centerMataX1 = ((mataX1[2] - mataX1[1]) / 2) + mataX1[2];
            centerMataY1 = ((mataY1[2] - mataY1[2]) / 2) + mataY1[1];

            centerMataX2 = ((mataX2[2] - mataX2[1]) / 2) + mataX2[1];
            centerMataY2 = ((mataY2[2] - mataY2[1]) / 2) + mataY2[1];

            centerMataX = (centerMataX2 - centerMataX1) / 2;
            centerMataY = (centerMataY2 - centerMataY1) / 2;

            double a, b;
            a = centerMataX2 - centerMataX1;
            b = centerMataY2 - centerMataY1;
            F5 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            

            F2= ((mataY1[2] - mataY1[1]) + (mataY2[2] - mataY2[1])) / 2;
        }
        #endregion

        #region ComputeEyeBrow
        public void EyeBrow(int[]alisX1,int[]alisY1,int[]alisX2,int[]alisY2,ref double F1,ref double F4,ref double F6)
        {
            centerAlisX1 = ((alisX1[2]-alisX1[1])/2) + alisX1[1];
            centerAlisY1 = ((alisY1[2]-alisY1[1])/2) + alisY1[1];

            centerAlisX2 = ((alisX2[2] - alisX2[1]) / 2) + alisX2[1];
            centerAlisY2 = ((alisY2[2] - alisY2[1]) / 2) + alisY2[1];

            centerDuaAlisX = ((centerAlisX2 - centerAlisX1) / 2) + centerAlisX1;
            centerDuaAlisY = ((centerAlisY2 - centerAlisY1) / 2) + centerAlisY1;
            double a, b,c,d,e,f;
            a = centerDuaAlisX - centerMataX;
            b = centerDuaAlisY - centerMataY;
            F1 = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));

            c = centerAlisX2 - centerAlisX1;
            d = centerAlisY2 - centerAlisY1;
            F4 = Math.Sqrt(Math.Pow(c,2)+Math.Pow(d,2));

            e = centerMulutX - centerDuaAlisX;
            f = centerMulutY - centerDuaAlisY;
            F6 = Math.Sqrt(Math.Pow(e,2)+Math.Pow(f,2));
        }
        #endregion

    }
}
