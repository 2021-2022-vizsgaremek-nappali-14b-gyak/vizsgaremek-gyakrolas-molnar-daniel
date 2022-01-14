using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vizsgaremek.Models;

namespace Vizsgaremek.Models.Tests
{
    [TestClass()]
    public class ProgramInfoTests
    {
        [TestMethod()]
        public void ProgramInfoTestVersion()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            Version expected = new Version(0, 0, 3, 0);

            // act
            Version actual = programInfo.Version;

            // assert
            Assert.AreEqual(expected, actual, "Version is not 0.0.3.0");
        }

        [TestMethod()]
        public void ProgramInfoTestTitle()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Vizsgaremek";

            // act
            string actual = programInfo.Title;

            // assert
            Assert.AreEqual(expected, actual, "Title is not the same.");
        }

        [TestMethod()]
        public void ProgramInfoTestCompany()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Vasvári";

            // act
            string actual = programInfo.Company;

            // assert
            Assert.AreEqual(expected, actual, "Company is not the same.");
        }

        [TestMethod()]
        public void ProgramInfoTestDescription()
        {
            // arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "Program verzió, név, cég, leírás és navigáció működik.";

            // act
            string actual = programInfo.Description;

            // assert
            Assert.AreEqual(expected, actual, "Description is not the same.");
        }
    }
}