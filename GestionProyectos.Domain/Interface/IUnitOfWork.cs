using System;
using System.Collections.Generic;
using System.Text;

namespace GestionProyectos.Domain.Interface
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
