﻿#pragma checksum "..\..\..\TaskWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6A7E0AF0E25F468AA7FF130225D301E024209FEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Haley.Abstractions;
using Haley.Enums;
using Haley.Events;
using Haley.MVVM;
using Haley.MVVM.Converters;
using Haley.Models;
using Haley.Utils;
using Haley.WPF;
using Haley.WPF.Controls;
using NotTrello;
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


namespace NotTrello {
    
    
    /// <summary>
    /// TaskWindow
    /// </summary>
    public partial class TaskWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 306 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Haley.WPF.Controls.ColorPickerButton taskColor;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MoveComboBox;
        
        #line default
        #line hidden
        
        
        #line 321 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox taskName;
        
        #line default
        #line hidden
        
        
        #line 322 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label taskPanel;
        
        #line default
        #line hidden
        
        
        #line 323 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ticketNumber;
        
        #line default
        #line hidden
        
        
        #line 324 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox taskDescription;
        
        #line default
        #line hidden
        
        
        #line 327 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateToggle;
        
        #line default
        #line hidden
        
        
        #line 336 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox activities;
        
        #line default
        #line hidden
        
        
        #line 340 "..\..\..\TaskWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NotTrello;component/taskwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TaskWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 302 "..\..\..\TaskWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 303 "..\..\..\TaskWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 304 "..\..\..\TaskWindow.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.taskColor = ((Haley.WPF.Controls.ColorPickerButton)(target));
            return;
            case 5:
            this.MoveComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 307 "..\..\..\TaskWindow.xaml"
            this.MoveComboBox.DropDownClosed += new System.EventHandler(this.Move_Task);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 310 "..\..\..\TaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete_Task);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 319 "..\..\..\TaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            this.taskName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.taskPanel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.ticketNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.taskDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            
            #line 325 "..\..\..\TaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Activity);
            
            #line default
            #line hidden
            return;
            case 13:
            this.dateToggle = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 14:
            this.activities = ((System.Windows.Controls.ListBox)(target));
            
            #line 336 "..\..\..\TaskWindow.xaml"
            this.activities.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 339 "..\..\..\TaskWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 340 "..\..\..\TaskWindow.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

