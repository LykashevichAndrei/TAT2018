using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Task_DEV_11
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class Server
    {
        /// <summary>
        /// method print days from the date of 00.00.0000 to input date
        /// </summary>
        /// <param name="year">input year</param>
        /// <param name="monts">input monts</param>
        /// <param name="day">input day</param>
        [WebMethod()]
        public int GetDaysFromChristsBirthday(int year,int monts,int day)
        {
            int days=0;
            for(int i=0;i<=year;i++)
            {
                if (i % 4 == 0 && i!=0)
                    days += 366;
                else
                    days += 365;
            }
            for (int i = 0; i < monts; i++)
            {
                if (i == 0)
                    days += 31;
                if (i == 0 && year%4==0)
                    days += 29;
                if (i == 0 && year % 4 != 0)
                    days += 28;
                if (i == 0)
                    days += 31;
                if (i == 0)
                    days += 30;
                if (i == 0)
                    days += 31;
                if (i == 0)
                    days += 30;
                if (i == 0)
                    days += 31;
                if (i == 0)
                    days += 31;
                if (i == 0)
                    days += 30;
                if (i == 0)
                    days += 31;
                if (i == 0)
                    days += 30;
                if (i == 0)
                    days += 31;
            }
            days += day;
            return days;
        }
    }
}