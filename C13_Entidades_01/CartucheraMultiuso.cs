using C13_Entidades_01.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13_Entidades_01
{
    public class CartucheraMultiuso
    {
        private List<IAcciones> elementos;

        public CartucheraMultiuso(List<IAcciones> elementos)
        {
            this.elementos = elementos;
        }

        public bool RecorrerElementos()
        {
            List<IAcciones> elementosARecargar = new List<IAcciones>();
            bool retorno = true;

            //Escribo con los boligrafos y/o lápices:
            foreach (IAcciones elemento in this.elementos)
            {
                try
                {
                    if (elemento.GetType().Name == "Lapiz")
                    {
                        elemento.Escribir("¡Una unidad!"); //10 caracteres = una unidad.
                    }
                    else if (elemento.GetType().Name == "Boligrafo")
                    {
                        elemento.UnidadesDeEscritura -= 1; //No lo hago con "Escribir()" porque gastaría de a 0.3 unidades y no podría gastar EXACTAMENTE una como pide el enunciado.
                    }
                }
                catch (CantidadInsuficienteException ex)
                {
                    Console.WriteLine(ex.Message);
                    elementosARecargar.Add(elemento);
                    retorno = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    retorno = false;
                }
            }

            if (elementosARecargar.Count > 0)
            {
                foreach (IAcciones elemento in elementosARecargar)
                {
                    try
                    {
                        elemento.Recargar(20);
                    } 
                    catch(NotImplementedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }

            return retorno;
        }
    }
}
