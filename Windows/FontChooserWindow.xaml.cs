using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace SimpleTextEditor
{
    /// <summary>
    /// Interaction logic for FontChooserWindow.xaml
    /// </summary>
    public partial class FontChooserWindow : Window
    {
        WindowController wc = null;



        public FontChooserWindow()
        {
            InitializeComponent();
        }
        public FontChooserWindow(WindowController wc)
        {
            InitializeComponent();
            fontComboBox.Items.Add(new FontComboBoxItem { Name = "Tahoma", Value = new FontFamily("Tahoma") });
            fontComboBox.Items.Add(new FontComboBoxItem { Name = "Arial", Value = new FontFamily("Arial") });
            fontComboBox.Items.Add(new FontComboBoxItem { Name = "Times New Roman", Value = new FontFamily("Times New Roman") });
            fontComboBox.SelectedIndex = 0;
            this.wc = wc;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FontComboBoxItem f = (FontComboBoxItem)fontComboBox.SelectedItem;
            wc.selectedFont = f.Value;
            this.Close();
        }
    }
}
