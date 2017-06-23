using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms; 
using Xamarin.Forms.Platform.Android;
using Renderer;
using Renderer.Droid;
using Android.Graphics.Drawables;

[assembly:ExportRenderer(typeof(RoundCornersButton), typeof(RoundCornersButtonRenderer))]

namespace Renderer.Droid
{ 
    public class RoundCornersButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                //Subscribe to the events and stuff
            }
            else if (e.OldElement != null)
            {
                //Unsubscribe from events
            }


            if (Control != null)
            {
                GradientDrawable gradientDrawable = new GradientDrawable();
                gradientDrawable.SetShape(ShapeType.Rectangle);
                gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid());
                gradientDrawable.SetStroke(4, Element.BorderColor.ToAndroid());
                gradientDrawable.SetCornerRadius(38.0f);
                Control.SetBackground(gradientDrawable);
            }

        }
    }
}