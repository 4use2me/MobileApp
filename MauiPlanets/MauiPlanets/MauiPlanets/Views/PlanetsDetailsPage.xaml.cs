using MauiPlanets.Models;

namespace MauiPlanets.Views;

public partial class PlanetsDetailsPage : ContentPage
{
    public PlanetsDetailsPage(Planet planet)
    {
        InitializeComponent();
        this.BindingContext = planet;
    }

    // S�ndmusek�sitleja BackButtonile
    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        // Tagasi liikumise loogika
        await Navigation.PopAsync();
    }
}

