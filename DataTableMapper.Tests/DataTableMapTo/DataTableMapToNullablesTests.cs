﻿using NUnit.Framework;

namespace DataTableMapper.Tests.DataTableMapTo
{
    [TestFixture]
    public class DataTableMapToNullablesTests
    {
        //TODO Add support for nullable types!

        //[Test]
        //public void ReadAllNullRowToNullableTypes()
        //{
        //    var table = CreateTable();
        //    table.Rows.Add();


        //    //Act
        //    var list = table.MapTo<NullableTypesClass>();
        //    var x = list.First();
        //    //Assert
        //    Assert.AreEqual(1, list.Count());


        //    Assert.AreEqual(null, x.NullableInt);
        //}


        //[Test]
        //public void ReadValuesFromRowToNullableTypes()
        //{
        //    var table = CreateTable();
        //    table.Rows.Add(123);


        //    //Act
        //    var list = table.MapTo<NullableTypesClass>();
        //    var x = list.First();
        //    //Assert
        //    Assert.AreEqual(1, list.Count());


        //    Assert.AreEqual(123, x.NullableInt);
        //}


        //public class NullableTypesClass
        //{
        //    public int? NullableInt { get; set; }
        //}

        //private System.Data.DataTable CreateTable()
        //{
        //    var table = new System.Data.DataTable();

        //    table.Columns.Add("Int", typeof(int));
        //    table.Columns.Add("Bool", typeof(bool));

        //    return table;
        //}
    }
}
