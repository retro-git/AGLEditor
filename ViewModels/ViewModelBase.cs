using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGLEditor.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        // WPF will automatically subscribe to this event for each property that binds to this class.
        // We simply need to raise this event whenever a relevant property changes.
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void Dispose()
        {

        }
    }
}
