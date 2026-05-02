using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Organizador.Views;

public partial class MostrarPersonaWindow : Window
{
    public MostrarPersonaWindow()
    {
        InitializeComponent();
        this.FindControl<Button>("EditarButton").Click += EditarButton_Click;
    }

    private void EditarButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var ciTextBox = this.FindControl<TextBox>("CITextBox");
        var ciSelectableTextBlock = this.FindControl<SelectableTextBlock>("CISelectableTextBlock");

        ciTextBox.IsVisible = true;
        ciSelectableTextBlock.IsVisible = false;
    }
}