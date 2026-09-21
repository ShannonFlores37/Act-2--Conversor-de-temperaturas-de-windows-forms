namespace Act_2__Conversor_de_temperaturas_de_windows_forms
{
    public partial class Form1 : Form
    {
        //agregamos un objeto textbox
        private TextBox objTextbox = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Conversion()
        {
            try
            {
                double grados;
                //Si se e scribe en la caja de texto grados centigrados
                if (objTextbox == txtcen)
                {
                    grados = Convert.ToDouble(txtcen.Text);
                    txtfa.Text = ((grados * 9) / 5 + 32).ToString();
                }
                if (objTextbox == txtfa)
                {
                    grados = (Convert.ToDouble(txtfa.Text) - 32.0) * 5.0 / 9.0;
                    txtcen.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (FormatException)
            {
                txtcen.Text = "0.00";
                txtfa.Text = "32.00";
            }

        }

        private void txtcen_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextbox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                //enter
                e.Handled = true;
                Conversion();
            }
        }

        private void txtfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextbox = (TextBox)sender;
            if (e.KeyChar == Convert.ToChar(13))
            {
                //enter
                e.Handled = true;
                Conversion();
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
