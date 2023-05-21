using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo092023A
{
    public partial class MainPage : ContentPage
    {
     
        public MainPage()
        {
            InitializeComponent();

            /*
           Paso 1: Declarar una instancia del gesture a utilizar
           Paso 2: Creo un Evento
           Paso 3: Asigno mi evento creado en el paso2
           Paso 4: Asignarr el gesto a  un control.
           */
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Tap());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Pinch());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Swipe());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PinchDemo());
            };
        } 

    }
}
