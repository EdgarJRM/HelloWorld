namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Hello World";
        }

        private void label1_Click(object sender, EventArgs e){
            Close();
        }
    }
}
