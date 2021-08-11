using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MH212532_tallerpractico1_dsp
{
    //Diego Mancía
    public partial class Form1 : Form
    {
        //Primero creamos un array con las letras de las filas de los asientos
        string[] rowLetter = { "A", "B", "C", "D", "E", " F", "G", "H", "I", "J" };
        //Luego creamos el array bidemensional que tendrá los asientos,
        //es un bool porque recordemos que los asientos solo tienen dos
        //estados: libre(false) y ocupado (true)
        bool[,] asientos = new bool[10, 6];

        //Creamos una función que nos permite inicializar el array
        //de los asientos con el estado por defecto que es libre
        public void iniciarAsientos()
        {
            //Ocupamos un doble FOR para recorrer todas las posiciciones
            //y colocarles un valor por defecto, es decir, libre
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    asientos[i,j] = false;
                }
            }
        }

        //Creamos una función para crear los asientos, valga la
        //redundancia, en el DataGridView pues no estan por defecto en
        //la tabla sino que los añadimos durante la ejecución
        public void crearAsientos()
        {
            //Declaramos el nombre del asiento, que tiene la letra(fila)
            //y número(columna)
            string nombreAsiento;

            //Definimos cuantas filas tendra el DataGridView
            dataGridView1.RowCount = 10;
            //Recorremos la tabla
            for (int i = 0; i < 10; i++)
            {
                //Colocamos el nombre de letra a las filas
                dataGridView1.Rows[i].HeaderCell.Value = rowLetter[i];
                for (int j = 0; j < 6; j++)
                {
                    //Creamos el nombre de los asientos, y los asientos
                    nombreAsiento = rowLetter[i] + Convert.ToString(j + 1);
                    dataGridView1.Rows[i].Cells[j].Value = nombreAsiento;
                }
            }
        }

        //Esta función nos sirve para cargar
        //los asientos ocupados y los que estan libres
        public void corroborarAsientos()
        {
            //Ocupamos un doble FOR para recorrer todas las posiciones
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //Recordemos que el array de asientos es un bool, por
                    //lo que nos facilita comprobar cuando esta libre
                    //y cuando esta ocupado
                    if(asientos[i, j])
                    {
                        //Si esta ocupado, le pone el color rojo
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(163, 15, 29);
                    }
                    else
                    {
                        //Si esta libre, le pone el color verde
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(55, 139, 0);
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Llamamos a las funciones para comenzar nuestra ejecución
            iniciarAsientos();
            crearAsientos();
            corroborarAsientos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Descontinuado
        }

        //Se apartan los asientos
        private void btnApartar_Click(object sender, EventArgs e)
        {
            //Extraemos los index del asiento seleccionado
            int index1 = dataGridView1.CurrentCell.RowIndex;
            int index2 = dataGridView1.CurrentCell.ColumnIndex;
            //Recordemos que el array de asientos es un bool, por
            //lo que nos facilita comprobar cuando esta libre
            //y cuando esta ocupado
            if (asientos[index1, index2])
            {
                //Esta ocupado y no se puede volver a ocupar
                MessageBox.Show("Este asiento esta ocupado, selecciona otro.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Esta libre y se puede ocupar
                string cliente = Microsoft.VisualBasic.Interaction.InputBox("A nombre de quién:", "Cliente");
                asientos[index1, index2] = true;
                corroborarAsientos();
            }
            
        }

        //Nos permite cancelar reservaciones
        private void btnCancelarReservacion_Click(object sender, EventArgs e)
        {
            //Extraemos los index del asiento seleccionado
            int index1 = dataGridView1.CurrentCell.RowIndex;
            int index2 = dataGridView1.CurrentCell.ColumnIndex;
            //Recordemos que el array de asientos es un bool, por
            //lo que nos facilita comprobar cuando esta libre
            //y cuando esta ocupado
            if (!(asientos[index1, index2]))
            {
                //Esta libre y no podemos cancelar la reservación
                MessageBox.Show("Este asiento no esta ocupado, selecciona otro.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Esta ocupado y podemos cancelar la reservación
                asientos[index1, index2] = false;
                corroborarAsientos();
            }
        }

        //Salimos de la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
