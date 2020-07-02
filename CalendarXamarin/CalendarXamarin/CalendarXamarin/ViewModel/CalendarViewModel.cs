using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin
{
    public class CalendarViewModel
    {
        public SelectionRange SelectedRange { get; set; }
        public CalendarViewModel()
        {
            SelectedRange = new SelectionRange();
            SelectedRange.StartDate = new DateTime(2019, 09, 16);
            SelectedRange.EndDate = new DateTime(2019, 09, 20);

        }
    }
}

