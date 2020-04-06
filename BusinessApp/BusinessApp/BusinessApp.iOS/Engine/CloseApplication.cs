using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Foundation;
using UIKit;

namespace BusinessApp.iOS.Engine
{
    public class CloseApplication
    {
        public void ExitApplication()
        {
            Thread.CurrentThread.Abort();
        }
    }
}