﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B872997A52C9B428AB835D3F05890E9C0D04C61"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SimpleTextEditor;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SimpleTextEditor {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox Textbox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem openBut;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem closeBut;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem saveBut;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem undoBut;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem redoBut;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyBut;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem cutBut;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem pasteBut;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem selectAllBut;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem fontBut;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem colorBut;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem fontSizeBut;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SimpleTextEditor;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Textbox = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 2:
            this.openBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 19 "..\..\..\Windows\MainWindow.xaml"
            this.openBut.Click += new System.Windows.RoutedEventHandler(this.openBut_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.closeBut = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.saveBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\Windows\MainWindow.xaml"
            this.saveBut.Click += new System.Windows.RoutedEventHandler(this.saveBut_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.undoBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\..\Windows\MainWindow.xaml"
            this.undoBut.Click += new System.Windows.RoutedEventHandler(this.undoBut_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.redoBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\..\Windows\MainWindow.xaml"
            this.redoBut.Click += new System.Windows.RoutedEventHandler(this.redoBut_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.copyBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 26 "..\..\..\Windows\MainWindow.xaml"
            this.copyBut.Click += new System.Windows.RoutedEventHandler(this.copyBut_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cutBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\..\Windows\MainWindow.xaml"
            this.cutBut.Click += new System.Windows.RoutedEventHandler(this.cutBut_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.pasteBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\..\Windows\MainWindow.xaml"
            this.pasteBut.Click += new System.Windows.RoutedEventHandler(this.pasteBut_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.selectAllBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\..\Windows\MainWindow.xaml"
            this.selectAllBut.Click += new System.Windows.RoutedEventHandler(this.selectAllBut_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.fontBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\..\Windows\MainWindow.xaml"
            this.fontBut.Click += new System.Windows.RoutedEventHandler(this.fontBut_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.colorBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\..\Windows\MainWindow.xaml"
            this.colorBut.Click += new System.Windows.RoutedEventHandler(this.colorBut_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.fontSizeBut = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\Windows\MainWindow.xaml"
            this.fontSizeBut.Click += new System.Windows.RoutedEventHandler(this.fontSizeBut_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

