﻿using MiniHosting.Data.Entities;
using MiniHosting.Data.Repositories;
using MiniHosting.Web.ViewModels.Role;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MiniHosting.Web.Components.ListRole
{
	public class ListRoleViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public ListRoleViewComponent(GenericRepository _db)
		{
			repository = _db;
		}
		public async Task<IViewComponentResult> InvokeAsync(int? seletetedId, IEnumerable<int> excludeIds)
		{
			var data = await repository
					.GetAll<AppRole>(where: r => excludeIds == null || excludeIds.Any() && !excludeIds.Contains(r.Id))
					.ToListAsync();
			ViewBag.SelectedId = seletetedId;
			return View(data);
		}
	}
}
