using System;
using System.Collections.Generic;
using System.Text;

namespace GestionProyectos.Domain
{
    public class Proyecto
    {
        private int Id { get; set; }
        private string Nombre  { get; set; }
        private string Resumen { get; set; }

        private Obsercion Obsercion;
        private Evaluacion Evaluacion;

        public Proyecto(int id, string nombre, string resumen)
        {
            Id = id;
            Nombre = nombre;
            Resumen = resumen;
        }

        public string ValidarNombre(string nombre)
        {
            if (nombre.Length == 0)
            {
                return "Registro Fallido, El Dato recibido se encuantra vacio";
            }
            if (nombre.Length > 0 && nombre.Length < 100)
            {
                return "Registro Fallido, El Nombre registrado es muy corto";
            }
            if (nombre.Length >= 100)
            {
                Nombre = nombre;
                return "Registro Exitozo, Se ha registrado el nuevo Nombre";
            }
            throw new NotImplementedException();
        }

        public string ValidarResumen(string resumen)
        {
            if (resumen.Length == 0)
            {
                return "Registro Fallido, El Dato recibido se encuantra vacio";
            }
            if (resumen.Length > 0 && resumen.Length < 300)
            {
                return "Registro Fallido, El Resumen registrado es muy corto";
            }
            if (resumen.Length >= 300)
            {
                Nombre = resumen;
                return "Registro Exitozo, Se ha registrado el nuevo Resumen";
            }
            throw new NotImplementedException();
        }
    }
}
