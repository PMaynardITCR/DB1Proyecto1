﻿#pragma checksum "..\..\..\..\Vistas\EventosPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C9B91F6D14D98DA3FA5291C92F7988BBB1910449"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Olimpiadas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Olimpiadas {
    
    
    /// <summary>
    /// EventosPage
    /// </summary>
    public partial class EventosPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Vistas\EventosPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EventoEvento;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Vistas\EventosPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CompeticionEvento;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Vistas\EventosPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AgendaCheckBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Vistas\EventosPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Top5CheckBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Olimpiadas;component/vistas/eventospage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Vistas\EventosPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EventoEvento = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.CompeticionEvento = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.AgendaCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 20 "..\..\..\..\Vistas\EventosPage.xaml"
            this.AgendaCheckBox.Click += new System.Windows.RoutedEventHandler(this.AgendaClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Top5CheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 21 "..\..\..\..\Vistas\EventosPage.xaml"
            this.Top5CheckBox.Click += new System.Windows.RoutedEventHandler(this.Top5Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

