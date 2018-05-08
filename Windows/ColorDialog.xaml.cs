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
    /// Interaction logic for ColorDialog.xaml
    /// </summary>
    public partial class ColorDialog : Window
    {
        WindowController wc = null;
       public ColorDialog()
        {
            InitializeComponent();
        }
        public ColorDialog(WindowController wc)
        {
            this.wc = wc;
            InitializeComponent();
        }
    #region Public Properties
    public Color SelectedColor
    {
        get { return colorPicker.SelectedColor; }
    }
    #endregion

    #region Private Methods
    /// <summary>
    /// Closes the dialog on Enter key pressed
    /// </summary>
    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
            if (e.Key == Key.Enter)
            {
                wc.color = SelectedColor;
                DialogResult = true;
                this.Close();
            }
            else {
                DialogResult = false;
            }
    }

    /// <summary>
    /// User is happy with choice
    /// </summary>
    private void btnOk_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
    }

    /// <summary>
    /// User is not happy with choice
    /// </summary>
    private void btnCancel_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
    }
    }
    #endregion
}
