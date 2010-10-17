﻿using System;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Mathematical.MatrixTests
{
    [TestFixture]
    public class InterchangeColumns
    {

        [Test]
        public void Simple()
        {
            var matrix = MatrixTest.GetTestMatrix();

            var columnCount = matrix.Columns;
            var rowCount = matrix.Rows;

            matrix.InterchangeColumns(0, 1);

            Assert.AreEqual(matrix.Columns, columnCount);
            Assert.AreEqual(matrix.Rows, rowCount);

            for (var i = 0; i < matrix.Rows; i++)
            {
                for (var j = 0; j < matrix.Columns; j++)
                {
                    if (j == 0)
                    {
                        Assert.AreEqual(matrix[i, j], (i) + (j + 1));
                    }
                    else if (j == 1)
                    {
                        Assert.AreEqual(matrix[i, j], (i) + (j - 1));
                    }
                    else
                    {
                        Assert.AreEqual(matrix[i, j], i + j);
                    }
                }
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionInvalidColumn1()
        {
            var matrix = MatrixTest.GetTestMatrix();
            matrix.InterchangeColumns(-1, 1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionInvalidColumn2()
        {
            var matrix = MatrixTest.GetTestMatrix();
            matrix.InterchangeColumns(matrix.Columns, 1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionInvalidColumn3()
        {
            var matrix = MatrixTest.GetTestMatrix();
            matrix.InterchangeColumns(0, -1);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionInvalidColumn4()
        {
            var matrix = MatrixTest.GetTestMatrix();
            matrix.InterchangeColumns(0, matrix.Columns);
        }

    }
}