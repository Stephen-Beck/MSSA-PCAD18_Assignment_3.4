namespace Assignment_3._4
{
    public partial class Form1 : Form
    {
        public static List<Coffee> coffees = Coffee.PopulateCoffees();
        public Form1()
        {
            InitializeComponent();

            coffeeBindingSource.DataSource = coffees;
        }
    }
}
