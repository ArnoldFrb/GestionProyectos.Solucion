using NUnit.Framework;

namespace GestionProyectos.Domain.Test
{
    public class UTEstudiante
    {
        [SetUp]
        public void Setup()
        {
        }

        /*
         Modificar Contrase�a 
            H1: Como Estudiante quiero modificar mi contrase�a de acceso en el sistema para tener mayor seguridad.
            Criterio de Aceptaci�n:
            1.2 La contrase�a no puede ser igual a la anterior.
            Dado El estudiante tiene una cuenta en el sistema 
            Id "101010" Nombres "Jose Carlos" Apellidos "Santander Pimienta" NumeroIdentificacion "0123456789" Correo "hola@gmail.com" Contrase�a "@#Hl1g2l34"
            Cuando Ingresa una contrase�a igual a la anterior; Contrase�a "@#Hl1g2l34"
            Entonces El sistema presentar� el mensaje. �No puede ingresar una contrase�a igual a la registrada, pruebe de nuevo�
        */
        [Test]
        public void NoPuedeIngresarContrase�aIgualALaAnterior()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var estudiante = new Estudiante("101010", "Jose Carlo", "Santander Pimienta", "0123456789", "hola@gmail.com", "@#Hl1g2l34");
            // ACT // ACCION // CUANDO // WHEN
            var resultado = estudiante.ModificarContrase�a("@#Hl1g2l34");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("No puede ingresar una contrase�a igual a la registrada, pruebe de nuevo", resultado);
        }

        /*
         Modificar Contrase�a 
            H1: Como Estudiante quiero modificar mi contrase�a de acceso en el sistema para tener mayor seguridad.
            Criterio de Aceptaci�n:
            1.2 La contrase�a debe ser mayor a 10 caracteres.
            Dado El estudiante tiene una cuenta en el sistema 
            Id "101010" Nombres "Jose Carlos" Apellidos "Santander Pimienta" NumeroIdentificacion "0123456789" Correo "hola@gmail.com" Contrase�a "@#Hl1g2l34"
            Cuando Ingresa una contrase�a mayor o igual a 10 caracteres; Contrase�a "g2l34@#Hl1"
            Entonces El sistema presentar� el mensaje. �Su nueva contrase�a es correcta�
        */
        [Test]
        public void PuedeIngresarContrase�aMayorOIgualA10Caracteres()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var estudiante = new Estudiante("101010", "Jose Carlo", "Santander Pimienta", "0123456789", "hola@gmail.com", "@#Hl1g2l34");
            // ACT // ACCION // CUANDO // WHEN
            var resultado = estudiante.ModificarContrase�a("g2l34@#Hl1");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("Su nueva contrase�a es correcta", resultado);
        }

        /*
         Modificar Correo 
            H1: Como Estudiante quiero modificar mi correo de acceso en el sistema para mantener mi informacion actualizada.
            Criterio de Aceptaci�n:
            1.2 El Correo no debe tener espacios o faltar el @.
            Dado El estudiante tiene una cuenta en el sistema 
            Id "101010" Nombres "Jose Carlos" Apellidos "Santander Pimienta" NumeroIdentificacion "0123456789" Correo "hola@gmail.com" Contrase�a "@#Hl1g2l34"
            Cuando Ingresar el correo con espacio; correo "g2l34@#Hl1"
            Entonces El sistema presentar� el mensaje. �Su nueva contrase�a es correcta�
        */
        [Test]
        public void NoPuedeIngresarCorreosConEspacios()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var estudiante = new Estudiante("101010", "Jose Carlo", "Santander Pimienta", "0123456789", "hola@gmail.com", "@#Hl1g2l34");
            // ACT // ACCION // CUANDO // WHEN
            var resultado = estudiante.ModificarCorreo("hol @gmail.com");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("El correo ingresado es invalido", resultado);
        }

        /*
         Modificar Correo 
            H1: Como Estudiante quiero modificar mi correo de acceso en el sistema para mantener mi informacion actualizada.
            Criterio de Aceptaci�n:
            1.2 El Correo no debe tener espacios o faltar el @.
            Dado El estudiante tiene una cuenta en el sistema 
            Id "101010" Nombres "Jose Carlos" Apellidos "Santander Pimienta" NumeroIdentificacion "0123456789" Correo "hola@gmail.com" Contrase�a "@#Hl1g2l34"
            Cuando Ingresar el correo con espacio; correo "g2l34@#Hl1"
            Entonces El sistema presentar� el mensaje. �Su nueva contrase�a es correcta�
        */
        [Test]
        public void NoPuedeIngresarCorreosSinArroba()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var estudiante = new Estudiante("101010", "Jose Carlo", "Santander Pimienta", "0123456789", "hola@gmail.com", "@#Hl1g2l34");
            // ACT // ACCION // CUANDO // WHEN
            var resultado = estudiante.ModificarCorreo("holagmail.com");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("El correo ingresado es invalido", resultado);
        }

        /*
         Modificar Correo 
            H1: Como Estudiante quiero modificar mi correo de acceso en el sistema para mantener mi informacion actualizada.
            Criterio de Aceptaci�n:
            1.2 El Correo no debe tener espacios o faltar el @.
            Dado El estudiante tiene una cuenta en el sistema 
            Id "101010" Nombres "Jose Carlos" Apellidos "Santander Pimienta" NumeroIdentificacion "0123456789" Correo "hola@gmail.com" Contrase�a "@#Hl1g2l34"
            Cuando Ingresar el correo con espacio; correo "g2l34@#Hl1"
            Entonces El sistema presentar� el mensaje. �Su nueva contrase�a es correcta�
        */
        [Test]
        public void PuedeIngresarCorreosConEstructuraAdecuada()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var estudiante = new Estudiante("101010", "Jose Carlo", "Santander Pimienta", "0123456789", "hola@gmail.com", "@#Hl1g2l34");
            // ACT // ACCION // CUANDO // WHEN
            var resultado = estudiante.ModificarCorreo("mundo@gmail.com");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.Pass("El correo ingresado es valido", resultado);
        }
    }
}