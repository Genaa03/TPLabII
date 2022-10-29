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
        // CONSULTA N°1
        DataTable consulta1(string tipoExamen, string tecnicatura, DateTime fechaDesde, DateTime fechaHasta);

        DataTable consulta1_todos_ex(string tecnicatura, DateTime fechaDesde, DateTime fechaHasta);

        DataTable consulta1_todos_tec(string tipoExamen, DateTime fechaDesde, DateTime fechaHasta);

        DataTable consulta1_todos(DateTime fechaDesde, DateTime fechaHasta);

        DataTable cargarTecnicaturas();

        DataTable cargarTiposDeExamenes();

        // CONSULTA N°2

        DataTable consulta2(int año);

        // CONSULTA N°3

        DataTable consulta3(int promedio1, int promedio2, DateTime fecha1, DateTime fecha2);

        // CONSULTA N°4

        DataTable consulta4(string estadoAcademico, string curso);

        DataTable cargarEstadosAcademicos();

        DataTable cargarCursos();

        // CONSULTA N°5

        DataTable consulta5(int IdMateria);

        DataTable cargarMaterias(int IdTecnicatura);

        DataTable cargarTodasMaterias();

        // CONSULTA N°6

        DataTable consulta6(DateTime fechaDesde, DateTime fechaHasta);

        // CONSULTA N°7

        DataTable consulta7();

        // CONSULTA N°8

        DataTable consulta8(int año);

        DataTable consultaPromedio();
    }
}
