﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exam.ViewModels
{
    class KartochkaViewModel
    {
        public string Image { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICommand ZakazCommand { get; set; } 


    }
}
