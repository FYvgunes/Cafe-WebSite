﻿using System.Web;
using System.Web.Mvc;

namespace Cafe_Web_Site_Themlate
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
