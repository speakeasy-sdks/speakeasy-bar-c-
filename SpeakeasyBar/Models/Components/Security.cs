
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
    using SpeakeasyBar.Utils;
    
    public class Security
    {

        [SpeakeasyMetadata("security:scheme=true,type=apiKey,subType=header,name=Authorization")]
        public string ApiKey { get; set; } = default!;
    }
}