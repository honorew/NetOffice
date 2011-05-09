//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.VBIDEApi
{
	///<summary>
	/// DispatchInterface Events SupportByLibrary VBE5.3 VBE12 
	///</summary>
	[SupportByLibrary("VBE5.3","VBE12")]
	public class Events : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Events()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="VBProject">NetOffice.VBIDEApi.VBProject VBProject</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public NetOffice.VBIDEApi.ReferencesEvents get_ReferencesEvents(NetOffice.VBIDEApi.VBProject vBProject)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(vBProject);
			object returnItem = Invoker.PropertyGet(this, "ReferencesEvents", paramsArray);
			NetOffice.VBIDEApi.ReferencesEvents newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.ReferencesEvents;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12 
		/// </summary>
		/// <param name="CommandBarControl">object CommandBarControl</param>
		[SupportByLibrary("VBE5.3","VBE12")]
		public NetOffice.VBIDEApi.CommandBarEvents get_CommandBarEvents(object commandBarControl)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(commandBarControl);
			object returnItem = Invoker.PropertyGet(this, "CommandBarEvents", paramsArray);
			NetOffice.VBIDEApi.CommandBarEvents newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi.CommandBarEvents;
			return newObject;
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}