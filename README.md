# Catalog.API - Product Catalog REST Service

A .NET 8 REST API for managing a product catalog, built as part of the "C#, .NET & GitHub Copilot" workshop.

## Project Overview

This project demonstrates building a complete REST API from scratch, including:
- RESTful CRUD endpoints
- Repository pattern with in-memory storage
- Dependency injection
- Configuration management
- Unit testing
- Health monitoring endpoints

## Features

### API Endpoints

- **GET** `/api/products` - Get all products
- **GET** `/api/products/{id}` - Get product by ID
- **POST** `/api/products` - Create new product
- **PUT** `/api/products/{id}` - Update existing product
- **DELETE** `/api/products/{id}` - Delete product
- **GET** `/api/products/health` - Health check endpoint

### Technologies Used

- .NET 8
- ASP.NET Core Web API
- xUnit (for testing)
- Swagger/OpenAPI
- GitHub Copilot

## GitHub Copilot Usage

### Health Endpoint Implementation

**Prompt:** "Add a GET health endpoint at api/products/health that returns OK status"

**Result:** Created a health check endpoint returning 200 OK with status and timestamp for monitoring/load balancer integration.

## Project Structure

```
Catalog.API/
??? Controllers/
?   ??? ProductsController.cs
??? Models/
?   ??? Product.cs
?   ??? CreateProductDto.cs
??? Repositories/
?   ??? IProductRepository.cs
?   ??? InMemoryProductRepository.cs
??? Configuration/
?   ??? CatalogOptions.cs
??? Program.cs

Catalog.API.Tests/
??? ProductsControllerTests.cs
```

## Getting Started

### Prerequisites

- .NET 8 SDK
- Visual Studio 2022 or VS Code

### Running the Application

```bash
dotnet run --project Catalog.API
```

The API will be available at `https://localhost:7xxx` (check console output for exact port).

### Testing the API

1. **Via Swagger UI:**
   - Navigate to `https://localhost:7xxx/swagger`
   - Use the interactive UI to test endpoints

2. **Via Unit Tests:**
   ```bash
   dotnet test Catalog.API.Tests
   ```

## Development Process

This project was built incrementally with clear commits showing each step:

![Commit History](commits-screenshot.png)

### Commit History

1. **Remove default WeatherForecast controller and model** - Clean project setup
2. **Add Product model, CreateProductDto, and in-memory repository** - Domain model and data access
3. **Add ProductsController with CRUD endpoints** - REST API implementation
4. **Add DI registration and configuration options** - Dependency injection setup
5. **Add health endpoint using Copilot** - Monitoring endpoint
6. **Add unit test for GetById returns 404 when missing** - Test coverage
7. **Introduce off-by-one bug in GetById endpoint** - Bug simulation
8. **Fix off-by-one bug in GetById endpoint** - Debugging practice

## Configuration

Default settings in `appsettings.json`:

```json
{
  "Catalog": {
    "DefaultPageSize": 10
  }
}
```

## Sample Product Data

Example product JSON:

```json
{
  "name": "Laptop",
  "price": 999.99,
  "category": "Electronics"
}
```

## Assignment Completion

This project fulfills all requirements of the workshop assignment:
- ? Controllers-based Web API setup
- ? Product model and DTOs
- ? Repository pattern with in-memory storage
- ? Full CRUD operations
- ? Proper HTTP status codes (200, 201, 204, 400, 404)
- ? Async/await throughout
- ? Dependency injection
- ? Configuration binding
- ? GitHub Copilot integration
- ? Unit testing
- ? Debugging workflow

## Author

Built by sangya25-cg

## Repository

[GitHub Repository](https://github.com/sangya25-cg/Catalog.API_.NET)
