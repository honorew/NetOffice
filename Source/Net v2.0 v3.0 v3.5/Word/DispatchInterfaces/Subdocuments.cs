//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Subdocuments SupportByLibrary WD09 WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
	public class Subdocuments : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Subdocuments()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool Expanded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Expanded", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Expanded", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Subdocument Item(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			NetOffice.WordApi.Subdocument newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Name">ref object Name</param>
		/// <param name="ConfirmConversions">ref optional object ConfirmConversions</param>
		/// <param name="ReadOnly">ref optional object ReadOnly</param>
		/// <param name="PasswordDocument">ref optional object PasswordDocument</param>
		/// <param name="PasswordTemplate">ref optional object PasswordTemplate</param>
		/// <param name="Revert">ref optional object Revert</param>
		/// <param name="WritePasswordDocument">ref optional object WritePasswordDocument</param>
		/// <param name="WritePasswordTemplate">ref optional object WritePasswordTemplate</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Subdocument AddFromFile(ref object name, ref object confirmConversions, ref object readOnly, ref object passwordDocument, ref object passwordTemplate, ref object revert, ref object writePasswordDocument, ref object writePasswordTemplate)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(name, confirmConversions, readOnly, passwordDocument, passwordTemplate, revert, writePasswordDocument, writePasswordTemplate);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray, modifiers);
			NetOffice.WordApi.Subdocument newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Subdocument;
			name = (object)paramsArray[0];
			confirmConversions = (object)paramsArray[1];
			readOnly = (object)paramsArray[2];
			passwordDocument = (object)paramsArray[3];
			passwordTemplate = (object)paramsArray[4];
			revert = (object)paramsArray[5];
			writePasswordDocument = (object)paramsArray[6];
			writePasswordTemplate = (object)paramsArray[7];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Name">ref object Name</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Subdocument AddFromFile(ref object name)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "AddFromFile", paramsArray, modifiers);
			NetOffice.WordApi.Subdocument newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Subdocument;
			name = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Subdocument AddFromRange(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddFromRange", paramsArray);
			NetOffice.WordApi.Subdocument newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Subdocument;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="FirstSubdocument">ref optional object FirstSubdocument</param>
		/// <param name="LastSubdocument">ref optional object LastSubdocument</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Merge(ref object firstSubdocument, ref object lastSubdocument)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(firstSubdocument, lastSubdocument);
			Invoker.Method(this, "Merge", paramsArray, modifiers);
			firstSubdocument = (object)paramsArray[0];
			lastSubdocument = (object)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Merge()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Merge", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}