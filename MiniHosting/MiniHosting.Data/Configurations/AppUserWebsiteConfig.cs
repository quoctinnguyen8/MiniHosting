using MiniHosting.Data.DataSeeders;
using MiniHosting.Data.Entities;
using MiniHosting.Data.Entities.Base;
using MiniHosting.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHosting.Data.Configurations
{
	public class AppUserWebsiteConfig : IEntityTypeConfiguration<AppUserWebsite>
	{
		public void Configure(EntityTypeBuilder<AppUserWebsite> builder)
		{
			builder.ToTable(DB.AppUserWebsite.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);

			builder.Property(m => m.Domain)
				.HasMaxLength(DB.AppUserWebsite.DOMAIN_LENGTH)
				.IsRequired(false);

			builder.Property(m => m.SiteName)
				.HasMaxLength(DB.AppUserWebsite.SITENAME_LENGTH)
				.IsRequired();

			builder.Property(m => m.Path)
				.HasMaxLength(DB.AppUserWebsite.PATH_LENGTH)
				.IsRequired();

			builder.Property(m => m.Description)
				.HasMaxLength(DB.AppUserWebsite.DESC_LENGTH)
				.IsRequired(false);
		}
	}
}
