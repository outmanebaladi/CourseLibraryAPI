using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Helpers
{
<<<<<<< HEAD
	public static class DateTimeOffsetExtensions
	{
		public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
		{
			var currentDate = DateTime.UtcNow;
			int age = currentDate.Year - dateTimeOffset.Year;

			if(currentDate < dateTimeOffset.AddYears(age)) 
			{
				age--;
			}

			return age;
		}
	}
=======
    public static class DateTimeOffsetExtensions
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
        {
            var currentDate = DateTime.UtcNow;
            int age = currentDate.Year - dateTimeOffset.Year;

            if(currentDate < dateTimeOffset.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
>>>>>>> 21bd37e18e465a5efc7706f81d1ae26581316af7
}
