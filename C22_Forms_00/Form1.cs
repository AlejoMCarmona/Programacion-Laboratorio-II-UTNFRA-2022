using C20_Entidades_00;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C20_Forms_00
{
    public partial class Form1 : Form
    {
        public List<object> Items { get; set; } //Lista de objetos
        Class1 algo;

        public Form1()
        {
            InitializeComponent();
            Items = new List<object>();
            algo = new Class1();
            algo.algoEvent += this.RefrescarLista;
        }

        //Manejador del evento click de mi boton "AGREGAR"
        //Este metodo, solo se encarga de AGREGAR.
        public void ClickAgregar(object objeto, EventArgs e)
        {           
            try
            {
                //Llamo al metodo de la clase que agrega:
                algo.Agregar("");
                //Al devolver void, no puedo saber si agregó un objeto a la BBDD basándome en su retorno,
                //  por lo que dentro del método Agregar, refresca la lista con un evento.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Este método se va a disparar dentro del método "algo.Agregar();",
        //  No lo llamo en this.ClickAgregar() porque ese metodo solo agrega, no refresca la lista. Por lo que hacer que Agregar devuelva un booleano para saber si refrescar no tendría sentido.
        //  Ni tampoco refresco la lista dentro de algo.Agregar() porque no la tengo dentro de ese método, ni tampoco se la quiero pasar por parámetros porque tampoco tendría sentido hacerlo.
        //  Entonces disparo ese evento dentro de algo.Agregar(), para que venga hacia esta clase y refresque la lista, que pertenece a esta clase.
        public void RefrescarLista(object objeto, EventArgs e)
        {
            //Refresca la lista
            //Traería la lista de base de datos:
            //this.Lista = DAO.TraerTodos();
        }
    }
}
