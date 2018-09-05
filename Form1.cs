using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portSmasher
{
    public partial class Form1 : Form
    {

        private TcpClient tcp;
        private Datos datos;
        private List<string> list;
        private StreamWriter escritor;

        public Form1()
        {
            InitializeComponent();
            list = new List<string>();
            LeerArchivo();
            CargarCampos();
            validarForm();
            validarBtnElimninar();



        }


        public bool validarForm()
        {

            bool bandera = true;
            if (string.IsNullOrEmpty(txtHost.Text))
            {
                bandera = false;

            }
            if (lstPorts.Items.Count == 0)
            {
                bandera = false;
            }


            return bandera;
        }

        public void validarBtnElimninar()
        {


            if (datos.pnPorts.Count == 0)
            {

                btnEliminarPort.Enabled = false;
            }
            else
            {
                btnEliminarPort.Enabled = true;
            }



        }
        private void btnSmash_Click(object sender, EventArgs e)
        {
            //LlenarList();
            EscribirArchivo();
            //LlenarDatos();
            Smash();

        }

        public void LlenarDatos()
        {

            datos.pnHost = txtHost.Text;
            datos.pnPorts = new List<int>();
            for (int i = 0; i < lstPorts.Items.Count; i++)
            {

                datos.pnPorts.Add(Convert.ToInt32(lstPorts.Items[i].ToString()));
            }

        }

        public void CargarCampos()
        {
            txtHost.Text = datos.pnHost;
            lstPorts.DataSource = datos.pnPorts;
        }

        public void Smash()
        {
            LlenarDatos();

            for (int i = 0; i < datos.pnPorts.Count; i++)
            {


                try
                {
                    tcp = new TcpClient();
                    tcp.Connect(datos.pnHost, datos.pnPorts[i]);
                    MessageBox.Show(this, "Smash Correcto Host+Port:" + datos.pnHost + "   " + datos.pnPorts[i], "Validacion de Smash");

                    tcp.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btnAgregarPort_Click(object sender, EventArgs e)
        {
            datos.pnPorts.Add(Convert.ToInt32(txtPort.Text));
            actualizar();
        }


        public void actualizar()
        {


            lstPorts.DataSource = null;
            lstPorts.DataSource = datos.pnPorts;
            validarBtnElimninar();
            if (validarForm())
            {
                btnSmash.Enabled = true;
            }
            else
            {
                btnSmash.Enabled = false;

            }



        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LeerArchivo()
        {
            List<int> lstPortsArchivo = new List<int>();
            StreamReader lector = new StreamReader(Directory.GetCurrentDirectory() + @"\datosKnock.txt");
            string hostArchivo = "";
            string lineaArchivo = "";
            int acum = 0;
            while (lineaArchivo != null)
            {
                lineaArchivo = lector.ReadLine();

                if (lineaArchivo != null)
                {
                    if (acum == 0)
                    {
                        hostArchivo = lineaArchivo;

                    }
                    else
                    {
                        lstPortsArchivo.Add(Convert.ToInt32(lineaArchivo));
                    }
                    acum++;
                }

            }
            lector.Close();

            datos = new Datos(lstPortsArchivo, hostArchivo);
        }

        public void LlenarList()
        {
            list = new List<string>();
            list.Add(txtHost.Text);
            for (int i = 0; i < lstPorts.Items.Count; i++)
            {
                list.Add(lstPorts.Items[i].ToString());
            }
        }

        public void EscribirArchivo()
        {
            LlenarList();
            escritor = new StreamWriter(Directory.GetCurrentDirectory() + @"\datosKnock.txt");
            int i = 0;
            Console.WriteLine(list.Count);
            while (i < list.Count)
            {
                escritor.WriteLine(list[i].ToString());
                i++;
            }
            escritor.Close();
            Console.Read();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LlenarList();
            EscribirArchivo();
        }

        private void btnEliminarPort_Click(object sender, EventArgs e)
        {
            int port;
            if (datos.pnPorts.Count != 0)
            {
                port = Convert.ToInt32(lstPorts.SelectedItem);
                datos.pnPorts.Remove(port);
                actualizar();
            }


        }

        private void txtHost_Leave(object sender, EventArgs e)
        {
            if (validarForm())
            {
                btnSmash.Enabled = true;
            }
            else
            {
                btnSmash.Enabled = false;

            }
        }
    }
}
