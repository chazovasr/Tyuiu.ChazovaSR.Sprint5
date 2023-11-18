using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChazovaSR.Sprint5.Task0.V19.Lib;
using System.IO;
namespace Tyuiu.ChazovaSR.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"C:\Users\chazo\source\repos\Tyuiu.ChazovaSR.Sprint5\Tyuiu.ChazovaSR.Sprint5.Task0.V19\bin\Debug\OutPutFileTask0.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
