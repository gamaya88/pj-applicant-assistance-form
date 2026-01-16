using System;
using System.Collections.Generic;

namespace PJ.Inf.ApplicantAssistance.Win.Model.Concurso;

public partial class Participante
{
    public Guid ParId { get; set; }

    public string ParDocumentoIdentidad { get; set; } = null!;

    public string ParApellidoPaterno { get; set; } = null!;

    public string ParApellidoMaterno { get; set; } = null!;

    public string ParNombres1 { get; set; } = null!;

    public string? ParNombres2 { get; set; }

    public string? ParNombres3 { get; set; }

    public string ParPlaza { get; set; } = null!;

    public string ParDependencia { get; set; } = null!;

    public string ParFicha { get; set; } = null!;

    public string? ParTelefonoTrabajo { get; set; }

    public string? ParTelefonoDomicilio { get; set; }

    public string? ParTelefonoPersonal { get; set; }

    public string? ParEmailTrabajo { get; set; }

    public string? ParEmailPersonal { get; set; }

    public DateTime? ParFechaIngreso { get; set; }

    public byte? ParEstadoIngreso { get; set; }

    public string? ParAula { get; set; }

    public bool? SecActivo { get; set; }

    public string SecUsuarioCreacionId { get; set; } = null!;

    public string? SecUsuarioActualizacionId { get; set; }

    public string? SecUsuarioEliminacionId { get; set; }

    public DateTime SecFechaCreacion { get; set; }

    public DateTime? SecFechaActualizacion { get; set; }

    public DateTime? SecFechaEliminacion { get; set; }
}
