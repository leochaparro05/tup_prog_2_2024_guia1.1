using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1._1._3
{
    internal class Peaje1
    {
        public double PromedioMes= 0;
        public int[] Cantidades = new int[31];
        public int contador = 0;
        int cantidadtotal = 0;

        public void RegistrarResumenDia(int dia, int cantidadautos)
        {
            Cantidades[dia-1] = cantidadautos;
           cantidadtotal = cantidadtotal + cantidadautos;
            contador++;
            PromedioMes = cantidadtotal / contador*1.0;


        }

        public int MayorMovimineto()
        {
            int cantidadmayor = 0;
            int dia = -1;
            for (int i = 0; i < Cantidades.Length; i++)
            {
                if (Cantidades[i] > cantidadmayor)
                {
                    cantidadmayor = Cantidades[i];
                    dia = i;
                }

            }

            return dia;

        }

        
        public int[] DiasmayoresProm (out int cantDias)
        {
            int contaux = 0;
            cantDias = 0;

            int[] diasmayores = new int[contador];
            for (int i = 0;i < Cantidades.Length;i++)
            {
                if (Cantidades[i] > PromedioMes)
                {
                    diasmayores[contaux] = i;
                    contaux++;
                    cantDias = contaux;
                
                }


            }
            
            return diasmayores;

        }

        public int Terciodelmesmayor()
        {
            int tercio1= 0, tercio2= 0, tercio3 = 0;

            for ( int i = 0; i<10; i++)
            {
                tercio1 += Cantidades[i];
            }

            for (int i = 10; i < 20; i++)
            {
                tercio2 += Cantidades[i];
            }

            for (int i = 20; i < 30; i++)
            {
                tercio3 += Cantidades[i];
            }

            if (tercio1>tercio2 && tercio1>tercio3)
            {
                int ter1 = 1;
                return ter1;
            }
            else if (tercio2 > tercio1 && tercio2 > tercio3)
            {
                int ter2 = 2;
                return ter2;
            }
            else
            {
                int ter3 = 3;
                return ter3;
            }
        }
        
    }
}
