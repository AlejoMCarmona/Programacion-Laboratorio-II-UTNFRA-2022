using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Entidades_01
{
    public class ParaisoFiscal
    {
        #region ATRIBUTOS
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;
        #endregion

        #region CONSTRUCTORES
        static ParaisoFiscal()
        {
            ParaisoFiscal.cantidadDeCuentas = 0;
            ParaisoFiscal.fechaInicioActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            this._lugar = lugar;
        }
#endregion

        #region SOBRECARGAS DE OPERADORES
        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos) 
        {
            bool retorno = false;

            foreach (CuentaOffShore cuenta in pf._listadoCuentas)
            {
                if (cuenta == cos)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }
        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf != cos)
            {
                pf._listadoCuentas.Add(cos);
                ParaisoFiscal.cantidadDeCuentas++;
                Console.WriteLine("Se agregó la cuenta al paraiso...");
            }
            else
            {
                int index = pf._listadoCuentas.FindIndex(c => c == cos);
                pf._listadoCuentas[index].Saldo += cos.Saldo;
                Console.WriteLine("Se actualizó el saldo de la cuenta...");
            }

            return pf;
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf == cos)
            {
                pf._listadoCuentas.Remove(cos);
                ParaisoFiscal.cantidadDeCuentas--;
                Console.WriteLine("Se quitó la cuenta del paraiso...");
            } else
            {
                Console.WriteLine("La cuenta no existe en el paraiso...");
            }

            return pf;
        }


        public static implicit operator ParaisoFiscal(eParaisosFiscales pf)
        {
            return new ParaisoFiscal(pf);
        }
#endregion

        #region METODOS
        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine("Fecha de inicio: " + ParaisoFiscal.fechaInicioActividades);
            sb.AppendLine("Localización: " + this._lugar);
            sb.AppendLine("Cantidad de 'cuentitas': " + ParaisoFiscal.cantidadDeCuentas);
            sb.AppendLine("***********Listado de cuentas offshore***********");
            foreach (CuentaOffShore cuenta in this._listadoCuentas)
            {
                sb.AppendLine(Cliente.RetornarDatos(cuenta.Duenio));
                sb.AppendLine("Numero de cuenta: " + (int)cuenta);
                sb.AppendLine("Saldo: " + cuenta.Saldo);
                sb.AppendLine();
            }

            Console.Write(sb.ToString());
        }
#endregion
    }
}
