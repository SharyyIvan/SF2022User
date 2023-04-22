using Microsoft.VisualStudio.TestTools.UnitTesting;
using SF2022User;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void AvailablePeriodsTest1()
        {
            var timeList = new TimeSpan[]
             {
                new TimeSpan(10,00,00),
                new TimeSpan(11,00,00),
                new TimeSpan(15,00,00),
                new TimeSpan(15,30,00),
                new TimeSpan(16,50,00)
             };
            var duration = new int[]
            {
                60,30,10,10,40
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(18, 00, 00);
            var consultTime = 30;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join("," , calculations.AvailablePeriods(timeList,duration,startWork,endWork,consultTime));

            var result = "08:00-08:30,08:30-09:00,09:00-09:30,09:30-10:00,11:30-12:00,12:00-12:30,12:30-13:00,13:00-13:30,13:30-14:00,14:00-14:30,14:30-15:00,15:40-16:10,16:10-16:40,17:30-18:00";

            Assert.AreEqual<string>(result, text);
            //ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest2()
        {
            var timeList = new TimeSpan[]
             {
                new TimeSpan(10,00,00),
                new TimeSpan(11,00,00),
                new TimeSpan(15,00,00),
                new TimeSpan(15,30,00),
                new TimeSpan(19,50,00)
             };
            var duration = new int[]
            {
                60,30,10,10,40,300
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(22, 00, 00);
            var consultTime = 5;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:05,08:05-08:10,08:10-08:15,08:15-08:20,08:20-08:25,08:25-08:30,08:30-08:35,08:35-08:40,08:40-08:45,08:45-08:50,08:50-08:55,08:55-09:00,09:00-09:05,09:05-09:10,09:10-09:15,09:15-09:20,09:20-09:25,09:25-09:30,09:30-09:35,09:35-09:40,09:40-09:45,09:45-09:50,09:50-09:55,09:55-10:00,11:30-11:35,11:35-11:40,11:40-11:45,11:45-11:50,11:50-11:55,11:55-12:00,12:00-12:05,12:05-12:10,12:10-12:15,12:15-12:20,12:20-12:25,12:25-12:30,12:30-12:35,12:35-12:40,12:40-12:45,12:45-12:50,12:50-12:55,12:55-13:00,13:00-13:05,13:05-13:10,13:10-13:15,13:15-13:20,13:20-13:25,13:25-13:30,13:30-13:35,13:35-13:40,13:40-13:45,13:45-13:50,13:50-13:55,13:55-14:00,14:00-14:05,14:05-14:10,14:10-14:15,14:15-14:20,14:20-14:25,14:25-14:30,14:30-14:35,14:35-14:40,14:40-14:45,14:45-14:50,14:50-14:55,14:55-15:00,15:10-15:15,15:15-15:20,15:20-15:25,15:25-15:30,15:40-15:45,15:45-15:50,15:50-15:55,15:55-16:00,16:00-16:05,16:05-16:10,16:10-16:15,16:15-16:20,16:20-16:25,16:25-16:30,16:30-16:35,16:35-16:40,16:40-16:45,16:45-16:50,16:50-16:55,16:55-17:00,17:00-17:05,17:05-17:10,17:10-17:15,17:15-17:20,17:20-17:25,17:25-17:30,17:30-17:35,17:35-17:40,17:40-17:45,17:45-17:50,17:50-17:55,17:55-18:00,18:00-18:05,18:05-18:10,18:10-18:15,18:15-18:20,18:20-18:25,18:25-18:30,18:30-18:35,18:35-18:40,18:40-18:45,18:45-18:50,18:50-18:55,18:55-19:00,19:00-19:05,19:05-19:10,19:10-19:15,19:15-19:20,19:20-19:25,19:25-19:30,19:30-19:35,19:35-19:40,19:40-19:45,19:45-19:50,20:30-20:35,20:35-20:40,20:40-20:45,20:45-20:50,20:50-20:55,20:55-21:00,21:00-21:05,21:05-21:10,21:10-21:15,21:15-21:20,21:20-21:25,21:25-21:30,21:30-21:35,21:35-21:40,21:40-21:45,21:45-21:50,21:50-21:55,21:55-22:00";

            Assert.AreEqual<string>(result, text);
            //ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest3()
        {
            var timeList = new TimeSpan[]
             {
                new TimeSpan(10,00,00),
                new TimeSpan(11,00,00),
                new TimeSpan(15,00,00),
                new TimeSpan(15,30,00),
                new TimeSpan(19,50,00)
             };
            var duration = new int[]
            {
                60,30,10,10,40,300
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(22, 00, 00);
            var consultTime = 5;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:05,08:05-08:10,08:10-08:15,08:15-08:20,08:20-08:25,08:25-08:30,08:30-08:35,08:35-08:40,08:40-08:45,08:45-08:50,08:50-08:55,08:55-09:00,09:00-09:05,09:05-09:10,09:10-09:15,09:15-09:20,09:20-09:25,09:25-09:30,09:30-09:35,09:35-09:40,09:40-09:45,09:45-09:50,09:50-09:55,09:55-10:00,11:30-11:35,11:35-11:40,11:40-11:45,11:45-11:50,11:50-11:55,11:55-12:00,12:00-12:05,12:05-12:10,12:10-12:15,12:15-12:20,12:20-12:25,12:25-12:30,12:30-12:35,12:35-12:40,12:40-12:45,12:45-12:50,12:50-12:55,12:55-13:00,13:00-13:05,13:05-13:10,13:10-13:15,13:15-13:20,13:20-13:25,13:25-13:30,13:30-13:35,13:35-13:40,13:40-13:45,13:45-13:50,13:50-13:55,13:55-14:00,14:00-14:05,14:05-14:10,14:10-14:15,14:15-14:20,14:20-14:25,14:25-14:30,14:30-14:35,14:35-14:40,14:40-14:45,14:45-14:50,14:50-14:55,14:55-15:00,15:10-15:15,15:15-15:20,15:20-15:25,15:25-15:30,15:40-15:45,15:45-15:50,15:50-15:55,15:55-16:00,16:00-16:05,16:05-16:10,16:10-16:15,16:15-16:20,16:20-16:25,16:25-16:30,16:30-16:35,16:35-16:40,16:40-16:45,16:45-16:50,16:50-16:55,16:55-17:00,17:00-17:05,17:05-17:10,17:10-17:15,17:15-17:20,17:20-17:25,17:25-17:30,17:30-17:35,17:35-17:40,17:40-17:45,17:45-17:50,17:50-17:55,17:55-18:00,18:00-18:05,18:05-18:10,18:10-18:15,18:15-18:20,18:20-18:25,18:25-18:30,18:30-18:35,18:35-18:40,18:40-18:45,18:45-18:50,18:50-18:55,18:55-19:00,19:00-19:05,19:05-19:10,19:10-19:15,19:15-19:20,19:20-19:25,19:25-19:30,19:30-19:35,19:35-19:40,19:40-19:45,19:45-19:50,20:30-20:35,20:35-20:40,20:40-20:45,20:45-20:50,20:50-20:55,20:55-21:00,21:00-21:05,21:05-21:10,21:10-21:15,21:15-21:20,21:20-21:25,21:25-21:30,21:30-21:35,21:35-21:40,21:40-21:45,21:45-21:50,21:50-21:55,21:55-22:00";

            Assert.AreEqual<string>(result, text);
            //not ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest4()
        {
            var timeList = new TimeSpan[]
             {
                new TimeSpan(10,00,00),
                new TimeSpan(11,00,00),
                new TimeSpan(15,00,00),
                new TimeSpan(15,30,00),
                new TimeSpan(50,19,00)
             };
            var duration = new int[]
            {
                60,30,10,10,40,300
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(22, 00, 00);
            var consultTime = 5;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:05,08:05-08:10,08:10-08:15,08:15-08:20,08:20-08:25,08:25-08:30,08:30-08:35,08:35-08:40,08:40-08:45,08:45-08:50,08:50-08:55,08:55-09:00,09:00-09:05,09:05-09:10,09:10-09:15,09:15-09:20,09:20-09:25,09:25-09:30,09:30-09:35,09:35-09:40,09:40-09:45,09:45-09:50,09:50-09:55,09:55-10:00,11:30-11:35,11:35-11:40,11:40-11:45,11:45-11:50,11:50-11:55,11:55-12:00,12:00-12:05,12:05-12:10,12:10-12:15,12:15-12:20,12:20-12:25,12:25-12:30,12:30-12:35,12:35-12:40,12:40-12:45,12:45-12:50,12:50-12:55,12:55-13:00,13:00-13:05,13:05-13:10,13:10-13:15,13:15-13:20,13:20-13:25,13:25-13:30,13:30-13:35,13:35-13:40,13:40-13:45,13:45-13:50,13:50-13:55,13:55-14:00,14:00-14:05,14:05-14:10,14:10-14:15,14:15-14:20,14:20-14:25,14:25-14:30,14:30-14:35,14:35-14:40,14:40-14:45,14:45-14:50,14:50-14:55,14:55-15:00,15:10-15:15,15:15-15:20,15:20-15:25,15:25-15:30,15:40-15:45,15:45-15:50,15:50-15:55,15:55-16:00,16:00-16:05,16:05-16:10,16:10-16:15,16:15-16:20,16:20-16:25,16:25-16:30,16:30-16:35,16:35-16:40,16:40-16:45,16:45-16:50,16:50-16:55,16:55-17:00,17:00-17:05,17:05-17:10,17:10-17:15,17:15-17:20,17:20-17:25,17:25-17:30,17:30-17:35,17:35-17:40,17:40-17:45,17:45-17:50,17:50-17:55,17:55-18:00,18:00-18:05,18:05-18:10,18:10-18:15,18:15-18:20,18:20-18:25,18:25-18:30,18:30-18:35,18:35-18:40,18:40-18:45,18:45-18:50,18:50-18:55,18:55-19:00,19:00-19:05,19:05-19:10,19:10-19:15,19:15-19:20,19:20-19:25,19:25-19:30,19:30-19:35,19:35-19:40,19:40-19:45,19:45-19:50,20:30-20:35,20:35-20:40,20:40-20:45,20:45-20:50,20:50-20:55,20:55-21:00,21:00-21:05,21:05-21:10,21:10-21:15,21:15-21:20,21:20-21:25,21:25-21:30,21:30-21:35,21:35-21:40,21:40-21:45,21:45-21:50,21:50-21:55,21:55-22:00";

            Assert.AreEqual<string>(result, text);
            //not ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest5()
        {
            var timeList = new TimeSpan[]
             {
                //new TimeSpan(10,00,00),
                //new TimeSpan(11,00,00),
                //new TimeSpan(15,00,00),
                //new TimeSpan(15,30,00),
                //new TimeSpan(16,50,00)
             };
            var duration = new int[]
            {
                0
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(18, 00, 00);
            var consultTime = 30;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:30,08:30-09:00,09:00-09:30,09:30-10:00,10:00-10:30,10:30-11:00,11:00-11:30,11:30-12:00,12:00-12:30,12:30-13:00,13:00-13:30,13:30-14:00,14:00-14:30,14:30-15:00,15:00-15:30,15:30-16:00,16:00-16:30,16:30-17:00,17:00-17:30,17:30-18:00";

            Assert.AreEqual<string>(result, text);
            //ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest6()
        {
            var timeList = new TimeSpan[]
             {
                //new TimeSpan(10,00,00),
                //new TimeSpan(11,00,00),
                //new TimeSpan(15,00,00),
                //new TimeSpan(15,30,00),
                //new TimeSpan(16,50,00)
             };
            var duration = new int[]
            {
                0
            };
            var startWork = new TimeSpan(18, 00, 00);
            var endWork = new TimeSpan(8, 00, 00);
            var consultTime = 30;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:30,08:30-09:00,09:00-09:30,09:30-10:00,10:00-10:30,10:30-11:00,11:00-11:30,11:30-12:00,12:00-12:30,12:30-13:00,13:00-13:30,13:30-14:00,14:00-14:30,14:30-15:00,15:00-15:30,15:30-16:00,16:00-16:30,16:30-17:00,17:00-17:30,17:30-18:00";

            Assert.AreEqual<string>(result, text);
            //not ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest7()
        {
            var timeList = new TimeSpan[]
             {
                new TimeSpan(18,00,00),
             };
            var duration = new int[]
            {
                30
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(18, 00, 00);
            var consultTime = 30;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:30,08:30-09:00,09:00-09:30,09:30-10:00,10:00-10:30,10:30-11:00,11:00-11:30,11:30-12:00,12:00-12:30,12:30-13:00,13:00-13:30,13:30-14:00,14:00-14:30,14:30-15:00,15:00-15:30,15:30-16:00,16:00-16:30,16:30-17:00,17:00-17:30,17:30-18:00";

            Assert.AreEqual<string>(result, text);
            // ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest8()
        {
            var timeList = new TimeSpan[]
             {
                new TimeSpan(18,00,00),
             };
            var duration = new int[]
            {
                30
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(13, 00, 00);
            var consultTime = 30;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:30,08:30-09:00,09:00-09:30,09:30-10:00,10:00-10:30,10:30-11:00,11:00-11:30,11:30-12:00,12:00-12:30,12:30-13:00";

            Assert.AreEqual<string>(result, text);
            //ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest9()
        {
            var timeList = new TimeSpan[]
             {
                new TimeSpan(11,00,00),
             };
            var duration = new int[]
            {
                120
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(13, 00, 00);
            var consultTime = 30;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:30,08:30-09:00,09:00-09:30,09:30-10:00,10:00-10:30,10:30-11:00";

            Assert.AreEqual<string>(result, text);
            //ok
        }
        [TestMethod()]
        public void AvailablePeriodsTest10()
        {
            var timeList = new TimeSpan[]
             {
                new TimeSpan(11,00,00),
             };
            var duration = new int[]
            {
                15
            };
            var startWork = new TimeSpan(8, 00, 00);
            var endWork = new TimeSpan(13, 00, 00);
            var consultTime = 240;

            SF2022User.Calculations calculations = new SF2022User.Calculations();

            var text = string.Join(",", calculations.AvailablePeriods(timeList, duration, startWork, endWork, consultTime));

            var result = "08:00-08:30,08:30-09:00,09:00-09:30,09:30-10:00,10:00-10:30,10:30-11:00";

            Assert.AreEqual<string>(result, text);
            //not ok
        }
    }
}