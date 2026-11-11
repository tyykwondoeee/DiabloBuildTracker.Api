using DiabloBuildTracker.Api.Controllers;
using DiabloBuildTracker.Api.Data;
using DiabloBuildTracker.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Tests
{
    public class SkillCategoriesControllerTests
    {
        [Fact]
        public async Task GetSkillCategories_ReturnsAllCategories()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            context.SkillCategories.AddRange(
                new SkillCategory { Id = 1, Name = "Basic" },
                new SkillCategory { Id = 2, Name = "Core" },
                new SkillCategory { Id = 3, Name = "Defensive" }
            );

            await context.SaveChangesAsync();

            var controller = new SkillCategoriesController(context);
            // Act
            var result = await controller.GetSkillCategories();
            // Assert
            var categories = Assert.IsAssignableFrom<IEnumerable<SkillCategory>>(result.Value);

            Assert.Equal(3, categories.Count());
            Assert.Contains(categories, c => c.Name == "Basic");
            Assert.Contains(categories, c => c.Name == "Core");
            Assert.Contains(categories, c => c.Name == "Defensive");
        }
        [Fact]
        public async Task GetSkillCategory_ReturnsCategory_WhenIdExists()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var testCategory = new SkillCategory
            {
                Id = 1,
                Name = "Basic"
            };

            context.SkillCategories.Add(testCategory);
            await context.SaveChangesAsync();

            var controller = new SkillCategoriesController(context);

            // Act
            var result = await controller.GetSkillCategory(1);

            // Assert
            var returnedCategory = Assert.IsType<SkillCategory>(result.Value);

            Assert.Equal(1, returnedCategory.Id);
            Assert.Equal("Basic", returnedCategory.Name);
        }
        [Fact]
        public async Task GetSkillCategory_ReturnsNotFound_WhenIdDoesNotExist()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillCategoriesController(context);

            // Act
            var result = await controller.GetSkillCategory(999);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }
        [Fact]
        public async Task PostSkillCategory_CreatesNewCategory()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillCategoriesController(context);

            var newCategory = new SkillCategory
            {
                Id = 8,
                Name = "Test Category"
            };

            // Act
            var result = await controller.PostSkillCategory(newCategory);

            // Assert
            var createdResult = Assert.IsType<CreatedAtActionResult>(result.Result);

            Assert.Equal(201, createdResult.StatusCode);

            var savedCategory = await context.SkillCategories.FindAsync(8);

            Assert.NotNull(savedCategory);
            Assert.Equal("Test Category", savedCategory.Name);
        }
        [Fact]
        public async Task PutSkillCategory_UpdatesCategory_WhenIdsMatch()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var existingCategory = new SkillCategory
            {
                Id = 1,
                Name = "Old Category Name"
            };

            context.SkillCategories.Add(existingCategory);
            await context.SaveChangesAsync();

            context.ChangeTracker.Clear();

            var controller = new SkillCategoriesController(context);

            var updatedCategory = new SkillCategory
            {
                Id = 1,
                Name = "Updated Category Name"
            };

            // Act
            var result = await controller.PutSkillCategory(1, updatedCategory);

            // Assert
            Assert.IsType<NoContentResult>(result);

            var savedCategory = await context.SkillCategories.FindAsync(1);

            Assert.NotNull(savedCategory);
            Assert.Equal("Updated Category Name", savedCategory.Name);
        }
        [Fact]
        public async Task PutSkillCategory_ReturnsBadRequest_WhenIdsDoNotMatch()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillCategoriesController(context);

            var updatedCategory = new SkillCategory
            {
                Id = 2,
                Name = "Updated Category"
            };

            // Act
            var result = await controller.PutSkillCategory(1, updatedCategory);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public async Task DeleteSkillCategory_DeletesCategory_WhenIdExists()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var testCategory = new SkillCategory
            {
                Id = 1,
                Name = "Basic"
            };

            context.SkillCategories.Add(testCategory);
            await context.SaveChangesAsync();

            var controller = new SkillCategoriesController(context);

            // Act
            var result = await controller.DeleteSkillCategory(1);

            // Assert
            Assert.IsType<NoContentResult>(result);

            var deletedCategory = await context.SkillCategories.FindAsync(1);

            Assert.Null(deletedCategory);
        }
        [Fact]
        public async Task DeleteSkillCategory_ReturnsNotFound_WhenIdDoesNotExist()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillCategoriesController(context);

            // Act
            var result = await controller.DeleteSkillCategory(999);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
