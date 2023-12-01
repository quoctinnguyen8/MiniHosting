using MiniHosting.Data.Entities;
using MiniHosting.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MiniHosting.Web.Components.Permission
{
	public class PermissionViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public PermissionViewComponent(GenericRepository _repository)
		{
			repository = _repository;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await repository
							.GetAllMst<MstPermission>()
							.AsEnumerable()
							.GroupBy(x => x.GroupName)
							.ToListAsync();
			return View(data);
		}
	}
}
