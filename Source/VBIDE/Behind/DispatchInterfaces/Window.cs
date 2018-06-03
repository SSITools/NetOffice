﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VBIDEApi.Behind
{
    /// <summary>
    /// DispatchInterface Window
    /// SupportByVersion VBIDE, 12,14,5.3
    /// </summary>
    [SupportByVersion("VBIDE", 12, 14, 5.3)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class Window : COMObject, NetOffice.VBIDEApi.Window
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
                    _type = typeof(Window);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Window() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public NetOffice.VBIDEApi.VBE VBE
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.VBIDEApi.VBE>(this, "VBE", typeof(NetOffice.VBIDEApi.VBE));
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public NetOffice.VBIDEApi.Windows Collection
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.VBIDEApi.Windows>(this, "Collection", typeof(NetOffice.VBIDEApi.Windows));
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public string Caption
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Caption");
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get/Set
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
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
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get/Set
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public Int32 Left
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Left");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Left", value);
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get/Set
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public Int32 Top
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Top");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Top", value);
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get/Set
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public Int32 Width
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Width");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Width", value);
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get/Set
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public Int32 Height
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Height");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Height", value);
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get/Set
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public NetOffice.VBIDEApi.Enums.vbext_WindowState WindowState
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.VBIDEApi.Enums.vbext_WindowState>(this, "WindowState");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "WindowState", value);
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public NetOffice.VBIDEApi.Enums.vbext_WindowType Type
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.VBIDEApi.Enums.vbext_WindowType>(this, "Type");
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public NetOffice.VBIDEApi.LinkedWindows LinkedWindows
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.VBIDEApi.LinkedWindows>(this, "LinkedWindows", typeof(NetOffice.VBIDEApi.LinkedWindows));
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public NetOffice.VBIDEApi.Window LinkedWindowFrame
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.VBIDEApi.Window>(this, "LinkedWindowFrame", typeof(NetOffice.VBIDEApi.Window));
            }
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// Get
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Int32 HWnd
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "HWnd");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void Close()
        {
            Factory.ExecuteMethod(this, "Close");
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void SetFocus()
        {
            Factory.ExecuteMethod(this, "SetFocus");
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="eKind">NetOffice.VBIDEApi.Enums.vbext_WindowType eKind</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void SetKind(NetOffice.VBIDEApi.Enums.vbext_WindowType eKind)
        {
            Factory.ExecuteMethod(this, "SetKind", eKind);
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void Detach()
        {
            Factory.ExecuteMethod(this, "Detach");
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="lWindowHandle">Int32 lWindowHandle</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void Attach(Int32 lWindowHandle)
        {
            Factory.ExecuteMethod(this, "Attach", lWindowHandle);
        }

        #endregion

        #pragma warning restore
    }
}
