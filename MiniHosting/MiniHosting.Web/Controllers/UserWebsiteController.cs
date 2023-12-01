using MiniHosting.Data.Entities;
using MiniHosting.Data.Repositories;
using MiniHosting.Share.Consts;
using MiniHosting.Web.Common;
using MiniHosting.Web.ViewModels.Role;
using MiniHosting.Web.ViewModels.User;
using MiniHosting.Web.WebConfig;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using MiniHosting.Web.ViewModels.UserWebsite;

namespace MiniHosting.Web.Controllers
{
	public class UserWebsiteController : AppControllerBase
	{
		readonly GenericRepository _repository;

		public UserWebsiteController(GenericRepository repository, IMapper mapper) : base(mapper)
		{
			_repository = repository;
		}

		[AppAuthorize()]
		public async Task<IActionResult> Index(int page = 1, int size = DEFAULT_PAGE_SIZE)
		{
			var isSiteManager = User.IsInPermission(AuthConst.AppUserWebsite.MANAGE_ALL_SITE);
			var data = (await _repository
				.GetAll<AppUserWebsite>(w => w.OwnerId == this.CurrentUserId || isSiteManager)
				.ProjectTo<WebsiteListItemVM>(AutoMapperProfile.UserWebsiteIndexConf)
				.ToPagedListAsync(page, size))
				.GenRowIndex();
			return View(data);
		}
	}
}
