using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint5.Task1.V2.Lib;
using System.IO;
namespace Tyuiu.ChazovaSR.Sprint5.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = $@"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint5\Tyuiu.ChazovaSR.Sprint5.Task1.V2\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
