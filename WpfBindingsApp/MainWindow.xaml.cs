using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBindingsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee employee;
        public MainWindow()
        {
            InitializeComponent();

            //Binding binding = new Binding();
            //binding.ElementName = "txtBox";
            //binding.Path = new PropertyPath("Text");
            //binding.Mode = BindingMode.TwoWay;
            //txtBlock.SetBinding(TextBlock.TextProperty, binding);

            employee = new Employee() { Name = "Bobby", Age = 32 };
            
            this.DataContext = employee;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //txtBlock.Text = "Hello world";
            employee.Name = "Tommy";
            employee.Age = 33;

            MessageBox.Show(employee.ToString());
        }
    }
}