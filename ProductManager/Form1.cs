namespace ProductManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Source Control!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ProductManager p = new()
            {
                Name = txtProductName.Text,
            };
            
            MessageBox.Show("Saved to database! (not yet but will be");
        }
    }
}
