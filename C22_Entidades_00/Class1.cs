using System;

namespace C20_Entidades_00
{
    public class Class1
    {
        //Para lo único que se usa, es para que el evento tenga un tipo y una firma.
        public delegate void AlgoDelegate(object objeto, EventArgs e); //Delegado
        
        //El evento es del mismo tipo que el delegado
        public event AlgoDelegate algoEvent; //Evento
        
        public void Agregar(object obj)
        {
            //Agregar objeto a la base de datos

            //Llama a la clase DAO, método "Insertar()":
            //AlgoDAO.Insertar(objeto);

            bool seAgrego = true;
            if (seAgrego) //si se agregó
            {
                //EventArgs puede ser un objeto creado por mi, que contenga datos de interés para el manejador de eventos. Encapsula, por ejemplo, atributos que puedo utilizar
                //  como argumentos para el manejador del evento. En este caso, no necesito más argumentos, por lo que creo un EventArgs() y listo.
                //Disparo el evento:
                this.algoEvent.Invoke(this, new EventArgs()); //Este evento refrescaría la lista del formulario.
            }
        }
    }
}
