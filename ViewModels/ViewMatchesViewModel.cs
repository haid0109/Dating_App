﻿using _2019_9_3_Dating_app_XAML_.Models.DBA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_9_3_Dating_app_XAML_.ViewModels
{
    class ViewMatchesViewModel
    {
        public ViewMatchesRepo viewMatchesRepo { get; set; }
        public ViewMatchesViewModel() { viewMatchesRepo = new ViewMatchesRepo(); }
    }
}
