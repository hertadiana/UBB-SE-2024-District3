﻿#pragma checksum "..\..\..\..\LogIn\SignInPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "950FAD71D83909DA91633F37AEA4EA7D521DD5B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Log_In;
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


namespace District_3_App.LogIn {
    
    
    /// <summary>
    /// SignInPage
    /// </summary>
    public partial class SignInPage : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 92 "..\..\..\..\LogIn\SignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SignInGrid;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\LogIn\SignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsernameAndEmail;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\LogIn\SignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\LogIn\SignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVisiblePassword;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\LogIn\SignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton TogglePasswordVisibility;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\LogIn\SignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PasswordVisibilityIcon;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\LogIn\SignInPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignInButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/District 3 App;component/login/signinpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\LogIn\SignInPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SignInGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtUsernameAndEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.txtVisiblePassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TogglePasswordVisibility = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 109 "..\..\..\..\LogIn\SignInPage.xaml"
            this.TogglePasswordVisibility.Click += new System.Windows.RoutedEventHandler(this.TogglePasswordVisibility_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordVisibilityIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.SignInButton = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\..\LogIn\SignInPage.xaml"
            this.SignInButton.Click += new System.Windows.RoutedEventHandler(this.SignInButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 121 "..\..\..\..\LogIn\SignInPage.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.ForgotPasswordLink_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 130 "..\..\..\..\LogIn\SignInPage.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToSignUp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

