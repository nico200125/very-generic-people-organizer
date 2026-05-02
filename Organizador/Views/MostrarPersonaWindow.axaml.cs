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
        this.FindControl<Button>("EditarButtonN").Click += EditarButton_Click;
        this.FindControl<Button>("EditarButtonBD").Click += EditarButton_Click;
    }

    private void EditarButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        string buttonName = (sender as Button)?.Name ?? string.Empty;

        var ciTextBox = this.FindControl<TextBox>("CITextBox");
        var ciSelectableTextBlock = this.FindControl<SelectableTextBlock>("CISelectableTextBlock");
        var nombreSelectableTextBlock = this.FindControl<SelectableTextBlock>("NameSelectableTextBlock");
        var nombreTextBox = this.FindControl<TextBox>("NameTextBox");
        var birthDateSelectableTextBlock = this.FindControl<SelectableTextBlock>("BirthDateSelectableTextBlock");
        var birthDateDatePicker = this.FindControl<DatePicker>("BirthDateDatePicker");

        switch (buttonName)
        {
            case "EditarButton":
                ciTextBox.IsVisible = true;
                ciSelectableTextBlock.IsVisible = false;
                break;
            case "EditarButtonN":
                nombreTextBox.IsVisible = true;
                nombreSelectableTextBlock.IsVisible = false;
                break;
            case "EditarButtonBD":
                birthDateDatePicker.IsVisible = true;
                birthDateSelectableTextBlock.IsVisible = false;
                break;
        }
    }
}