using DiabloBuildTracker.Api.Controllers;
using DiabloBuildTracker.Api.Data;
using DiabloBuildTracker.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Tests
{
    public class SkillUpgradesControllerTests
    {
        [Fact]
        public async Task GetSkillUpgrades_ReturnsAllSkillUpgrades()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var testClass = new Class
            {
                Id = 100,
                Name = "Test Class"
            };

            var testCategory = new SkillCategory
            {
                Id = 100,
                Name = "Test Category"
            };

            var testSkill = new Skill
            {
                Id = 10001,
                ClassId = 100,
                Class = testClass,
                Name = "Test Skill",
                MaxRank = 5,
                SkillCategoryId = 100,
                SkillCategory = testCategory,
                SkillType = DiabloBuildTracker.Api.Models.Enums.SkillType.Active
            };

            context.Skills.Add(testSkill);

            context.SkillUpgrades.AddRange(
                new SkillUpgrade
                {
                    Id = 10001,
                    SkillId = 10001,
                    Skill = testSkill,
                    Name = "Test Upgrade One",
                    Description = "First test upgrade"
                },
                new SkillUpgrade
                {
                    Id = 10002,
                    SkillId = 10001,
                    Skill = testSkill,
                    Name = "Test Upgrade Two",
                    Description = "Second test upgrade"
                }
            );

            await context.SaveChangesAsync();

            var controller = new SkillUpgradesController(context);

            // Act
            var result = await controller.GetSkillUpgrades();

            // Assert
            var upgrades = Assert.IsAssignableFrom<IEnumerable<SkillUpgrade>>(result.Value);

            Assert.Equal(2, upgrades.Count());
            Assert.Contains(upgrades, u => u.Name == "Test Upgrade One");
            Assert.Contains(upgrades, u => u.Name == "Test Upgrade Two");
        }
        [Fact]
        public async Task GetSkillUpgrade_ReturnsUpgrade_WhenIdExists()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var testClass = new Class
            {
                Id = 100,
                Name = "Test Class"
            };

            var testCategory = new SkillCategory
            {
                Id = 100,
                Name = "Test Category"
            };

            var testSkill = new Skill
            {
                Id = 10001,
                ClassId = 100,
                Class = testClass,
                Name = "Test Skill",
                MaxRank = 5,
                SkillCategoryId = 100,
                SkillCategory = testCategory,
                SkillType = DiabloBuildTracker.Api.Models.Enums.SkillType.Active
            };

            var testUpgrade = new SkillUpgrade
            {
                Id = 10001,
                SkillId = 10001,
                Skill = testSkill,
                Name = "Test Upgrade",
                Description = "This is a test upgrade."
            };

            context.SkillUpgrades.Add(testUpgrade);
            await context.SaveChangesAsync();

            var controller = new SkillUpgradesController(context);

            // Act
            var result = await controller.GetSkillUpgrade(10001);

            // Assert
            var returnedUpgrade = Assert.IsType<SkillUpgrade>(result.Value);

            Assert.Equal(10001, returnedUpgrade.Id);
            Assert.Equal("Test Upgrade", returnedUpgrade.Name);
            Assert.Equal("This is a test upgrade.", returnedUpgrade.Description);
        }
        [Fact]
        public async Task GetSkillUpgrade_ReturnsNotFound_WhenIdDoesNotExist()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillUpgradesController(context);

            // Act
            var result = await controller.GetSkillUpgrade(99999);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }
        [Fact]
        public async Task PostSkillUpgrade_CreatesNewSkillUpgrade()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var testClass = new Class
            {
                Id = 100,
                Name = "Test Class"
            };

            var testCategory = new SkillCategory
            {
                Id = 100,
                Name = "Test Category"
            };

            var testSkill = new Skill
            {
                Id = 10001,
                ClassId = 100,
                Class = testClass,
                Name = "Test Skill",
                MaxRank = 5,
                SkillCategoryId = 100,
                SkillCategory = testCategory,
                SkillType = DiabloBuildTracker.Api.Models.Enums.SkillType.Active
            };

            context.Skills.Add(testSkill);
            await context.SaveChangesAsync();

            var controller = new SkillUpgradesController(context);

            var newUpgrade = new SkillUpgrade
            {
                Id = 10002,
                SkillId = 10001,
                Name = "Test Upgrade",
                Description = "This is a newly created upgrade."
            };

            // Act
            var result = await controller.PostSkillUpgrade(newUpgrade);

            // Assert
            var createdResult = Assert.IsType<CreatedAtActionResult>(result.Result);

            Assert.Equal(201, createdResult.StatusCode);

            var savedUpgrade = await context.SkillUpgrades.FindAsync(10002);

            Assert.NotNull(savedUpgrade);
            Assert.Equal("Test Upgrade", savedUpgrade.Name);
            Assert.Equal("This is a newly created upgrade.", savedUpgrade.Description);
            Assert.Equal(10001, savedUpgrade.SkillId);
        }
        [Fact]
        public async Task PutSkillUpgrade_UpdatesSkillUpgrade_WhenIdsMatch()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var testClass = new Class
            {
                Id = 100,
                Name = "Test Class"
            };

            var testCategory = new SkillCategory
            {
                Id = 100,
                Name = "Test Category"
            };

            var testSkill = new Skill
            {
                Id = 10001,
                ClassId = 100,
                Class = testClass,
                Name = "Test Skill",
                MaxRank = 5,
                SkillCategoryId = 100,
                SkillCategory = testCategory,
                SkillType = DiabloBuildTracker.Api.Models.Enums.SkillType.Active
            };

            var existingUpgrade = new SkillUpgrade
            {
                Id = 10002,
                SkillId = 10001,
                Name = "Old Upgrade Name",
                Description = "Old description."
            };

            context.Skills.Add(testSkill);
            context.SkillUpgrades.Add(existingUpgrade);

            await context.SaveChangesAsync();

            // Stop tracking the original entity.
            // This simulates receiving a detached object from an HTTP request.
            context.ChangeTracker.Clear();

            var controller = new SkillUpgradesController(context);

            var updatedUpgrade = new SkillUpgrade
            {
                Id = 10002,
                SkillId = 10001,
                Name = "Updated Upgrade Name",
                Description = "Updated description."
            };

            // Act
            var result = await controller.PutSkillUpgrade(10002, updatedUpgrade);

            // Assert
            Assert.IsType<NoContentResult>(result);

            var savedUpgrade = await context.SkillUpgrades.FindAsync(10002);

            Assert.NotNull(savedUpgrade);
            Assert.Equal("Updated Upgrade Name", savedUpgrade.Name);
            Assert.Equal("Updated description.", savedUpgrade.Description);
        }
        [Fact]
        public async Task PutSkillUpgrade_ReturnsBadRequest_WhenIdsDoNotMatch()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillUpgradesController(context);

            var updatedUpgrade = new SkillUpgrade
            {
                Id = 10002,
                SkillId = 10001,
                Name = "Updated Upgrade",
                Description = "Updated description."
            };

            // Act
            var result = await controller.PutSkillUpgrade(10001, updatedUpgrade);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public async Task DeleteSkillUpgrade_DeletesSkillUpgrade_WhenIdExists()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var testClass = new Class
            {
                Id = 100,
                Name = "Test Class"
            };

            var testCategory = new SkillCategory
            {
                Id = 100,
                Name = "Test Category"
            };

            var testSkill = new Skill
            {
                Id = 10001,
                ClassId = 100,
                Class = testClass,
                Name = "Test Skill",
                MaxRank = 5,
                SkillCategoryId = 100,
                SkillCategory = testCategory,
                SkillType = DiabloBuildTracker.Api.Models.Enums.SkillType.Active
            };

            var testUpgrade = new SkillUpgrade
            {
                Id = 10002,
                SkillId = 10001,
                Name = "Test Upgrade",
                Description = "This is a test upgrade."
            };

            context.Skills.Add(testSkill);
            context.SkillUpgrades.Add(testUpgrade);

            await context.SaveChangesAsync();

            var controller = new SkillUpgradesController(context);

            // Act
            var result = await controller.DeleteSkillUpgrade(10002);

            // Assert
            Assert.IsType<NoContentResult>(result);

            var deletedUpgrade = await context.SkillUpgrades.FindAsync(10002);

            Assert.Null(deletedUpgrade);
        }
        [Fact]
        public async Task DeleteSkillUpgrade_ReturnsNotFound_WhenIdDoesNotExist()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillUpgradesController(context);

            // Act
            var result = await controller.DeleteSkillUpgrade(99999);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}