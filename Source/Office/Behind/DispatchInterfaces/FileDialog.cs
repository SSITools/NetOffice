﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface FileDialog 
    /// SupportByVersion Office, 10,11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862446.aspx </remarks>
    [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class FileDialog : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.FileDialog
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
                    _type = typeof(FileDialog);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public FileDialog() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864165.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860295.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.FileDialogFilters Filters
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.FileDialogFilters>(this, "Filters", typeof(NetOffice.OfficeApi.FileDialogFilters));
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860516.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public Int32 FilterIndex
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "FilterIndex");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "FilterIndex", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863472.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public string Title
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Title");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Title", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863394.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public string ButtonName
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "ButtonName");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ButtonName", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863824.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public bool AllowMultiSelect
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "AllowMultiSelect");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "AllowMultiSelect", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860561.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Enums.MsoFileDialogView InitialView
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoFileDialogView>(this, "InitialView");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "InitialView", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863092.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public string InitialFileName
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "InitialFileName");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "InitialFileName", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863790.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.FileDialogSelectedItems SelectedItems
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.FileDialogSelectedItems>(this, "SelectedItems", typeof(NetOffice.OfficeApi.FileDialogSelectedItems));
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864572.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Enums.MsoFileDialogType DialogType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoFileDialogType>(this, "DialogType");
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864996.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public string Item
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Item");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865217.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public Int32 Show()
        {
            return Factory.ExecuteInt32MethodGet(this, "Show");
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862099.aspx </remarks>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public void Execute()
        {
            Factory.ExecuteMethod(this, "Execute");
        }

        #endregion

        #pragma warning restore
    }
}
