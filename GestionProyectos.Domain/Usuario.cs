using System;

namespace GestionProyectos.Domain
{
    public abstract class Usuario
    {
        public string Id { get; private set; }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public string NumeroIdentificacion { get; private set; }
        public string Correo { get; private set; }
        public string Contraseña { get; private set; }

        protected Usuario(string id, string nombres, string apellidos, string numeroIdentificacion, string correo, string contraseña)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            NumeroIdentificacion = numeroIdentificacion;
            Correo = correo;
            Contraseña = contraseña;
        }

        public abstract string ModificarCorreo(string correo);
        public abstract string ModificarContraseña(string contraseña);
    }
}
