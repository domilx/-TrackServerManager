﻿#pragma checksum "..\..\CreateNewServer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "84616EEDAA2291104CF71E5BC9E4E28A61EAB5E46041C9508B68C24E97820DD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Minecraft_Server_Wrapper;
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


namespace Minecraft_Server_Wrapper {
    
    
    /// <summary>
    /// CreateNewServer
    /// </summary>
    public partial class CreateNewServer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel TitleBar;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimize;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServerDir;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrowseServerFile;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectServerType;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ServerTypeInfo;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SelectServerVersion;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\CreateNewServer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DownloadInstall;
        
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
            System.Uri resourceLocater = new System.Uri("/Minecraft Server Wrapper;component/createnewserver.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateNewServer.xaml"
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
            
            #line 8 "..\..\CreateNewServer.xaml"
            ((Minecraft_Server_Wrapper.CreateNewServer)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TitleBar = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            
            #line 73 "..\..\CreateNewServer.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\CreateNewServer.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Minimize = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\CreateNewServer.xaml"
            this.Minimize.Click += new System.Windows.RoutedEventHandler(this.Minimize_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ServerDir = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\CreateNewServer.xaml"
            this.ServerDir.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ServerDir_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BrowseServerFile = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\CreateNewServer.xaml"
            this.BrowseServerFile.Click += new System.Windows.RoutedEventHandler(this.BrowseServerFile_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SelectServerType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 84 "..\..\CreateNewServer.xaml"
            this.SelectServerType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectServerType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ServerTypeInfo = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.SelectServerVersion = ((System.Windows.Controls.ComboBox)(target));
            
            #line 93 "..\..\CreateNewServer.xaml"
            this.SelectServerVersion.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectServerVersion_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DownloadInstall = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\CreateNewServer.xaml"
            this.DownloadInstall.Click += new System.Windows.RoutedEventHandler(this.BrowseServerFile_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

