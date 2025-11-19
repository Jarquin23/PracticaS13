using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaS13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        ///Búsqueda Lineal
        private void btnBusqLin_Click(object sender, EventArgs e)
        {
            lbLineal.Items.Clear();
            Random rnd = new Random();
            int[] arr = new int[20];
            lbLineal.Items.Add("Arreglo generado: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 50);
                lbLineal.Items.Add($"{i}");
            }
            if (!int.TryParse(tbNumero.Text, out int buscado))
            {
                MessageBox.Show("Ingrese un número válido: ");
                return;
            }
            bool existe = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == buscado)
                {
                    lbLineal.Items.Add($"Encontrado en la posición {i}");
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                lbLineal.Items.Add("no se encontró.");
            }
        }

        ///Búsqueda Binaria
        private void btnBusqBin_Click(object sender, EventArgs e)
        {
            lbBinaria.Items.Clear();
            Random rnd = new Random();
            List<int> lista = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                lista.Add(rnd.Next(1, 100));
            }
        }
    }
}
