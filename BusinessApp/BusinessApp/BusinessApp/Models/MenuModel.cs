using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BusinessApp.Models
{
    public class MenuModel
    {
        public int Id { get; set; }

        public string MenuTitle { get; set; }

        public string MenuDetail { get; set; }

        public ImageSource icon { get; set; }

        public Page Page { get; set; }
    }
}
