﻿#pragma checksum "..\..\..\..\View\Entities\PrepackView - Copy (2).xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "048E52434AC98C7EE0FC0B6C7F820E2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ManagerClient.Converters;
using ManagerClient.View;
using ManagerClient.View.Entities;
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


namespace ManagerClient.View.Entities {
    
    
    /// <summary>
    /// PrepackView
    /// </summary>
    public partial class PrepackView : ManagerClient.View.Entities.EntityUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\View\Entities\PrepackView - Copy (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UnitList;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\View\Entities\PrepackView - Copy (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddIngredient;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\View\Entities\PrepackView - Copy (2).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteIngredient;
        
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
            System.Uri resourceLocater = new System.Uri("/ManagerClient;component/view/entities/prepackview%20-%20copy%20(2).xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Entities\PrepackView - Copy (2).xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.UnitList = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.AddIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\..\View\Entities\PrepackView - Copy (2).xaml"
            this.AddIngredient.Click += new System.Windows.RoutedEventHandler(this.AddIngredient_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteIngredient = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\View\Entities\PrepackView - Copy (2).xaml"
            this.DeleteIngredient.Click += new System.Windows.RoutedEventHandler(this.DeleteIngredient_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
