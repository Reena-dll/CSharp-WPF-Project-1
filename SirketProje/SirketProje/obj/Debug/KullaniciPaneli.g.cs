﻿#pragma checksum "..\..\KullaniciPaneli.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EAC58B3B20DDC04FE656137F02A7C5E1E0EC6C4D74B1190404CF0523BA0903A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SirketProje;
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


namespace SirketProje {
    
    
    /// <summary>
    /// KullaniciPaneli
    /// </summary>
    public partial class KullaniciPaneli : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\KullaniciPaneli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush image1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\KullaniciPaneli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textAd;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\KullaniciPaneli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textMaas;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\KullaniciPaneli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textDepartman;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\KullaniciPaneli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textSube;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\KullaniciPaneli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textHakkinda;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\KullaniciPaneli.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGeri;
        
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
            System.Uri resourceLocater = new System.Uri("/SirketProje;component/kullanicipaneli.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KullaniciPaneli.xaml"
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
            
            #line 10 "..\..\KullaniciPaneli.xaml"
            ((SirketProje.KullaniciPaneli)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.image1 = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 3:
            this.textAd = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.textMaas = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.textDepartman = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.textSube = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.textHakkinda = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnGeri = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\KullaniciPaneli.xaml"
            this.btnGeri.Click += new System.Windows.RoutedEventHandler(this.Geri_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
