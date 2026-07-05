using Catalog.API.Controllers;
using Catalog.API.Models;
using Catalog.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Tests;

public class ProductsControllerTests
{
    [Fact]
    public async Task GetById_ReturnsNotFound_WhenProductDoesNotExist()
    {
        // Arrange
        var repository = new InMemoryProductRepository();
        var controller = new ProductsController(repository);
        var nonExistentId = 999;

        // Act
        var result = await controller.GetById(nonExistentId);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }
}
