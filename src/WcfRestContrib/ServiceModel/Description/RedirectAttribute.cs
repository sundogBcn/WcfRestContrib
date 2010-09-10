﻿using System;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;

namespace WcfRestContrib.ServiceModel.Description
{
    public class RedirectAttribute : Attribute, IOperationBehavior 
    {
        // ────────────────────────── Private Fields ──────────────────────────

        readonly RedirectBehavior _behavior;

        // ────────────────────────── Constructors ──────────────────────────

        public RedirectAttribute(string redirectUrlQuerystringParameter)
        {
            _behavior = new RedirectBehavior(redirectUrlQuerystringParameter);
        }

        // ────────────────────────── IOperationBehavior Members ──────────────────────────

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        { _behavior.ApplyDispatchBehavior(operationDescription, dispatchOperation); }
        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        { _behavior.ApplyClientBehavior(operationDescription, clientOperation); }
        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        { _behavior.AddBindingParameters(operationDescription, bindingParameters); }
        public void Validate(OperationDescription operationDescription)
        { _behavior.Validate(operationDescription); }
    }
}
