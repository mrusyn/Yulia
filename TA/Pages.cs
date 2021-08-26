using System;
using System.Collections.Generic;
using System.Text;
using TA.PageObjects;

namespace TA.Pages
{
    public static class Pages
    {
        public static SearchResultPage SearchResult => new SearchResultPage();
        public static StartPage Start => new StartPage();
    }
}
