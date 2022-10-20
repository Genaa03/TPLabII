using LabParte3.Datos.Interfaces;
using LabParte3.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabParte3.Datos.Implementaciones
{
    internal class Gestor : IGestor
    {
        public DataTable consulta1(string tipoExamen,string tecnicatura,DateTime fechaDesde,DateTime fechaHasta)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("tipoExamen", tipoExamen));
            lista.Add(new Parametro("fechaDesde", fechaDesde));
            lista.Add(new Parametro("fechaHasta", fechaHasta));
            lista.Add(new Parametro("tecnicatura", tecnicatura));

            return HelperDAO.ObtenerInstancia().consulta("SP_CONSULTA1", lista);
        }

        public DataTable cargarTecnicaturas()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("SP_CONSULTA_TECNICATURAS");
        }

        public DataTable cargarTiposDeExamenes()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("SP_CONSULTA_TIPOS_EXAMENES");
        }
    }
}
