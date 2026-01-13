namespace PJ.Inf.ApplicantAssistance.Win.Model.View
{
    internal class ParticipanteView
    {
        public Guid ParId { get; set; }

        public string ParDocumentoIdentidad { get; set; } = null!;

        public string ParNombres { get; set; }

        public string ParFechaIngreso { get; set; }

        public string ParPlaza { get; set; } = null!;

        public string ParDependencia { get; set; } = null!;

        public string ParFicha { get; set; } = null!;
    }
}
