﻿// Developer Express Code Central Example:
// How to fix a row in GridControl
// 
// This example demonstrates how to provide the capability to fix a row in
// GridControl. Our GridControl doesn't have the capability to fix a row. So, to
// provide this capability in this sample, we manipulate
// the child collection of
// the HeirarchyPanel. We add a StackPanel with a collection of editors to the
// child
// collection of the HeirarchyPanel and bind them to respective cells of the
// selected row. Then, we assign
// it to a ScrollChanged event of the ScrollViewer.
// When ScrollChanged raises, we change the location of the StackPanel, so it is
// always displayed on the top of the grid view.
// Please note, that this approach
// is not compatible with Bands and Conditional Formatting. Also, a fixed row may
// not be displayed immediately when PerPixelScrolling is enabled.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T161325

// Developer Express Code Central Example:
// How to fix a row in GridControl
// 
// This example demonstrates how to provide the capability to fix a row in
// GridControl. Our GridControl doesn't have the capability to fix a row. So, to
// provide this capability in this sample, we manipulate
// the child collection of
// the HeirarchyPanel. We add a StackPanel with a collection of editors to the
// child
// collection of the HeirarchyPanel and bind them to respective cells of the
// selected row. Then, we assign
// it to a ScrollChanged event of the ScrollViewer.
// When ScrollChanged raises, we change the location of the StackPanel, so it is
// always displayed on the top of the grid view.
// Please note, that this approach
// is not compatible with Bands and Conditional Formatting. Also, a fixed row may
// not be displayed immediately when PerPixelScrolling is enabled.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T161325

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FixedRowExample.Properties
{


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if ((resourceMan == null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FixedRowExample.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
    }
}