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

        public DataTable consulta1_todos_ex(string tecnicatura, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("fechaDesde", fechaDesde));
            lista.Add(new Parametro("fechaHasta", fechaHasta));
            lista.Add(new Parametro("tecnicatura", tecnicatura));

            return HelperDAO.ObtenerInstancia().consulta("SP_CONSULTA1_TODOS_EX", lista);
        }

        public DataTable consulta1_todos_tec(string tipoExamen, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("tipoExamen", tipoExamen));
            lista.Add(new Parametro("fechaDesde", fechaDesde));
            lista.Add(new Parametro("fechaHasta", fechaHasta));

            return HelperDAO.ObtenerInstancia().consulta("SP_CONSULTA1_TODOS_TEC", lista);
        }

        public DataTable consulta1_todos(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("fechaDesde", fechaDesde));
            lista.Add(new Parametro("fechaHasta", fechaHasta));

            return HelperDAO.ObtenerInstancia().consulta("SP_CONSULTA1_TODOS", lista);
        }

        public DataTable cargarTecnicaturas()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("SP_CONSULTA_TECNICATURAS");
        }

        public DataTable cargarTiposDeExamenes()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("SP_CONSULTA_TIPOS_EXAMENES");
        }

        public DataTable consulta2(int año)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("año", año));


            return HelperDAO.ObtenerInstancia().consulta("CONSULTA2", lista);
        }

        public DataTable consulta3(int promedio1, int promedio2, DateTime fecha1, DateTime fecha2)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("fecha1", fecha1));
            lista.Add(new Parametro("fecha2", fecha2));
            lista.Add(new Parametro("promedio1", promedio1));
            lista.Add(new Parametro("promedio2", promedio2));

            return HelperDAO.ObtenerInstancia().consulta("CONSULTA3", lista);
        }

        public DataTable consultaPromedio()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("PROMEDIO_GENERAL");
        }

        public DataTable consulta4(string estadoAcademico, string curso)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("estadoAcademico", estadoAcademico));
            lista.Add(new Parametro("curso", curso));


            return HelperDAO.ObtenerInstancia().consulta("Consulta4", lista);
        }

        public DataTable cargarEstadosAcademicos()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("Consulta4_EstadosAc");
        }

        public DataTable cargarCursos()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("Consulta4_Cursos");
        }

        public DataTable consulta5(int IdMateria)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("id_materia", IdMateria));


            return HelperDAO.ObtenerInstancia().consulta("Consulta5", lista);
        }

        public DataTable cargarMaterias(int IdTecnicatura)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("id_tecnicatura", IdTecnicatura));


            return HelperDAO.ObtenerInstancia().consulta("Consulta5_Materias", lista);
        }

        public DataTable consulta6(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("fechaDesde", fechaDesde));
            lista.Add(new Parametro("fechaHasta", fechaHasta));


            return HelperDAO.ObtenerInstancia().consulta("CONSULTA6", lista);
        }

        public DataTable consulta7()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("CONSULTA7");
        }

        public DataTable consulta8(int año)
        {
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("año", año));


            return HelperDAO.ObtenerInstancia().consulta("CONSULTA8", lista);
        }

        public DataTable cargarTodasMaterias()
        {
            return HelperDAO.ObtenerInstancia().consultaSinParametros("Consulta5_Materias_Todas");
        }
    }
}
