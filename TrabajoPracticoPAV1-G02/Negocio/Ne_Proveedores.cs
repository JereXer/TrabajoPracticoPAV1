using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1_G02.Clases;
using System.Data;

namespace TrabajoPracticoPAV1_G02.Negocio
{
    class Ne_Proveedores
    {
        BD_acceso_a_datos _BD_proveedores = new BD_acceso_a_datos();
        public DataTable RecuperarProveedores()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Proveedores]";
            return _BD_proveedores.EjecutarSQL(sql);
        }
        public DataTable RecuperarProveedores(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Barrio] WHERE nombre = '" + nombre + "'";
            return _BD_proveedores.EjecutarSQL(sql);
        }
    }
}
