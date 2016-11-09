using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KohonenFinal
{
    public class CKohonen
    {
        public double alfa;
        public double radio = 2;
        public double radiof = 0.01;
        public double beta = 0;
        public int Np;
        public int numN;
        public int tam;

        public double[] E;
        public double[,] X;
        public double[,] T;
        public double[, ,] w;

        public double ErrorMin;
        public int iteracionesMax;
        Random rndX;
        public void imicializarPesos()
        {
            rndX = new Random();
            w = new double[numN + 1, tam + 1, tam + 1];
            T = new double[tam + 1, tam + 1];
            for (int i = 1; i < numN; i++)
            {
                for (int j = 1; j < tam; j++)
                {
                    for (int k = 1; k <tam ; k++)
                    {
                        w[i, j, k] = Math.Round(rndX.NextDouble(), 7);
                    }
                }
            }
        }

        public void PresentacionNeuronas(int p)
        {
            E = new double[numN + 1];

            for (int k = 1; k <= numN; k++)
            {
                E[k] = X[k, p];
            }
        }

        public void DistanciaEuclidiana()
        {
            double suma = 0;

            for (int i = 1; i <= tam; i++)
            {
                for (int j = 1; j <= tam; j++)
                {
                    for (int k = 1; k <= numN; k++)
                    {
                        suma += Math.Pow(E[k] - w[k, i, j], 2);
                    }
                    T[i, j] = Math.Sqrt(suma);
                   // suma = 0;
                }
            }
        }
        public int[] CelulaGanadora()
        {
            double min = T[1,1];
            int[] indexs = new int[3];
            for (int i = 1; i <= tam; i++)
            {
                for (int j = 1; j <= tam; j++)
                {
                    if (min > T[i,j])
                    {
                        min = T[i,j];
                        indexs[1] = i;
                        indexs[2] = j;
                    }
                }
            }
            return indexs;
        }

        public void actPesos(int[] indexs, double radio)
        {
            double dis = 0, suma;
            for (int i = 1; i <= tam; i++)
            {
                for (int j = 1; j <= tam; j++)
                {
                    suma = Convert.ToInt16(Math.Pow((i - indexs[1]), 2)) + Convert.ToInt16(Math.Pow((j - indexs[2]), 2));
                    dis = Math.Sqrt(suma);

                    if (dis <= radio)
                    {
                        for (int k = 1; k <= numN; k++)
                        {
                            w[k, i, j] = w[k, i, j] + alfa * (E[k] - w[k, i, j]);
                        }
                    }
                }
            }
        }


        public double actAlfa(double alfainicial, double alfafinal, double iteracion, double numIteracionesTotales)
        {
            return alfa = alfainicial + (alfafinal - alfainicial) * (iteracion / numIteracionesTotales);
        }

        public double redRadios(double radioInicial, double radiofinal, double iteracion, double TotalIteraciones)
        {
            return radioInicial + (radiofinal - radioInicial) * (iteracion / TotalIteraciones);
        }
    }

    }
    
