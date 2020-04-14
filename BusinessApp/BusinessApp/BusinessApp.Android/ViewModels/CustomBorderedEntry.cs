using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using BusinessApp.Droid.ViewModels;
using BusinessApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderedEntry), typeof(CustomBorderedEntry))]
namespace BusinessApp.Droid.ViewModels
{
    public class CustomBorderedEntry : EntryRenderer
    {
        public CustomBorderedEntry(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                Control.Bottom = 5;

                int[][] states = new int[][] {
                new int[] { -Android.Resource.Attribute.StateFocused}, // enabled
                new int[] {Android.Resource.Attribute.StateFocused} // disabled
};

                int[] colors = new int[] { Color.Black.ToAndroid(), Color.FromHex("#FF4081").ToAndroid() };

                ColorStateList myList = new ColorStateList(states, colors);

                GradientDrawable gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(5);
                Control.Background = gradientDrawable;
                gradientDrawable.SetStroke(2, myList);
            }
        }
    }
}