﻿#pragma checksum "..\..\ManageTrainer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20BDD61FF862D886438A8A455665004D82CF29C435C37157BF5092CCF096611C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AdminGUI;
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


namespace AdminGUI {
    
    
    /// <summary>
    /// ManageTrainer
    /// </summary>
    public partial class ManageTrainer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridTotal;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CurrUserLbl;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvTrainer;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn GridViewColumnName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbID;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\ManageTrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTrainer;
        
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
            System.Uri resourceLocater = new System.Uri("/AdminGUI;component/managetrainer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManageTrainer.xaml"
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
            this.gridTotal = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.CurrUserLbl = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.lvTrainer = ((System.Windows.Controls.ListView)(target));
            
            #line 42 "..\..\ManageTrainer.xaml"
            this.lvTrainer.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.lvTrainer_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 42 "..\..\ManageTrainer.xaml"
            this.lvTrainer.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.lvTrainer_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GridViewColumnName = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 6:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\ManageTrainer.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\ManageTrainer.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.btnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbID = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\ManageTrainer.xaml"
            this.tbID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            
            #line 68 "..\..\ManageTrainer.xaml"
            this.tbName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.btnAddTrainer = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\ManageTrainer.xaml"
            this.btnAddTrainer.Click += new System.Windows.RoutedEventHandler(this.btnAddTrainer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
