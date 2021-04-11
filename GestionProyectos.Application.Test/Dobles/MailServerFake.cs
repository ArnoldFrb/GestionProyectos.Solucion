using System;
using System.Collections.Generic;
using System.Text;
using GestionProyectos.Domain.Interface;

namespace GestionProyectos.Application.Test.Dobles
{
    class MailServerFake : IMailServer
    {
        public void Send(string v, string email)
        {
            Console.WriteLine("Se enviar el email");
        }
    }
}
