using GestionProyectos.Domain;
using GestionProyectos.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionProyectos.Infrastructure.Data
{
    public class ProyectoRepository : IProyectoRepository
    {
        private readonly GestionProyectoContext _context;

        public ProyectoRepository(GestionProyectoContext context)
        {
            _context = context;
        }

        public void Add(Proyecto proyecto)
        {
            _context.Proyecto.Add(proyecto);
        }

        public void Delete(Proyecto proyecto)
        {
            _context.Proyecto.Remove(proyecto);
        }

        public Proyecto Find(int idenProyecto)
        {
            var res = _context.Proyecto.FirstOrDefault(proyecto => proyecto.Id == idenProyecto);
            return res;
        }

        public List<Proyecto> GetAll()
        {
            return _context.Proyecto.ToList();
        }

        public void Update(Proyecto proyecto)
        {
            _context.Proyecto.Update(proyecto);
        }
    }
}
