using MauiPlanets.Models;

namespace MauiPlanets.Views;

public partial class PlanetsDetailsPage : ContentPage
{
    public PlanetsDetailsPage(Planet planet)
    {
        InitializeComponent();
        this.BindingContext = planet;
    }

    // Sündmusekäsitleja BackButtonile
    private void BackButton_Clicked(object sender, EventArgs e)
    {
        // Tagasi liikumise loogika
        Navigation.PopAsync();
    }
}

