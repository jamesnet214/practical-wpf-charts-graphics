﻿#pragma checksum "..\..\Line3D.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2F3907B311375BF15C298CCF63E7C5E1"
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


namespace Chart3DNoWPFEngine {
    
    
    /// <summary>
    /// Line3D
    /// </summary>
    public partial class Line3D : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Line3D.xaml"
        internal System.Windows.Controls.TextBox tbElevation;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Line3D.xaml"
        internal System.Windows.Controls.TextBox tbAzimuth;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Line3D.xaml"
        internal System.Windows.Controls.Button Apply;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Line3D.xaml"
        internal System.Windows.Controls.Grid chartGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Line3D.xaml"
        internal System.Windows.Controls.Canvas chartCanvas;
        
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
            System.Uri resourceLocater = new System.Uri("/Chart3DNoWPFEngine;component/line3d.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Line3D.xaml"
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
            this.tbElevation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbAzimuth = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Apply = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Line3D.xaml"
            this.Apply.Click += new System.Windows.RoutedEventHandler(this.Apply_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chartGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 18 "..\..\Line3D.xaml"
            this.chartGrid.SizeChanged += new System.Windows.SizeChangedEventHandler(this.chartGrid_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chartCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
