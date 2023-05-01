using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGLEditor.Models
{
    public class Project
    {
        // Name of the project
        public string Name { get; set; }

        // Directory where the project is located
        public string Directory { get; set; }

        // Path to the agl binary
        public string AGLBinPath { get; set; }
    }
}
