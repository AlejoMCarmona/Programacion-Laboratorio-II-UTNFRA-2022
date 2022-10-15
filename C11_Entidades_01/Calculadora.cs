using System;

namespace C11_Entidades_01
{
    public static class Calculadora
    {
        //Primera parte:
        public static int Add (string numeros)
        {
            int resultado = 0;
            string posibleNumero = "";
            int contadorNumeros = 0;

            if (!String.IsNullOrEmpty(numeros))
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (!numeros[i].Equals(',')) posibleNumero += numeros[i];
                    if (contadorNumeros == 2) break;

                    if ((numeros[i].Equals(',') || i == numeros.Length - 1))
                    {
                        try
                        {
                            resultado += int.Parse(posibleNumero);
                            contadorNumeros++;
                            posibleNumero = "";
                        }
                        catch (FormatException ex)
                        {
                            throw new FormatException(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                }
            }

            return resultado;
        }
    }
}
