﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface SmartArt 
    /// SupportByVersion Office, 14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860804.aspx </remarks>
    [SupportByVersion("Office", 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class SmartArt : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.SmartArt
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
                    _type = typeof(SmartArt);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public SmartArt() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864691.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862828.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public NetOffice.OfficeApi.SmartArtNodes AllNodes
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.SmartArtNodes>(this, "AllNodes", typeof(NetOffice.OfficeApi.SmartArtNodes));
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860244.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public NetOffice.OfficeApi.SmartArtNodes Nodes
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.SmartArtNodes>(this, "Nodes", typeof(NetOffice.OfficeApi.SmartArtNodes));
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861866.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public NetOffice.OfficeApi.SmartArtLayout Layout
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.SmartArtLayout>(this, "Layout", typeof(NetOffice.OfficeApi.SmartArtLayout));
            }
            set
            {
                Factory.ExecuteReferencePropertySet(this, "Layout", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862785.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public NetOffice.OfficeApi.SmartArtQuickStyle QuickStyle
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.SmartArtQuickStyle>(this, "QuickStyle", typeof(NetOffice.OfficeApi.SmartArtQuickStyle));
            }
            set
            {
                Factory.ExecuteReferencePropertySet(this, "QuickStyle", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862120.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public NetOffice.OfficeApi.SmartArtColor Color
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.SmartArtColor>(this, "Color", typeof(NetOffice.OfficeApi.SmartArtColor));
            }
            set
            {
                Factory.ExecuteReferencePropertySet(this, "Color", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865245.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public NetOffice.OfficeApi.Enums.MsoTriState Reverse
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoTriState>(this, "Reverse");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "Reverse", value);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864968.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public void Reset()
        {
            Factory.ExecuteMethod(this, "Reset");
        }

        #endregion

        #pragma warning restore
    }
}
