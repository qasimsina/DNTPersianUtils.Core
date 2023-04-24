using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class IranHolidaysTests
{
    [TestMethod]
    public void Test_GetBusinessDays_works()
    {
        Assert.AreEqual(23, 1397.GetBusinessDays(6).Count());
    }

    [TestMethod]
    public void Test_StartYear_EndYear_works()
    {
        Assert.AreEqual(1395, IranHolidays.StartYear);
        Assert.AreEqual(DateTime.Now.ToPersianYearMonthDay().Year, IranHolidays.EndYear); // It's a reminder!
    }
}