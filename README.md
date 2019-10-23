# SuperMarketRegister
Basic app developed to a pre-defined test (See `Tests.cs`)  

Class library that takes several sets of (quantity, item name, price) and outputs them into receipted format when `.ToString()` is called on it.

## Prerequisites
.NET Core 3.0 Runtime

## Usage
Download this project and add it as a project reference


## Example Usage

### Convenience Store
```
var receipt = new Receipt();
receipt.AddItem(1, "Candy Bar", 0.50m);
receipt.AddItem(2, "Soda", 1);
```

`receipt.ToString()` will be equal to

```
1 Candy Bar @ $0.50 = $0.50
2 Soda @ $1.00 = $2.00
SubTotal = $2.50
Tax (10%) = $0.25
Total = $2.75
```

### Groceries
```
var receipt = new Receipt();
receipt.AddItem(1, "Cucumber", 1);
receipt.AddItem(2, "2L Cola", 0.89m);
receipt.AddItem(5, "Coconut", 1.50m);
receipt.AddItem(1, "Punnet cherry tomatoes", 3);
receipt.AddItem(5, "Banana", 0.8m);
receipt.AddItem(2, "Chicken breast", 1.77m);
receipt.AddItem(5, "Tin baked beans", 0.79m);
```

`receipt.ToString()` will be equal to

```
1 Cucumber @ $1.00 = $1.00
2 2L Cola @ $0.89 = $1.78
5 Coconut @ $1.50 = $7.50
1 Punnet cherry tomatoes @ $3.00 = $3.00
5 Banana @ $0.80 = $4.00
2 Chicken breast @ $1.77 = $3.54
5 Tin baked beans @ $0.79 = $3.95
SubTotal = $24.77
Tax (10%) = $2.48
Total = $27.25
```
