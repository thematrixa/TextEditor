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
    /// Interaction logic for FontSizeChooserWindow.xaml
    /// </summary>
    public partial class FontSizeChooserWindow : Window
    {
        private const int FONT_SIZES_STEP = 2;
        WindowController wc = null;

        public FontSizeChooserWindow(WindowController wc)
        {
            InitializeComponent();
            this.fontSizeItemGenerator(10,72);
            this.wc = wc;
            fontSizeComboBox.SelectedIndex = 0;
        }

        private void fontSizeItemGenerator(int from, int to) {
            for(int i = from; i<to; i+= FONT_SIZES_STEP)
            fontSizeComboBox.Items.Add(new FontSizeComboBoxItem { Name = i+"pt", Value = i });
        }

        private void btnFontSize_Click(object sender, RoutedEventArgs e)
        {
            FontSizeComboBoxItem f = (FontSizeComboBoxItem)fontSizeComboBox.SelectedItem;
            wc.fontSize = f.Value;
            this.Close();
        }
    }
}
