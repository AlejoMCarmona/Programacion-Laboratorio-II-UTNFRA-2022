using C20_Entidades_01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C20_Forms_01
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;

        public FrmAvisador()
        {
            InitializeComponent();
        }

        //Manejador de eventos "btnActualizar_Click"
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (persona is null)
            {
                //INICIO - Es mejor en el constructor:
                this.persona = new Persona();
                this.persona.EventoString += FrmAvisador.NotificarCambio; //Le pasamos al evento de "Persona", su manejador. Si volvemos a asignarle el manejador más de una vez, entonces el mismo se ejecutará n cantidad de veces si es que lo asigne n cantidad de veces.
                //FIN
                this.btnCrear.Text = "Actualizar";
            }
            this.persona.Nombre = this.txtNombre.Text;
            this.persona.Apellido = this.txtApellido.Text;

            //Sería más lógico hacerlo en NotificarCambio() porque este método btnActualizarClick() solo actualiza y crea, no muestra nada.
            //  Además, solo se actualizaría el lblNombreCompleto cuando hay un cambio en los nombres.
            //  Debería hacerse también, una condicion en el "set", de que solo se cambie si el nombre != value.
            this.lblNombreCompleto.Text = this.persona.Mostrar();
        }

        //Es un EventHandler (manejador de eventos) sin "object" ni "EventArgs"
        //  Este método capturará el evento lanzado cuando hacemos un "set" en las propiedades de "Persona"
        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}
