# Template SDK

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>   
</div>

## How to use this repository

**👀** This template repository is designed to bootstrap a [Speakeasy managed SDK repository](https://speakeasyapi.dev/docs/create-client-sdks/) using Github's repository clone feature. Once this repository is setup it will automatically keep your SDK up to date and published to a package manager. 


### Creating an SDK

1. To get started, simply clone the repository by clicking on the "Use template" button and give it a name.
   
![Screenshot 2023-09-06 at 09 20 52](https://github.com/speakeasy-sdks/template-sdk/assets/68016351/b4cf4e43-db4e-455a-9359-0f09f942b997)

3. Configure the Speakeasy workflow to generate the SDK. Go to the [generation workflow file](https://github.com/speakeasy-sdks/template-sdk/blob/main/.github/workflows/speakeasy_sdk_generation.yml) and configure the `language`, `mode` and `location` of your openapi document. For complete documentation on all the available generation configurations, see [here](https://speakeasyapi.dev/docs/create-client-sdks/advanced-setup/github-setup/). You will also need to add a `SPEAKEASY_API_KEY` as a repository secret. If you don't already have a key you can get one by making a workspace on Speakeasy [here](https://app.speakeasyapi.dev/workspaces/cl6augut900003b6b06012z1s).

4. Configure the Speakeasy workflow to publish the SDK. Go to the [publishing workflow file](https://github.com/speakeasy-sdks/template-sdk/blob/main/.github/workflows/speakeasy_sdk_publish.yml) and configure any relevant package manager credentials as repository secrets. For complete documentation on all the available publishing configurations, see [here](https://speakeasyapi.dev/docs/package-publishing/).

5. Configure the generation by editing the `gen.yaml` file in the root of the repo. This file controls the generator and determines various attributes of the SDK like `packageName`, `sdkClassName`, inlining of parameters, and other ergonomics.

6. Finally go to the Actions tab, choose the generation workflow and click "Force Generate". This will trigger a new generation of your SDK using the configuration you provided above. Depending on whether you configured `pr` or `direct` mode above your updated SDK will appear in PR or in the main branch.

![Screenshot 2023-09-06 at 10 01 46](https://github.com/speakeasy-sdks/template-sdk/assets/68016351/35828982-c6de-4a5c-84f5-ae2b4224cece)

🚀 You should have a working SDK for your API 🙂 . To check out all the features of the SDK please see our docs [site](https://speakeasyapi.dev/docs/create-client-sdks/).

### Local development

Once you have the SDK setup you may want to iterate on the SDK. Speakeasy supports OpenAPI vendor extensions that can be added to your spec to customize the SDK ergonomics (method names, namespacing resources etc.) and functionality (adding retries, pagination, multiple server support etc)

To get started install the Speakeasy CLI.

In your terminal, run:

```bash
brew install speakeasy-api/homebrew-tap/speakeasy
```
Once you annonate your spec with an extension you will want to run `speakeasy validate` to check the spec for correctness and `speakeasy generate` to recreate the SDK locally. More documentation on OpenAPI extensions [here](https://speakeasyapi.dev/docs/customize-sdks/namespaces/). Here's an example of adding a multiple server support to the spec so that your SDK supports production and sandbox versions of your API. 

```yaml
info:
  title: Example
  version: 0.0.1
servers:
  - url: https://prod.example.com # Used as the default URL by the SDK
    description: Our production environment
    x-speakeasy-server-id: prod
  - url: https://sandbox.example.com
    description: Our sandbox environment
    x-speakeasy-server-id: sandbox
```

Once you're finished iterating and happy with the output push only the latest version of spec into the repo and regenerate the SDK using step 6 above.

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package Speakeasy.Bar
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using SpeakeasyBar;
using SpeakeasyBar.Models.Components;
using SpeakeasyBar.Models.Requests;

var sdk = new Speakeasy();

ListDrinksRequest req = new ListDrinksRequest() {};

var res = await sdk.Drinks.ListDrinksAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Authentication](docs/sdks/authentication/README.md)

* [Authenticate](docs/sdks/authentication/README.md#authenticate) - Authenticate with the API by providing a username and password.

### [Drinks](docs/sdks/drinks/README.md)

* [GetDrink](docs/sdks/drinks/README.md#getdrink) - Get a drink.
* [ListDrinks](docs/sdks/drinks/README.md#listdrinks) - Get a list of drinks.

### [Ingredients](docs/sdks/ingredients/README.md)

* [ListIngredients](docs/sdks/ingredients/README.md#listingredients) - Get a list of ingredients.

### [Orders](docs/sdks/orders/README.md)

* [CreateOrder](docs/sdks/orders/README.md#createorder) - Create an order.

### [Config](docs/sdks/config/README.md)

* [SubscribeToWebhooks](docs/sdks/config/README.md#subscribetowebhooks) - Subscribe to webhooks.
<!-- End Available Resources and Operations [operations] -->





<!-- Start Error Handling -->
# Error Handling

Handling errors in your SDK should largely match your expectations.  All operations return a response object or throw an error.  If Error objects are specified in your OpenAPI Spec, the SDK will throw the appropriate Error type.


## Example

```typescript
import { Speakeasy } from "speakeasy-bar";

(async() => {
  const sdk = new Speakeasy({
    apiKey: "",
  });

  
  let res;
  try {
    res = await sdk.authentication.authenticate({});
  } catch (e) { 
    } else if (e instanceof APIError) {
      console.error(e) // handle exception 
    
  }


  if (res.statusCode == 200) {
    // handle response
  }
})();
```
<!-- End Error Handling -->



<!-- Start Custom HTTP Client -->
# Custom HTTP Client

The Typescript SDK makes API calls using the (axios)[https://axios-http.com/docs/intro] HTTP library.  In order to provide a convenient way to configure timeouts, cookies, proxies, custom headers, and other low-level configuration, you can initialize the SDK client with a custom `AxiosInstance` object.


For example, you could specify a header for every request that your sdk makes as follows:

```typescript
from speakeasy-bar import Speakeasy;
import axios;

const httpClient = axios.create({
    headers: {'x-custom-header': 'someValue'}
})


const sdk = new Speakeasy({defaultClient: httpClient});
```
<!-- End Custom HTTP Client -->



<!-- Start Server Selection [server] -->
## Server Selection

## Server Selection

### Select Server by Name

You can override the default server globally by passing a server name to the `server: string` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the names associated with the available servers:

| Name | Server | Variables |
| ----- | ------ | --------- |
| `prod` | `https://speakeasy.bar` | None |
| `staging` | `https://staging.speakeasy.bar` | None |
| `customer` | `https://{organization}.{environment}.speakeasy.bar` | `0` (default is `prod`), `1` (default is `api`) |


#### Variables

Some of the server options above contain variables. If you want to set the values of those variables, the following options are provided for doing so:
 * `environment: ServerEnvironment`
 * `organization: string`

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name     | Type     | Scheme   |
| -------- | -------- | -------- |
| `ApiKey` | apiKey   | API key  |

To authenticate with the API the `ApiKey` parameter must be set when initializing the SDK client instance. For example:
```csharp
using SpeakeasyBar;
using SpeakeasyBar.Models.Components;
using SpeakeasyBar.Models.Requests;

var sdk = new Speakeasy(ApiKey: "<YOUR_API_KEY_HERE>");

AuthenticateRequestBody req = new AuthenticateRequestBody() {};

var res = await sdk.Authentication.AuthenticateAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->



### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release !

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
