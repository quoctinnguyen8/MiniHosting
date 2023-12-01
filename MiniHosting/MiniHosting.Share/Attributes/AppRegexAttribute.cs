using MiniHosting.Share.Consts;
using System.ComponentModel.DataAnnotations;

namespace MiniHosting.Shared.Attributes
{
	public class AppRegexAttribute : RegularExpressionAttribute
	{
		public AppRegexAttribute(string pattern) : base(pattern)
		{
			this.ErrorMessage = AttributeErrMesg.REGEX;
		}
	}
}
