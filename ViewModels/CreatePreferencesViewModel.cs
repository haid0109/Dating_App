using _2019_9_3_Dating_app_XAML_.Models.DBA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_9_3_Dating_app_XAML_.ViewModels
{
    class CreatePreferencesViewModel
    {
        public CreateRepo createRepo { get; set; }
        public CreatePreferencesViewModel() { createRepo = new CreateRepo(); }
    }
}