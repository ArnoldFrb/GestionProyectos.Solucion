using System;
using System.Collections.Generic;
using System.Text;
using GestionProyectos.Domain;
using GestionProyectos.Domain.Interface;

namespace GestionProyectos.Application.Test.Dobles
{
    class ProyectoRepositoryFake : IProyectoRepository
    {
        public void Add(Proyecto proyecto)
        {
            throw new NotImplementedException();
        }

        public void Delete(Proyecto proyecto)
        {
            throw new NotImplementedException();
        }

        public Proyecto Find(int idenProyecto)
        {
            return new Proyecto(
                1211,
                "Aplicativo Web Para la Gestión, seguimiento y evaluación de los anteproyectos del programa de Psicología de la Universidad Popular del Cesar",
                "El aplicativo web a desarrollar tiene como objetivo ser una herramienta que permita gestionar y controlar de manera adecuada el seguimiento de los anteproyectos recibidos en la oficina de psicología en la Universidad Popular del Cesar, ubicada en la ciudad de Valledupar. Para esto se requiere que el sistema pueda",
                "C/ruta/Archivo.docs"
                );
        }

        public List<Proyecto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Proyecto proyecto)
        {
            throw new NotImplementedException();
        }
    }
}
