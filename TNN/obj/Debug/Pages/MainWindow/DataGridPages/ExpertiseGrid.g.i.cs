﻿#pragma checksum "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0891A548520EB5C6DCCF385A14CFAE650EFDCBC2ED749352CF2E3EB80CD127AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using TNN.Pages.MainWindow.DataGridPages;


namespace TNN.Pages.MainWindow.DataGridPages {
    
    
    /// <summary>
    /// ExpertiseGrid
    /// </summary>
    public partial class ExpertiseGrid : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Refresh;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ResetSettings;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Expertise;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrentPageNum;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AllPaheNum;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CountElements;
        
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
            System.Uri resourceLocater = new System.Uri("/TNN;component/pages/mainwindow/datagridpages/expertisegrid.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
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
            this.Refresh = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
            this.Refresh.Click += new System.Windows.RoutedEventHandler(this.Refresh_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ResetSettings = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
            this.ResetSettings.Click += new System.Windows.RoutedEventHandler(this.ResetSettings_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Search = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\..\..\Pages\MainWindow\DataGridPages\ExpertiseGrid.xaml"
            this.Search.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Search_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Expertise = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.CurrentPageNum = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.AllPaheNum = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.CountElements = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

