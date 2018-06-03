﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Name
    /// </summary>
    [SyntaxBypass]
    public class Name_ : COMObject, NetOffice.ExcelApi.Name_
    {
        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public Name_() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840686.aspx
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
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

        #endregion

        #region Methods

        #endregion
    }

    /// <summary>
    /// DispatchInterface Name 
    /// SupportByVersion Excel, 9,10,11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839264.aspx </remarks>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class Name : NetOffice.ExcelApi.Behind.Name_, NetOffice.ExcelApi.Name
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
                    _type = typeof(Name);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public Name() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840386.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Application Application
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835892.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834971.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string _Default
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "_Default");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838235.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public Int32 Index
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Index");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192973.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string Category
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Category");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Category", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821571.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string CategoryLocal
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "CategoryLocal");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "CategoryLocal", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197611.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Enums.XlXLMMacroType MacroType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlXLMMacroType>(this, "MacroType");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "MacroType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834743.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object RefersTo
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "RefersTo");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "RefersTo", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841269.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string ShortcutKey
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "ShortcutKey");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ShortcutKey", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195389.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string Value
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Value");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Value", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193309.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool Visible
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Visible");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Visible", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834392.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string NameLocal
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "NameLocal");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "NameLocal", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840088.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object RefersToLocal
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "RefersToLocal");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "RefersToLocal", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822115.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object RefersToR1C1
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "RefersToR1C1");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "RefersToR1C1", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196221.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object RefersToR1C1Local
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "RefersToR1C1Local");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "RefersToR1C1Local", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834918.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Range RefersToRange
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Range>(this, "RefersToRange", typeof(NetOffice.ExcelApi.Range));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834632.aspx </remarks>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public string Comment
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Comment");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Comment", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194620.aspx </remarks>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public bool WorkbookParameter
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "WorkbookParameter");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WorkbookParameter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841227.aspx </remarks>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public bool ValidWorkbookParameter
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "ValidWorkbookParameter");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197312.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public void Delete()
        {
            Factory.ExecuteMethod(this, "Delete");
        }

        #endregion

        #pragma warning restore
    }
}

