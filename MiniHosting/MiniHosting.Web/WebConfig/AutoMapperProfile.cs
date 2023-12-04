﻿using MiniHosting.Data.Entities;
using MiniHosting.Web.ViewModels.Account;
using MiniHosting.Web.ViewModels.Role;
using MiniHosting.Web.ViewModels.User;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniHosting.Web.ViewModels.UserWebsite;

namespace MiniHosting.Web.WebConfig
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			// Map dữ liệu từ kiểu UserAddOrEditVM sang AppUser
			CreateMap<UserAddOrEditVM, AppUser>();

			// Map dữ liệu từ kiểu AppUser sang UserAddOrEditVM
			CreateMap<AppUser, UserAddOrEditVM>();

			CreateMap<AppUserWebsite, WebsiteAddOrUpdateVM>().ReverseMap();

		}

		public static MapperConfiguration RoleIndexConf = new (mapper =>
		{
			// Map dữ liệu từ kiểu AppRole sang RoleListItemVM
			mapper.CreateMap<AppRole, RoleListItemVM>();
		});

		// Cấu hình mapping cho UserController, action Index
		public static MapperConfiguration UserIndexConf = new(mapper =>
		{
			// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
			mapper.CreateMap<AppUser, UserListItemVM>()
				.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole.Name));
		});

		// Cấu hình mapping cho AccountController, action Login
		public static MapperConfiguration LoginConf = new(mapper =>
		{
			// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
			mapper.CreateMap<AppUser, UserDataForLogin>()
				.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole == null ? "" : uEntity.AppRole.Name))
				.ForMember(uItem => uItem.Permission, opts => opts.MapFrom
				(
					uEntity => string.Join(',', uEntity.AppRole
														.AppRolePermissions
														.Select(p => p.MstPermissionId))
				)
			);
		});

		// Cấu hình mapping cho RoleController, action Delete
		public static MapperConfiguration RoleDeleteConf = new (mapper =>
		{
			// Map dữ liệu thuộc tính con
			mapper.CreateMap<AppUser, RoleDeleteVM_User>();
			// Map dữ liệu thuộc tính cha
			mapper.CreateMap<AppRole, RoleDeleteVM>();
		});

		// Cấu hình mapping cho UserWebsiteController
		public static MapperConfiguration UserWebsiteIndexConf = new(mapper =>
		{
			// Map dữ liệu từ kiểu AppRole sang RoleListItemVM
			mapper.CreateMap<AppUserWebsite, WebsiteListItemVM>();
		});
	}
}
