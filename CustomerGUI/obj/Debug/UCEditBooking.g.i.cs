#pragma checksum "..\..\UCEditBooking.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F06BF1549B17DC0F5F0C6ACD7BD2957136C14AEEACA4F7F9469A8D0AE1762435"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CustomerGUI;
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


namespace CustomerGUI {
    
    
    /// <summary>
    /// UCEditBooking
    /// </summary>
    public partial class UCEditBooking : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridEdit;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image custImage;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCust;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvBookings;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemRemove;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem itemEdit;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn GridViewColumnName;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btEdit;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDelete;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\UCEditBooking.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCusName2;
        
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
            System.Uri resourceLocater = new System.Uri("/CustomerGUI;component/uceditbooking.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UCEditBooking.xaml"
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
            this.gridEdit = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.custImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.lblCust = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            
            #line 19 "..\..\UCEditBooking.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 28 "..\..\UCEditBooking.xaml"
            ((System.Windows.Controls.Calendar)(target)).SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Calendar_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvBookings = ((System.Windows.Controls.ListView)(target));
            
            #line 55 "..\..\UCEditBooking.xaml"
            this.lvBookings.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lvBookings_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.itemRemove = ((System.Windows.Controls.MenuItem)(target));
            
            #line 64 "..\..\UCEditBooking.xaml"
            this.itemRemove.Click += new System.Windows.RoutedEventHandler(this.itemRemove_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.itemEdit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 65 "..\..\UCEditBooking.xaml"
            this.itemEdit.Click += new System.Windows.RoutedEventHandler(this.itemEdit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.GridViewColumnName = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 11:
            this.btEdit = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\UCEditBooking.xaml"
            this.btEdit.Click += new System.Windows.RoutedEventHandler(this.btEdit_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btDelete = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\UCEditBooking.xaml"
            this.btDelete.Click += new System.Windows.RoutedEventHandler(this.btDelete_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.lblCusName2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 7:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 59 "..\..\UCEditBooking.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.OnMouseDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

