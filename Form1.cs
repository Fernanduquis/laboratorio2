using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorio2
{
    public partial class Form1 : Form
    {
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"..\..\vehiculos.txt"))
            {
                FileStream stream = new FileStream(@"..\..\vehiculos.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Vehiculos vehiculo = new Vehiculos();
                    vehiculo.Placa = reader.ReadLine();
                    vehiculo.Marca = reader.ReadLine();
                    vehiculo.Modelo = Convert.ToInt32(reader.ReadLine());
                    vehiculo.Color = reader.ReadLine();
                    vehiculo.Precio = Convert.ToDouble(reader.ReadLine());

                    vehiculos.Add(vehiculo);
                }
                reader.Close();

            }
        }

        private void Guardar()
        {
            FileStream stream = new FileStream(@"..\..\vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var vehiculo in vehiculos)
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Color);
                writer.WriteLine(vehiculo.Precio);
            }
           
            writer.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool existe = vehiculos.Exists(i => i.Placa == textBoxPlaca.Text);

            if (existe)
            {

                MessageBox.Show("PLACA YA EXCISTENTE", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              
                Vehiculos vehiculo = new Vehiculos();

                vehiculo.Placa = textBoxPlaca.Text;
                vehiculo.Marca = comboBoxMarca.SelectedItem.ToString();
                vehiculo.Modelo = Convert.ToInt32(numericUpDownModelo.Value);
                vehiculo.Color = comboBoxColor.SelectedItem.ToString();
                vehiculo.Precio = Convert.ToDouble(textBoxPrecio.Text);
                vehiculos.Add(vehiculo);

                
                Guardar();

            }

            FileStream stream = new FileStream("vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var v in vehiculos)
            {
                writer.WriteLine(v.Placa);
                writer.WriteLine(v.Marca);
                writer.WriteLine(v.Modelo);
                writer.WriteLine(v.Color);
                writer.WriteLine(v.Precio);
            }
            writer.Close();
            textBoxPlaca.Text = "";
            textBoxPrecio.Text = "";

        }

        private void buttonAlquiler_Click(object sender, EventArgs e)
        {

            Form2 x = new Form2();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}
