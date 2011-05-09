//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface IBlogPictureExtensibility SupportByLibrary OF12 OF14 
	///</summary>
	[SupportByLibrary("OF12","OF14")]
	public class IBlogPictureExtensibility : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IBlogPictureExtensibility()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="BlogPictureProvider">ref string BlogPictureProvider</param>
		/// <param name="FriendlyName">ref string FriendlyName</param>
		[SupportByLibrary("OF12","OF14")]
		public void BlogPictureProviderProperties(ref string blogPictureProvider, ref string friendlyName)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(blogPictureProvider, friendlyName);
			Invoker.Method(this, "BlogPictureProviderProperties", paramsArray, modifiers);
			blogPictureProvider = (string)paramsArray[0];
			friendlyName = (string)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="BlogProvider">string BlogProvider</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		[SupportByLibrary("OF12","OF14")]
		public void CreatePictureAccount(string account, string blogProvider, Int32 parentWindow, object document)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(account, blogProvider, parentWindow, document);
			Invoker.Method(this, "CreatePictureAccount", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Account">string Account</param>
		/// <param name="ParentWindow">Int32 ParentWindow</param>
		/// <param name="Document">object Document</param>
		/// <param name="Image">object Image</param>
		/// <param name="PictureURI">ref string PictureURI</param>
		/// <param name="ImageType">Int32 ImageType</param>
		[SupportByLibrary("OF12","OF14")]
		public void PublishPicture(string account, Int32 parentWindow, object document, object image, ref string pictureURI, Int32 imageType)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,false,true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(account, parentWindow, document, image, pictureURI, imageType);
			Invoker.Method(this, "PublishPicture", paramsArray, modifiers);
			pictureURI = (string)paramsArray[4];
		}

		#endregion
		#pragma warning restore
	}
}