# OrderInput

An order for a drink or ingredient.


## Fields

| Field                                                    | Type                                                     | Required                                                 | Description                                              | Example                                                  |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `ProductCode`                                            | *string*                                                 | :heavy_check_mark:                                       | The product code of the drink or ingredient.             | AC-A2DF3                                                 |
| `Quantity`                                               | *long*                                                   | :heavy_check_mark:                                       | The number of units of the drink or ingredient to order. |                                                          |
| `Type`                                                   | [OrderType](../../Models/Components/OrderType.md)        | :heavy_check_mark:                                       | The type of order.                                       |                                                          |