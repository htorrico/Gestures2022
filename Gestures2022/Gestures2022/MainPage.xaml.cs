using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gestures2022
{
    public partial class MainPage : ContentPage
    {
        bool isVisible = false;
        public MainPage()
        {
            InitializeComponent();

            /*
             Paso 1: Declarar una instancia del gesture a utilizar
             Paso 2: Creo un Evento
             Paso 3: Asigno mi evento creado en el paso2
             Paso 4: Asignr el gesto a  un control.
             */

            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += EventoTap;
            image1.GestureRecognizers.Add(tap1);


            var pinch1 = new PinchGestureRecognizer();
            pinch1.PinchUpdated +=EventoUpdated;
            image1.GestureRecognizers.Add(pinch1);


            var pan1 = new PanGestureRecognizer();
            pan1.PanUpdated += EventoPanUpdated;
            image1.GestureRecognizers.Add(pan1);

            var swipe1 = new SwipeGestureRecognizer();
            swipe1.Swiped += EventoSwipe;
            image1.GestureRecognizers.Add(swipe1);




        }

        void EventoTap(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            isVisible = !isVisible;
            if (isVisible)
            {
                imageSender.Source = "tapped.jpg";
            }
            else
            {
                imageSender.Source = "tapped2.jpg";
            }

            
            
        }

        void EventoUpdated(object sender, EventArgs args)
        {
            labelMessage.Text = "OnPinchUpdated";
        }

        void EventoPanUpdated(object sender, EventArgs e)
        {
            labelMessage.Text = "OnPanUpdated";
        }

        void EventoSwipe(object sender, EventArgs e)
        {
            labelMessage.Text = "EventoSwipe";
        }

    }
}
