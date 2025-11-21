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
        
        //Búsqueda Lineal
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

        //Búsqueda Binaria
        private void btnBusqBin_Click(object sender, EventArgs e)
        {
            lbBinaria.Items.Clear();
            Random rnd = new Random();
            List<int> lista = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                lista.Add(rnd.Next(1, 100));
            }
            lista.Sort();
            lbBinaria.Items.Add("Lista ordenada: ");
            foreach (int n in lista) lbBinaria.Items.Add(n);
            if (!int.TryParse(tbNum.Text, out int buscado))
            {
                MessageBox.Show("Ingrese un número válido.");
                return;
            }
            int inicio = 0, fin = lista.Count - 1;
            while (inicio <= fin)
            {
                int mitad = (inicio + fin) / 2;
                lbBinaria.Items.Add($"Mitad: {mitad} -> {lista[mitad]}");
                if (lista[mitad] == buscado)
                {
                    lbBinaria.Items.Add($"Encontrado en índice {mitad}");
                    return;
                }
                else if (buscado < lista[mitad])
                {
                    lbBinaria.Items.Add("-> Buscar izquierda");
                    fin = mitad - 1;
                }
                else
                {
                    lbBinaria.Items.Add("-> Buscar derecha");
                    inicio = mitad + 1;
                }
            }
            lbBinaria.Items.Add("No encontrado.");
        }

        //Búsqueda de palabra
        private void btnBuscarP_Click(object sender, EventArgs e)
        {
            lbPalabras.Items.Clear();
            string texto = tbParrafo.Text.ToLower();
            string palabra = tbPalabra.Text.ToLower();
            if (palabra.Trim() == "")
            {
                MessageBox.Show("Ingrese una palabra.");
                return;
            }
            int contador = 0;
            for (int i = 0; i <= texto.Length - palabra.Length; i++)
            {
                bool coincide = true;
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (texto[i + j] != palabra[j])
                    {
                        coincide = false;
                        break;
                    }
                }
                if (coincide)
                    contador++;
            }
            lbPalabras.Items.Add($"La palabra aparece {contador} veces.");
        }

        //Búsqueda en objetos
        class Estudiante
        {
            public int Id { get; set;}
            public string Nombre { get; set;}
        }
        private void tbObjeto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusqObj_Click(object sender, EventArgs e)
        {
            lbObjetos.Items.Clear();
            List<Estudiante> ests = new List<Estudiante>
            {
                new Estudiante{Id=1, Nombre = "Ana"},
                new Estudiante{Id = 2, Nombre = "Bruno" },
                new Estudiante{Id=3, Nombre = "Carlos"},
                new Estudiante{Id=4, Nombre="Diana"},
                new Estudiante{Id=5, Nombre="Elena"},
                new Estudiante{Id=6, Nombre="Fernanda"},
                new Estudiante{Id=7, Nombre="Gabriel"},
                new Estudiante{Id=8, Nombre="Hector"},
                new Estudiante{Id=9, Nombre="Iris"},
                new Estudiante{Id=10,Nombre="Jorge"}
            };
            string entrada = tbObjeto.Text;
            //Búsqueda lineal
            if (int.TryParse(entrada, out int id))
            {
                foreach (var est in ests)
                {
                    if (est.Id==id)
                    {
                        lbObjetos.Items.Add($"Encontradp: {est.Nombre}");
                        return;
                    }
                }
                lbObjetos.Items.Add($"ID no encontrado.");
            }
            else
            //Búsqueda binaria por nombre
            {
                ests.Sort((a, b) => a.Nombre.CompareTo(b.Nombre));
                int inicio = 0, fin = ests.Count - 1;
                while (inicio <= fin)
                {
                    int mitad = (inicio + fin) / 2;
                    int cmp = entrada.CompareTo(ests[mitad].Nombre);
                    if (cmp == 0)
                    {
                        lbObjetos.Items.Add($"ID encontrado = {ests[mitad].Id}");
                        return;
                    }
                    else if (cmp < 0)
                        fin = mitad - 1;
                    else
                        inicio = mitad + 1;
                }
                lbObjetos.Items.Add("Nombre no encontrado.");
            }
        }

        //Maximo y minimo
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            lbNumeros.Items.Clear();
            List<int> lista = new List<int>() { 12, 7, 25, 3, 19, 42, 9 };
            int max = lista[0];
            int min = lista[0];
            int iter = 0;
            foreach (int n in lista)
            {
                iter++;
                if (n > max) max = n;
                if (n < min) min = n;
            }
            lbNumeros.Items.Add($"Máximo: {max}");
            lbNumeros.Items.Add($"Mínimo: {min}");
            lbNumeros.Items.Add($"Iteraciones: {iter}");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            lbMatriz.Items.Clear();
            Random rnd = new Random();
            int[,] mat = new int[10, 10];
            lbMatriz.Items.Add("Matriz gennerada");
            for (int i = 0; i < 10; i++)
            {
                string fila = "";
                for (int j = 0; j < 10; j++)
                {
                    mat[i, j] = rnd.Next(1, 99);
                    fila += mat[i, j].ToString("00") + " ";
                }
                lbMatriz.Items.Add(fila);
            }
            if (!int.TryParse(lbMatriz.Text, out int buscado))
            {
                MessageBox.Show("Ingresa el número a buscar.");
                return;
            }
            bool encontrado = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (mat[i, j] == buscado)
                    {
                        lbMatriz.Items.Add($"Encontrado en fila {i}, columna {j}");
                        encontrado = true;
                    }
                }
            }
            if (!encontrado)
                lbMatriz.Items.Add("No encontrado.");
        }
    }


}
