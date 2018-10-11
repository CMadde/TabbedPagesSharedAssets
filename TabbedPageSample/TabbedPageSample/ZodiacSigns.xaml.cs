﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageSample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ZodiacSigns : TabbedPage 
	{
		public ZodiacSigns ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            // depending on which button - do something different
            // conditional statement if

            ToolbarItem current = (ToolbarItem)sender;
            if( current.Text == "Add")
            {
                Navigation.PushAsync(new NewItemPage());
            }
        }

    }
}