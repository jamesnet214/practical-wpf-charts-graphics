﻿#pragma checksum "..\..\FirstWPFProgram.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C794F1EFBE4C79345FA31D8D529E46D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WPFOverview {
    
    
    /// <summary>
    /// FirstWPFProgram
    /// </summary>
    public partial class FirstWPFProgram : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\FirstWPFProgram.xaml"
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\FirstWPFProgram.xaml"
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFOverview;component/firstwpfprogram.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FirstWPFProgram.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\FirstWPFProgram.xaml"
            this.textBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 16 "..\..\FirstWPFProgram.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnChangeColor_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\FirstWPFProgram.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnChangeSize_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
