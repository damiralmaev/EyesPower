﻿#pragma checksum "..\..\..\Pages\Programs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4367E3D440D5E01D0E08A07B747B7DEEED3EE2FA172E97AA1C456B71FE04E8BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EyesPower.Pages;
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


namespace EyesPower.Pages {
    
    
    /// <summary>
    /// Programs
    /// </summary>
    public partial class Programs : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\Programs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnext;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Pages\Programs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btback;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\Programs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbnumber;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\Programs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btyes;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\Programs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btno;
        
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
            System.Uri resourceLocater = new System.Uri("/EyesPower;component/pages/programs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Programs.xaml"
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
            this.btnext = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Pages\Programs.xaml"
            this.btnext.Click += new System.Windows.RoutedEventHandler(this.btnext_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btback = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Pages\Programs.xaml"
            this.btback.Click += new System.Windows.RoutedEventHandler(this.btback_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lbnumber = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btyes = ((System.Windows.Controls.RadioButton)(target));
            
            #line 18 "..\..\..\Pages\Programs.xaml"
            this.btyes.Checked += new System.Windows.RoutedEventHandler(this.btyes_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btno = ((System.Windows.Controls.RadioButton)(target));
            
            #line 19 "..\..\..\Pages\Programs.xaml"
            this.btno.Checked += new System.Windows.RoutedEventHandler(this.btno_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

