﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHosting.Share.Consts
{
	public static class DB
	{
		public static class AppRole
		{
			public const string TABLE_NAME					= "AppRole";
			public const short NAME_LENGTH					= 50;
			public const short DESC_LENGTH					= 100;
		}
		public static class AppRolePermission
		{
			public const string TABLE_NAME					= "AppRolePermission";
		}
		public static class AppUser
		{
			public const string TABLE_NAME					= "AppUser";
			public const short USERNAME_LENGTH				= 200;
			public const short PWD_LENGTH					= 200;
			public const short FULLNAME_LENGTH				= 50;
			public const short PHONE_LENGTH					= 20;
			public const short EMAIL_LENGTH					= 200;
			public const short ADDRESS_LENGTH				= 100;
			public const short AVATAR_LENGTH				= 200;
		}
		public static class MstPermission
		{
			public const string TABLE_NAME					= "MstPermission";
			public const short CODE_LENGTH					= 50;
			public const short TABLE_LENGTH					= 50;
			public const short GROUPNAME_LENGTH				= 100;
			public const short DESC_LENGTH					= 100;
		}
		public static class AppUserWebsite
		{
			public const string TABLE_NAME					= "AppUserWebsite";
			public const short DOMAIN_LENGTH				= 50;
			public const short SITENAME_LENGTH				= 100;
			public const short PATH_LENGTH					= 200;
			public const short DESC_LENGTH					= 200;
		}
	}
}
