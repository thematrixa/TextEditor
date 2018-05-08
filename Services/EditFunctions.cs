using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SimpleTextEditor
{
    class EditFunctions
    {
        private RichTextBox t;
        public EditFunctions(RichTextBox t) {
            this.t = t;
        }

        public void copy() {
            this.t.Copy();
        }

        public void paste() {
            this.t.Paste();
        }

        public void cut() {
            this.t.Cut();
        }

        public void undo() {
            this.t.Undo();
        }
        public void redo() {
            this.t.Redo();
        }

        public void selectAll() {
            this.t.SelectAll();
        }
    }
}
