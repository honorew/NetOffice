//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface Module SupportByLibrary AC09 AC10 AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
	public class Module : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Module()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.AccessApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Line">Int32 Line</param>
		/// <param name="NumLines">Int32 NumLines</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public string get_Lines(Int32 line, Int32 numLines)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, numLines);
			object returnItem = Invoker.PropertyGet(this, "Lines", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public Int32 CountOfLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CountOfLines", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="ProcName">string ProcName</param>
		/// <param name="ProcKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public Int32 get_ProcStartLine(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcStartLine", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="ProcName">string ProcName</param>
		/// <param name="ProcKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public Int32 get_ProcCountLines(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcCountLines", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="ProcName">string ProcName</param>
		/// <param name="ProcKind">NetOffice.VBIDEApi.Enums.vbext_ProcKind ProcKind</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public Int32 get_ProcBodyLine(string procName, NetOffice.VBIDEApi.Enums.vbext_ProcKind procKind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(procName, procKind);
			object returnItem = Invoker.PropertyGet(this, "ProcBodyLine", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Line">Int32 Line</param>
		/// <param name="pprockind">NetOffice.VBIDEApi.Enums.vbext_ProcKind pprockind</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public string get_ProcOfLine(Int32 line, NetOffice.VBIDEApi.Enums.vbext_ProcKind pprockind)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, pprockind);
			object returnItem = Invoker.PropertyGet(this, "ProcOfLine", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public Int32 CountOfDeclarationLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CountOfDeclarationLines", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi.Enums.AcModuleType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.AccessApi.Enums.AcModuleType)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Text">string Text</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void InsertText(string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			Invoker.Method(this, "InsertText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="String">string String</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void AddFromString(string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string);
			Invoker.Method(this, "AddFromString", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void AddFromFile(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "AddFromFile", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Line">Int32 Line</param>
		/// <param name="String">string String</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void InsertLines(Int32 line, string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, _string);
			Invoker.Method(this, "InsertLines", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="StartLine">Int32 StartLine</param>
		/// <param name="Count">Int32 Count</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void DeleteLines(Int32 startLine, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(startLine, count);
			Invoker.Method(this, "DeleteLines", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Line">Int32 Line</param>
		/// <param name="String">string String</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void ReplaceLine(Int32 line, string _string)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(line, _string);
			Invoker.Method(this, "ReplaceLine", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="EventName">string EventName</param>
		/// <param name="ObjectName">string ObjectName</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public Int32 CreateEventProc(string eventName, string objectName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(eventName, objectName);
			object returnItem = Invoker.MethodReturn(this, "CreateEventProc", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Target">string Target</param>
		/// <param name="StartLine">ref Int32 StartLine</param>
		/// <param name="StartColumn">ref Int32 StartColumn</param>
		/// <param name="EndLine">ref Int32 EndLine</param>
		/// <param name="EndColumn">ref Int32 EndColumn</param>
		/// <param name="WholeWord">bool WholeWord</param>
		/// <param name="MatchCase">bool MatchCase</param>
		/// <param name="PatternSearch">bool PatternSearch</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public bool Find(string target, ref Int32 startLine, ref Int32 startColumn, ref Int32 endLine, ref Int32 endColumn, bool wholeWord, bool matchCase, bool patternSearch)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,false,false,false);
			object[] paramsArray = Invoker.ValidateParamsArray(target, startLine, startColumn, endLine, endColumn, wholeWord, matchCase, patternSearch);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			startLine = (Int32)paramsArray[1];
			startColumn = (Int32)paramsArray[2];
			endLine = (Int32)paramsArray[3];
			endColumn = (Int32)paramsArray[4];
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibrary("AC11","AC12","AC14")]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}