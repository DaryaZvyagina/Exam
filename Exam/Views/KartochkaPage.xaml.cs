using Exam.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Exam.Views
{
    public partial class KartochkaPage : ContentPage
    {
        public KartochkaPage()
        {
            InitializeComponent();
            this.BindingContext = new KartochkaViewModel();
        }
    }
}
