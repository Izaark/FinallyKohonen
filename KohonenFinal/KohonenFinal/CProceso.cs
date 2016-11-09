using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KohonenFinal
{
    class CProceso
    {
        CKohonen koh = new CKohonen();
        Form1 f = new Form1();
        Graphics grafica;

        public int[] indicesG;
        string[] data;
        string datos;


        public CKohonen LeerTxt()
        {
            StreamReader Informacion = new StreamReader(@"C:\Users\isaac\Desktop\Datos.txt");//aqui va el txt con las entradas coloca la ruta en donde dejaste el txt

            while (!Informacion.EndOfStream)
            {
                datos += Informacion.ReadLine() + " ";
            }

            data = datos.Split(' ');

            koh.numN = Convert.ToInt16(data[0]);
            koh.tam = Convert.ToInt16(data[1]);
            koh.alfa = Convert.ToDouble(data[2]);
            koh.iteracionesMax = Convert.ToInt16(data[3]);
            koh.ErrorMin = Convert.ToDouble(data[4]);
            koh.Np = Convert.ToInt16(data[5]);
            koh.beta = koh.alfa / koh.iteracionesMax;

            indicesG = new int[3];
            koh.X = new double[koh.numN + 1, koh.Np + 1];

            for (int i = 1; i <= koh.numN; i++)
            {
                for (int j = 1; j <= koh.Np; j++)
                {
                    string[] split = data[5 + j].Split('\t');
                    for (int s = 0; s < split.Length; s++)
                    {
                        koh.X[s+1, j] = Convert.ToDouble(split[s]);
                    }
                }
            }
            MessageBox.Show("Archivo Leido");
            return koh;
        }
        public void GraficarEntradas(Form1 form)
        {
            grafica = form.pbGrafica.CreateGraphics();
            Pen lapiz1 = new Pen(Color.White, 9);


            for (int i = 2; i <= koh.numN; i++)
            {
                for (int j = 1; j <= koh.Np; j++)
                {  
                    Point puntos = new Point(Convert.ToInt16(koh.X[1, j] * 2), Convert.ToInt16(koh.X[2, j] * 2));
                    grafica.DrawEllipse(lapiz1, puntos.X, puntos.Y, 1, 1);
                }
            }
        }
        public void GraficarEntrenamiento(Form1 form)
        {
           
            Pen lapiz = new Pen(Color.DarkRed, 7);

            for (int i = 1; i <= koh.tam; i++)
            {
                for (int j = 1; j <= koh.tam; j++)
                {
                    int x = Convert.ToInt16(koh.w[1, i, j] * 2);
                    int y = Convert.ToInt16(koh.w[2, i, j] * 2);
                    Point puntos = new Point(x, y);
                    grafica.DrawEllipse(lapiz, puntos.X, puntos.Y, 1, 1);
                }
            }
            MessageBox.Show("Entrenamiento Correcto");
        }

    }
    }
