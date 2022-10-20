using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabParte3.Datos.Interfaces
{
    internal interface IGestor
    {
        DataTable consulta1(string tipoExamen, string tecnicatura, DateTime fechaDesde, DateTime fechaHasta);

        DataTable cargarTecnicaturas();

        DataTable cargarTiposDeExamenes();
    }
}
