
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Speakeasy.Bar
{
    using Newtonsoft.Json;
    using Speakeasy.Bar.Models.Components;
    using Speakeasy.Bar.Models.Requests;
    using Speakeasy.Bar.Utils;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// The drinks endpoints.
    /// </summary>
    public interface IDrinks
    {

        /// <summary>
        /// Get a drink.
        /// 
        /// <remarks>
        /// Get a drink by name, if authenticated this will include stock levels and product codes otherwise it will only include public information.
        /// </remarks>
        /// </summary>
        Task<GetDrinkResponse> GetDrinkAsync(GetDrinkRequest? request = null);

        /// <summary>
        /// Get a list of drinks.
        /// 
        /// <remarks>
        /// Get a list of drinks, if authenticated this will include stock levels and product codes otherwise it will only include public information.
        /// </remarks>
        /// </summary>
        Task<ListDrinksResponse> ListDrinksAsync(ListDrinksRequest? request = null);
    }

    /// <summary>
    /// The drinks endpoints.
    /// </summary>
    public class Drinks: IDrinks
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "2.233.2";
        private const string _openapiDocVersion = "1.0.0";
        private const string _userAgent = "speakeasy-sdk/csharp 0.0.1 2.233.2 1.0.0 Speakeasy.Bar";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private ISpeakeasyHttpClient _securityClient;

        public Drinks(ISpeakeasyHttpClient defaultClient, ISpeakeasyHttpClient securityClient, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        public async Task<GetDrinkResponse> GetDrinkAsync(GetDrinkRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/drink/{name}", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _securityClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new GetDrinkResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Drink = JsonConvert.DeserializeObject<Drink>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode >= 500 && response.StatusCode < 600))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.APIError = JsonConvert.DeserializeObject<APIError>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        

        public async Task<ListDrinksResponse> ListDrinksAsync(ListDrinksRequest? request = null)
        {
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/drinks", request);
            
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            
            
            var client = _defaultClient;
            
            var httpResponse = await client.SendAsync(httpRequest);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            
            var response = new ListDrinksResponse
            {
                StatusCode = (int)httpResponse.StatusCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };
            
            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Classes = JsonConvert.DeserializeObject<List<Drink>>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            if((response.StatusCode >= 500 && response.StatusCode < 600))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.APIError = JsonConvert.DeserializeObject<APIError>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
                }
                
                return response;
            }
            response.Error = JsonConvert.DeserializeObject<Error>(await httpResponse.Content.ReadAsStringAsync(), new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new EnumSerializer() }});
            return response;
        }
        
    }
}