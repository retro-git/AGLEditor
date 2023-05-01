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

        public string CompiledText
        {
            get => _compiledText;
            set
            {
                if (_compiledText != value)
                {
                    _compiledText = value;
                    OnPropertyChanged(nameof(CompiledText));
                }
            }
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
                    CompiledText = AGL.Compile(_editorText, CsBindgen.Mode.PSX);
                }
            }
        }
    }
}
