using System;

namespace C11_Entidades_01
{
    public static class Calculadora
    {
        //Primera parte:
        //public static int Add (string numeros)
        //{
        //    int resultado = 0;
        //    string posibleNumero = "";
        //    int contadorNumeros = 0;

        //    if (!String.IsNullOrEmpty(numeros))
        //    {
        //        for (int i = 0; i < numeros.Length; i++)
        //        {
        //            if (!numeros[i].Equals(',')) posibleNumero += numeros[i];
        //            if (contadorNumeros == 2) break;

        //            if ((numeros[i].Equals(',') || i == numeros.Length - 1))
        //            {
        //                try
        //                {
        //                    resultado += int.Parse(posibleNumero);
        //                    contadorNumeros++;
        //                    posibleNumero = "";
        //                }
        //                catch (FormatException ex)
        //                {
        //                    throw new FormatException(ex.Message);
        //                }
        //                catch (Exception ex)
        //                {
        //                    throw new Exception(ex.Message);
        //                }
        //            }
        //        }
        //    }

        //    return resultado;
        //}

        //Segunda parte:
        //public static int Add(string numeros)
        //{
        //    int resultado = 0;
        //    string posibleNumero = "";

        //    if (!String.IsNullOrEmpty(numeros))
        //    {
        //        for (int i = 0; i < numeros.Length; i++)
        //        {
        //            if (!numeros[i].Equals(',')) posibleNumero += numeros[i];

        //            if ((numeros[i].Equals(',') || i == numeros.Length - 1))
        //            {
        //                try
        //                {
        //                    resultado += int.Parse(posibleNumero);
        //                    posibleNumero = "";
        //                }
        //                catch (FormatException ex)
        //                {
        //                    throw new FormatException(ex.Message);
        //                }
        //                catch (Exception ex)
        //                {
        //                    throw new Exception(ex.Message);
        //                }
        //            }
        //        }
        //    }

        //    return resultado;
        //}

        public static int Add(string numeros)
        {
            int resultado = 0;
            string posibleNumero = "";
            numeros = numeros.Replace(" ", string.Empty);
            
            if (!String.IsNullOrEmpty(numeros))
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    if (!numeros[i].Equals(',') && !numeros[i].Equals('\n')) posibleNumero += numeros[i];
                    if (numeros[i].Equals(',') && i != numeros.Length -1 && numeros[i+1].Equals('\n')) throw new FormatException();

                    if (i == numeros.Length - 1 || (numeros[i].Equals(',') && !numeros[i+1].Equals('\n')) || (numeros[i].Equals('\n') && !numeros[i+1].Equals(',')))
                    {
                        try
                        {
                            if (posibleNumero.Contains('\n')) posibleNumero = posibleNumero.Replace("\n", String.Empty);
                            resultado += int.Parse(posibleNumero);
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
