﻿using System.Web;
using System.Web.Mvc;

namespace MVCs00173510.Xmas20182019
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
