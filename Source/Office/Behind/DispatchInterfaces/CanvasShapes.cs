﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface CanvasShapes 
    /// SupportByVersion Office, 10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Method, "Item")]
    public class CanvasShapes : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.CanvasShapes
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
                    _type = typeof(CanvasShapes);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public CanvasShapes() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
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
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public Int32 Count
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Count");
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape Background
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.Shape>(this, "Background", typeof(NetOffice.OfficeApi.Shape));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        [NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
        public NetOffice.OfficeApi.Shape this[object index]
        {
            get
            {
                return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "Item", typeof(NetOffice.OfficeApi.Shape), index);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="type">NetOffice.OfficeApi.Enums.MsoCalloutType type</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddCallout(NetOffice.OfficeApi.Enums.MsoCalloutType type, Single left, Single top, Single width, Single height)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddCallout", typeof(NetOffice.OfficeApi.Shape), new object[] { type, left, top, width, height });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="type">NetOffice.OfficeApi.Enums.MsoConnectorType type</param>
        /// <param name="beginX">Single beginX</param>
        /// <param name="beginY">Single beginY</param>
        /// <param name="endX">Single endX</param>
        /// <param name="endY">Single endY</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddConnector(NetOffice.OfficeApi.Enums.MsoConnectorType type, Single beginX, Single beginY, Single endX, Single endY)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddConnector", typeof(NetOffice.OfficeApi.Shape), new object[] { type, beginX, beginY, endX, endY });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="safeArrayOfPoints">object safeArrayOfPoints</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddCurve(object safeArrayOfPoints)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddCurve", typeof(NetOffice.OfficeApi.Shape), safeArrayOfPoints);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation orientation</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddLabel(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddLabel", typeof(NetOffice.OfficeApi.Shape), new object[] { orientation, left, top, width, height });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="beginX">Single beginX</param>
        /// <param name="beginY">Single beginY</param>
        /// <param name="endX">Single endX</param>
        /// <param name="endY">Single endY</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddLine(Single beginX, Single beginY, Single endX, Single endY)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddLine", typeof(NetOffice.OfficeApi.Shape), beginX, beginY, endX, endY);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="fileName">string fileName</param>
        /// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
        /// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">optional Single Width = -1</param>
        /// <param name="height">optional Single Height = -1</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, object width, object height)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddPicture", typeof(NetOffice.OfficeApi.Shape), new object[] { fileName, linkToFile, saveWithDocument, left, top, width, height });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="fileName">string fileName</param>
        /// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
        /// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        [CustomMethod]
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddPicture", typeof(NetOffice.OfficeApi.Shape), new object[] { fileName, linkToFile, saveWithDocument, left, top });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="fileName">string fileName</param>
        /// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState linkToFile</param>
        /// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">optional Single Width = -1</param>
        [CustomMethod]
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, object width)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddPicture", typeof(NetOffice.OfficeApi.Shape), new object[] { fileName, linkToFile, saveWithDocument, left, top, width });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="safeArrayOfPoints">object safeArrayOfPoints</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddPolyline(object safeArrayOfPoints)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddPolyline", typeof(NetOffice.OfficeApi.Shape), safeArrayOfPoints);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="type">NetOffice.OfficeApi.Enums.MsoAutoShapeType type</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddShape(NetOffice.OfficeApi.Enums.MsoAutoShapeType type, Single left, Single top, Single width, Single height)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddShape", typeof(NetOffice.OfficeApi.Shape), new object[] { type, left, top, width, height });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="presetTextEffect">NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect</param>
        /// <param name="text">string text</param>
        /// <param name="fontName">string fontName</param>
        /// <param name="fontSize">Single fontSize</param>
        /// <param name="fontBold">NetOffice.OfficeApi.Enums.MsoTriState fontBold</param>
        /// <param name="fontItalic">NetOffice.OfficeApi.Enums.MsoTriState fontItalic</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddTextEffect(NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect, string text, string fontName, Single fontSize, NetOffice.OfficeApi.Enums.MsoTriState fontBold, NetOffice.OfficeApi.Enums.MsoTriState fontItalic, Single left, Single top)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddTextEffect", typeof(NetOffice.OfficeApi.Shape), new object[] { presetTextEffect, text, fontName, fontSize, fontBold, fontItalic, left, top });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation orientation</param>
        /// <param name="left">Single left</param>
        /// <param name="top">Single top</param>
        /// <param name="width">Single width</param>
        /// <param name="height">Single height</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.Shape AddTextbox(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.Shape>(this, "AddTextbox", typeof(NetOffice.OfficeApi.Shape), new object[] { orientation, left, top, width, height });
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType editingType</param>
        /// <param name="x1">Single x1</param>
        /// <param name="y1">Single y1</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.FreeformBuilder BuildFreeform(NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.FreeformBuilder>(this, "BuildFreeform", typeof(NetOffice.OfficeApi.FreeformBuilder), editingType, x1, y1);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="index">object index</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public NetOffice.OfficeApi.ShapeRange Range(object index)
        {
            return Factory.ExecuteKnownReferenceMethodGet<NetOffice.OfficeApi.ShapeRange>(this, "Range", typeof(NetOffice.OfficeApi.ShapeRange), index);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public void SelectAll()
        {
            Factory.ExecuteMethod(this, "SelectAll");
        }

        #endregion

        #region IEnumerableProvider<NetOffice.OfficeApi.Shape>

        ICOMObject IEnumerableProvider<NetOffice.OfficeApi.Shape>.GetComObjectEnumerator(ICOMObject parent)
        {
            return NetOffice.Utils.GetComObjectEnumeratorAsProperty(parent, this, false);
        }

        IEnumerable IEnumerableProvider<NetOffice.OfficeApi.Shape>.FetchVariantComObjectEnumerator(ICOMObject parent, ICOMObject enumerator)
        {
            return NetOffice.Utils.FetchVariantComObjectEnumerator(parent, enumerator, false);
        }

        #endregion

        #region IEnumerable<NetOffice.OfficeApi.Shape>

        /// <summary>
        /// SupportByVersion Office, 10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public IEnumerator<NetOffice.OfficeApi.Shape> GetEnumerator()
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.OfficeApi.Shape item in innerEnumerator)
                yield return item;
        }

        #endregion

        #region IEnumerable

        /// <summary>
        /// SupportByVersion Office, 10,11,12,14,15,16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
        {
            return NetOffice.Utils.GetProxyEnumeratorAsProperty(this, false);
        }

        #endregion

        #pragma warning restore
    }
}
