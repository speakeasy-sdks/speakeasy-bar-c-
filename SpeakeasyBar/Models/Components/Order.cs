
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Bar.Models.Components
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// An order for a drink or ingredient.
    /// </summary>
    public class Order
    {

        /// <summary>
        /// The product code of the drink or ingredient.
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode { get; set; } = default!;

        /// <summary>
        /// The number of units of the drink or ingredient to order.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; } = default!;

        /// <summary>
        /// The status of the order.
        /// </summary>
        [JsonProperty("status")]
        public Status Status { get; set; } = default!;

        /// <summary>
        /// The type of order.
        /// </summary>
        [JsonProperty("type")]
        public OrderType Type { get; set; } = default!;
    }
}