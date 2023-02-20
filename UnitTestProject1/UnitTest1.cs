using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VIN_LIB;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_Contry_Asia() //простая проверка
        {
            Class1 class1 = new Class1();

            string vin = "JNKBV61E57M729118";
            string expected = "Азия";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Contry_Asia1() //простая проверка
        {
            Class1 class1 = new Class1();

            string vin = "KMHDU4AD4AU955646";
            string expected = "Азия";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Contry_Not_Exist() //не сущ
        {
            Class1 class1 = new Class1();

            string vin = "*06VR52R9WR220134";
            string expected = "ошибка";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Contry_Amer() //простая проверка
        {
            Class1 class1 = new Class1();

            string vin = "106VR52R9WR220134";
            string expected = "Северная Америка";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Contry_Europa4() //простая проверка
        {
            Class1 class1 = new Class1();

            string vin = "W06VR52R9WR220134";
            string expected = "Европа";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Contry_South_Amer() //простая проверка
        {
            Class1 class1 = new Class1();

            string vin = "806VR52R9WR220134";
            string expected = "Южная Америка";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Contry_Europa() //простая проверка
        {
            Class1 class1 = new Class1();

            string vin = "W06VR52R9WR220134";
            string expected = "Европа";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Contry_Africa() //простая проверка
        {
            Class1 class1 = new Class1();

            string vin = "HH4KA855FMC0120GQ";
            string expected = "Африка";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_VinWith_Wrong_VIS_Q() //неккоректооный vis
        {
            Class1 class1 = new Class1();

            string vin = "HH4KA855FMC0120GQ";
            bool expected = false;

            bool actual = class1.CheckVIN(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_VinWith_Wrong_VDS_Q() //неккоректооный vin
        {
            Class1 class1 = new Class1();

            string vin = "HH4KA8Q5FMC0120GG";
            bool expected = false;

            bool actual = class1.CheckVIN(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_VinWith_Wrong_WMS_q() //неккоректооный wms не сущ букв
        {
            Class1 class1 = new Class1();

            string vin = "QH4KA815FMC0120GG";
            bool expected = false;

            bool actual = class1.CheckVIN(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Check_Vin_With_Wrong_Vis() //неккоректооный vis
        {
            Class1 class1 = new Class1();

            string vin = "JH4KA815FMC0120GG";
            bool expected = false;

            bool actual = class1.CheckVIN(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Vin_normal() //простая проверка
        {
            Class1 class1 = new Class1();

            string vin = "JH4KA8GGFMC012098";
            bool expected = true;

            bool actual = class1.CheckVIN(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Check_Vin_With_WMS() //
        {
            Class1 class1 = new Class1();

            string vin = "GH4KA8GGFMC012098";
            bool expected = true;

            bool actual = class1.CheckVIN(vin);
            Assert.AreEqual(expected, actual);
        }
    }

}
