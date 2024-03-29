
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
    using SpeakeasyBar.Models.Components;
    
    public class DrinkInput
    {

        /// <summary>
        /// The name of the drink.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The price of one unit of the drink in US cents.
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; } = default!;

        /// <summary>
        /// The product code of the drink, only available when authenticated.
        /// </summary>
        [JsonProperty("productCode")]
        public string? ProductCode { get; set; }

        /// <summary>
        /// The type of drink.
        /// </summary>
        [JsonProperty("type")]
        public DrinkType? Type { get; set; }
    }
}