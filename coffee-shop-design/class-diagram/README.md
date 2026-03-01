# Coffee Shop UML Class Diagram

This repository contains the UML class diagram for the digitalization of a coffee shop chain, based on the provided business scenario.

## Diagram

![UML Class Diagram](class-diagram.png)

## Description

This class diagram models the main entities and relationships required for the coffee shop chain’s digital operations:

- **CoffeeShop**
  - Properties: `shopName: String`, `location: String`
  - Methods: `addBarista(barista: Barista): void`, `addOrder(order: Order): void`, `getOrdersByDate(date: Date): List<Order>`
  - Relationships: has multiple `Barista` and `Order` instances

- **Barista**
  - Properties: `baristaName: String`, `baristaId: String`
  - Methods: `prepareOrder(order: Order): void`
  - Relationships: prepares `Order`, works at `CoffeeShop`

- **Order**
  - Properties: `orderId: String`, `orderTimestamp: DateTime`, `totalPrice: float`
  - Methods: `calculateTotalPrice(): float`, `assignBarista(barista: Barista): void`
  - Relationships: placed by `Customer`, prepared by `Barista`, contains one `Beverage` and multiple `Extra` items

- **Customer**
  - Properties: `customerName: String`, `customerId: String`
  - Methods: `placeOrder(order: Order): void`, `redeemLoyaltyPoints(points: int): void`
  - Relationships: has one `LoyaltyAccount`, places multiple `Order` instances

- **LoyaltyAccount**
  - Properties: `loyaltyPoints: int`, `membershipType: MembershipType`
  - Methods: `addPoints(amount: float): void`, `redeem(points: int): void`, `getPoints(): int`
  - Relationships: belongs to one `Customer`

- **Beverage**
  - Properties: `beverageType: BeverageType`, `beverageSize: BeverageSize`, `basePrice: float`
  - Methods: `getPrice(): float`
  - Relationships: part of `Order`

- **Extra**
  - Properties: `extraType: ExtraType`, `extraPrice: float`
  - Methods: `getPrice(): float`
  - Relationships: part of `Order`

- **Enumerations**
  - `MembershipType`: REGULAR, GOLD
  - `BeverageType`: ESPRESSO, LATTE, CAPPUCCINO
  - `BeverageSize`: SMALL, MEDIUM, LARGE
  - `ExtraType`: EXTRA_SHOT, VANILLA_SYRUP, CARAMEL_SYRUP, WHIPPED_CREAM

All relationships and multiplicities are shown in the diagram.

## How to Use

- The diagram can be used as a reference for implementing the object-oriented model of the coffee shop chain system.
- For further details, see the class diagram image above.