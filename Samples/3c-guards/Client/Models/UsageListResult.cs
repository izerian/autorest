// Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Storage.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The List Usages operation response.
    /// </summary>
    public partial class UsageListResult
    {
        /// <summary>
        /// Initializes a new instance of the UsageListResult class.
        /// </summary>
        public UsageListResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UsageListResult class.
        /// </summary>
        /// <param name="value">Gets or sets the list Storage Resource
        /// Usages.</param>
        public UsageListResult(IList<Usage> value = default(IList<Usage>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list Storage Resource Usages.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Usage> Value { get; set; }

    }
}
