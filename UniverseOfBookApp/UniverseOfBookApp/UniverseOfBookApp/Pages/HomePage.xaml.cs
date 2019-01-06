﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace UniverseOfBookApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : Xamarin.Forms.TabbedPage
    {
        public HomePage ()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom)
                                                             .SetBarItemColor(Color.Red)
                                                             .SetBarSelectedItemColor(Color.Blue)
                                                             .SetIsLegacyColorModeEnabled(true);
                                                          
            
        }
    }
}