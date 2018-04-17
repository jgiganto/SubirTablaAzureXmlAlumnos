using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubirTablaAzureXmlAlumnos
{
    public class Alumno : TableEntity
    {
        //rowkey    extendido
        private int _IdAlumno;
        public int IdAlumno
        {
            get { return this._IdAlumno; }
            set
            {
                this._IdAlumno = value;
                this.RowKey = value.ToString();

            }
        }
        //partition key
        private String _Curso;
        public String Curso
        {
            get
               {
                    return this._Curso;
              }
           set
            {
                this.PartitionKey = value;
                this._Curso = value;
            }

        }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Nota { get; set; }
        
    }
}
