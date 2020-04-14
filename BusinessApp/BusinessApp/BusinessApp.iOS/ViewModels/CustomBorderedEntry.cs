using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessApp.iOS.ViewModels;
using BusinessApp.ViewModels;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderedEntry), typeof(CustomBorderedEntry))]
namespace BusinessApp.iOS.ViewModels
{
    public class CustomBorderedEntry : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromCGColor(Color.Transparent.ToCGColor());
                Control.BorderStyle = UITextBorderStyle.Bezel;
                Control.Layer.CornerRadius = 5;
                //Control.Layer.BorderColor = Color.Black.ToCGColor();
            }
        }
    }

}