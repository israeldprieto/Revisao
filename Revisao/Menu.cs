namespace Revisao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Divisao dv = new Divisao();
            dv.ShowDialog();
        }
    }
}