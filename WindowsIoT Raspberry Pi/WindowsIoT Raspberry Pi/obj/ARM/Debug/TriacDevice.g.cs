﻿#pragma checksum "C:\Users\Anand\Google Drive\Raspberry Pi\WindowsIoT Raspberry Pi\WindowsIoT Raspberry Pi\TriacDevice.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F484954A43356A82E893E24AC9DDA1D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsIoT_Raspberry_Pi
{
    partial class TriacDevice : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 2:
                {
                    this.toggle_dim_bright = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 12 "..\..\..\TriacDevice.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.toggle_dim_bright).Checked += this.toggle_dim_bright_Checked;
                    #line 12 "..\..\..\TriacDevice.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.toggle_dim_bright).Unchecked += this.toggle_dim_bright_Unchecked;
                    #line default
                }
                break;
            case 3:
                {
                    this.slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 13 "..\..\..\TriacDevice.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.slider).ValueChanged += this.slider_ValueChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.relay_on_off = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 14 "..\..\..\TriacDevice.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.relay_on_off).Toggled += this.relay_on_off_Toggled;
                    #line default
                }
                break;
            case 5:
                {
                    this.buzzer = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 15 "..\..\..\TriacDevice.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.buzzer).Toggled += this.buzzer_Toggled;
                    #line default
                }
                break;
            case 6:
                {
                    this.TimerControl = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 16 "..\..\..\TriacDevice.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.TimerControl).Checked += this.soc_Checked;
                    #line default
                }
                break;
            case 7:
                {
                    this.days = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.hours = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.minutes = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.seconds = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.textBlock_Copy = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.textBlock_Copy1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.textBlock_Copy2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.repeat = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
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
            return returnValue;
        }
    }
}
