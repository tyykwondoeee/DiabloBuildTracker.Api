using Microsoft.EntityFrameworkCore;
using DiabloBuildTracker.Api.Models;
using DiabloBuildTracker.Api.Data.Seed;

namespace DiabloBuildTracker.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Class> Classes => Set<Class>();
        public DbSet<Build> Builds => Set<Build>();
        public DbSet<Skill> Skills => Set<Skill>();
        public DbSet<Item> Items => Set<Item>();
        public DbSet<BuildSkill> BuildSkills => Set<BuildSkill>();
        public DbSet<BuildItem> BuildItems => Set<BuildItem>();
        public DbSet<SkillCategory> SkillCategories => Set<SkillCategory>();
        public DbSet<SkillUpgrade> SkillUpgrades => Set<SkillUpgrade>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuildSkill>()
                .HasKey(bs => new { bs.BuildId, bs.SkillId });

            modelBuilder.Entity<BuildSkill>()
                .HasOne(bs => bs.Build)
                .WithMany(b => b.BuildSkills)
                .HasForeignKey(bs => bs.BuildId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BuildSkill>()
                .HasOne(bs => bs.Skill)
                .WithMany(s => s.BuildSkills)
                .HasForeignKey(bs => bs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BuildItem>()
                .HasKey(bi => new { bi.BuildId, bi.ItemId });

            modelBuilder.Entity<BuildItem>()
                .HasOne(bi => bi.Build)
                .WithMany(b => b.BuildItems)
                .HasForeignKey(bi => bi.BuildId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BuildItem>()
                .HasOne(bi => bi.Item)
                .WithMany(i => i.BuildItems)
                .HasForeignKey(bi => bi.ItemId)
                .OnDelete(DeleteBehavior.Restrict);
            // Seed Data
            ClassSeed.Seed(modelBuilder);
            SkillCategorySeed.Seed(modelBuilder);
            // Barbarian Seeds
            BarbarianActiveSkillSeed.Seed(modelBuilder);
            BarbarianPassiveSkillSeed.Seed(modelBuilder);
            BarbarianSkillUpgradeSeed.Seed(modelBuilder);
            // Druid Seeds
            DruidActiveSkillSeed.Seed(modelBuilder);
            DruidPassiveSkillSeed.Seed(modelBuilder);
            DruidSkillUpgradeSeed.Seed(modelBuilder);
        }
    }
}
