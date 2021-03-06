// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Payments
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    

    /// <summary>
    /// Indicates a set of supported payment methods and any associated
    /// payment method specific data for those methods
    /// </summary>
    public partial class PaymentMethodData
    {
        /// <summary>
        /// Initializes a new instance of the PaymentMethodData class.
        /// </summary>
        public PaymentMethodData() { }

        /// <summary>
        /// Initializes a new instance of the PaymentMethodData class.
        /// </summary>
        public PaymentMethodData(IList<string> supportedMethods = default(IList<string>), object data = default(object))
        {
            SupportedMethods = supportedMethods;
            Data = data;
        }

        /// <summary>
        /// Required sequence of strings containing payment method identifiers
        /// for payment methods that the merchant web site accepts
        /// </summary>
        [JsonProperty(PropertyName = "supportedMethods")]
        public IList<string> SupportedMethods { get; set; }

        /// <summary>
        /// A JSON-serializable object that provides optional information that
        /// might be needed by the supported payment methods
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

    }
}
