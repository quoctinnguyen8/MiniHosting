using MiniHosting.Data.Entities.Base;
using MiniHosting.Share.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHosting.Data.Entities
{
	public class AppUserWebsite : AppEntityBase
	{
		public string Domain { get; set; }
		public bool IsIncludeWww { get; set; }
		public string SiteName { get; set; }
		public string Path { get; set; }
		public string Description { get; set; }
		public SourceCodeType SourceCodeType { get; set; }
		public bool IsTurnOnSSL { get; set; }

		/// <summary>
		/// người sở hữu, admin có thể tạo rồi trả lại cho user
		/// </summary>
		public int? OwnerId { get; set; }
		public bool IsActive { get; set; }

		/// <summary>
		/// Cổng chạy cho source code C#, chỉ dùng khi SourceCodeType là C#
		/// </summary>
		public int? CSharpInternalPort { get; set; }
	}
}
