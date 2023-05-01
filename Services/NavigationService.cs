using AGLEditor.Stores;
using AGLEditor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGLEditor.Services
{
    // Class that encapsulates the logic of navigating to a new view/ViewModel. 
    // The input to the class is a function that creates the new ViewModel.
    // When Navigate() is called, the function is executed and the result is assigned to the CurrentViewModel property of the NavigationStore.
    public class NavigationService
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<ViewModelBase> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<ViewModelBase> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }
        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
