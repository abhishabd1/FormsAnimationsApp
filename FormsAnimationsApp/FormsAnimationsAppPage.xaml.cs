using Xamarin.Forms;

namespace FormsAnimationsApp
{
    public partial class FormsAnimationsAppPage : ContentPage
    {
        public FormsAnimationsAppPage()
        {
            InitializeComponent();
            lblGret.IsVisible = true;

            //Translate effect
            lblGret.TranslateTo(100, 0, 1000, Easing.BounceOut);

            //Scale
            xamImage.ScaleTo(1.5, 2000, Easing.SpringIn);

            //Rotate
            lblForms.RotateTo(360,1000);

            //Fade
            lblFade.FadeTo(0.2, 2000, Easing.SpringOut);



        }




    }
}
