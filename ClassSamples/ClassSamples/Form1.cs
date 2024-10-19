namespace ClassSamples
{
    public partial class Form1 : Form
    {
        private Animal animal1 = null;
        private Animal animal2 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnimalInstanceCreate_Click(object sender, EventArgs e)
        {
            animal1 = new Animal("ネコ", "白");
            animal2 = new Animal("犬", "茶");
            txtName1.Text = animal1.Name;
            txtColor1.Text = animal1.Color;
            txtSing1.Text = animal1.sing();
            txtName2.Text = animal2.Name;
            txtColor2.Text = animal2.Color;
            txtSing2.Text = animal2.sing();

        }
    }
}
