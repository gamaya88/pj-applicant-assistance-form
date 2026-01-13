using MaterialSkin.Controls;
using PJ.Inf.ApplicantAssistance.Win.Model.Concurso;

namespace PJ.Inf.ApplicantAssistance.Win
{
    public partial class frmInformacionPostulante : MaterialForm
    {
        public frmInformacionPostulante(Participante participante)
        {
            InitializeComponent();
            CargaDatos(participante);
        }

        private void CargaDatos(Participante participante)
        {
            txtDni.Text = participante.ParDocumentoIdentidad;
            txtApellidos.Text = $"{participante.ParApellidoPaterno} {participante.ParApellidoMaterno}";
            txtNombres.Text = $"{participante.ParNombres1} {participante.ParNombres2 ?? ""} {participante.ParNombres3 ?? ""}".Trim();
            txtDependencia.Text = participante.ParDependencia;
            txtPlaza.Text = participante.ParPlaza;
            txtFicha.Text = participante.ParFicha;
            txtTelefono.Text = $"{participante.ParTelefonoPersonal} - {participante.ParTelefonoTrabajo} - {participante.ParTelefonoDomicilio}".Trim();
            txtEmail.Text = $"{participante.ParEmailPersonal} - {participante.ParEmailTrabajo}".Trim();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
