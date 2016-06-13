using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Emotion.Machine
{
    public class HiddenLayer
    {
        public int numInput;
        public double[] inputs;
        public double[] weights;
        public double Teta;
        public double biasWeights;
        private double cerebrofit;
        private Random r = new Random();

        public HiddenLayer(int numInput,double learningRate)
        {
            this.numInput = numInput;
            this.cerebrofit = learningRate;
            this.inputs = new double[numInput];
            this.weights = new double[numInput];
        }

        /*Function Hitung Nilai Output*/
        public double outputSebenarnya
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < numInput; i++)
                {
                    sum += (weights[i]*inputs[i]);
                }
                double output = sum+(1*biasWeights);
                return Activation.output(output);
            }
        }

        /*Function Random Bobot (weights)*/
        public void randomizeWeights()
        {
            for (int i = 0; i < numInput; i++)
            {
                weights[i] = r.NextDouble();
            }
            biasWeights = r.NextDouble();
        }

        /*Function Update Weight (Bobot)*/
        public void updateWeights()
        {
            for (int i = 0; i < numInput; i++)
            {
                weights[i] += Teta * inputs[i] * cerebrofit;
            }
            biasWeights += Teta * cerebrofit;
        }
    }
}
