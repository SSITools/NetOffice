﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface ListObjects 
	/// SupportByVersion Excel, 11,12,14,15,16
	/// </summary>	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196851.aspx </remarks>
	[SupportByVersion("Excel", 11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "_Default")]
	public class ListObjects : COMObject, NetOffice.ExcelApi.ListObjects
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ListObjects);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ListObjects() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834429.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822511.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197718.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		public NetOffice.ExcelApi.ListObject this[object index]
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ListObject>(this, "_Default", typeof(NetOffice.ExcelApi.ListObject), index);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837797.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public Int32 Count
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Count");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		/// <param name="linkSource">optional object linkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		/// <param name="destination">optional object destination</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders, object destination)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "Add", typeof(NetOffice.ExcelApi.ListObject), new object[]{ sourceType, source, linkSource, xlListObjectHasHeaders, destination });
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		/// <param name="linkSource">optional object linkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		/// <param name="destination">optional object destination</param>
		/// <param name="tableStyleName">optional object tableStyleName</param>
		[SupportByVersion("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders, object destination, object tableStyleName)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "Add", typeof(NetOffice.ExcelApi.ListObject), new object[]{ sourceType, source, linkSource, xlListObjectHasHeaders, destination, tableStyleName });
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.ListObject Add()
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "Add", typeof(NetOffice.ExcelApi.ListObject));
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "Add", typeof(NetOffice.ExcelApi.ListObject), sourceType);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "Add", typeof(NetOffice.ExcelApi.ListObject), sourceType, source);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		/// <param name="linkSource">optional object linkSource</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source, object linkSource)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "Add", typeof(NetOffice.ExcelApi.ListObject), sourceType, source, linkSource);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823155.aspx </remarks>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		/// <param name="linkSource">optional object linkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.ListObject Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "Add", typeof(NetOffice.ExcelApi.ListObject), sourceType, source, linkSource, xlListObjectHasHeaders);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		/// <param name="linkSource">optional object linkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		/// <param name="destination">optional object destination</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersion("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders, object destination)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "_Add", typeof(NetOffice.ExcelApi.ListObject), new object[]{ sourceType, source, linkSource, xlListObjectHasHeaders, destination });
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.ListObject _Add()
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "_Add", typeof(NetOffice.ExcelApi.ListObject));
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "_Add", typeof(NetOffice.ExcelApi.ListObject), sourceType);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType, object source)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "_Add", typeof(NetOffice.ExcelApi.ListObject), sourceType, source);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		/// <param name="linkSource">optional object linkSource</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType, object source, object linkSource)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "_Add", typeof(NetOffice.ExcelApi.ListObject), sourceType, source, linkSource);
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// </summary>
		/// <param name="sourceType">optional NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType = 1</param>
		/// <param name="source">optional object source</param>
		/// <param name="linkSource">optional object linkSource</param>
		/// <param name="xlListObjectHasHeaders">optional NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders = 0</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.ListObject _Add(object sourceType, object source, object linkSource, object xlListObjectHasHeaders)
		{
			return Factory.ExecuteKnownReferenceMethodGet<NetOffice.ExcelApi.ListObject>(this, "_Add", typeof(NetOffice.ExcelApi.ListObject), sourceType, source, linkSource, xlListObjectHasHeaders);
		}

        #endregion

        #region IEnumerableProvider<NetOffice.ExcelApi.ListObject>

        ICOMObject IEnumerableProvider<NetOffice.ExcelApi.ListObject>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.ExcelApi.ListObject>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.ListObject>

        /// <summary>
        /// SupportByVersion Excel, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        public IEnumerator<NetOffice.ExcelApi.ListObject> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.ListObject item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Excel, 11,12,14,15,16
        /// </summary>
        [SupportByVersion("Excel", 11,12,14,15,16)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
		}

		#endregion

		#pragma warning restore
	}
}

