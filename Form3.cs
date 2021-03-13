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

            labelRecorrido.Text = "El mayor recorrido fue de " + mayor.ToString();
        }

    }
    }
}
