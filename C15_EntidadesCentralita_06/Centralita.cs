using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15_EntidadesCentralita_06
{
    public class Centralita : IGuardar<string>
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        private string rutaDeArchivo; //TODO: preguntar si esto está bien
        #endregion

        #region Constructores
        public Centralita()
        {
            this.rutaDeArchivo = "bitacora.txt";
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(eTipoLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(eTipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(eTipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        public string RutaDeArchivo
        {
            get { return this.rutaDeArchivo; }
            set { this.rutaDeArchivo = value; }
        }
        #endregion

        #region Métodos
        private float CalcularGanancia(eTipoLlamada tipo)
        {
            float ganancia = 0;
            string tipoLlamadaActual = "";

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                tipoLlamadaActual = llamada.GetType().Name.ToString();

                if (tipoLlamadaActual == eTipoLlamada.Local.ToString() && (tipo == eTipoLlamada.Todas || tipo == eTipoLlamada.Local))
                {
                    ganancia += ((Local)llamada).CostoLlamada;
                } else if (tipoLlamadaActual == eTipoLlamada.Provincial.ToString() && (tipo == eTipoLlamada.Todas || tipo == eTipoLlamada.Provincial))
                {
                    ganancia += ((Provincial)llamada).CostoLlamada;
                }
            }

            return ganancia;
        }

        private string Mostrar()
        {
            StringBuilder datosCentralita = new StringBuilder();

            datosCentralita.AppendLine("********************************");
            datosCentralita.AppendLine("Razón social: " + this.razonSocial);
            datosCentralita.AppendLine("********Llamadas********");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                datosCentralita.Append(llamada.ToString());
                datosCentralita.AppendLine("---------------------");
            }
            datosCentralita.AppendLine("************************");
            datosCentralita.AppendLine("Ganancia por total: " + this.GananciasPorTotal);
            datosCentralita.AppendLine("Ganancias por local: " + this.GananciasPorLocal);
            datosCentralita.AppendLine("Ganancias por provincial: " + this.GananciasPorProvincial);
            datosCentralita.AppendLine("********************************");

            return datosCentralita.ToString();
        }

        public void OrdenarLlamadas ()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        private void AgregarLlamada (Llamada nuevaLlamada)
        {
            if (nuevaLlamada is not null)
            {
                this.listaDeLlamadas.Add(nuevaLlamada);
            }
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool retorno = false;

            foreach (Llamada llamada in c.listaDeLlamadas)
            {
                if (llamada == l)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static bool operator +(Centralita c, Llamada l)
        {
            bool retorno = false;

            if (c is not null && l is not null)
            {
                if (c != l)
                {
                    retorno = true;
                    c.AgregarLlamada(l);

                    try
                    {
                        c.Guardar();
                        if (l is Local) //TODO: preguntar
                        {
                            ((Local)l).Guardar();
                        } else if (l is Provincial)
                        {
                            ((Provincial)l).Guardar();
                        }
                    } 
                    catch (FallaLogException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                } else
                {
                    throw new CentralitaException($"La llamada desde el número {l.NroOrigen} hacia el {l.NroDestino} ya existe en la centralita", c.GetType().Name.ToString(), "public static bool operator +(Centralita c, Llamada l)");
                }
            }

            return retorno;
        }

        public bool Guardar()
        {
            StringBuilder bitacora = new StringBuilder();
            StreamWriter sw = null;
            DateTime dia = DateTime.Now;

            bitacora.Append(dia.ToString("f", new CultureInfo("es-ES")));
            bitacora.Append(" - Se realizó una llamada");

            try
            {
                sw = new StreamWriter(this.rutaDeArchivo, true);
                sw.WriteLine(bitacora.ToString());
            }
            catch
            {
                throw new FallaLogException();
            }
            finally
            {
                if (sw is not null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }

            return true;
        }

        public string Leer()
        {
            string datos = "";
            StreamReader sr = null;

            try
            {
                if(File.Exists(this.rutaDeArchivo))
                {
                    sr = new StreamReader(this.rutaDeArchivo);
                    datos = sr.ReadToEnd();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr is not null)
                {
                    sr.Close();
                }
            }

            return datos;
        }
        #endregion
    }
}
