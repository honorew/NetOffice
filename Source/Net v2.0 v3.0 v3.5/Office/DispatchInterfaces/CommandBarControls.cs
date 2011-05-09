//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface CommandBarControls SupportByLibrary OF09 OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
	public class CommandBarControls : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBarControls(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBarControls(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBarControls(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandBarControls()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
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
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.CommandBarControl get_Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.CommandBar Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.OfficeApi.CommandBar newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.CommandBar;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Id">optional object Id</param>
		/// <param name="Parameter">optional object Parameter</param>
		/// <param name="Before">optional object Before</param>
		/// <param name="Temporary">optional object Temporary</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.CommandBarControl Add(object type, object id, object parameter, object before, object temporary)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, id, parameter, before, temporary);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.CommandBarControl Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.CommandBarControl newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.CommandBarControl;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
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