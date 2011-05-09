//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PivotAxisMember SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class PivotAxisMember : PivotMember
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotAxisMember(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotAxisMember(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotAxisMember(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotAxisMember()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotAxisMembers ChildAxisMembers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildAxisMembers", paramsArray);
				NetOffice.OWC10Api.PivotAxisMembers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotAxisMembers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotAxisMember ParentAxisMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentAxisMember", paramsArray);
				NetOffice.OWC10Api.PivotAxisMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotAxisMember;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="Format">NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum Format</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotAxisMember get_FindAxisMember(string path, NetOffice.OWC10Api.Enums.PivotMemberFindFormatEnum format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, format);
			object returnItem = Invoker.PropertyGet(this, "FindAxisMember", paramsArray);
			NetOffice.OWC10Api.PivotAxisMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotAxisMember;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotAxisMember TotalMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalMember", paramsArray);
				NetOffice.OWC10Api.PivotAxisMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotAxisMember;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultGroupAxis Axis
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Axis", paramsArray);
				NetOffice.OWC10Api.PivotResultGroupAxis newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultGroupAxis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
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

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool AutoFit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFit", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotHyperlink Hyperlink
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hyperlink", paramsArray);
				NetOffice.OWC10Api.PivotHyperlink newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotHyperlink;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultMemberProperties MemberProperties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MemberProperties", paramsArray);
				NetOffice.OWC10Api.PivotResultMemberProperties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultMemberProperties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotResultGroupField GroupField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupField", paramsArray);
				NetOffice.OWC10Api.PivotResultGroupField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotResultGroupField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool IsTotal
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsTotal", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotMember SourceMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceMember", paramsArray);
				NetOffice.OWC10Api.PivotMember newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotMember;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void ShowDetails()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowDetails", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void HideDetails()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "HideDetails", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}