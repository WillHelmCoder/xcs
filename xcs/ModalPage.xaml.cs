using System.ComponentModel;
using xcs.Models;

namespace xcs;

public partial class ModalPage : ContentPage
{
    Command Command;
    PersonModel Person;    
    public ModalPage(PersonModel person, Command test)
    {
        Command = test;
        Person = person;
        BindingContext = Person;
        InitializeComponent();
    }    

    void GoToTermButton_Clicked(object sender, EventArgs e)
    {
        Command.Execute(null);
        Application.Current.MainPage.Navigation.PopModalAsync();
    } 
}