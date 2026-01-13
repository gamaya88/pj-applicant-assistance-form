using MaterialSkin;
using MaterialSkin.Controls;

namespace PJ.Inf.ApplicantAssistance.Win
{
    public static class UtilService
    {
        public static void SetMaterialSkin(this MaterialForm materialForm)
        {
            MaterialSkinManager materialSkinManager;
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;

            // Set this to false to disable backcolor enforcing on non-materialSkin components
            // This HAS to be set before the AddFormToManage()
            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            // MaterialSkinManager properties
            materialSkinManager.AddFormToManage(materialForm);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red300, Accent.Red700, TextShade.WHITE);
        }

        public static void Configurar(this DataGridView dataGridView)
        {
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToAddRows = false;
            //dataGridView.AllowDrop = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
