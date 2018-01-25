using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using System.Diagnostics;
using Ionic.Zip;

namespace Update_softwareRM
{
    public partial class Form1 : MetroForm
    {
        Stopwatch sw = new Stopwatch();
        int count = 10;
        public Form1()
        {
            InitializeComponent();
        }
        public void dfj(bool visibilidad)
        {
            Visible = visibilidad;
            status.Text = "Iniciando descarga...";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (CheckInternetConnection())
            {
                dfj(true);
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadFileAsync(new Uri("https://occd-ocoainc.org/update_program/Update.zip"), "Update_OCCD.zip");
                sw.Start();
            }
            else
            {
                MessageBox.Show("No hay conexión a internet", "Error en descarga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Descomprimir Zip
        static public Boolean DescromprimirZip(string ArchivoZip, string RutaGuardar)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(ArchivoZip))
                {

                    zip.ExtractAll(RutaGuardar);
                    zip.Dispose();

                }

                return true;
            }
            catch
            {
                return false;

            }

        }
        // Comprobar conexion
        public static bool CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com.do"))
                    {
                        return true;
                    }

                }
            }
            catch
            {

                return false;
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
            status.Text = "Descargando actualizacion... ";
            status_porcent.Text = e.ProgressPercentage + "%";
            status_speed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            status_speed.Visible = false;
            status.Text = "Descarga Completada!";
            status.Text = "Descomprimiendo...";
            string ruta1 = @"./Update_OCCD.zip";
            string ruta2 = Environment.CurrentDirectory;
            DescromprimirZip(ruta1, ruta2);
            status.Text = "Actualizacion Instalada!";
            status_count.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status_count.Text = $"Iniciando Programa... {count.ToString()}s";
            count--;
            if (count == 0)
            {
                timer1.Stop();
                Application.Exit();
            }
        }
    }
}
