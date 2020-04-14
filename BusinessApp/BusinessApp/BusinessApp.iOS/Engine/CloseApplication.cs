using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BusinessApp.Engine;
using BusinessApp.iOS.Engine;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(CloseApplication))]
namespace BusinessApp.iOS.Engine
{
    public class CloseApplication: ICloseApplication
    {
        public void ExitApplication()
        {
            Thread.CurrentThread.Abort();
        }
    }
}