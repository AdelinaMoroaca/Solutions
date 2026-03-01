# Coffee Shop ER Diagram

This folder contains the Entity-Relationship (ER) diagram for the coffee shop chain database design.

## Diagram

![ER Diagram](er-diagram.png)

## Description

**Entities and Columns:**

- **CoffeeShop**: `id` (PK), `name`, `location`
- **Barista**: `id` (PK), `name`, `coffee_shop_id` (FK)
- **Customer**: `id` (PK), `name`
- **LoyaltyAccount**: `id` (PK), `customer_id` (FK), `points`, `membership_type`
- **Order**: `id` (PK), `customer_id` (FK), `barista_id` (FK), `coffee_shop_id` (FK), `order_timestamp`, `total_price`
- **Beverage**: `id` (PK), `type`, `size`, `base_price`
- **OrderBeverage**: `id` (PK), `order_id` (FK), `beverage_id` (FK)
- **Extra**: `id` (PK), `name`, `price`
- **OrderExtra**: `id` (PK), `order_id` (FK), `extra_id` (FK)

**Relationships:**

- Each `CoffeeShop` has multiple `Barista` and `Order` records.
- Each `Order` is placed by a `Customer`, prepared by a `Barista`, and belongs to a `CoffeeShop`.
- Each `Customer` has one `LoyaltyAccount`.
- Each `Order` can have multiple `Beverage` and `Extra` items (via join tables).

All primary keys (PK) and foreign keys (FK) are shown in the diagram.

## How to Use

- Use this ER diagram as a reference for implementing the relational database schema for the coffee shop chain.