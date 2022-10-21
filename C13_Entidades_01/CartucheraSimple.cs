using C13_Entidades_01.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Entidades_01
{
    public class CartucheraSimple
    {
        private List<Boligrafo> boligrafos;
        private List<Lapiz> lapices;

        public CartucheraSimple(List<Boligrafo> boligrafos, List<Lapiz> lapices)
        {
            this.boligrafos = boligrafos;
            this.lapices = lapices;
        }

        public bool RecorrerElementos()
        {
            bool retorno = true;
            List<Boligrafo> boligrafosARecargar = new List<Boligrafo>();

            //Escribo con los boligrafos:
            foreach (Boligrafo boligrafo in this.boligrafos)
            {
                try
                {
                    boligrafo.UnidadesDeEscritura -= 1;
                }
                catch (CantidadInsuficienteException ex)
                {
                    retorno = false;
                    boligrafosARecargar.Add(boligrafo);
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Escribo con los lápices:
            foreach (Lapiz lapiz in this.lapices)
            {
                try
                {
                    ((IAcciones)lapiz).Escribir("Una unidad!"); //Debido a que Lapiz implementa la interfaz de forma explícita en todos sus miembros, debo utilizarlos de esta forma.
                }
                catch (CantidadInsuficienteException ex)
                {
                    retorno = false;
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Recargo los boligrafos:
            if (boligrafosARecargar.Count > 0)
            {
                foreach (Boligrafo boligrafo in boligrafosARecargar)
                {
                    boligrafo.Recargar(20);
                }
            }

            return retorno;
        }
    }
}
