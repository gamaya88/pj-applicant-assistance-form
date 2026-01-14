using MaterialSkin.Controls;
using PJ.Inf.ApplicantAssistance.Win.Model.Concurso;
using PJ.Inf.ApplicantAssistance.Win.Model.View;
using PJ.Inf.ApplicantAssistance.Win.Service;
using PJ.Inf.ApplicantAssistance.Win.Utils.Enums;

namespace PJ.Inf.ApplicantAssistance.Win
{
    public partial class Form1 : MaterialForm
    {
        private ParticipanteService participanteService;

        public Form1()
        {
            participanteService = new ParticipanteService();

            InitializeComponent();
            this.SetMaterialSkin();
            dgvBusqueda.Configurar();
            Design();
            DesignSearchView(null);
        }

        public void Design()
        {
            lblAsistentes.ForeColor = Color.Green;
            lblNoAsistentes.ForeColor = Color.Red;
            label1.ForeColor = Color.White;
            lblNoAsistentes.Font =
            lblAsistentes.Font =
            label1.Font = new Font("Consolas", 14, FontStyle.Bold);
        }

        private async void txtDniBuscado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcesarIngreso(txtDniBuscado.Text);

                // Limpiar para la siguiente lectura
                txtDniBuscado.Text = "";

                txtDniBuscado.Select();
                txtDniBuscado.Focus();
                txtDniBuscado.SelectAll();
            }
        }

        private async void ProcesarIngreso(string dni)
        {
            toolStripProgressBar1.Visible = true;

            var participante = await participanteService.RetornaPorDocumentoIdentidad(dni);

            DesignSearchView(participante);

            CargaInformacion(participante);

            if (participante != null && participante.ParEstadoIngreso == EstadoAsistencia.SIN_ASISTENCIA)
            {
                await MarcaAsistencia(participante);
            }

            await CargarContadores();
        }

        private async Task MarcaAsistencia(Participante? participante)
        {
            if (participante == null)
            {
                return;
            }

            await participanteService.MarcarAsistencia(participante);
        }

        private async Task CargarContadores()
        {
            var asistentes = await participanteService.RetornaAsitentes(EstadoAsistencia.CON_ASISTENCIA);
            var no_asistentes = await participanteService.RetornaAsitentes(EstadoAsistencia.SIN_ASISTENCIA);

            lblAsistentes.Text = asistentes.ToString();
            lblNoAsistentes.Text = no_asistentes.ToString();

            toolStripProgressBar1.Visible = false;
        }

        private void CargaInformacion(Participante? participante)
        {
            if (participante == null)
            {
                txtDni.Text =
                txtApellidos.Text =
                txtNombres.Text =
                txtDependencia2.Text =
                txtPlaza.Text = string.Empty;
                return;
            }

            txtDni.Text = participante.ParDocumentoIdentidad;
            txtApellidos.Text = $"{participante.ParApellidoPaterno} {participante.ParApellidoMaterno}";
            txtNombres.Text = $"{participante.ParNombres1} {participante.ParNombres2 ?? ""} {participante.ParNombres3 ?? ""}".Trim();
            txtDependencia2.Text = participante.ParDependencia;
            txtPlaza.Text = participante.ParPlaza;
        }

        private void DesignSearchView(Participante? participante)
        {
            bool found = participante != null;

            label1.Text = found
                            ? participante.ParEstadoIngreso == EstadoAsistencia.SIN_ASISTENCIA
                                ? "ASISTENCIA REGISTRADA"
                                : "ASISTENCIA YA EXISTE"
                            : "NO ENCONTRADO";

            label1.BackColor = participante != null && participante.ParEstadoIngreso == EstadoAsistencia.SIN_ASISTENCIA ? Color.Green : Color.Red;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarContadores();
        }

        private async void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtBusqueda.Text.Trim().Length >= 3)
            {
                toolStripProgressBar1.Visible = true;

                var participantes = await participanteService.Busqueda(txtBusqueda.Text);

                dgvBusqueda.DataSource = participantes;

                await CargarContadores();
            }
        }

        private async void dgvBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBusqueda.SelectedRows.Count > 0)
            {
                toolStripProgressBar1.Visible = true;

                var participanteSeleccionado = dgvBusqueda.SelectedRows[0].DataBoundItem as ParticipanteView;

                var participante = await participanteService.RetornaPorDocumentoIdentidad(participanteSeleccionado.ParDocumentoIdentidad);

                await CargarContadores();

                var frm = new frmInformacionPostulante(participante);
                frm.StartPosition = FormStartPosition.CenterParent;
                var result = frm.ShowDialog(this);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                txtDniBuscado.Select();
                txtDniBuscado.Focus();
                txtDniBuscado.SelectAll();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
