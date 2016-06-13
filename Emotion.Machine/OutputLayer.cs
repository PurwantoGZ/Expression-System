using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Emotion.Machine
{
    public class OutputLayer
    {
        public int numInput;
        public double[] inputs;
        public double[] weights;
        public double Teta;
        public double biasWeights;
        private double cerebrofit;
        private Random r = new Random();

        public OutputLayer(int numHidden,double learningRate)
        {
            this.numInput = numHidden;
            this.cerebrofit = learningRate;
            inputs = new double[numInput];
            weights = new double[numInput];
        }
        
        /* Function Hitung Nilai Output*/
        public double outputSebenarnya
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < numInput; i++)
                {
                    sum += (weights[i]*inputs[i]);
                }
                double output = sum + (1*biasWeights);
                return Activation.output(output);
            }
        }

        public void randomizeWeights()
        {
            for (int i = 0; i < numInput; i++)
            {
                weights[i]= r.NextDouble();
            }
            biasWeights = r.NextDouble();
        }

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
