using System;

namespace Duda_Entidades
{
    public static class Clase
    {

        //Lo mas conveniente es hacerlo de esta forma:
        //  Se chequean los posibles errores antes de todo el código de la función, y se lanza una excepción en base a eso, para no tener que entrar
        //  de lleno al cuerpo del método y tener que esperar mucho para lanzar la excepción.
        //  Luego, en la última posibilidad de capturar la excepción, se captura a la misma y se muestra el mensaje o se hace lo que desee con el mismo.
        public static double DividirSinTryCatch(int numero1, int numero2)
        {
            if (numero2 == 0) throw new DivideByZeroException("mensaje"); 
            return numero1 / numero2;
        }

        //No es la forma más conveniente:
        //  No tiene sentido hacer un try-catch si es que voy a capturar la excepción en una llamada superior. En este caso, en el main.
        public static double DividirConTryCatch(int numero1, int numero2)
        {
            double resultado = 0;

            try
            {
                resultado = numero1 / numero2;
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception(ex.Message);
            }
            
            return resultado;
        }
    }
}
