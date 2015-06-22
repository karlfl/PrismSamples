using BusinessServiceInterface;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IBusinessService _businessService;

        string _message = "Hello View Model";
        public string Message
        {
            get { return _message; }
            set { SetProperty<string>(ref _message, value); }
        }

        List<string> _Names;
        public List<string> Names
        {
            get { return _Names; }
            set { SetProperty<List<string>>(ref _Names, value); }
        }


        public MainViewModel(IBusinessService businessService)
        {
            _businessService = businessService;
            Names = businessService.GetAllNames();
        }
    }
}
