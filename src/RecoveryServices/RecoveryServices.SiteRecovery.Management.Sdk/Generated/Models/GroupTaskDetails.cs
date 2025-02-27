// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This class represents the group task details when parent child
    /// relationship exists in the drill down.
    /// </summary>
    [Newtonsoft.Json.JsonObject("GroupTaskDetails")]
    public partial class GroupTaskDetails
    {
        /// <summary>
        /// Initializes a new instance of the GroupTaskDetails class.
        /// </summary>
        public GroupTaskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupTaskDetails class.
        /// </summary>
        /// <param name="childTasks">The child tasks.</param>
        public GroupTaskDetails(IList<ASRTask> childTasks = default(IList<ASRTask>))
        {
            ChildTasks = childTasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the child tasks.
        /// </summary>
        [JsonProperty(PropertyName = "childTasks")]
        public IList<ASRTask> ChildTasks { get; set; }

    }
}
