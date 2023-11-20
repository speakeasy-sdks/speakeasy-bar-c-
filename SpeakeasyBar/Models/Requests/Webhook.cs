
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Bar.Models.Requests
{
    using Newtonsoft.Json;
    using System;
    
    public enum Webhook
    {
        [JsonProperty("stockUpdate")]
        StockUpdate,
    }

    public static class WebhookExtension
    {
        public static string Value(this Webhook value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Webhook ToEnum(this string value)
        {
            foreach(var field in typeof(Webhook).GetFields())
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

                    if (enumVal is Webhook)
                    {
                        return (Webhook)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Webhook");
        }
    }
}