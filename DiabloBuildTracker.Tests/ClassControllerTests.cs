using DiabloBuildTracker.Api.Controllers;
using DiabloBuildTracker.Api.Data;
using DiabloBuildTracker.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Tests;

public class ClassControllerTests
{
    [Fact]
    public async Task GetClasses_ReturnsAllClasses()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using var context = new AppDbContext(options);

        context.Classes.AddRange(
            new Class { Id = 1, Name = "Barbarian" },
            new Class { Id = 2, Name = "Druid" }
        );

        await context.SaveChangesAsync();

        var controller = new ClassController(context);

        // Act
        var result = await controller.GetClasses();

        // Assert
        var classes = Assert.IsAssignableFrom<IEnumerable<Class>>(result.Value);

        Assert.Equal(2, classes.Count());
        Assert.Contains(classes, c => c.Name == "Barbarian");
        Assert.Contains(classes, c => c.Name == "Druid");
    }
    [Fact]
    public async Task GetClass_ReturnsClass_WhenIdExists()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using var context = new AppDbContext(options);

        var testClass = new Class { Id = 1, Name = "Barbarian" };

        context.Classes.Add(testClass);
        await context.SaveChangesAsync();

        var controller = new ClassController(context);

        // Act
        var result = await controller.GetClass(1);

        // Assert
        var returnedClass = Assert.IsType<Class>(result.Value);

        Assert.Equal(1, returnedClass.Id);
        Assert.Equal("Barbarian", returnedClass.Name);
    }
    [Fact]
    public async Task GetClass_ReturnsNotFound_WhenIdDoesNotExist()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using var context = new AppDbContext(options);

        var controller = new ClassController(context);

        // Act
        var result = await controller.GetClass(999);

        // Assert
        Assert.IsType<NotFoundResult>(result.Result);
    }
    [Fact]
    public async Task PostClass_CreatesNewClass()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using var context = new AppDbContext(options);

        var controller = new ClassController(context);

        var newClass = new Class
        {
            Id = 8,
            Name = "Test Class"
        };
        // Act
        var result = await controller.PostClass(newClass);

        // Assert
        var createdResult = Assert.IsType<CreatedAtActionResult>(result.Result);

        Assert.Equal(201, createdResult.StatusCode);

        var savedClass = await context.Classes.FindAsync(8);

        Assert.NotNull(savedClass);
        Assert.Equal("Test Class", savedClass.Name);
    }
    [Fact]
    public async Task PutClass_UpdatesClass_WhenIdsMatch()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using var context = new AppDbContext(options);

        var existingClass = new Class
        {
            Id = 1,
            Name = "Old Name"
        };

        context.Classes.Add(existingClass);
        await context.SaveChangesAsync();

        context.ChangeTracker.Clear();

        var controller = new ClassController(context);

        var updatedClass = new Class
        {
            Id = 1,
            Name = "New Name"
        };
        // Act
        var result = await controller.PutClass(1, updatedClass);
        // Assert
        Assert.IsType<NoContentResult>(result);

        var savedClass = await context.Classes.FindAsync(1);

        Assert.NotNull(savedClass);
        Assert.Equal("New Name", savedClass.Name);
    }
    [Fact]
    public async Task PutClass_ReturnsBadRequest_WhenIdsDoNotMatch()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using var context = new AppDbContext(options);

        var controller = new ClassController(context);

        var updatedClass = new Class
        {
            Id = 2,
            Name = "Updated Barbarian"
        };
        // Act
        var result = await controller.PutClass(1, updatedClass);
        // Assert
        Assert.IsType<BadRequestResult>(result);
    }
    [Fact]
    public async Task DeleteClass_DeletesClass_WhenIdExists()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using var context = new AppDbContext(options);

        var testClass = new Class
        {
            Id = 1,
            Name = "Barbarian"
        };

        context.Classes.Add(testClass);
        await context.SaveChangesAsync();

        var controller = new ClassController(context);
        // Act
        var result = await controller.DeleteClass(1);
        // Assert
        Assert.IsType<NoContentResult>(result);

        var deletedClass = await context.Classes.FindAsync(1);

        Assert.Null(deletedClass);
    }
    [Fact]
    public async Task DeleteClass_ReturnsNotFound_WhenIdDoesNotExist()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        using var context = new AppDbContext(options);

        var controller = new ClassController(context);

        // Act
        var result = await controller.DeleteClass(999);

        // Assert
        Assert.IsType<NotFoundResult>(result);
    }
}