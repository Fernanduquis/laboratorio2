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
    public partial class Form2 : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        List<Clientes> clientes = new List<Clientes>();


        public Form2()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            FileStream stream = new FileStream(@"..\..\alquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var alquiler in alquileres)
            {
                writer.WriteLine(alquiler.Nit);
                writer.WriteLine(alquiler.Placa);
                writer.WriteLine(alquiler.FechaAlquiler);
                writer.WriteLine(alquiler.FechaDevolucion);
                writer.WriteLine(alquiler.Kilometros);

            }


            writer.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
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


            //se cargan las placas al combobox
            comboBoxPlaca.ValueMember = "Placa";
            comboBoxPlaca.DataSource = null;
            comboBoxPlaca.DataSource = vehiculos;

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            Alquiler alquiler = new Alquiler();
            alquiler.Nit = textBoxNit.Text;
            alquiler.Placa = comboBoxPlaca.SelectedValue.ToString();
            alquiler.FechaAlquiler = dateTimePickerEntrega.Value;
            alquiler.FechaDevolucion = dateTimePickerSalida.Value;
            alquiler.Kilometros = Convert.ToInt32(textBoxKilometros.Text);

            alquileres.Add(alquiler);
            Guardar();

            FileStream stream = new FileStream("vehiculos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            textBoxNit.Text = "";
            textBoxKilometros.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 x = new Form3();
            this.Hide();
            x.ShowDialog();
            this.Close();
        }
    }
}
