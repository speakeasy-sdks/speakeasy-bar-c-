
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of order.
    /// </summary>
    public enum OrderType
    {
        [JsonProperty("drink")]
        Drink,
        [JsonProperty("ingredient")]
        Ingredient,
    }

    public static class OrderTypeExtension
    {
        public static string Value(this OrderType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static OrderType ToEnum(this string value)
        {
            foreach(var field in typeof(OrderType).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is OrderType)
                    {
                        return (OrderType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum OrderType");
        }
    }
}