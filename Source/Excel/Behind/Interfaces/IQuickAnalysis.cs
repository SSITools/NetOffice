﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface IQuickAnalysis 
	/// SupportByVersion Excel, 15, 16
	/// </summary>
	[SupportByVersion("Excel", 15, 16)]
	[EntityType(EntityType.IsInterface)]
 	public class IQuickAnalysis : COMObject, NetOffice.ExcelApi.IQuickAnalysis
	{
		#pragma warning disable

		#region Type Information

        /// <summary>        /// Instance Type
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
                    _type = typeof(IQuickAnalysis);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IQuickAnalysis() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 15, 16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <param name="xlQuickAnalysisMode">optional NetOffice.ExcelApi.Enums.XlQuickAnalysisMode XlQuickAnalysisMode = 0</param>
		[SupportByVersion("Excel", 15, 16)]
		public Int32 Show(object xlQuickAnalysisMode)
		{
			return Factory.ExecuteInt32MethodGet(this, "Show", xlQuickAnalysisMode);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public Int32 Show()
		{
			return Factory.ExecuteInt32MethodGet(this, "Show");
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		/// <param name="xlQuickAnalysisMode">optional NetOffice.ExcelApi.Enums.XlQuickAnalysisMode XlQuickAnalysisMode = 0</param>
		[SupportByVersion("Excel", 15, 16)]
		public Int32 Hide(object xlQuickAnalysisMode)
		{
			return Factory.ExecuteInt32MethodGet(this, "Hide", xlQuickAnalysisMode);
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		[CustomMethod]
		[SupportByVersion("Excel", 15, 16)]
		public Int32 Hide()
		{
			return Factory.ExecuteInt32MethodGet(this, "Hide");
		}

		#endregion

		#pragma warning restore
	}
}


