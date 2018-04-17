using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace SubirTablaAzureXmlAlumnos
{
    public partial class Form1 : Form
    {
        CloudStorageAccount cuenta;
        public Form1()
        {
           
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsubirtabla_Click(object sender, EventArgs e)
        {
            String claves =
              CloudConfigurationManager.GetSetting("cuentastorage");
            cuenta = CloudStorageAccount.Parse(claves);
            CloudTableClient cliente = cuenta.CreateCloudTableClient();  
            CloudTable tabla = cliente.GetTableReference("alumnos");
            tabla.CreateIfNotExists();

            Stream stream =
                this.GetType().Assembly.GetManifestResourceStream("SubirTablaAzureXmlAlumnos.alumnos_tables_storage.xml");
            XDocument docxml = XDocument.Load(stream);
            var consulta = from datos in docxml.Descendants("alumno")
                           select new Alumno
                           {
                               IdAlumno = int.Parse(datos.Element("idalumno").Value),
                               Nombre = datos.Element("nombre").Value,
                               Apellidos = datos.Element("apellidos").Value,
                               Curso = datos.Element("curso").Value,
                               Nota = int.Parse(datos.Element("nota").Value)
                           };
            foreach(Alumno alumno in consulta.ToList())
            {
                TableOperation insert = TableOperation.Insert(alumno);
                tabla.Execute(insert);
            }
        }
    }
}
