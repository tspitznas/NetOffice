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
	/// DispatchInterface Sync SupportByLibrary Office, 11,12,14
	///</summary>
	[SupportByLibrary("Office", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Sync : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Sync(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Sync(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Sync(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Sync()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoSyncStatusType Status
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Status", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoSyncStatusType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public string WorkspaceLastChangedBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WorkspaceLastChangedBy", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public object LastSyncTime
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastSyncTime", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoSyncErrorType ErrorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ErrorType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoSyncErrorType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public void GetUpdate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "GetUpdate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public void PutUpdate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PutUpdate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="SyncVersionType">NetOffice.OfficeApi.Enums.MsoSyncVersionType SyncVersionType</param>
		[SupportByLibrary("Office", 11,12,14)]
		public void OpenVersion(NetOffice.OfficeApi.Enums.MsoSyncVersionType syncVersionType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(syncVersionType);
			Invoker.Method(this, "OpenVersion", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="SyncConflictResolution">NetOffice.OfficeApi.Enums.MsoSyncConflictResolutionType SyncConflictResolution</param>
		[SupportByLibrary("Office", 11,12,14)]
		public void ResolveConflict(NetOffice.OfficeApi.Enums.MsoSyncConflictResolutionType syncConflictResolution)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(syncConflictResolution);
			Invoker.Method(this, "ResolveConflict", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 11,12,14)]
		public void Unsuspend()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Unsuspend", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}