using CsBindgen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGLEditor
{
    public class AGL
    {
        // Compile source agl code.
        // Throws an exception if the compilation fails.
        public static string Compile(string source, Mode mode)
        {
            unsafe
            {
                fixed (char* p = source)
                {
                    var compiled = new String((sbyte*)NativeMethods.compile_csharp((ushort*)p, source.Length, mode));
                    return compiled;
                }
            }
        }
    }
}
