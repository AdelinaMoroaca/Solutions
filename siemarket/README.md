# SieMarket Coding Challenge

SieMarket is an online electronics store that has been growing rapidly. The company receives hundreds of orders daily from customers across Europe. Each order is placed by a customer and contains one or more items. For every item in an order, the system records the product name, the quantity ordered, and the unit price at the time of purchase.

The company has a simple discount policy: if the total value of an order exceeds 500€, the customer receives a 10% discount on the entire order.

---

## Requirements

### 2.1 Create the necessary C# classes to represent orders and their items with appropriate properties and data types.

- **Customer**: Represents a customer with properties such as `CustomerId` and `Name`.
- **Order**: Represents an order with properties such as `OrderId`, `OrderDate`, `Customer`, and a list of `OrderItem`.
- **OrderItem**: Represents an item in an order with properties such as `ProductName`, `Quantity`, and `UnitPrice`.

### 2.2 Implement a method that calculates the final price of an order, applying the discount rule when applicable.

- The method should sum the total value of all items in the order.
- If the total exceeds 500€, apply a 10% discount.

### 2.3 Implement a method that finds and returns the name of the customer who has spent the most money on all their orders.

- The method should iterate through all customers and their orders, calculate the total spent, and return the name of the top spender.

### 2.4 (Bonus) Implement a method that returns the popular products along with their total quantity sold.

- The method should aggregate all order items, group by product name, and return each product with its total quantity sold.

---

## Folder Structure
    src/
    │
    ├── Customer.cs
    ├── Order.cs
    ├── OrderItem.cs
    └── Program.cs
---

## How to Use

- Review the C# classes in the `src/` folder for the object model.
- Check the `class-diagram/` and `er-diagram/` folders for visual diagrams and explanations.
- Run the methods in `Program.cs` to test the business logic.

---

## Solution Overview

- The solution models customers, orders, and order items using C# classes.
- Business logic for discounts, top spender, and popular products is implemented as methods.
- Diagrams and documentation are provided for clarity and maintainability.

---

If you have any questions or need further explanations, please refer to the code comments or contact Adelina Moroaca, the repository maintainer.