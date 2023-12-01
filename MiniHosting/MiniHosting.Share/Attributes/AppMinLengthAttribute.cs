using MiniHosting.Share.Consts;
using System.ComponentModel.DataAnnotations;

namespace MiniHosting.Shared.Attributes
{
	public class AppMinLengthAttribute : MinLengthAttribute
	{
		public AppMinLengthAttribute(int length) : base(length)
		{
			this.ErrorMessage = string.Format(AttributeErrMesg.MINLEN, length);
		}
	}
}
