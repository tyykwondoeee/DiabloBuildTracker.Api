using DiabloBuildTracker.Api.Controllers;
using DiabloBuildTracker.Api.Data;
using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiabloBuildTracker.Tests
{
    public class SkillsControllerTests
    {
        [Fact]
        public async Task GetSkills_ReturnsAllSkills()
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

            context.Classes.Add(testClass);
            context.SkillCategories.Add(testCategory);

            context.Skills.AddRange(
                new Skill
                {
                    Id = 10001,
                    ClassId = 100,
                    Class = testClass,
                    Name = "Test Skill One",
                    MaxRank = 5,
                    SkillCategoryId = 100,
                    SkillCategory = testCategory,
                    SkillType = SkillType.Active
                },
                new Skill
                {
                    Id = 10002,
                    ClassId = 100,
                    Class = testClass,
                    Name = "Test Skill Two",
                    MaxRank = 5,
                    SkillCategoryId = 100,
                    SkillCategory = testCategory,
                    SkillType = SkillType.Passive
                }
            );

            await context.SaveChangesAsync();

            var controller = new SkillsController(context);

            // Act
            var result = await controller.GetSkills();

            // Assert
            var skills = Assert.IsAssignableFrom<IEnumerable<Skill>>(result.Value);

            Assert.Equal(2, skills.Count());
            Assert.Contains(skills, s => s.Name == "Test Skill One");
            Assert.Contains(skills, s => s.Name == "Test Skill Two");
        }
        [Fact]
        public async Task GetSkill_ReturnsSkill_WhenIdExists()
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
                SkillType = SkillType.Active
            };

            context.Skills.Add(testSkill);
            await context.SaveChangesAsync();

            var controller = new SkillsController(context);

            // Act
            var result = await controller.GetSkill(10001);

            // Assert
            var returnedSkill = Assert.IsType<Skill>(result.Value);

            Assert.Equal(10001, returnedSkill.Id);
            Assert.Equal("Test Skill", returnedSkill.Name);
        }
        [Fact]
        public async Task GetSkill_ReturnsNotFound_WhenIdDoesNotExist()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillsController(context);

            // Act
            var result = await controller.GetSkill(99999);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }
        [Fact]
        public async Task PostSkill_CreatesNewSkill()
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

            context.Classes.Add(testClass);
            context.SkillCategories.Add(testCategory);

            await context.SaveChangesAsync();

            var controller = new SkillsController(context);

            var newSkill = new Skill
            {
                Id = 10001,
                ClassId = 100,
                Name = "Test Skill",
                MaxRank = 5,
                SkillCategoryId = 100,
                SkillType = SkillType.Active
            };
            // Act
            var result = await controller.PostSkill(newSkill);

            // Assert
            var createdResult = Assert.IsType<CreatedAtActionResult>(result.Result);

            Assert.Equal(201, createdResult.StatusCode);

            var savedSkill = await context.Skills.FindAsync(10001);

            Assert.NotNull(savedSkill);
            Assert.Equal("Test Skill", savedSkill.Name);
            Assert.Equal(100, savedSkill.ClassId);
            Assert.Equal(100, savedSkill.SkillCategoryId);
        }
        [Fact]
        public async Task PutSkill_UpdatesSkill_WhenIdsMatch()
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

            var existingSkill = new Skill
            {
                Id = 10001,
                ClassId = 100,
                Class = testClass,
                Name = "Old Skill Name",
                MaxRank = 5,
                SkillCategoryId = 100,
                SkillCategory = testCategory,
                SkillType = SkillType.Active
            };

            context.Skills.Add(existingSkill);
            await context.SaveChangesAsync();

            // Stop tracking the original entity.
            // This simulates receiving a detached object from an HTTP request.
            context.ChangeTracker.Clear();

            var controller = new SkillsController(context);

            var updatedSkill = new Skill
            {
                Id = 10001,
                ClassId = 100,
                Name = "Updated Skill Name",
                MaxRank = 10,
                SkillCategoryId = 100,
                SkillType = SkillType.Passive
            };

            // Act
            var result = await controller.PutSkill(10001, updatedSkill);

            // Assert
            Assert.IsType<NoContentResult>(result);

            var savedSkill = await context.Skills.FindAsync(10001);

            Assert.NotNull(savedSkill);
            Assert.Equal("Updated Skill Name", savedSkill.Name);
            Assert.Equal(10, savedSkill.MaxRank);
            Assert.Equal(SkillType.Passive, savedSkill.SkillType);
        }
        [Fact]
        public async Task PutSkill_ReturnsBadRequest_WhenIdsDoNotMatch()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillsController(context);

            var updatedSkill = new Skill
            {
                Id = 10002,
                ClassId = 100,
                Name = "Updated Skill",
                MaxRank = 5,
                SkillCategoryId = 100,
                SkillType = SkillType.Active
            };

            // Act
            var result = await controller.PutSkill(10001, updatedSkill);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public async Task DeleteSkill_DeletesSkill_WhenIdExists()
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
                SkillType = SkillType.Active
            };

            context.Skills.Add(testSkill);
            await context.SaveChangesAsync();

            var controller = new SkillsController(context);

            // Act
            var result = await controller.DeleteSkill(10001);

            // Assert
            Assert.IsType<NoContentResult>(result);

            var deletedSkill = await context.Skills.FindAsync(10001);

            Assert.Null(deletedSkill);
        }
        [Fact]
        public async Task DeleteSkill_ReturnsNotFound_WhenIdDoesNotExist()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using var context = new AppDbContext(options);

            var controller = new SkillsController(context);

            // Act
            var result = await controller.DeleteSkill(99999);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
