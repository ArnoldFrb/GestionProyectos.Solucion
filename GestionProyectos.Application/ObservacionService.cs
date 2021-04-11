using System;
using GestionProyectos.Domain;
using GestionProyectos.Domain.Interface;

namespace GestionProyectos.Application
{
    public class ObservacionService
    {
        private IProyectoRepository _proyectoRepository;
        private IMailServer _mailServer;
        private IUnitOfWork _unitOfWork;

        public ObservacionService(IProyectoRepository proyectoRepository, IMailServer mailServer, IUnitOfWork unitOfWork)
        {
            _proyectoRepository = proyectoRepository;
            _mailServer = mailServer;
            _unitOfWork = unitOfWork;
        }

        public string RealizarObservacion(int identProyecto, string nombreObsercacion, string ComentarioObservacion)
        {
            var proyecto = _proyectoRepository.Find(1232);
            _mailServer.Send("Se ha agragado una nueva Oobservacion", "hola@hl.com");
            _unitOfWork.Commit();
            var res = proyecto.Observar(new Obsercion(nombreObsercacion, ComentarioObservacion));
            
            return res;
        }
    }
}
