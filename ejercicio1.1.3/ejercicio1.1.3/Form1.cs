using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1._1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Peaje1 peaje = new Peaje1();
        Cargapeaje objventana = new Cargapeaje();
        private void btnregistrarpeaje_Click(object sender, EventArgs e)
        {
            while (objventana.ShowDialog() == DialogResult.OK)
            {
                int numerodia = Convert.ToInt32(objventana.numdias.Text);
                int cantidadauto = Convert.ToInt32(objventana.tbCantautos.Text);

                peaje.RegistrarResumenDia(numerodia, cantidadauto);

            }

        }

        private void btnverresumen_Click(object sender, EventArgs e)
        {
            int cantDias = 0;
            int[] vector = new int[31]; 
            vector = peaje.DiasmayoresProm(out cantDias);
            lbagregar.Items.Add($"el promedio del total es:{peaje.PromedioMes} "); ;
            lbagregar.Items.Add($"los dias mayores al promedio son: ");

            for (int i = 0; i < cantDias; i++) 
            {
                lbagregar.Items.Add(vector[i]);
            
            }

            lbagregar.Items.Add($"el tercio con mayor movimiento es tercio nro: {peaje.Terciodelmesmayor()}");
        }
    }
}
