using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19_Ejercicio_01
{
    public partial class FrmRelojero : Form
    {
        public FrmRelojero()
        {
            InitializeComponent();
        }

        private void FrmRelojero_Load(object sender, EventArgs e)
        {
            //Punto 1:

            //Punto 2:
            //this.AsignarHora();

            //Punto 3:
            Task task = Task.Run(AsignarHora);
        }

        //Punto 1: SIN HACER
        //public void AsignarHora()
        //{
        //    while (true)
        //    {
        //        this.lblHora.Text = DateTime.Now.ToString();
        //        Thread.Sleep(1000);
        //    }
        //}

        //Punto 2:
        //public void AsignarHora()
        //{
        //    this.tmrHora.Start();
        //    this.tmrHora.Interval = 1000;
        //}       
        private void tmrHora_Tick(object sender, EventArgs e) //No se comenta para no romper el formulario
        {
            this.lblHora.Text = DateTime.Now.ToString();
        }

        //Punto 3:
        public void AsignarHora()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.UtcNow.ToString();
                    });
                    //Aunque, como MethodInvoker es un delegado void sin parámetros, puede hacerse también con un delegado de tipo Action:
                    //Action action = new Action(() =>
                    //{
                    //    this.lblHora.Text = DateTime.UtcNow.ToString();
                    //});
                    //this.lblHora.BeginInvoke(action);
                }
                else
                {
                    this.lblHora.Text = DateTime.UtcNow.ToString();
                }
            }
        }
    }
}
