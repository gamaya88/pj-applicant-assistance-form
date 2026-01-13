using MaterialSkin.Controls;

namespace PJ.Inf.ApplicantAssistance.Win
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            this.SetMaterialSkin();
            Design();
            DesignSearchView(true);
        }

        public void Design()
        {
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Red;
            label1.ForeColor = Color.White;
            label3.Font =
            label2.Font =
            label1.Font = new Font("Consolas", 14, FontStyle.Bold);
        }

        private void txtDniBuscado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //ProcesarIngreso(txtDniScan.Text);

                // Limpiar para la siguiente lectura
                txtDniBuscado.Text = "";

                txtDniBuscado.Select();
                txtDniBuscado.Focus();
                txtDniBuscado.SelectAll();
            }
        }

        private void DesignSearchView(bool found)
        {
            label1.Text = found ? "ENCONTRADO" : "NO ENCONTRADO";
            label1.BackColor = found ? Color.Green : Color.Red;
        }
    }
}
