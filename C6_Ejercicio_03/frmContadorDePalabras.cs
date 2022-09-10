using C6_Entidades_03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C6_Ejercicio_03
{
    public partial class frmContadorDePalabras : Form
    {
        public frmContadorDePalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string palabrasMasUsadas;
            Diccionario diccionarioPalabras = new Diccionario();
            string textoRtx = this.rtxDiccionario.Text;

            diccionarioPalabras.AgregarPalabras(textoRtx);
            diccionarioPalabras.OrdenarPalabrasPorUso();
            palabrasMasUsadas = diccionarioPalabras.MostrarPalabrasMasUsadas(3);

            MessageBox.Show($"TOP 3 palabras más usadas:\n{palabrasMasUsadas}");
        }
    }
}

/*
PRUEBA:
alejo alejo
amigo
perro
gato
perro
perro
perro
gato
hola
test
amigo
martin
alejo
perro

alejo: 3
gato: 2
amigo: 2
perro: 5
*/