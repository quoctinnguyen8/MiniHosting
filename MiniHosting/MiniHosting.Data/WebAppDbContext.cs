using MiniHosting.Data.Configurations;
using MiniHosting.Data.DataSeeders;
using MiniHosting.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHosting.Data
{
	public class WebAppDbContext : DbContext
	{
		public DbSet<AppRole> AppPolicies { get; set; }
		public DbSet<AppRolePermission> AppRolePermissions { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<MstPermission> MstPermissions { get; set; }

		public WebAppDbContext(DbContextOptions options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AppUserConfig());
			modelBuilder.ApplyConfiguration(new AppRoleConfig());
			modelBuilder.ApplyConfiguration(new AppRolePermissionConfig());
			modelBuilder.ApplyConfiguration(new MstPermissionConfig());

			// Tạo dữ liệu
			modelBuilder.Entity<MstPermission>().SeedData();
			modelBuilder.Entity<AppRole>().SeedData();
			modelBuilder.Entity<AppUser>().SeedData();
			modelBuilder.Entity<AppRolePermission>().SeedData();
		}
	}
}
