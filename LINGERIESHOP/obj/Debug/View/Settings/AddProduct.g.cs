﻿#pragma checksum "..\..\..\..\View\Settings\AddProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B2DE75683D7B2A8FEADD385A6BFAC23006F0FEB9AAF5403B7A3EE20AF0B94165"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LINGERIESHOP.View.Settings;
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


namespace LINGERIESHOP.View.Settings {
    
    
    /// <summary>
    /// AddProduct
    /// </summary>
    public partial class AddProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 39 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listCategory;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listViewProducts;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameItem;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaterialItem;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StructureItem;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InformationItem;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UidItem;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CostItem;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\View\Settings\AddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SizeItem;
        
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
            System.Uri resourceLocater = new System.Uri("/LINGERIESHOP;component/view/settings/addproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Settings\AddProduct.xaml"
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
            
            #line 26 "..\..\..\..\View\Settings\AddProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.newlist);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 35 "..\..\..\..\View\Settings\AddProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.dellist);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listCategory = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\..\..\View\Settings\AddProduct.xaml"
            this.listCategory.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.listCategory_PreviewMouseWheel);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\..\View\Settings\AddProduct.xaml"
            this.listCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listViewProducts = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.NameItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.MaterialItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.StructureItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.InformationItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.UidItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.CostItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.SizeItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 173 "..\..\..\..\View\Settings\AddProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clear);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 176 "..\..\..\..\View\Settings\AddProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewItemClick);
            
            #line default
            #line hidden
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
            switch (connectionId)
            {
            case 5:
            
            #line 119 "..\..\..\..\View\Settings\AddProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInfo);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

