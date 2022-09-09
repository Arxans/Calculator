using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Tests
{
    [TestClass()]
    public class DemoModelTests
    {
        [TestMethod()]
        public void Div_15div3_returned5()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "5";

            // act
            model.text = "15/3";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_15div5_returned3()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "3";

            // act
            model.text = "15/5";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_54div21_returned2()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "2";

            // act
            model.text = "54/21";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_5div20_returned0()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "0";

            // act
            model.text = "5/20";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_Empty_returnedEmpty()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "";

            // act
            model.text = "";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_div_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "/";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_5div0_returnedInfinity()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Infinity";

            // act
            model.text = "5/0";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_5divNegative5_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "5/-5";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_5divSymbol_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "5/a";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_SymbolDiv15_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "f/15";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_5divSymbols_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "5/absa";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_SymbolsDiv22_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "absa/22";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_5div5div_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "5/5/";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_15divdiv15_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "15//15";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_5divFloat_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "5/48.1";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_FloatDiv37_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "14.54/37";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_EmptyDiv5_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "/5";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_55_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "55";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_Symbol_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "a";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }

        [TestMethod()]
        public void Div_Symbols_returnedError()
        {
            // arrange 
            var model = new DemoModel();
            string expected = "Error";

            // act
            model.text = "aA*bcde_-/dav";
            model.Div();

            // assert            
            Assert.AreEqual(expected, model.text);
        }
    }
}