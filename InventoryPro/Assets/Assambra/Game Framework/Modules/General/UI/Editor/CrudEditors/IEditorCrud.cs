using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assambra.General.Editors
{
    public interface IEditorCrud
    {
        bool requiresDatabase { get; set; }

        void Focus();
        void Draw();
    }
}
