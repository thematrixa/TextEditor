using Microsoft.Win32;
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

    public partial class MainWindow : Window
    {
        public static string openedFileName = null;
        private Dialogs dialogs = null;
        private FileFunctions fileFunctions = null;
        private EditFunctions editFunctions = null;
        private TextFunctions textFunctions = null;
        private WindowController wc = null;

        public MainWindow()
        {
            InitializeComponent();
            this.dialogs = new Dialogs(Textbox);
            this.wc = new WindowController();
            this.fileFunctions = new FileFunctions(Textbox);
            this.editFunctions = new EditFunctions(Textbox);
            this.textFunctions = new TextFunctions(Textbox,wc);
        }

        public void clearTextBox() {
            Textbox.Document.Blocks.Clear();
        }

        private void openBut_Click(object sender, RoutedEventArgs e)
        {
            this.dialogs.openFileChooserDialog();
        }

        private void saveBut_Click(object sender, RoutedEventArgs e)
        {
            if (isFileOpened()) {
                this.fileFunctions.writeToFile();
            }
            else{
                this.dialogs.saveFileChooserDialog();
            }
        }

        private bool isFileOpened() {
            if (openedFileName != null && openedFileName != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        private void undoBut_Click(object sender, RoutedEventArgs e)
        {
            this.editFunctions.undo();
        }

        private void redoBut_Click(object sender, RoutedEventArgs e)
        {
            this.editFunctions.redo();
        }

        private void copyBut_Click(object sender, RoutedEventArgs e)
        {
            this.editFunctions.copy();
        }

        private void cutBut_Click(object sender, RoutedEventArgs e)
        {
            this.editFunctions.cut();
        }

        private void pasteBut_Click(object sender, RoutedEventArgs e)
        {
            this.editFunctions.paste();
        }

        private void selectAllBut_Click(object sender, RoutedEventArgs e)
        {
            this.editFunctions.selectAll();
        }

        private void fontBut_Click(object sender, RoutedEventArgs e)
        {
            
            this.dialogs.fontChooserDialog(wc);
            this.textFunctions.changeFont();
        }

        private void colorBut_Click(object sender, RoutedEventArgs e)
        {
            this.dialogs.colorPickerDialog(wc);
            this.textFunctions.changeFontColor();
        }

        private void fontSizeBut_Click(object sender, RoutedEventArgs e)
        {
            this.dialogs.fontSizePickerDialog(wc);
            this.textFunctions.changeFontSize();
        }
    }
}
