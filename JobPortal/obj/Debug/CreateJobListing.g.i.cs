﻿#pragma checksum "..\..\CreateJobListing.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "780BA08D3F43C472F09633313165C024"
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


namespace JobPortal {
    
    
    /// <summary>
    /// CreateJobListing
    /// </summary>
    public partial class CreateJobListing : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox listingTitle;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox listingDescription;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton OpenToAll;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SelectedRequirements;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Requirements;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Age;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Gpa;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Experience;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\CreateJobListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateListing;
        
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
            System.Uri resourceLocater = new System.Uri("/JobPortal;component/createjoblisting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateJobListing.xaml"
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
            this.listingTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.listingDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.OpenToAll = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.SelectedRequirements = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\CreateJobListing.xaml"
            this.SelectedRequirements.Checked += new System.Windows.RoutedEventHandler(this.SelectedRequirementsChecked);
            
            #line default
            #line hidden
            
            #line 23 "..\..\CreateJobListing.xaml"
            this.SelectedRequirements.Unchecked += new System.Windows.RoutedEventHandler(this.SelectedRequirementsUnchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Requirements = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.Age = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Gpa = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.Experience = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\CreateJobListing.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.CreateListing = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\CreateJobListing.xaml"
            this.CreateListing.Click += new System.Windows.RoutedEventHandler(this.CreateListing_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

