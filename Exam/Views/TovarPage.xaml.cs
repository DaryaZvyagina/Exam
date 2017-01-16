using Exam.ViewModel;
using Exam.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Exam.Views
{
    public partial class TovarPage : ContentPage
    {
        private readonly TovarViewModel _viewmodel;

        public TovarPage()
        {
            InitializeComponent();
            _viewmodel = new TovarViewModel(this);
            BindingContext = _viewmodel;
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            await _viewmodel.OpenKartochka();
        }
        
    }
}
