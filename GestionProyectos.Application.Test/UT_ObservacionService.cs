using NUnit.Framework;
using GestionProyectos.Application;
using GestionProyectos.Application.Test.Dobles;

namespace GestionProyectos.Application.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var service = new ObservacionService(
                new ProyectoRepositoryFake(),
                new MailServerFake(),
                new UnitOfWorkFake());
            //Act
            var response = service.RealizarObservacion(
                1231,
                "Aplicativo Web Para la Gestión, seguimiento y evaluación de los anteproyectos del programa de Psicología de la Universidad Popular del Cesar",
                "El aplicativo web a desarrollar tiene como objetivo ser una herramienta que permita gestionar y controlar de manera adecuada el seguimiento de los anteproyectos recibidos en la oficina de psicología en la Universidad Popular del Cesar, ubicada en la ciudad de Valledupar. Para esto se requiere que el sistema pueda"
                );
            //Assert
            Assert.AreEqual("Nueva Observacon", response);
        }
    }
}