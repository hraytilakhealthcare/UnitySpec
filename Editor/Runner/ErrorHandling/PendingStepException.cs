using System;
using System.Runtime.Serialization;

// the exceptions are part of the public API, keep them in TechTalk.SpecFlow namespace
// ReSharper disable once CheckNamespace
namespace UnitySpec.ErrorHandling
{
    [Serializable]
    public class PendingStepException : SpecFlowException
    {
        public PendingStepException()
            : base("One or more step definitions are not implemented yet.")
        {
        }

        public PendingStepException(string message) : base(message)
        {
        }

        protected PendingStepException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}