using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PJ.Inf.ApplicantAssistance.Win.Model.Concurso;
using PJ.Inf.ApplicantAssistance.Win.Model.View;
using PJ.Inf.ApplicantAssistance.Win.Registrars;
using PJ.Inf.ApplicantAssistance.Win.Utils.Enums;

namespace PJ.Inf.ApplicantAssistance.Win.Service
{
    internal class ParticipanteService
    {
        private IMapper mapper;

        public ParticipanteService()
        {
            mapper = MappingProfile.GetInstance();
        }

        public async Task MarcarAsistencia(Participante participante)
        {
            participante.ParEstadoIngreso = EstadoAsistencia.CON_ASISTENCIA;
            participante.ParFechaIngreso = DateTime.Now;

            using (var context = new HelpDeskDbContext())
            {
                context.Attach(participante);
                context.Entry(participante).State = EntityState.Modified;

                await context.SaveChangesAsync();
            }
        }

        public async Task<Participante?> RetornaPorDocumentoIdentidad(string dni)
        {
            using var context = new HelpDeskDbContext();

            var participante = await context.Participantes.FirstOrDefaultAsync(x => x.ParDocumentoIdentidad == dni);

            return participante;
        }

        public async Task<int> RetornaAsitentes(byte estadoAsistencia)
        {
            using var context = new HelpDeskDbContext();

            var participantes = await context.Participantes.Where(x => x.ParEstadoIngreso == estadoAsistencia).CountAsync();

            return participantes;
        }

        public async Task<List<ParticipanteView?>> Busqueda(string termino)
        {
            using var context = new HelpDeskDbContext();

            var participante = await context.Participantes
                            .Where(x => 
                                x.ParDocumentoIdentidad.Contains(termino) ||
                                x.ParApellidoPaterno.Contains(termino) ||
                                x.ParApellidoMaterno.Contains(termino) ||
                                x.ParNombres1.Contains(termino) ||
                                x.ParNombres2.Contains(termino) ||
                                x.ParNombres3.Contains(termino) ||
                                x.ParPlaza.Contains(termino) ||
                                x.ParDependencia.Contains(termino) ||
                                x.ParFicha.Contains(termino)
                            ).ToListAsync();

            var participantes = mapper.Map<List<ParticipanteView>>(participante);

            return participantes;
        }
    }
}
