namespace GestionProyectos.Domain
{
    public class AsesorTematico : Usuario
    {
        public AsesorTematico(string id, string nombres, string apellidos, string numeroIdentificacion, string correo, string contraseña) : base(id, nombres, apellidos, numeroIdentificacion, correo, contraseña)
        {
        }

        public override string ModificarContraseña(string contraseña)
        {
            throw new System.NotImplementedException();
        }

        public override string ModificarCorreo(string correo)
        {
            throw new System.NotImplementedException();
        }
    }
}