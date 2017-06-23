
using Renderer;
using Renderer.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

 [assembly: ExportRenderer(typeof(RoundCornersButton), typeof(RoundCornersButtonRenderer))]

namespace Renderer.iOS
{
    
    public class RoundCornersButtonRenderer: ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
        }
    }
}
