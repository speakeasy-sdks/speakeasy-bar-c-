
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyBar.Models.Requests
{
    using Newtonsoft.Json;
    using SpeakeasyBar.Models.Requests;
    
    public class RequestBody
    {

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("webhook")]
        public Webhook? Webhook { get; set; }
    }
}