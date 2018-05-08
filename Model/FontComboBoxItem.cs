using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SimpleTextEditor
{
    class FontComboBoxItem
    {
        public string Name { get; set; }
        public FontFamily Value { get; set; }
        public override string ToString() { return this.Name; }
    }
}
