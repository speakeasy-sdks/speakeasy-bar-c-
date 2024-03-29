# Ingredients
(*Ingredients*)

## Overview

The ingredients endpoints.

### Available Operations

* [ListIngredients](#listingredients) - Get a list of ingredients.

## ListIngredients

Get a list of ingredients, if authenticated this will include stock levels and product codes otherwise it will only include public information.

### Example Usage

```csharp
using SpeakeasyBar;
using SpeakeasyBar.Models.Components;
using SpeakeasyBar.Models.Requests;
using System.Collections.Generic;

var sdk = new Speakeasy(ApiKey: "<YOUR_API_KEY_HERE>");

ListIngredientsRequest req = new ListIngredientsRequest() {};

var res = await sdk.Ingredients.ListIngredientsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [ListIngredientsRequest](../../Models/Requests/ListIngredientsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[ListIngredientsResponse](../../Models/Requests/ListIngredientsResponse.md)**

