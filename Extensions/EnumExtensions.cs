using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace poc.ga4.ev.Extensions
{
    public static  class EnumExtensions
    {
		public static string EnumMemberValue(this Enum enumType)
		{
			return enumType.MemberInfo()
				.GetCustomAttribute<EnumMemberAttribute>()?.Value;
		}

		private static MemberInfo MemberInfo(this Enum enumType)
		{
			return enumType.GetType().GetMember(enumType.ToString()).First();
		}
    }
}
