using System;
using System.Collections.Generic;
using System.Text;
using TA.PageObjects;

namespace TA
{
    public static class Pages
    {
        public static HistoryPage History => new HistoryPage();
        public static MainPage Main => new MainPage();
    }
}
