using MiniHosting.Share.Enums;
using MiniHosting.Shared.Attributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniHosting.Web.ViewModels.UserWebsite
{
	public class WebsiteAddOrUpdateVM
	{
		public int Id { get; set; }

		[AppRequired]
		[AppMaxLength(100)]
		[DisplayName("Tên trang web")]
		public string SiteName { get; set; }

		[AppMaxLength(200)]
		[DisplayName("Mô tả")]
		public string Description { get; set; }

		[AppRequired]
		public SourceCodeType SourceCodeType { get; set; }

		/// <summary>
		/// người sở hữu, admin có thể tạo rồi trả lại cho user
		/// </summary>
		[DisplayName("Chủ sở hữu")]
		public int? OwnerId { get; set; }

		/// <summary>
		/// Cổng chạy cho source code C#, chỉ dùng khi SourceCodeType là C#
		/// </summary>
		[AppRange(10000, 30000)]
		[DisplayName("Cổng nội bộ (chỉ khả dụng với .NET)")]
		public int? CSharpInternalPort { get; set; }
	}
}
