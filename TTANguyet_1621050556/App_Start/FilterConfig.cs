﻿using System.Web;
using System.Web.Mvc;

namespace TTANguyet_1621050556
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
