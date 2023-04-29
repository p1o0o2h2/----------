using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using えいようちゃん;

namespace えいようちゃんテスト
{
    [TestClass]
    class JsonTest
    {
        [TestMethod]
        public void InportJsonTestOK()
        {
            var result = Json.InportFile(@"C:\Users\Arisa\source\repos\えいようちゃん\えいようちゃんテスト\水.json");
            Assert.AreEqual("水", result.SetDishes[0].meals[0].MealName);
        }
        [TestMethod]
        public void InportJsonTestErrer()
        {
            string result = "";
            try
            {
                var _ = Json.InportFile(@"C:\Users\Arisa\source\repos\えいようちゃん\えいようちゃんテスト\エラーファイル.json");
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            Assert.AreEqual("水", result.SetDishes[0].meals[0].MealName);

        }
    }
}
