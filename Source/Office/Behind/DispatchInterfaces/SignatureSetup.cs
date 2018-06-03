﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface SignatureSetup 
    /// SupportByVersion Office, 12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865226.aspx </remarks>
    [SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class SignatureSetup : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.SignatureSetup
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
                    _type = typeof(SignatureSetup);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public SignatureSetup() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860803.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public bool ReadOnly
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "ReadOnly");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863130.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public string Id
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Id");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863744.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public string SignatureProvider
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SignatureProvider");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860539.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public string SuggestedSigner
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SuggestedSigner");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SuggestedSigner", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862848.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public string SuggestedSignerLine2
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SuggestedSignerLine2");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SuggestedSignerLine2", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861399.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public string SuggestedSignerEmail
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SuggestedSignerEmail");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SuggestedSignerEmail", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861142.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public string SigningInstructions
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SigningInstructions");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SigningInstructions", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860571.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public bool AllowComments
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "AllowComments");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "AllowComments", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861064.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public bool ShowSignDate
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "ShowSignDate");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ShowSignDate", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864950.aspx </remarks>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public string AdditionalXml
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "AdditionalXml");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "AdditionalXml", value);
            }
        }

        #endregion

        #region Methods

        #endregion

        #pragma warning restore
    }
}
