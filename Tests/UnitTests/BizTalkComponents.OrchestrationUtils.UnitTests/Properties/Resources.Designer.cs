﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BizTalkComponents.OrchestrationUtils.UnitTests.Properties {
    using System;
    
    
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BizTalkComponents.OrchestrationUtils.UnitTests.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap BizTalkServer2013R2 {
            get {
                object obj = ResourceManager.GetObject("BizTalkServer2013R2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        /// &lt;library
        ///   xmlns=&quot;http://eric.van-der-vlist.com/ns/library&quot;
        ///   xmlns:hr=&quot;http://eric.van-der-vlist.com/ns/person&quot;&gt;
        ///  &lt;book id=&quot;b0836217462&quot; available=&quot;true&quot;&gt;
        ///   &lt;isbn&gt;0836217462&lt;/isbn&gt;
        ///   &lt;title xml:lang=&quot;en&quot;&gt;Being a Dog Is a Full-Time Job&lt;/title&gt;
        ///   &lt;hr:author id=&quot;CMS&quot;&gt;
        ///    &lt;hr:name&gt;Charles M Schulz&lt;/hr:name&gt;
        ///    &lt;hr:born&gt;1922-11-26&lt;/hr:born&gt;
        ///    &lt;hr:dead&gt;2000-02-12&lt;/hr:dead&gt;
        ///   &lt;/hr:author&gt;
        ///   &lt;character id=&quot;PP&quot;&gt;
        ///    &lt;hr:name&gt;Peppermint Patty&lt;/hr:name&gt;
        ///    &lt;hr:born&gt;19 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XmlExample {
            get {
                return ResourceManager.GetString("XmlExample", resourceCulture);
            }
        }
    }
}
