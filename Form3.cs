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
    public partial class Form3 : Form
    {
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        List<Clientes> clientes = new List<Clientes>();
        List<reporte> reportes = new List<reporte>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //cargar todos los datos a sus listas

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

            if (File.Exists(@"..\..\clientes.txt"))
            {
                FileStream stream = new FileStream(@"..\..\clientes.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Clientes cliente = new Clientes();
                    cliente.Nit = reader.ReadLine();
                    cliente.Nombre = reader.ReadLine();
                    cliente.Direccion = reader.ReadLine();

                    clientes.Add(cliente);
                }
                reader.Close();
            }

            if (File.Exists(@"..\..\alquileres.txt"))
            {
                FileStream stream = new FileStream(@"..\..\alquileres.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);

                while (reader.Peek() > -1)
                {
                    Alquiler alquiler = new Alquiler();
                    alquiler.Nit = reader.ReadLine();
                    alquiler.Placa = reader.ReadLine();
                    alquiler.FechaAlquiler = Convert.ToDateTime(reader.ReadLine());
                    alquiler.FechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                    alquiler.Kilometros = Convert.ToInt32(reader.ReadLine());

                    alquileres.Add(alquiler);

                }
                reader.Close();
            }



        }

        private void buttonRecorrido_Click(object sender, EventArgs e)
        {
            int mayor = alquileres.Max(k => k.Kilometros);

            label1.Text = "El mayor recorrido fue de " + mayor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var alquiler in alquileres)
            {
                Clientes cliente = clientes.Find(c => c.Nit == alquiler.Nit);

                Vehiculos vehiculo = vehiculos.Find(v => v.Placa == alquiler.Placa);

                reporte reporte = new reporte();
                reporte.Nombre = cliente.Nombre;
                reporte.Placa = vehiculo.Placa;
                reporte.Marca = vehiculo.Marca;
                reporte.Modelo = vehiculo.Modelo;
                reporte.Color = vehiculo.Color;
                reporte.FechaDevolucion = alquiler.FechaDevolucion;
                reporte.Total = vehiculo.Precio * alquiler.Kilometros;

                reportes.Add(reporte);

            }

            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
            dataGridViewReporte.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            this.Hide();
            x.ShowDialog();
            this.Close();

        }
    }
}
