﻿using Microsoft.XLANGs.BaseTypes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BizTalkComponents.OrchestrationUtils.UnitTests
{
    internal class MockXLANGMessage : XLANGMessage, IDisposable, IReadOnlyList<XLANGPart>
    {
        private readonly IDictionary<Type, object> _properties = new Dictionary<Type, object>();
        private IList<XLANGPart> _parts = new List<XLANGPart>();
        private IDictionary<string, int> _partsByName = new Dictionary<string, int>();

        public MockXLANGMessage()
        {
            _parts.Add(new MockXLANGPart());
        }

        public override string Name
        {
            get { return "MockXLANGMessage"; }
        }

        public override XLANGPart this[string partName]
        {
            get { return _parts[_partsByName[partName]]; }
        }

        public override void Dispose()
        {
            foreach (var part in _parts)
            {
                part.Dispose();
            }
            _parts = null;
            _partsByName = null;
        }

        public override int Count
        {
            get { return _parts.Count; }
        }

        public override XLANGPart this[int partIndex]
        {
            get { return _parts[partIndex]; }
        }

        IEnumerator<XLANGPart> IEnumerable<XLANGPart>.GetEnumerator()
        {
            return _parts.GetEnumerator();
        }

        public override IEnumerator GetEnumerator()
        {
            IEnumerable<XLANGPart> generic = this;
            return generic.GetEnumerator();
        }

        public override void AddPart(XLANGPart part)
        {
            _parts.Add(part);
        }

        public override void AddPart(object part, string partName)
        {
            var newPart = new MockXLANGPart();
            newPart.LoadFrom(part);
            _parts.Add(newPart);
            _partsByName[partName] = _parts.IndexOf(newPart);
        }

        public override void AddPart(XLANGPart part, string partName)
        {
            _parts.Add(part);
            _partsByName[partName] = _parts.IndexOf(part);
        }

        public override object GetPropertyValue(Type propType)
        {
            return _properties[propType];
        }

        public override void SetPropertyValue(Type propType, object value)
        {
            _properties[propType] = value;
        }
    }
}