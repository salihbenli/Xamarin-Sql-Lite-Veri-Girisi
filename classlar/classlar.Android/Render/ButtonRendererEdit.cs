using Android.Graphics;
using classlar.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(Button), typeof(ButtonRendererEdit))]
namespace classlar.Droid
{
    public class ButtonRendererEdit : ButtonRenderer

    {
       //bütün butonları "Güncelleme" seklindeki gibi yapar
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.SetAllCaps(false);
        }

    }
}