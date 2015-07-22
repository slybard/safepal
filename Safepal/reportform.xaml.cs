using System;
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
    public partial class reportform : PhoneApplicationPage
    {
        public reportform()
        {
            InitializeComponent();
        }

       
        private void tglSwitch_Checked(object sender, RoutedEventArgs e)
        {
            
            tglSwitch.Content = "Yes";
        }

        private void tglSwitch_Unchecked(object sender, RoutedEventArgs e)
        {
            
            tglSwitch.Content = "No";
        }
    }
}