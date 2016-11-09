using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KohonenFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CKohonen kohonen;
        CProceso proceso;

        private void leerArquitecturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            proceso = new CProceso();
            kohonen = proceso.LeerTxt();
        }

        private void abrirKohonenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo koh = new ProcessStartInfo("notepad.exe", @"C:\Users\isaac\Desktop\Datos.txt");
            Process kh = Process.Start(koh);
        }

        private void propagarNeuronasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            proceso.GraficarEntradas(this);

        }  

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void inicarEntrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int contador = 1;

            kohonen.imicializarPesos();
            while (kohonen.alfa >= kohonen.ErrorMin && contador <= kohonen.iteracionesMax)
            {
                for (int p = 1; p <= kohonen.Np; p++)
                {
                    kohonen.PresentacionNeuronas(p);
                    kohonen.DistanciaEuclidiana();
                    proceso.indicesG = kohonen.CelulaGanadora();
                    kohonen.actPesos(proceso.indicesG, kohonen.radio);
                }
                kohonen.alfa = kohonen.actAlfa(kohonen.alfa, kohonen.ErrorMin, contador, kohonen.iteracionesMax);
                kohonen.radio = kohonen.redRadios(kohonen.radio, kohonen.radiof, contador, kohonen.iteracionesMax);
                contador++;
            }

            proceso.GraficarEntrenamiento(this);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            pbGrafica.Refresh();
        }

    }
    }

