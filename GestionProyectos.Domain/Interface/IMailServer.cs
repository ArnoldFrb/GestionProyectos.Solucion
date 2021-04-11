using System;
using System.Collections.Generic;
using System.Text;

namespace GestionProyectos.Domain.Interface
{
    public interface IMailServer
    {
        void Send(string v, string email);
    }
}
