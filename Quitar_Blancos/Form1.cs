using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Quitar_Blancos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtOrigen.Text = @"E:\ATENCIONES\SOMOS BELCORP\002_SOPORTEF-2 Duplicidad Data - Reporte Excel - Gestiona Postulante - MX\SCRIPTS_PRODUCCION";
            txtDestino.Text = @"E:\ATENCIONES\SOMOS BELCORP\002_SOPORTEF-2 Duplicidad Data - Reporte Excel - Gestiona Postulante - MX\SCRIPTS_LIMPIOS";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                string archivo = "";
                string script = "";
                archivo = txtOrigen.Text;
                string destino = txtDestino.Text;
                DirectoryInfo carpeta = new DirectoryInfo(archivo);
                FileInfo[] archivos = carpeta.GetFiles();
                destino = "SCRIPTS_LIMPIOS";
  
                string archivoNuevo = "";
                foreach (FileInfo ar in archivos)
                {
                    script = limpiarScript(ar.FullName);
                    if (script != "")
                    {
                        archivoNuevo = Path.ChangeExtension(ar.FullName, ".sql");
                        using (StreamWriter sw = new StreamWriter(archivoNuevo, true))
                        {
                            sw.Write(script);
                        }
                        rpta += ar.FullName + "\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            txtResultado.Text = rpta;
        }


        public string limpiarScript(string rutaArchivo)
        {
            string rpta = "";
            string linea = "";
            string rpta2 = "";
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    rpta = sr.ReadToEnd();
                }
                int inicio = rpta.IndexOf("CREATE") + 6;
                rpta = "ALTER" + rpta.Substring(inicio , rpta.Length - inicio);
                rpta = rpta.Replace("\"", "");

                byte[] buffer = Encoding.UTF8.GetBytes(rpta);
                StringBuilder sb = new StringBuilder();
                
                using(MemoryStream ms = new MemoryStream(buffer))
                using (StreamReader sr = new StreamReader(ms))
                {
                    while (!sr.EndOfStream)
                    {
                        linea = sr.ReadLine();
                        if (linea != "") sb.AppendLine(linea);
                    }
                }

                //int pos = rpta.LastIndexOf("END");
                //rpta   = rpta.Insert(pos, "\r\n");
                //rpta = rpta.Replace("END", "\r\nEND");
                rpta2 = sb.ToString();
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rpta2;
        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtOrigen.Text = fbd.SelectedPath;
                }

            }
            
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDestino.Text = fbd.SelectedPath;
                }

            }
        }
    }
}
