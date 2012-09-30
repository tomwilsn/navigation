﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Navigation.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Navigation.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} is a mandatory attribute for a Dialog.
        /// </summary>
        internal static string DialogAttributeMissing {
            get {
                return ResourceManager.GetString("DialogAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Dialog with key {0} already exists.
        /// </summary>
        internal static string DuplicateDialogKey {
            get {
                return ResourceManager.GetString("DuplicateDialogKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A State with key {0} already exists for Dialog {1}.
        /// </summary>
        internal static string DuplicateStateKey {
            get {
                return ResourceManager.GetString("DuplicateStateKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Transition with key {0} already exists for State {1}.
        /// </summary>
        internal static string DuplicateTransitionKey {
            get {
                return ResourceManager.GetString("DuplicateTransitionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action parameter must be a Dialog key or a Transition key that is a child of the current State.
        /// </summary>
        internal static string InvalidAction {
            get {
                return ResourceManager.GetString("InvalidAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot convert to and from a string.
        /// </summary>
        internal static string InvalidConversion {
            get {
                return ResourceManager.GetString("InvalidConversion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Navigation Data converter {0} is not valid.
        /// </summary>
        internal static string InvalidConverterAttribute {
            get {
                return ResourceManager.GetString("InvalidConverterAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Dialog&apos;s initial key of {1} does not match a child State key.
        /// </summary>
        internal static string InvalidDialogInitialKey {
            get {
                return ResourceManager.GetString("InvalidDialogInitialKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The distance parameter must be greater than zero and less than or equal to the number of Crumbs ({0}).
        /// </summary>
        internal static string InvalidDistance {
            get {
                return ResourceManager.GetString("InvalidDistance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ArrayList and Generic List are the only valid enumerable types in NavigationData.
        /// </summary>
        internal static string InvalidEnumerableNavigationData {
            get {
                return ResourceManager.GetString("InvalidEnumerableNavigationData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid expression, NavigationDataExpressionBuilder expects a string with format: Key1=Value1,Key2?type=Value2.
        /// </summary>
        internal static string InvalidExpression {
            get {
                return ResourceManager.GetString("InvalidExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No TypeConverter found for {0}.
        /// </summary>
        internal static string InvalidNavigationData {
            get {
                return ResourceManager.GetString("InvalidNavigationData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid route data, a mandatory route parameter has not been supplied a value.
        /// </summary>
        internal static string InvalidRouteData {
            get {
                return ResourceManager.GetString("InvalidRouteData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} State&apos;s Transition to key of {1} does not match a sibling State key.
        /// </summary>
        internal static string InvalidTransitionToKey {
            get {
                return ResourceManager.GetString("InvalidTransitionToKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Navigation Data type {0} is not valid.
        /// </summary>
        internal static string InvalidTypeAttribute {
            get {
                return ResourceManager.GetString("InvalidTypeAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Url is invalid.
        /// </summary>
        internal static string InvalidUrl {
            get {
                return ResourceManager.GetString("InvalidUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not have a public property named &apos;{1}&apos;.
        /// </summary>
        internal static string PropertyMissing {
            get {
                return ResourceManager.GetString("PropertyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ScriptManager must appear on the Page before the HistoryNavigator.
        /// </summary>
        internal static string ScriptManagerMissing {
            get {
                return ResourceManager.GetString("ScriptManagerMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} State&apos;s {1} attribute is invalid.
        /// </summary>
        internal static string StateAttributeInvalid {
            get {
                return ResourceManager.GetString("StateAttributeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is a mandatory attribute for a State.
        /// </summary>
        internal static string StateAttributeMissing {
            get {
                return ResourceManager.GetString("StateAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is a mandatory attribute for a Transition.
        /// </summary>
        internal static string TransitionAttributeMissing {
            get {
                return ResourceManager.GetString("TransitionAttributeMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to type is a mandatory attribute for Navigation Data.
        /// </summary>
        internal static string TypeAttributeMissing {
            get {
                return ResourceManager.GetString("TypeAttributeMissing", resourceCulture);
            }
        }
    }
}
