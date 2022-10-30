using System;

namespace C15_EntidadesIO_05
{
    public interface IArchivo<T>
    {
        void Guardar(string ruta, T contenido);
        void GuardarComo(string ruta, T contenido);
        T Leer(string ruta);
    }
}
