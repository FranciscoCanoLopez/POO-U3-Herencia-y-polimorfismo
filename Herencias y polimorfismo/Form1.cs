using ClassLibrary1;
namespace Herencias_y_polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Seller seller1 = new Seller();
            seller1.Surname = txtSurname.Text;
            seller1.Name = txtNames.Text;
            seller1.Type = cboType.Text;
            seller1.TypeOfContract = cboContract.Text;

            seller1.CalculateSallary(750);

            dgvSellers.Rows.Insert(0, seller1.Type, seller1.Surname, seller1.Name, seller1.Sallary);
        }

    }
}
