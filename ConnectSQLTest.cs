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
    class ConnectSQLTest
    {
        [TestMethod]
        public void GetCommpositionNameTest()
        {
            var d=ConnectSQL.GetCompositionName();
            Assert.AreEqual((58,5,"分類番号"),(d.Rows.Count,d.Columns.Count,d.Rows[0][0].ToString()));
        }

        [TestMethod]
        public void GetFoodCompositionFoodsTest()
        {
            var result= ConnectSQL.GetFoodCompositionFoods(1)[0];
            Assert.AreEqual((1, "アマランサス　玄穀"),result);
        }

        [TestMethod]
        public void GetFoodCompositionValueTest()
        {
            var result = ConnectSQL.GetFoodCompositionValue(1)[12];
            Assert.AreEqual("6",result);
        }

        [TestMethod]
        public void GetFoodCompositionValueTestWater()
        {
            var result = ConnectSQL.GetFoodCompositionValue(0);
            Assert.AreEqual("100", result[7]);
        }
    }
}
