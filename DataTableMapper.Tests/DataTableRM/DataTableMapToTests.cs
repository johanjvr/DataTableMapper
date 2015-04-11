﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTableMapper.DataTable;

namespace DataTableMapper.Tests.DataTableRM
{
    [TestFixture]
    public class DataTableMapToTests
    {
        [Test]
        public void MapToMyTestClass1()
        {
            //Arrange

            var table = CreateTable();
            table.Rows.Add(1, "Padraic Duffy", "1987-09-11", 1.82);

            //Act
            var xList = table.MapTo<MyTestClass>();

            var c1 = xList.First();

            //Assert
            Assert.AreEqual(1, xList.Count());

            Assert.AreEqual(1, c1.Id);
            Assert.AreEqual("Padraic Duffy", c1.Name);
            Assert.AreEqual(1.82, c1.Height);
            Assert.AreEqual(new DateTime(1987, 09, 11), c1.DOB);

        }

        [Test]
        public void MapToMyTestClass2()
        {
            //Arrange

            var table = CreateTable();
            table.Rows.Add(1, "Padraic Duffy", "1987-09-11", 1.82);
            table.Rows.Add(2, "James Maguire", "1986-09-11", 1.78);

            //Act
            var xList = table.MapTo<MyTestClass>();

            var c1 = xList.First();
            var c2 = xList.Skip(1).First();

            //Assert
            Assert.AreEqual(2, xList.Count());

            Assert.AreEqual(1, c1.Id);
            Assert.AreEqual("Padraic Duffy", c1.Name);
            Assert.AreEqual(1.82, c1.Height);
            Assert.AreEqual(new DateTime(1987, 09, 11), c1.DOB);

            Assert.AreEqual(2, c2.Id);
            Assert.AreEqual("James Maguire", c2.Name);
            Assert.AreEqual(1.78, c2.Height);
            Assert.AreEqual(new DateTime(1986, 09, 11), c2.DOB);

        }


        
        private System.Data.DataTable CreateTable()
        {
            var table = new System.Data.DataTable();

            table.Columns.Add("Id");
            table.Columns.Add("Name");
            table.Columns.Add("DOB");
            table.Columns.Add("Height");



            return table;
        }

    }
}
