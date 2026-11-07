using DiabloBuildTracker.Api.Controllers;
using DiabloBuildTracker.Api.Data;
using DiabloBuildTracker.Api.Models;
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
}