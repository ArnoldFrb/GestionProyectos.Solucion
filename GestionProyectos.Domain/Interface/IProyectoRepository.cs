using System;
using System.Collections.Generic;
using System.Text;

namespace GestionProyectos.Domain.Interface
{
    public interface IProyectoRepository
    {
        Proyecto Find(int idenProyecto);
        List<Proyecto> GetAll();
        void Add(Proyecto proyecto);
        void Update(Proyecto proyecto);
        void Delete(Proyecto proyecto);
    }
}
