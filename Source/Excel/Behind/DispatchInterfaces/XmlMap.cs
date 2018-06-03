﻿using System.Reflection;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface XmlMap 
	/// SupportByVersion Excel, 11,12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196723.aspx </remarks>
	[SupportByVersion("Excel", 11,12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class XmlMap : COMObject, NetOffice.ExcelApi.XmlMap
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
                    _type = typeof(XmlMap);                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public XmlMap() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837973.aspx </remarks>
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
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837435.aspx </remarks>
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
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838579.aspx </remarks>
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
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public string _Default
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "_Default");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821797.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public string Name
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Name");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Name", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff198192.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public bool IsExportable
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "IsExportable");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193545.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public bool ShowImportExportValidationErrors
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "ShowImportExportValidationErrors");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ShowImportExportValidationErrors", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836522.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public bool SaveDataSourceDefinition
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "SaveDataSourceDefinition");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "SaveDataSourceDefinition", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839452.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public bool AdjustColumnWidth
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AdjustColumnWidth");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "AdjustColumnWidth", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834417.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public bool PreserveColumnFilter
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "PreserveColumnFilter");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PreserveColumnFilter", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195992.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public bool PreserveNumberFormatting
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "PreserveNumberFormatting");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "PreserveNumberFormatting", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837963.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public bool AppendOnImport
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "AppendOnImport");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "AppendOnImport", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193360.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public string RootElementName
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "RootElementName");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841104.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.XmlNamespace RootElementNamespace
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.XmlNamespace>(this, "RootElementNamespace", typeof(NetOffice.ExcelApi.XmlNamespace));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835875.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.XmlSchemas Schemas
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.XmlSchemas>(this, "Schemas", typeof(NetOffice.ExcelApi.XmlSchemas));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194288.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.XmlDataBinding DataBinding
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.XmlDataBinding>(this, "DataBinding", typeof(NetOffice.ExcelApi.XmlDataBinding));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194285.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.WorkbookConnection WorkbookConnection
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.WorkbookConnection>(this, "WorkbookConnection", typeof(NetOffice.ExcelApi.WorkbookConnection));
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835524.aspx </remarks>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public void Delete()
		{
			 Factory.ExecuteMethod(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821620.aspx </remarks>
		/// <param name="url">string url</param>
		/// <param name="overwrite">optional object overwrite</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlXmlImportResult Import(string url, object overwrite)
		{
			return Factory.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlImportResult>(this, "Import", url, overwrite);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821620.aspx </remarks>
		/// <param name="url">string url</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlXmlImportResult Import(string url)
		{
			return Factory.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlImportResult>(this, "Import", url);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193320.aspx </remarks>
		/// <param name="xmlData">string xmlData</param>
		/// <param name="overwrite">optional object overwrite</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlXmlImportResult ImportXml(string xmlData, object overwrite)
		{
			return Factory.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlImportResult>(this, "ImportXml", xmlData, overwrite);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193320.aspx </remarks>
		/// <param name="xmlData">string xmlData</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlXmlImportResult ImportXml(string xmlData)
		{
			return Factory.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlImportResult>(this, "ImportXml", xmlData);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194404.aspx </remarks>
		/// <param name="url">string url</param>
		/// <param name="overwrite">optional object overwrite</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlXmlExportResult Export(string url, object overwrite)
		{
			return Factory.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlExportResult>(this, "Export", url, overwrite);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194404.aspx </remarks>
		/// <param name="url">string url</param>
		[CustomMethod]
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlXmlExportResult Export(string url)
		{
			return Factory.ExecuteEnumMethodGet<NetOffice.ExcelApi.Enums.XlXmlExportResult>(this, "Export", url);
		}

		/// <summary>
		/// SupportByVersion Excel 11, 12, 14, 15, 16
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841274.aspx </remarks>
		/// <param name="data">string data</param>
		[SupportByVersion("Excel", 11,12,14,15,16)]
		public NetOffice.ExcelApi.Enums.XlXmlExportResult ExportXml(out string data)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			data = string.Empty;
			object[] paramsArray = Invoker.ValidateParamsArray(data);
			object returnItem = Invoker.MethodReturn(this, "ExportXml", paramsArray, modifiers);
			data = paramsArray[0] as string;
			int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
			return (NetOffice.ExcelApi.Enums.XlXmlExportResult)intReturnItem;
		}

		#endregion

		#pragma warning restore
	}
}


