﻿using System.Web;
using System.Web.Mvc;

namespace SlutProjekt2k19 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
