using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doParcialExamen
{
    public partial class ListViewxD : Form
    {
        public ListViewxD()
        {
            InitializeComponent();
        }
        int numero;
        int[,] matriz = new int[3, 3];
        int i = 0, j = 0;
        private void ListViewxD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox1.Text);
            if (j == 3)
            {
                j = 0;
                i++;
            }
            if (i <= 2)
            {
                matriz[i, j] = numero;

            }
            j++;

            for (int i = 0; i <= 2; i++)
            {
                ListViewItem tabla = new ListViewItem(i.ToString());
                tabla.SubItems.Add(matriz[i, 0].ToString());
                tabla.SubItems.Add(matriz[i, 1].ToString());
                tabla.SubItems.Add(matriz[i, 2].ToString());
                listView1.Items.Add(tabla);
                textBox1.Focus();
            }
        }
    }
}
