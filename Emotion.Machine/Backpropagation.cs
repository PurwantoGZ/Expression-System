using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Emotion.Machine
{
    public class Backpropagation
    {
        #region PROPESTIES
        public double learningRate;
        private int numInput=6;
        private int numHidden=3;
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        #endregion

        #region KONSTRUKTOR
        public Backpropagation(double learningRate)
        {
            this.learningRate = learningRate;
        }
        #endregion

        #region Train Backpropagation
        public void Train(int numData,double[]f1,double[]f2,double[]f3,double[]f4,double[]f5,double[]f6,double[] outputDiharapkan,
            ref ListBox Terminal,ref double[] weights, double[] oldWeight)
        {
            /*Cretae Node Sel*/
            /*Jumlah Hidden Layer Statis*/
            HiddenLayer h1 = new HiddenLayer(numInput, learningRate);
            HiddenLayer h2 = new HiddenLayer(numInput, learningRate);
            HiddenLayer h3 = new HiddenLayer(numInput, learningRate);

            OutputLayer selOutput = new OutputLayer(numHidden, learningRate);

            #region Get BOBOT FROM DB
            /*Generate Random Bobot*/
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    h1.weights[i] = oldWeight[i];
                }
                for (int i = 0; i < 6; i++)
                {
                    h2.weights[i] = oldWeight[6 + i];
                }
                for (int i = 0; i < 6; i++)
                {
                    h3.weights[i] = oldWeight[12 + i];
                }
                h1.biasWeights = oldWeight[18];
                h2.biasWeights = oldWeight[19];
                h3.biasWeights = oldWeight[20];

                for (int i = 0; i < 3; i++)
                {
                    selOutput.weights[i] = oldWeight[21 + i];
                }
                selOutput.biasWeights = oldWeight[24];
            }
            catch (Exception)
            {
            }
            /*--------END----------*/
            #endregion

            /*Iterasi*/
            double SSE = 0;
            int iterasi = 0;
            
            do
            {
                iterasi++;
                SSE = 0;
                
                for (int i = 0; i < numData; i++)
                {
                    /*1) Forward propagation*/
                    h1.inputs = new double[] { f1[i], f2[i], f3[i], f4[i], f5[i], f6[i] };
                    h2.inputs = new double[] { f1[i], f2[i], f3[i], f4[i], f5[i], f6[i] };
                    h3.inputs = new double[] { f1[i], f2[i], f3[i], f4[i], f5[i], f6[i] };

                    selOutput.inputs = new double[] { h1.outputSebenarnya, h2.outputSebenarnya, h3.outputSebenarnya };
                    double ERROR = outputDiharapkan[i] - selOutput.outputSebenarnya;
                    SSE += Math.Pow(ERROR, 2);
                  
                    /*2) Back propagation*/
                    selOutput.Teta = Activation.derivative(selOutput.outputSebenarnya) * (outputDiharapkan[i] - selOutput.outputSebenarnya);
                    selOutput.updateWeights();

                    h1.Teta = Activation.derivative(h1.outputSebenarnya) * selOutput.Teta * selOutput.weights[0];
                    h2.Teta = Activation.derivative(h2.outputSebenarnya) * selOutput.Teta * selOutput.weights[1];
                    h3.Teta = Activation.derivative(h3.outputSebenarnya) * selOutput.Teta * selOutput.weights[2];

                    h1.updateWeights();
                    h2.updateWeights();
                    h3.updateWeights();
                }
                /*
                if (iterasi % 2 == 0)
                {
                    Terminal.Items.Add("iterasi-" + iterasi+", SSE : "+SSE);
                }
                */
                //AllocConsole();
                //Console.WriteLine(" Iterasi-{0}, SSE: {1}",iterasi,SSE);
                //Console.ReadLine();
                Terminal.Items.Add("iterasi-" + iterasi + ", SSE : " + SSE);

            } while (SSE>0.001&&iterasi<50000);
            MessageBox.Show("SSE : "+SSE.ToString()+", Iterasi : "+iterasi.ToString());

            #region Set BOBOT OPTIMAL
            /*SET BOBOT OPTIMAL*/
            try
            {
                int numWeights = 25;
                weights=new double[numWeights];
                for (int i = 0; i < 6; i++)
                {
                    weights[i] = h1.weights[i];
                }
                for (int i = 0; i < 6; i++)
                {
                    weights[6 +i] = h2.weights[i];
                }
                for (int i = 0; i < 6; i++)
                {
                    weights[12 + i] = h3.weights[i];
                }
                weights[18] = h1.biasWeights;
                weights[19] = h2.biasWeights;
                weights[20] = h3.biasWeights;

                for (int i = 0; i < 3; i++)
                {
                    weights[21 + i] = selOutput.weights[i];
                }
                weights[24] = selOutput.biasWeights;
            }
            catch (Exception)
            {
            }
            #endregion

        }
        #endregion

        #region Train Backpropagation By User
        public void TrainByUser(int numData, double[] f1, double[] f2, double[] f3, double[] f4, double[] f5, double[] f6, double[] outputDiharapkan,
             ref double[] weights,double[]oldWeight,ref string result)
        {
            /*Cretae Node Sel*/
            /*Jumlah Hidden Layer Statis*/
            HiddenLayer h1 = new HiddenLayer(numInput, learningRate);
            HiddenLayer h2 = new HiddenLayer(numInput, learningRate);
            HiddenLayer h3 = new HiddenLayer(numInput, learningRate);

            OutputLayer selOutput = new OutputLayer(numHidden, learningRate);

            /*Generate Random Bobot*/
            #region Random Bobot
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    h1.weights[i] = oldWeight[i];
                }
                for (int i = 0; i < 6; i++)
                {
                    h2.weights[i]=oldWeight[6 + i];
                }
                for (int i = 0; i < 6; i++)
                {
                    h3.weights[i] = oldWeight[12 + i];
                }
                  h1.biasWeights = oldWeight[18];
                  h2.biasWeights = oldWeight[19];
                  h3.biasWeights = oldWeight[20];

                for (int i = 0; i < 3; i++)
                {
                    selOutput.weights[i] = oldWeight[21 + i];
                }
                selOutput.biasWeights = oldWeight[24];
            }
            catch (Exception)
            {
            }
            /*--------END----------*/
            #endregion

            /*Iterasi*/
            double SSE = 0;
            int iterasi = 0;

            do
            {
                iterasi++;
                SSE = 0;

                for (int i = 0; i < numData; i++)
                {
                    /*1) Forward propagation*/
                    h1.inputs = new double[] { f1[i], f2[i], f3[i], f4[i], f5[i], f6[i] };
                    h2.inputs = new double[] { f1[i], f2[i], f3[i], f4[i], f5[i], f6[i] };
                    h3.inputs = new double[] { f1[i], f2[i], f3[i], f4[i], f5[i], f6[i] };

                    selOutput.inputs = new double[] { h1.outputSebenarnya, h2.outputSebenarnya, h3.outputSebenarnya };
                    double ERROR = outputDiharapkan[i] - selOutput.outputSebenarnya;
                    SSE += Math.Pow(ERROR, 2);

                    /*2) Back propagation*/
                    selOutput.Teta = Activation.derivative(selOutput.outputSebenarnya) * (outputDiharapkan[i] - selOutput.outputSebenarnya);
                    selOutput.updateWeights();

                    h1.Teta = Activation.derivative(h1.outputSebenarnya) * selOutput.Teta * selOutput.weights[0];
                    h2.Teta = Activation.derivative(h2.outputSebenarnya) * selOutput.Teta * selOutput.weights[1];
                    h3.Teta = Activation.derivative(h3.outputSebenarnya) * selOutput.Teta * selOutput.weights[2];

                    h1.updateWeights();
                    h2.updateWeights();
                    h3.updateWeights();
                }
                

            } while (SSE > 0.001 && iterasi < 500000);
            result= ("SSE : " + SSE.ToString() + ", Iterasi : " + iterasi.ToString());

            #region Set Bobot
            /*SET BOBOT OPTIMAL*/
            try
            {
                int numWeights = 25;
                weights = new double[numWeights];
                for (int i = 0; i < 6; i++)
                {
                    weights[i] = h1.weights[i];
                }
                for (int i = 0; i < 6; i++)
                {
                    weights[6 + i] = h2.weights[i];
                }
                for (int i = 0; i < 6; i++)
                {
                    weights[12 + i] = h3.weights[i];
                }
                weights[18] = h1.biasWeights;
                weights[19] = h2.biasWeights;
                weights[20] = h3.biasWeights;

                for (int i = 0; i < 3; i++)
                {
                    weights[21 + i] = selOutput.weights[i];
                }
                weights[24] = selOutput.biasWeights;
            }
            catch (Exception)
            {
            }
            #endregion

        }
        #endregion

        #region Test Backpropagation
        public void Test(double f1, double f2, double f3, double f4, double f5, double f6,ref double output,double[] weights)
        {
            /*Cretae Node Sel*/
            /*Jumlah Hidden Layer Statis*/
            HiddenLayer h1 = new HiddenLayer(numInput, learningRate);
            HiddenLayer h2 = new HiddenLayer(numInput, learningRate);
            HiddenLayer h3 = new HiddenLayer(numInput, learningRate);

            OutputLayer selOutput = new OutputLayer(numHidden, learningRate);

            /* Retrieve Bobot Optimal*/
            for (int i = 0; i < 6; i++)
            {
                h1.weights[i] = weights[i];
            }
            for (int i = 0; i < 6; i++)
            {
                h2.weights[i] = weights[6 + i];
            }
            for (int i = 0; i < 6; i++)
            {
                h3.weights[i] = weights[12 + i];
            }
            h1.biasWeights = weights[18];
            h2.biasWeights = weights[19];
            h3.biasWeights = weights[20];

            for (int i = 0; i < 3; i++)
            {
                selOutput.weights[i] = weights[21 + i];
            }
            selOutput.biasWeights = weights[24];

            try
            {
                h1.inputs = new double[] { f1, f2, f3, f4, f5, f6 };
                h2.inputs = new double[] { f1, f2, f3, f4, f5, f6 };
                h3.inputs = new double[] { f1, f2, f3, f4, f5, f6 };

                selOutput.inputs = new double[] { h1.outputSebenarnya, h2.outputSebenarnya, h3.outputSebenarnya };
                output= selOutput.outputSebenarnya;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
    }
}
