﻿#pragma checksum "..\..\..\Views\FindMatches.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D5C83AB28E8C09971B1047A9D2C303846C0C3FBB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Shell;
using _2019_9_3_Dating_app_XAML_.ViewModels;
using _2019_9_3_Dating_app_XAML_.Views;


namespace _2019_9_3_Dating_app_XAML_.Views {
    
    
    /// <summary>
    /// FindMatches
    /// </summary>
    public partial class FindMatches : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal _2019_9_3_Dating_app_XAML_.ViewModels.FindMatchesViewModel myFindMatchesViewModel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBoxMenu;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewMatches;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSettings;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogOut;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtblNameAge;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtblShortDesc;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDislike;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Views\FindMatches.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLike;
        
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
            System.Uri resourceLocater = new System.Uri("/2019-9-3(Dating app XAML);component/views/findmatches.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\FindMatches.xaml"
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
            this.myFindMatchesViewModel = ((_2019_9_3_Dating_app_XAML_.ViewModels.FindMatchesViewModel)(target));
            return;
            case 2:
            this.cmbBoxMenu = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.btnViewMatches = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Views\FindMatches.xaml"
            this.btnViewMatches.Click += new System.Windows.RoutedEventHandler(this.btnViewMatches_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSettings = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Views\FindMatches.xaml"
            this.btnSettings.Click += new System.Windows.RoutedEventHandler(this.btnSettings_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnLogOut = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\Views\FindMatches.xaml"
            this.btnLogOut.Click += new System.Windows.RoutedEventHandler(this.btnLogOut_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtblNameAge = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtblShortDesc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.btnDislike = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\Views\FindMatches.xaml"
            this.btnDislike.Click += new System.Windows.RoutedEventHandler(this.btnDislike_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnLike = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\..\Views\FindMatches.xaml"
            this.btnLike.Click += new System.Windows.RoutedEventHandler(this.btnLike_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

