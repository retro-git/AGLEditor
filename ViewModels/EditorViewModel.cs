using CsBindgen;
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
        private Mode _systemMode = Mode.PSX;

        public IEnumerable<Mode> SystemModes { get; } = Enum.GetValues(typeof(Mode)).Cast<Mode>();

        public string EditorText
        {
            get => _editorText;
            set
            {
                if (_editorText != value)
                {
                    _editorText = value;
                    OnPropertyChanged(nameof(EditorText));
                    CompileUpdate();
                }
            }
        }

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

        public Mode SystemMode
        {
            get => _systemMode;
            set
            {
                if (_systemMode != value)
                {
                    _systemMode = value;
                    OnPropertyChanged(nameof(SystemMode));
                    CompileUpdate();
                }
            }
        } 

        private void CompileUpdate()
        {
            if (_editorText == null) { return; }
            CompiledText = AGL.Compile(_editorText, SystemMode);
        }
    }
}
