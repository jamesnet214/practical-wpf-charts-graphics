﻿#pragma checksum "..\..\ColorPicker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4D0D3B80787F1ABA78C98CD337DAC358"
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


namespace ColorsAndBrushes {
    
    
    /// <summary>
    /// ColorPicker
    /// </summary>
    public partial class ColorPicker : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ColorPicker.xaml"
        internal System.Windows.Controls.RadioButton rbRectangle;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ColorPicker.xaml"
        internal System.Windows.Controls.RadioButton rbEllipse;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ColorPicker.xaml"
        internal System.Windows.Controls.RadioButton rbSelect;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ColorPicker.xaml"
        internal System.Windows.Controls.RadioButton rbDelete;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ColorPicker.xaml"
        internal System.Windows.Shapes.Rectangle rectFill;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\ColorPicker.xaml"
        internal System.Windows.Controls.Canvas canvas1;
        
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
            System.Uri resourceLocater = new System.Uri("/ColorsAndBrushes;component/colorpicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ColorPicker.xaml"
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
            this.rbRectangle = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.rbEllipse = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.rbSelect = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.rbDelete = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            
            #line 48 "..\..\ColorPicker.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnFill_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rectFill = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.canvas1 = ((System.Windows.Controls.Canvas)(target));
            
            #line 57 "..\..\ColorPicker.xaml"
            this.canvas1.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 58 "..\..\ColorPicker.xaml"
            this.canvas1.MouseMove += new System.Windows.Input.MouseEventHandler(this.OnMouseMove);
            
            #line default
            #line hidden
            
            #line 59 "..\..\ColorPicker.xaml"
            this.canvas1.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
