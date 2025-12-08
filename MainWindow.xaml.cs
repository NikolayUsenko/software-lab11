using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace software_lab11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding bind = new Binding();
            bind.ElementName = "Mark";
            bind.Path = new PropertyPath("IsChecked");
            bind.Mode = BindingMode.Default;
            Target.SetBinding(TextBox.IsReadOnlyProperty, bind);
        }
    }
}