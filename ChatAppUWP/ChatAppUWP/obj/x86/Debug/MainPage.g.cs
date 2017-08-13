﻿#pragma checksum "c:\users\mjnht\onedrive\documents\visual studio 2017\Projects\ChatAppUWP\ChatAppUWP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C466DE6001F3AB28DA75348C6FC60C6A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatAppUWP
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenuImageItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj2;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenuImageItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenuImageItem)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenuImageItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Label(obj.Label, phase);
                    }
                }
            }
            private void Update_Label(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj2, obj, null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private class MainPage_obj3_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenuGlyphItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;

            public MainPage_obj3_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenuGlyphItem) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenuGlyphItem)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenuGlyphItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Label(obj.Label, phase);
                    }
                }
            }
            private void Update_Label(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 5:
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    #line 59 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)this.MainGrid).SizeChanged += this.Page_SizeChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7:
                {
                    this.colContent = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 8:
                {
                    this.gridEdgeBlur = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 71 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.gridEdgeBlur).Tapped += this.gridEdgeBlur_Tapped;
                    #line default
                }
                break;
            case 9:
                {
                    this.ContentGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.titleChating = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11:
                {
                    this.listViewContent = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 12:
                {
                    this.txtContentSend = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 234 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtContentSend).TextChanged += this.txtContentSend_TextChanged;
                    #line 237 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtContentSend).KeyDown += this.txtContentSend_KeyDown;
                    #line default
                }
                break;
            case 13:
                {
                    this.btnFile = (global::Windows.UI.Xaml.Controls.Border)(target);
                    #line 240 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Border)this.btnFile).Tapped += this.btnFile_Tapped;
                    #line default
                }
                break;
            case 14:
                {
                    this.btnSend = (global::Windows.UI.Xaml.Controls.Border)(target);
                    #line 245 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Border)this.btnSend).PointerEntered += this.btnSend_PointerEntered;
                    #line 246 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Border)this.btnSend).PointerExited += this.btnSend_PointerExited;
                    #line 246 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Border)this.btnSend).Tapped += this.btnSend_Tapped;
                    #line default
                }
                break;
            case 15:
                {
                    this.avatarChating = (global::Windows.UI.Xaml.Shapes.Ellipse)(target);
                }
                break;
            case 16:
                {
                    this.checkBoxHide = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 131 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.checkBoxHide).Checked += this.CheckBox_Checked;
                    #line 131 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.checkBoxHide).Unchecked += this.CheckBox_Unchecked;
                    #line default
                }
                break;
            case 17:
                {
                    this.Header = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.listViewContact = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 137 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.listViewContact).SelectionChanged += this.listViewContact_SelectionChanged;
                    #line default
                }
                break;
            case 19:
                {
                    this.gridEdge = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 73 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.gridEdge).SizeChanged += this.gridEdge_SizeChanged;
                    #line default
                }
                break;
            case 20:
                {
                    this.Expand = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 21:
                {
                    this.Collapse = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 22:
                {
                    this.HamburgerMenu = (global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenu)(target);
                    #line 94 "..\..\..\MainPage.xaml"
                    ((global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenu)this.HamburgerMenu).ItemClick += this.HamburgerMenu_OnItemClick;
                    #line 95 "..\..\..\MainPage.xaml"
                    ((global::Microsoft.Toolkit.Uwp.UI.Controls.HamburgerMenu)this.HamburgerMenu).OptionsItemClick += this.HamburgerMenu_OnOptionsItemClick;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Grid element1 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element1.DataContext);
                    element1.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element1, bindings);
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.Grid element3 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    MainPage_obj3_Bindings bindings = new MainPage_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

