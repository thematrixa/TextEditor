using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SimpleTextEditor
{
    class Dialogs
    {
        private RichTextBox t;
        private FileFunctions ff = null;
        public Dialogs(RichTextBox t) {
            this.t = t;
            this.ff = new FileFunctions(t);
        }


        public void openFileChooserDialog()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                t.Document.Blocks.Clear();
                MainWindow.openedFileName = dlg.FileName;
                ff.readFromFile();
            }
            else
            {
                MessageBox.Show("File could not be loaded", "File Open error", MessageBoxButton.OK);
            }
        }

        public void saveFileChooserDialog()
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            Nullable<bool> result = SaveFileDialog1.ShowDialog();
            if (result == true)
            {
                MainWindow.openedFileName = SaveFileDialog1.FileName;
                this.ff.writeToFile();
            }
            else
            {
                MessageBox.Show("File could not be loaded", "File Open error", MessageBoxButton.OK);
            }
        }

        public void fontChooserDialog(WindowController wc) {

            FontChooserWindow fcw = new FontChooserWindow(wc);
            fcw.ShowDialog();

        }

        public void colorPickerDialog(WindowController wc)
        {
            ColorDialog colorDialog = new ColorDialog(wc);
            colorDialog.ShowDialog();
        }


        public void fontSizePickerDialog(WindowController wc) {
            FontSizeChooserWindow fontSizeDialog = new FontSizeChooserWindow(wc);
            fontSizeDialog.ShowDialog();
        }


    }
}
