/* 
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AdditionalPropertiesClass
    /// </summary>
    [DataContract]
    public partial class AdditionalPropertiesClass :  IEquatable<AdditionalPropertiesClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="mapString">mapString.</param>
        /// <param name="mapNumber">mapNumber.</param>
        /// <param name="mapInteger">mapInteger.</param>
        /// <param name="mapBoolean">mapBoolean.</param>
        /// <param name="mapArrayInteger">mapArrayInteger.</param>
        /// <param name="mapArrayAnytype">mapArrayAnytype.</param>
        /// <param name="mapMapString">mapMapString.</param>
        /// <param name="mapMapAnytype">mapMapAnytype.</param>
        /// <param name="anytype1">anytype1.</param>
        /// <param name="anytype2">anytype2.</param>
        /// <param name="anytype3">anytype3.</param>
        public AdditionalPropertiesClass(Dictionary<string, string> mapString = default(Dictionary<string, string>), Dictionary<string, decimal?> mapNumber = default(Dictionary<string, decimal?>), Dictionary<string, int?> mapInteger = default(Dictionary<string, int?>), Dictionary<string, bool?> mapBoolean = default(Dictionary<string, bool?>), Dictionary<string, List<int?>> mapArrayInteger = default(Dictionary<string, List<int?>>), Dictionary<string, List<Object>> mapArrayAnytype = default(Dictionary<string, List<Object>>), Dictionary<string, Dictionary<string, string>> mapMapString = default(Dictionary<string, Dictionary<string, string>>), Dictionary<string, Dictionary<string, Object>> mapMapAnytype = default(Dictionary<string, Dictionary<string, Object>>), Object anytype1 = default(Object), Object anytype2 = default(Object), Object anytype3 = default(Object))
        {
            this.MapString = mapString;
            this.MapNumber = mapNumber;
            this.MapInteger = mapInteger;
            this.MapBoolean = mapBoolean;
            this.MapArrayInteger = mapArrayInteger;
            this.MapArrayAnytype = mapArrayAnytype;
            this.MapMapString = mapMapString;
            this.MapMapAnytype = mapMapAnytype;
            this.Anytype1 = anytype1;
            this.Anytype2 = anytype2;
            this.Anytype3 = anytype3;
        }
        
        /// <summary>
        /// Gets or Sets MapString
        /// </summary>
        [DataMember(Name="map_string", EmitDefaultValue=false)]
        public Dictionary<string, string> MapString { get; set; }

        /// <summary>
        /// Gets or Sets MapNumber
        /// </summary>
        [DataMember(Name="map_number", EmitDefaultValue=false)]
        public Dictionary<string, decimal?> MapNumber { get; set; }

        /// <summary>
        /// Gets or Sets MapInteger
        /// </summary>
        [DataMember(Name="map_integer", EmitDefaultValue=false)]
        public Dictionary<string, int?> MapInteger { get; set; }

        /// <summary>
        /// Gets or Sets MapBoolean
        /// </summary>
        [DataMember(Name="map_boolean", EmitDefaultValue=false)]
        public Dictionary<string, bool?> MapBoolean { get; set; }

        /// <summary>
        /// Gets or Sets MapArrayInteger
        /// </summary>
        [DataMember(Name="map_array_integer", EmitDefaultValue=false)]
        public Dictionary<string, List<int?>> MapArrayInteger { get; set; }

        /// <summary>
        /// Gets or Sets MapArrayAnytype
        /// </summary>
        [DataMember(Name="map_array_anytype", EmitDefaultValue=false)]
        public Dictionary<string, List<Object>> MapArrayAnytype { get; set; }

        /// <summary>
        /// Gets or Sets MapMapString
        /// </summary>
        [DataMember(Name="map_map_string", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, string>> MapMapString { get; set; }

        /// <summary>
        /// Gets or Sets MapMapAnytype
        /// </summary>
        [DataMember(Name="map_map_anytype", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, Object>> MapMapAnytype { get; set; }

        /// <summary>
        /// Gets or Sets Anytype1
        /// </summary>
        [DataMember(Name="anytype_1", EmitDefaultValue=false)]
        public Object Anytype1 { get; set; }

        /// <summary>
        /// Gets or Sets Anytype2
        /// </summary>
        [DataMember(Name="anytype_2", EmitDefaultValue=false)]
        public Object Anytype2 { get; set; }

        /// <summary>
        /// Gets or Sets Anytype3
        /// </summary>
        [DataMember(Name="anytype_3", EmitDefaultValue=false)]
        public Object Anytype3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalPropertiesClass {\n");
            sb.Append("  MapString: ").Append(MapString).Append("\n");
            sb.Append("  MapNumber: ").Append(MapNumber).Append("\n");
            sb.Append("  MapInteger: ").Append(MapInteger).Append("\n");
            sb.Append("  MapBoolean: ").Append(MapBoolean).Append("\n");
            sb.Append("  MapArrayInteger: ").Append(MapArrayInteger).Append("\n");
            sb.Append("  MapArrayAnytype: ").Append(MapArrayAnytype).Append("\n");
            sb.Append("  MapMapString: ").Append(MapMapString).Append("\n");
            sb.Append("  MapMapAnytype: ").Append(MapMapAnytype).Append("\n");
            sb.Append("  Anytype1: ").Append(Anytype1).Append("\n");
            sb.Append("  Anytype2: ").Append(Anytype2).Append("\n");
            sb.Append("  Anytype3: ").Append(Anytype3).Append("\n");
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
            return this.Equals(input as AdditionalPropertiesClass);
        }

        /// <summary>
        /// Returns true if AdditionalPropertiesClass instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalPropertiesClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalPropertiesClass input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MapString == input.MapString ||
                    this.MapString != null &&
                    this.MapString.SequenceEqual(input.MapString)
                ) && 
                (
                    this.MapNumber == input.MapNumber ||
                    this.MapNumber != null &&
                    this.MapNumber.SequenceEqual(input.MapNumber)
                ) && 
                (
                    this.MapInteger == input.MapInteger ||
                    this.MapInteger != null &&
                    this.MapInteger.SequenceEqual(input.MapInteger)
                ) && 
                (
                    this.MapBoolean == input.MapBoolean ||
                    this.MapBoolean != null &&
                    this.MapBoolean.SequenceEqual(input.MapBoolean)
                ) && 
                (
                    this.MapArrayInteger == input.MapArrayInteger ||
                    this.MapArrayInteger != null &&
                    this.MapArrayInteger.SequenceEqual(input.MapArrayInteger)
                ) && 
                (
                    this.MapArrayAnytype == input.MapArrayAnytype ||
                    this.MapArrayAnytype != null &&
                    this.MapArrayAnytype.SequenceEqual(input.MapArrayAnytype)
                ) && 
                (
                    this.MapMapString == input.MapMapString ||
                    this.MapMapString != null &&
                    this.MapMapString.SequenceEqual(input.MapMapString)
                ) && 
                (
                    this.MapMapAnytype == input.MapMapAnytype ||
                    this.MapMapAnytype != null &&
                    this.MapMapAnytype.SequenceEqual(input.MapMapAnytype)
                ) && 
                (
                    this.Anytype1 == input.Anytype1 ||
                    (this.Anytype1 != null &&
                    this.Anytype1.Equals(input.Anytype1))
                ) && 
                (
                    this.Anytype2 == input.Anytype2 ||
                    (this.Anytype2 != null &&
                    this.Anytype2.Equals(input.Anytype2))
                ) && 
                (
                    this.Anytype3 == input.Anytype3 ||
                    (this.Anytype3 != null &&
                    this.Anytype3.Equals(input.Anytype3))
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
                if (this.MapString != null)
                    hashCode = hashCode * 59 + this.MapString.GetHashCode();
                if (this.MapNumber != null)
                    hashCode = hashCode * 59 + this.MapNumber.GetHashCode();
                if (this.MapInteger != null)
                    hashCode = hashCode * 59 + this.MapInteger.GetHashCode();
                if (this.MapBoolean != null)
                    hashCode = hashCode * 59 + this.MapBoolean.GetHashCode();
                if (this.MapArrayInteger != null)
                    hashCode = hashCode * 59 + this.MapArrayInteger.GetHashCode();
                if (this.MapArrayAnytype != null)
                    hashCode = hashCode * 59 + this.MapArrayAnytype.GetHashCode();
                if (this.MapMapString != null)
                    hashCode = hashCode * 59 + this.MapMapString.GetHashCode();
                if (this.MapMapAnytype != null)
                    hashCode = hashCode * 59 + this.MapMapAnytype.GetHashCode();
                if (this.Anytype1 != null)
                    hashCode = hashCode * 59 + this.Anytype1.GetHashCode();
                if (this.Anytype2 != null)
                    hashCode = hashCode * 59 + this.Anytype2.GetHashCode();
                if (this.Anytype3 != null)
                    hashCode = hashCode * 59 + this.Anytype3.GetHashCode();
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
