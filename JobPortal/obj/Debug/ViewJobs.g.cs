﻿#pragma checksum "..\..\ViewJobs.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A7D946ED0B8EBC588BDABA071213CBB6"
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
    /// ViewJobs
    /// </summary>
    public partial class ViewJobs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\ViewJobs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Error;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ViewJobs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SideBar;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ViewJobs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListingsList;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ViewJobs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ListingBody;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ViewJobs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel RequirementsPanel;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ViewJobs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SendMessage;
        
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
            System.Uri resourceLocater = new System.Uri("/JobPortal;component/viewjobs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewJobs.xaml"
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
            
            #line 20 "..\..\ViewJobs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Error = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.SideBar = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.ListingsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 30 "..\..\ViewJobs.xaml"
            this.ListingsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListingBody = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.RequirementsPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 7:
            this.SendMessage = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\ViewJobs.xaml"
            this.SendMessage.Click += new System.Windows.RoutedEventHandler(this.SendMessage_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 65 "..\..\ViewJobs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

