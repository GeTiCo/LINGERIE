﻿#pragma checksum "..\..\..\..\View\Settings\UpdateProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A5433324001382399D45D7838B97B39463C3A65E29D1B51C2FEC948F9296A8DE"
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
    /// UpdateProduct
    /// </summary>
    public partial class UpdateProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listCategory;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listViewProducts;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameItem;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaterialItem;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StructureItem;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InformationItem;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UidItem;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CostItem;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SizeItem;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\View\Settings\UpdateProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PhotoItem;
        
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
            System.Uri resourceLocater = new System.Uri("/LINGERIESHOP;component/view/settings/updateproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Settings\UpdateProduct.xaml"
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
            this.listCategory = ((System.Windows.Controls.ListBox)(target));
            
            #line 21 "..\..\..\..\View\Settings\UpdateProduct.xaml"
            this.listCategory.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.listCategory_PreviewMouseWheel);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\View\Settings\UpdateProduct.xaml"
            this.listCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listViewProducts = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.NameItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.MaterialItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.StructureItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.InformationItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.UidItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.CostItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.SizeItem = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.PhotoItem = ((System.Windows.Controls.Image)(target));
            return;
            case 12:
            
            #line 152 "..\..\..\..\View\Settings\UpdateProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clear);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 155 "..\..\..\..\View\Settings\UpdateProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.updateitem);
            
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
            case 3:
            
            #line 99 "..\..\..\..\View\Settings\UpdateProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnInfo);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

