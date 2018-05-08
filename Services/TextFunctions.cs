using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace SimpleTextEditor
{
    class TextFunctions
    {
        private RichTextBox t = null;
        private WindowController wc = null;

        public TextFunctions(RichTextBox t, WindowController wc) {
            this.t = t;
            this.wc = wc;
        }

        public void changeFont() {
            this.changeProperty(RichTextBox.FontFamilyProperty, wc.selectedFont);
        }

        public void changeFontColor() {
            this.changeProperty(RichTextBox.ForegroundProperty, new SolidColorBrush(wc.color));
        }

        public void changeFontSize() {
            this.changeProperty(RichTextBox.FontSizeProperty, (double)wc.fontSize);
        }

        private void changeProperty(DependencyProperty property, object value) {
            if (value == null) {
                return;
            }

            if (value.Equals(0)) {
                return;
            }

            TextRange text = t.Selection;
            if (!text.IsEmpty)
            {
                text.ApplyPropertyValue(property, value);
            }
            else
            {
                text = new TextRange(t.Document.ContentStart, t.Document.ContentEnd);
                text.ApplyPropertyValue(property, value);
            }
        }

    }
}
