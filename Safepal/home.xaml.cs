﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Safepal
{
    public partial class home : PhoneApplicationPage
    {
        public home()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/home.xaml?Refresh=true&random={0}", Guid.NewGuid()), UriKind.Relative));
        }
    }
}