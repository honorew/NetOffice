//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void OlkContactPhoto_ClickEventHandler();
	public delegate void OlkContactPhoto_DoubleClickEventHandler();
	public delegate void OlkContactPhoto_MouseDownEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkContactPhoto_MouseMoveEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkContactPhoto_MouseUpEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkContactPhoto_EnterEventHandler();
	public delegate void OlkContactPhoto_ExitEventHandler(ref bool Cancel);
	public delegate void OlkContactPhoto_KeyDownEventHandler(ref Int32 KeyCode, NetOffice.OutlookApi.Enums.OlShiftState Shift);
	public delegate void OlkContactPhoto_KeyPressEventHandler(ref Int32 KeyAscii);
	public delegate void OlkContactPhoto_KeyUpEventHandler(ref Int32 KeyCode, NetOffice.OutlookApi.Enums.OlShiftState Shift);
	public delegate void OlkContactPhoto_ChangeEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass OlkContactPhoto SupportByLibrary OL12 OL14 
	///</summary>
	[SupportByLibrary("OL12","OL14")]
	public class OlkContactPhoto : _OlkContactPhoto, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		OlkContactPhotoEvents_SinkHelper _olkContactPhotoEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkContactPhoto(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkContactPhoto(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkContactPhoto(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public OlkContactPhoto()
		{
			CreateFromProgId("Outlook.OlkContactPhoto");
		}
		
		/// <param name="progId">progId</param>
		public OlkContactPhoto(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, OlkContactPhotoEvents_SinkHelper.Id);


			if(OlkContactPhotoEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_olkContactPhotoEvents_SinkHelper = new OlkContactPhotoEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_DoubleClickEventHandler _DoubleClickEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_DoubleClickEventHandler DoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_DoubleClickEvent += value;
			}
			remove
			{
				_DoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkContactPhoto_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkContactPhoto_ChangeEventHandler ChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ChangeEvent += value;
			}
			remove
			{
				_ChangeEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _olkContactPhotoEvents_SinkHelper)
			{
				_olkContactPhotoEvents_SinkHelper.Dispose();
				_olkContactPhotoEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}