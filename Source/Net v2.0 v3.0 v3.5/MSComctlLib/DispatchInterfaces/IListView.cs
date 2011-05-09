//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IListView SupportByLibrary WCC6.0 
	///</summary>
	[SupportByLibrary("WCC6.0")]
	public class IListView : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListView(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListView(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListView(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IListView()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.ListArrangeConstants Arrange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Arrange", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.ListArrangeConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Arrange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IColumnHeaders ColumnHeaders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnHeaders", paramsArray);
				NetOffice.MSComctlLibApi.IColumnHeaders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IColumnHeaders;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColumnHeaders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IListItem DropHighlight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DropHighlight", paramsArray);
				NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IListItem;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DropHighlight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool HideColumnHeaders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HideColumnHeaders", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HideColumnHeaders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool HideSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HideSelection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HideSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public COMObject Icons
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Icons", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Icons", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IListItems ListItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListItems", paramsArray);
				NetOffice.MSComctlLibApi.IListItems newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IListItems;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListItems", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.ListLabelEditConstants LabelEdit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LabelEdit", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.ListLabelEditConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LabelEdit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool LabelWrap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LabelWrap", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LabelWrap", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public stdole.Picture MouseIcon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MouseIcon", paramsArray);
				stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MouseIcon", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.MousePointerConstants MousePointer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MousePointer", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.MousePointerConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MousePointer", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool MultiSelect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MultiSelect", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MultiSelect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IListItem SelectedItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectedItem", paramsArray);
				NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IListItem;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelectedItem", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public COMObject SmallIcons
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmallIcons", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SmallIcons", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool Sorted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sorted", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sorted", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int16 SortKey
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SortKey", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SortKey", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.ListSortOrderConstants SortOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SortOrder", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.ListSortOrderConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SortOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.ListViewConstants View
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "View", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.ListViewConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "View", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.OLEDragConstants OLEDragMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEDragMode", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.OLEDragConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OLEDragMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.OLEDropConstants OLEDropMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEDropMode", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.OLEDropConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OLEDropMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.AppearanceConstants Appearance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Appearance", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.AppearanceConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Appearance", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int32 BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.BorderStyleConstants BorderStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BorderStyle", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.BorderStyleConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BorderStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public stdole.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				stdole.Font newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Font;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Font", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int32 ForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForeColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int32 hWnd
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hWnd", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "hWnd", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool AllowColumnReorder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowColumnReorder", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowColumnReorder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool Checkboxes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Checkboxes", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Checkboxes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool FlatScrollBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FlatScrollBar", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FlatScrollBar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool FullRowSelect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FullRowSelect", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FullRowSelect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool GridLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridLines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool HotTracking
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HotTracking", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HotTracking", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public bool HoverSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HoverSelection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HoverSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public stdole.Picture Picture
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Picture", paramsArray);
				stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Picture", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.ListPictureAlignmentConstants PictureAlignment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PictureAlignment", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.ListPictureAlignmentConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PictureAlignment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public COMObject ColumnHeaderIcons
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnHeaderIcons", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColumnHeaderIcons", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.Enums.ListTextBackgroundConstants TextBackground
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextBackground", paramsArray);
				return (NetOffice.MSComctlLibApi.Enums.ListTextBackgroundConstants)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextBackground", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="sz">string sz</param>
		/// <param name="Where">ref optional object Where</param>
		/// <param name="Index">ref optional object Index</param>
		/// <param name="fPartial">ref optional object fPartial</param>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IListItem FindItem(string sz, ref object where, ref object index, ref object fPartial)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sz, where, index, fPartial);
			object returnItem = Invoker.MethodReturn(this, "FindItem", paramsArray, modifiers);
			NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IListItem;
			where = (object)paramsArray[1];
			index = (object)paramsArray[2];
			fPartial = (object)paramsArray[3];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="sz">string sz</param>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IListItem FindItem(string sz)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sz);
			object returnItem = Invoker.MethodReturn(this, "FindItem", paramsArray);
			NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IListItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IListItem GetFirstVisible()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetFirstVisible", paramsArray);
			NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IListItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IListItem HitTest(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			object returnItem = Invoker.MethodReturn(this, "HitTest", paramsArray);
			NetOffice.MSComctlLibApi.IListItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IListItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public void StartLabelEdit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "StartLabelEdit", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public void OLEDrag()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "OLEDrag", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public void AboutBox()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AboutBox", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}