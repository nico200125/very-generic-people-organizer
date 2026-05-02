using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Organizador.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void AgregarPersona_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new NuevaPersonaWindow();
            // 'ShowDialog' hace que la ventana sea modal (bloquea la principal)
            dialog.ShowDialog(this);
        }
    }
}