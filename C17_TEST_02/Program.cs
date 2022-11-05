using C17_Entidades_02;
using System.Collections.Generic;

namespace C17_TEST_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLO PARA PROBAR:
            Juego juegoNuevo = new Juego("GTA V", 20, "ACCION", 1000);
            JuegoDAO.Guardar(juegoNuevo);
            List<Biblioteca> listaJuegos = JuegoDAO.Leer();
            JuegoDAO.Eliminar(9);

            Juego juegoNuevo2 = new Juego("GTA IV", 12, "ACCION", 1001);
            JuegoDAO.Guardar(juegoNuevo2);
            Juego juegoModificado = new Juego("GTA IV", 10, "ACCION-MUNDO_ABIERTO", 10, 1001);
            JuegoDAO.Modificar(juegoModificado);
            Juego juegoPorID = JuegoDAO.LeerPorID(1);

            List<Usuario> listaUsuarios = UsuarioDAO.Leer();
        }
    }
}
