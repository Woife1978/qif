﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace QifApi
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
				if (object.ReferenceEquals(resourceMan, null))
				{
					global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QifApi.Resources", typeof(Resources).Assembly);
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

		/// <summary>
		///   Looks up a localized string similar to Date: {0}, Payee: {1}, Amount: {2}.
		/// </summary>
		internal static string BasicTransactionDisplay
		{
			get
			{
				return ResourceManager.GetString("BasicTransactionDisplay", resourceCulture);
			}
		}

		/// <summary>
		///   Looks up a localized string similar to Invalid bank transaction: {0}.
		/// </summary>
		internal static string InvalidBankTransaction
		{
			get
			{
				return ResourceManager.GetString("InvalidBankTransaction", resourceCulture);
			}
		}

		/// <summary>
		///   Looks up a localized string similar to Invalid boolean format..
		/// </summary>
		internal static string InvalidBooleanFormat
		{
			get
			{
				return ResourceManager.GetString("InvalidBooleanFormat", resourceCulture);
			}
		}

		/// <summary>
		///   Looks up a localized string similar to Invalid date format..
		/// </summary>
		internal static string InvalidDateFormat
		{
			get
			{
				return ResourceManager.GetString("InvalidDateFormat", resourceCulture);
			}
		}

		/// <summary>
		///   Looks up a localized string similar to Invalid decimal format..
		/// </summary>
		internal static string InvalidDecimalFormat
		{
			get
			{
				return ResourceManager.GetString("InvalidDecimalFormat", resourceCulture);
			}
		}

		/// <summary>
		///   Looks up a localized string similar to Invalid transaction type..
		/// </summary>
		internal static string InvalidTransactionType
		{
			get
			{
				return ResourceManager.GetString("InvalidTransactionType", resourceCulture);
			}
		}

		/// <summary>
		///   Looks up a localized string similar to Date: {0}, Text: {1}, Amount: {2}.
		/// </summary>
		internal static string InvestmentTransactionDisplay
		{
			get
			{
				return ResourceManager.GetString("InvestmentTransactionDisplay", resourceCulture);
			}
		}

		/// <summary>
		///   Looks up a localized string similar to Payee: {0}, Amount: {1}.
		/// </summary>
		internal static string MemorizedTransactionDisplay
		{
			get
			{
				return ResourceManager.GetString("MemorizedTransactionDisplay", resourceCulture);
			}
		}
	}
}
