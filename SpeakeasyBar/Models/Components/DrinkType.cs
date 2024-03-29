
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyBar.Models.Components
{
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The type of drink.
    /// </summary>
    public enum DrinkType
    {
        [JsonProperty("cocktail")]
        Cocktail,
        [JsonProperty("non-alcoholic")]
        NonAlcoholic,
        [JsonProperty("beer")]
        Beer,
        [JsonProperty("wine")]
        Wine,
        [JsonProperty("spirit")]
        Spirit,
        [JsonProperty("other")]
        Other,
    }

    public static class DrinkTypeExtension
    {
        public static string Value(this DrinkType value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static DrinkType ToEnum(this string value)
        {
            foreach(var field in typeof(DrinkType).GetFields())
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

                    if (enumVal is DrinkType)
                    {
                        return (DrinkType)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum DrinkType");
        }
    }

}