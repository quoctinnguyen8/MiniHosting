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
	public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.ToTable(DB.AppRole.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);

			builder.Property(m => m.Name)
				.HasMaxLength(DB.AppRole.NAME_LENGTH)
				.IsRequired();

			builder.Property(m => m.Desc)
				.HasMaxLength(DB.AppRole.DESC_LENGTH)
				.IsRequired();
		}
	}
}
