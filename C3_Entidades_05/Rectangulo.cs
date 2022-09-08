using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.area = 0;
            this.perimetro = 0;
        }

        public float Area()
        {
            float baseRectangulo;
            float alturaRectangulo;

            if (this.area == 0)
            {
                baseRectangulo = Math.Abs(this.vertice2.GetX() - this.vertice1.GetX());
                alturaRectangulo = Math.Abs(this.vertice4.GetY() - this.vertice2.GetY());
                this.area = baseRectangulo * alturaRectangulo;
            }

            return this.area;
        }

        public float Perimetro()
        {
            float baseRectangulo;
            float alturaRectangulo;

            if (this.perimetro == 0)
            {
                baseRectangulo = Math.Abs(this.vertice2.GetX() - this.vertice1.GetX());
                alturaRectangulo = Math.Abs(this.vertice4.GetY() - this.vertice2.GetY());
                this.perimetro = (baseRectangulo + alturaRectangulo) * 2;
            }

            return this.perimetro;
        }
    }
}
