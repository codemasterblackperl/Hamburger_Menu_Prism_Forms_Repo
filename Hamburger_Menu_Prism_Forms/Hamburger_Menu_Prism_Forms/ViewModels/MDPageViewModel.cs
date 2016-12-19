using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hamburger_Menu_Prism_Forms.ViewModels
{
    public class MDPageViewModel : BindableBase
    {
        private INavigationService _navigationService;


        public DelegateCommand<string> NavigationCommand => new DelegateCommand<string>(Navigation);


        public MDPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private void Navigation(string page)
        {
            _navigationService.NavigateAsync(page);
        }
    }
}
