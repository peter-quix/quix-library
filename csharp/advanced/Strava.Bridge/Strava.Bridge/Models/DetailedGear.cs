/* 
 * Strava API v3
 *
 * The [Swagger Playground](https://developers.strava.com/playground) is the easiest way to familiarize yourself with the Strava API by submitting HTTP requests and observing the responses before you write any client code. It will show what a response will look like with different endpoints depending on the authorization scope you receive from your athletes. To use the Playground, go to https://www.strava.com/settings/api and change your “Authorization Callback Domain” to developers.strava.com. Please note, we only support Swagger 2.0. There is a known issue where you can only select one scope at a time. For more information, please check the section “client code” at https://developers.strava.com/docs.
 *
 * OpenAPI spec version: 3.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
 

namespace IO.Swagger.Model
{
    /// <summary>
    /// DetailedGear
    /// </summary>
    [DataContract]
    public partial class DetailedGear :  IEquatable<DetailedGear>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedGear" /> class.
        /// </summary>
        /// <param name="id">The gear&#39;s unique identifier..</param>
        /// <param name="resourceState">Resource state, indicates level of detail. Possible values: 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot;.</param>
        /// <param name="primary">Whether this gear&#39;s is the owner&#39;s default one..</param>
        /// <param name="name">The gear&#39;s name..</param>
        /// <param name="distance">The distance logged with this gear..</param>
        /// <param name="brandName">The gear&#39;s brand name..</param>
        /// <param name="modelName">The gear&#39;s model name..</param>
        /// <param name="frameType">The gear&#39;s frame type (bike only)..</param>
        /// <param name="description">The gear&#39;s description..</param>
        public DetailedGear(string id = default(string), int? resourceState = default(int?), bool? primary = default(bool?), string name = default(string), float? distance = default(float?), string brandName = default(string), string modelName = default(string), int? frameType = default(int?), string description = default(string))
        {
            this.Id = id;
            this.ResourceState = resourceState;
            this.Primary = primary;
            this.Name = name;
            this.Distance = distance;
            this.BrandName = brandName;
            this.ModelName = modelName;
            this.FrameType = frameType;
            this.Description = description;
        }
        
        /// <summary>
        /// The gear&#39;s unique identifier.
        /// </summary>
        /// <value>The gear&#39;s unique identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Resource state, indicates level of detail. Possible values: 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot;
        /// </summary>
        /// <value>Resource state, indicates level of detail. Possible values: 2 -&gt; \&quot;summary\&quot;, 3 -&gt; \&quot;detail\&quot;</value>
        [DataMember(Name="resource_state", EmitDefaultValue=false)]
        public int? ResourceState { get; set; }

        /// <summary>
        /// Whether this gear&#39;s is the owner&#39;s default one.
        /// </summary>
        /// <value>Whether this gear&#39;s is the owner&#39;s default one.</value>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool? Primary { get; set; }

        /// <summary>
        /// The gear&#39;s name.
        /// </summary>
        /// <value>The gear&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The distance logged with this gear.
        /// </summary>
        /// <value>The distance logged with this gear.</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public float? Distance { get; set; }

        /// <summary>
        /// The gear&#39;s brand name.
        /// </summary>
        /// <value>The gear&#39;s brand name.</value>
        [DataMember(Name="brand_name", EmitDefaultValue=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// The gear&#39;s model name.
        /// </summary>
        /// <value>The gear&#39;s model name.</value>
        [DataMember(Name="model_name", EmitDefaultValue=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// The gear&#39;s frame type (bike only).
        /// </summary>
        /// <value>The gear&#39;s frame type (bike only).</value>
        [DataMember(Name="frame_type", EmitDefaultValue=false)]
        public int? FrameType { get; set; }

        /// <summary>
        /// The gear&#39;s description.
        /// </summary>
        /// <value>The gear&#39;s description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailedGear {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ResourceState: ").Append(ResourceState).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
            sb.Append("  FrameType: ").Append(FrameType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetailedGear);
        }

        /// <summary>
        /// Returns true if DetailedGear instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedGear to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedGear input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ResourceState == input.ResourceState ||
                    (this.ResourceState != null &&
                    this.ResourceState.Equals(input.ResourceState))
                ) && 
                (
                    this.Primary == input.Primary ||
                    (this.Primary != null &&
                    this.Primary.Equals(input.Primary))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.ModelName == input.ModelName ||
                    (this.ModelName != null &&
                    this.ModelName.Equals(input.ModelName))
                ) && 
                (
                    this.FrameType == input.FrameType ||
                    (this.FrameType != null &&
                    this.FrameType.Equals(input.FrameType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ResourceState != null)
                    hashCode = hashCode * 59 + this.ResourceState.GetHashCode();
                if (this.Primary != null)
                    hashCode = hashCode * 59 + this.Primary.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.BrandName != null)
                    hashCode = hashCode * 59 + this.BrandName.GetHashCode();
                if (this.ModelName != null)
                    hashCode = hashCode * 59 + this.ModelName.GetHashCode();
                if (this.FrameType != null)
                    hashCode = hashCode * 59 + this.FrameType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
