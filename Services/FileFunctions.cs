using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleTextEditor
{
    class FileFunctions
    {
        private RichTextBox t;

        public FileFunctions(RichTextBox t) {
            this.t = t;
        }

        public void readFromFile()
        {
            try
            {
                TextRange tr = new TextRange(t.Document.ContentStart, t.Document.ContentEnd);
                FileStream file = new FileStream(MainWindow.openedFileName, FileMode.Open);
                tr.Load(file, System.Windows.DataFormats.Rtf);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be read: " + ex.Message, "File Open error", MessageBoxButton.OK);
            }

        }

        public void writeToFile()
        {
            TextRange tr = new TextRange(t.Document.ContentStart, t.Document.ContentEnd);
            FileStream file = new FileStream(MainWindow.openedFileName, FileMode.Create);
            tr.Save(file, System.Windows.DataFormats.Rtf);
            file.Close();
        }


    }
}
