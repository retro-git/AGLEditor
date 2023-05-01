using AGLEditor.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml;

namespace AGLEditor.ViewModels
{
    public class EditorViewModel : ViewModelBase
    {
        private string _editorText;
        private string _compiledText;

        public ICommand EditorTextChangedCommand { get; }

        public EditorViewModel()
        {
            EditorTextChangedCommand = new EditorTextChangedCommand();
        }

        public string EditorText
        {
            get => _editorText;
            set
            {
                if (_editorText != value)
                {
                    _editorText = value;
                    OnPropertyChanged(nameof(EditorText));
                }
            }
        }
    }
}
