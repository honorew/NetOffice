//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface MailingLabel SupportByLibrary WD09 WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
	public class MailingLabel : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailingLabel(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailingLabel(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailingLabel(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailingLabel()
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
		public bool DefaultPrintBarCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultPrintBarCode", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultPrintBarCode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdPaperTray DefaultLaserTray
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultLaserTray", paramsArray);
				return (NetOffice.WordApi.Enums.WdPaperTray)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultLaserTray", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.CustomLabels CustomLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomLabels", paramsArray);
				NetOffice.WordApi.CustomLabels newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.CustomLabels;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string DefaultLabelName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultLabelName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultLabelName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool Vertical
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Vertical", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Vertical", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD09 
		/// </summary>
		/// <param name="Name">ref optional object Name</param>
		/// <param name="Address">ref optional object Address</param>
		/// <param name="AutoText">ref optional object AutoText</param>
		/// <param name="ExtractAddress">ref optional object ExtractAddress</param>
		/// <param name="LaserTray">ref optional object LaserTray</param>
		[SupportByLibrary("WD09")]
		public NetOffice.WordApi.Document CreateNewDocument(ref object name, ref object address, ref object autoText, ref object extractAddress, ref object laserTray)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, autoText, extractAddress, laserTray);
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument", paramsArray, modifiers);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			name = (object)paramsArray[0];
			address = (object)paramsArray[1];
			autoText = (object)paramsArray[2];
			extractAddress = (object)paramsArray[3];
			laserTray = (object)paramsArray[4];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Name">ref optional object Name</param>
		/// <param name="Address">ref optional object Address</param>
		/// <param name="AutoText">ref optional object AutoText</param>
		/// <param name="ExtractAddress">ref optional object ExtractAddress</param>
		/// <param name="LaserTray">ref optional object LaserTray</param>
		/// <param name="PrintEPostageLabel">ref optional object PrintEPostageLabel</param>
		/// <param name="Vertical">ref optional object Vertical</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Document CreateNewDocument(ref object name, ref object address, ref object autoText, ref object extractAddress, ref object laserTray, ref object printEPostageLabel, ref object vertical)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, autoText, extractAddress, laserTray, printEPostageLabel, vertical);
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument", paramsArray, modifiers);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			name = (object)paramsArray[0];
			address = (object)paramsArray[1];
			autoText = (object)paramsArray[2];
			extractAddress = (object)paramsArray[3];
			laserTray = (object)paramsArray[4];
			printEPostageLabel = (object)paramsArray[5];
			vertical = (object)paramsArray[6];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Document CreateNewDocument()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 
		/// </summary>
		/// <param name="Name">ref optional object Name</param>
		/// <param name="Address">ref optional object Address</param>
		/// <param name="ExtractAddress">ref optional object ExtractAddress</param>
		/// <param name="LaserTray">ref optional object LaserTray</param>
		/// <param name="SingleLabel">ref optional object SingleLabel</param>
		/// <param name="Row">ref optional object Row</param>
		/// <param name="Column">ref optional object Column</param>
		[SupportByLibrary("WD09")]
		public void PrintOut(ref object name, ref object address, ref object extractAddress, ref object laserTray, ref object singleLabel, ref object row, ref object column)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, extractAddress, laserTray, singleLabel, row, column);
			Invoker.Method(this, "PrintOut", paramsArray, modifiers);
			name = (object)paramsArray[0];
			address = (object)paramsArray[1];
			extractAddress = (object)paramsArray[2];
			laserTray = (object)paramsArray[3];
			singleLabel = (object)paramsArray[4];
			row = (object)paramsArray[5];
			column = (object)paramsArray[6];
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Name">ref optional object Name</param>
		/// <param name="Address">ref optional object Address</param>
		/// <param name="ExtractAddress">ref optional object ExtractAddress</param>
		/// <param name="LaserTray">ref optional object LaserTray</param>
		/// <param name="SingleLabel">ref optional object SingleLabel</param>
		/// <param name="Row">ref optional object Row</param>
		/// <param name="Column">ref optional object Column</param>
		/// <param name="PrintEPostageLabel">ref optional object PrintEPostageLabel</param>
		/// <param name="Vertical">ref optional object Vertical</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public void PrintOut(ref object name, ref object address, ref object extractAddress, ref object laserTray, ref object singleLabel, ref object row, ref object column, ref object printEPostageLabel, ref object vertical)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, extractAddress, laserTray, singleLabel, row, column, printEPostageLabel, vertical);
			Invoker.Method(this, "PrintOut", paramsArray, modifiers);
			name = (object)paramsArray[0];
			address = (object)paramsArray[1];
			extractAddress = (object)paramsArray[2];
			laserTray = (object)paramsArray[3];
			singleLabel = (object)paramsArray[4];
			row = (object)paramsArray[5];
			column = (object)paramsArray[6];
			printEPostageLabel = (object)paramsArray[7];
			vertical = (object)paramsArray[8];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void PrintOut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Name">ref optional object Name</param>
		/// <param name="Address">ref optional object Address</param>
		/// <param name="AutoText">ref optional object AutoText</param>
		/// <param name="ExtractAddress">ref optional object ExtractAddress</param>
		/// <param name="LaserTray">ref optional object LaserTray</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Document CreateNewDocument2000(ref object name, ref object address, ref object autoText, ref object extractAddress, ref object laserTray)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, autoText, extractAddress, laserTray);
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument2000", paramsArray, modifiers);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			name = (object)paramsArray[0];
			address = (object)paramsArray[1];
			autoText = (object)paramsArray[2];
			extractAddress = (object)paramsArray[3];
			laserTray = (object)paramsArray[4];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Document CreateNewDocument2000()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocument2000", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Name">ref optional object Name</param>
		/// <param name="Address">ref optional object Address</param>
		/// <param name="ExtractAddress">ref optional object ExtractAddress</param>
		/// <param name="LaserTray">ref optional object LaserTray</param>
		/// <param name="SingleLabel">ref optional object SingleLabel</param>
		/// <param name="Row">ref optional object Row</param>
		/// <param name="Column">ref optional object Column</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public void PrintOut2000(ref object name, ref object address, ref object extractAddress, ref object laserTray, ref object singleLabel, ref object row, ref object column)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(name, address, extractAddress, laserTray, singleLabel, row, column);
			Invoker.Method(this, "PrintOut2000", paramsArray, modifiers);
			name = (object)paramsArray[0];
			address = (object)paramsArray[1];
			extractAddress = (object)paramsArray[2];
			laserTray = (object)paramsArray[3];
			singleLabel = (object)paramsArray[4];
			row = (object)paramsArray[5];
			column = (object)paramsArray[6];
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public void PrintOut2000()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOut2000", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public void LabelOptions()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "LabelOptions", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="LabelID">ref optional object LabelID</param>
		/// <param name="Address">ref optional object Address</param>
		/// <param name="AutoText">ref optional object AutoText</param>
		/// <param name="ExtractAddress">ref optional object ExtractAddress</param>
		/// <param name="LaserTray">ref optional object LaserTray</param>
		/// <param name="PrintEPostageLabel">ref optional object PrintEPostageLabel</param>
		/// <param name="Vertical">ref optional object Vertical</param>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.Document CreateNewDocumentByID(ref object labelID, ref object address, ref object autoText, ref object extractAddress, ref object laserTray, ref object printEPostageLabel, ref object vertical)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(labelID, address, autoText, extractAddress, laserTray, printEPostageLabel, vertical);
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocumentByID", paramsArray, modifiers);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			labelID = (object)paramsArray[0];
			address = (object)paramsArray[1];
			autoText = (object)paramsArray[2];
			extractAddress = (object)paramsArray[3];
			laserTray = (object)paramsArray[4];
			printEPostageLabel = (object)paramsArray[5];
			vertical = (object)paramsArray[6];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.Document CreateNewDocumentByID()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateNewDocumentByID", paramsArray);
			NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="LabelID">ref optional object LabelID</param>
		/// <param name="Address">ref optional object Address</param>
		/// <param name="ExtractAddress">ref optional object ExtractAddress</param>
		/// <param name="LaserTray">ref optional object LaserTray</param>
		/// <param name="SingleLabel">ref optional object SingleLabel</param>
		/// <param name="Row">ref optional object Row</param>
		/// <param name="Column">ref optional object Column</param>
		/// <param name="PrintEPostageLabel">ref optional object PrintEPostageLabel</param>
		/// <param name="Vertical">ref optional object Vertical</param>
		[SupportByLibrary("WD12","WD14")]
		public void PrintOutByID(ref object labelID, ref object address, ref object extractAddress, ref object laserTray, ref object singleLabel, ref object row, ref object column, ref object printEPostageLabel, ref object vertical)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(labelID, address, extractAddress, laserTray, singleLabel, row, column, printEPostageLabel, vertical);
			Invoker.Method(this, "PrintOutByID", paramsArray, modifiers);
			labelID = (object)paramsArray[0];
			address = (object)paramsArray[1];
			extractAddress = (object)paramsArray[2];
			laserTray = (object)paramsArray[3];
			singleLabel = (object)paramsArray[4];
			row = (object)paramsArray[5];
			column = (object)paramsArray[6];
			printEPostageLabel = (object)paramsArray[7];
			vertical = (object)paramsArray[8];
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public void PrintOutByID()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PrintOutByID", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}