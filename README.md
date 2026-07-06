# ☕ Cash Register Management System

A desktop application simulating an end-to-end business sales process (café/retail style), including product, customer, sale (discount), and order management. The project was built as a comprehensive exercise in professional software architecture, applying solid design principles and industry-standard design patterns.

## 🏗️ Architecture

The project follows a **Three-Tier Architecture**, where each layer depends only on the interfaces of the layer beneath it, never on concrete implementations - a direct application of the **Dependency Inversion Principle (DIP)**:

```
┌─────────────┐
│      UI      │   Windows Forms - user interface
└──────┬──────┘
       │ IBl
┌──────▼──────┐
│   BL Layer   │   Business logic (IBl, BO, BlApi/Factory)
└──────┬──────┘
       │ IDal
┌──────▼──────┐
│ DalFacade    │   Data access contract (IDal, DO, DalApi/Factory)
└──────┬──────┘
       │
   ┌───┴────┐
┌──▼──┐  ┌──▼───┐
│DalList│ │DalXml│   Two interchangeable data layer implementations
└──────┘  └──────┘
```

Thanks to this structure, the data layer implementation can be swapped (e.g., from an in-memory implementation to an XML-file-based one) **without changing a single line of code** in the BL and UI layers.

## 🎯 Design Patterns

### Singleton
Every implementation of `IDal` (e.g., `DalXml`, `DalList`) is built as a Singleton - a `private` constructor, a `static readonly` field, and a static `Instance` property - ensuring a single instance and avoiding unnecessary creation of data-access-layer objects.

### Factory (with Reflection)
The `Factory` class in the `DalApi` project does not instantiate a concrete implementation directly in code. Instead, it:
1. Reads a configuration file (`dal-config.xml`) that specifies which DAL implementation to load
2. Loads the relevant DLL at runtime (`Assembly.Load`)
3. Locates the class using **Reflection** (`Type.GetType`)
4. Retrieves its Singleton instance (`Instance`) and returns it as `IDal`

This allows the DAL implementation to be swapped simply by changing the XML configuration file - with no recompilation required.

## 🔄 DTO Pattern

Each entity in the system (Product, Customer, Sale) has two separate classes:

| Layer | Type | Example |
|-------|------|---------|
| DAL (`DO`) | Immutable `record` | `DO.Product` |
| BL (`BO`) | Regular mutable class, used as a DTO toward the UI | `BO.Product` |

Conversion between the two is handled via dedicated extension methods (`ToDO()` / `ToBO()`), so the UI layer is never exposed to the internal structure of the data layer, and internal DAL changes never ripple into other layers.

## 🛠️ Technologies

- **C# / .NET**
- **Windows Forms** (user interface)
- **LINQ** for querying data collections
- **XML Serialization** for persisting and retrieving data (`DalXml` implementation)
- **Reflection & Assembly Loading** for dynamic loading of implementations
- **Custom Exception Handling** (`DalConfigException`, etc.) to maintain system stability

## 📂 Project Structure

```
project .net/
├── UI/              Windows Forms - cashier screen, product/customer/sale management
├── BL/              Business logic - BO (DTOs), BlApi (interfaces + Factory), BlImplementation
├── DalFacade/        Data layer contract - DO (Entities), DalApi (interfaces + Factory)
├── DalList/         In-memory collection-based DAL implementation
├── DalXml/          XML-file-based DAL implementation
├── DalTest/ BlTest/  Manual test projects for each layer
```

## ✨ Core Entities

- **Product** - items sold at the business, divided into categories (coffee, cold drinks, pastries, sweets, extras)
- **Customer** - business customers
- **Sale** - discounts/promotions on products
- **Order** - orders containing both discounted and regular-priced products

## 💡 What I Took Away From This Project

This project strengthened my long-term architectural thinking - building a system designed for extensibility and maintainability, properly separating responsibilities across layers, and applying well-known design patterns to solve real design problems rather than just "making the code work."
