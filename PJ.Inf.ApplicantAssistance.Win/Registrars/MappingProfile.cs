using AutoMapper;
using PJ.Inf.ApplicantAssistance.Win.Model.Concurso;
using PJ.Inf.ApplicantAssistance.Win.Model.View;
using PJ.Inf.ApplicantAssistance.Win.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PJ.Inf.ApplicantAssistance.Win.Registrars
{
    public class MappingProfile : Profile
    {
        private static IMapper _instance;

        public static IMapper GetInstance()
        {
            if (_instance == null)
            {
                // Auto Mapper Configurations
                var mappingConfig = new AutoMapper.MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfile());
                });

                IMapper mapper = mappingConfig.CreateMapper();

                _instance = mapper;
            }
            return _instance;
        }

        private MappingProfile()
        {
            CreateMap<Participante, ParticipanteView>()
                .ForMember(dest => dest.ParFechaIngreso, opt => opt.MapFrom(src => src.ParEstadoIngreso == EstadoAsistencia.SIN_ASISTENCIA ? "" : src.ParFechaIngreso.ToString()))
                .ForMember(dest => dest.ParNombres, opt => opt.MapFrom(src => $"{src.ParApellidoPaterno} {src.ParApellidoMaterno}, {src.ParNombres1} {src.ParNombres2} {src.ParNombres3}"))
                .ReverseMap()
                .ForAllMembersOfType(typeof(ICollection<>), x => x.UseDestinationValue());

        }
    }
}
