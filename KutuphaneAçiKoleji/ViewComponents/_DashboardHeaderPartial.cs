﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KutuphaneAçiKoleji.ViewComponents
{
    public class _DashboardHeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
