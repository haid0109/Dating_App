﻿#pragma checksum "..\..\..\Views\CreatePreference.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7A8044080BB54EE053C69360ADCF20FCFDE6EB3E"
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
    /// CreatePreference
    /// </summary>
    public partial class CreatePreference : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal _2019_9_3_Dating_app_XAML_.ViewModels.CreatePreferencesViewModel myCreatePreferencesViewModel;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCreateGenderPref;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbBoxCreateGenderPref;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCreateAgeGroupPref;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxCreateMinAgePref;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDash;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxCreateMaxAgePref;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGoBack;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\Views\CreatePreference.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreatePreferences;
        
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
            System.Uri resourceLocater = new System.Uri("/2019-9-3(Dating app XAML);component/views/createpreference.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CreatePreference.xaml"
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
            this.myCreatePreferencesViewModel = ((_2019_9_3_Dating_app_XAML_.ViewModels.CreatePreferencesViewModel)(target));
            return;
            case 2:
            this.lblCreateGenderPref = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.cmbBoxCreateGenderPref = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\Views\CreatePreference.xaml"
            this.cmbBoxCreateGenderPref.AddHandler(System.Windows.ContentElement.TextInputEvent, new System.Windows.Input.TextCompositionEventHandler(this.CmbBoxCreateGenderPref_TextInput));
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblCreateAgeGroupPref = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtBoxCreateMinAgePref = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\Views\CreatePreference.xaml"
            this.txtBoxCreateMinAgePref.AddHandler(System.Windows.ContentElement.TextInputEvent, new System.Windows.Input.TextCompositionEventHandler(this.TxtBoxCreateMinAgePref_TextInput));
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblDash = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtBoxCreateMaxAgePref = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\Views\CreatePreference.xaml"
            this.txtBoxCreateMaxAgePref.AddHandler(System.Windows.ContentElement.TextInputEvent, new System.Windows.Input.TextCompositionEventHandler(this.TxtBoxCreateMaxAgePref_TextInput));
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnGoBack = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\Views\CreatePreference.xaml"
            this.btnGoBack.Click += new System.Windows.RoutedEventHandler(this.BtnGoBack_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnCreatePreferences = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\Views\CreatePreference.xaml"
            this.btnCreatePreferences.Click += new System.Windows.RoutedEventHandler(this.BtnCreatePreferences_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

