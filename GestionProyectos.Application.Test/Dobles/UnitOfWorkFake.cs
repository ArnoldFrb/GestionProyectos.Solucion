using GestionProyectos.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionProyectos.Application.Test.Dobles
{
    public class UnitOfWorkFake : IUnitOfWork
    {
        public void Commit()
        {
            Console.WriteLine("Se confirman cambios en DB");
        }
    }
}
