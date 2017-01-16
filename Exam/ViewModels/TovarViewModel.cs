using Exam.Models;
using Exam.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exam.ViewModel
{
    public class TovarViewModel
    {
        public ObservableCollection<TovarModel> Tovar { get; set; } = new ObservableCollection<TovarModel>
        {
            new TovarModel
            {
             Name ="MSI Leopard pro",
             Price = "72900 руб",
             Image = "https://www.msi.com/asset/resize/image/global/product/product_5_20160301140958_56d532363da4e.png62405b38c58fe0f07fcef2367d8a9ba1/380.png",

            }
        };


        private Page _page;

        public Command ExitCommand { get; set; }

        public TovarViewModel(Page page)
        {
            _page = page;
            ExitCommand = new Command(Exit);
        }

        public async void Exit()
        {
            await _page.Navigation.PopToRootAsync();
        }

        public async Task OpenKartochka()
        {
            await _page.Navigation.PushAsync(new KartochkaPage());
        }

    }
}

