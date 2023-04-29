using えいようちゃん;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace えいようちゃんテスト
{
    [TestClass]
    public class TextMoldTest
    {
        [TestMethod]
        public void MakeShortFoodNameKonnnyaKu()
        {
            var result= TextMold.MakeShortFoodName("＜いも類＞　こんにゃく　赤こんにゃく");
            Assert.AreEqual("赤こんにゃく",result);
        }

        [TestMethod]
        public void MakeShortFoodNameRice()//米
        {
            var result = TextMold.MakeShortFoodName("こめ　［水稲穀粒］　発芽玄米");
            Assert.AreEqual("こめ［水稲穀粒］発芽玄米", result);
        }

        [TestMethod]
        public void MakeShortFoodNameNoodle()//カップ麺
        {
            var result = TextMold.MakeShortFoodName("こむぎ　［即席めん類］　中華スタイル即席カップめん　油揚げ　しょうゆ味　調理後全体　（添付調味料等を含むもの）");
            Assert.AreEqual("中華スタイル即席カップめん油揚げしょうゆ味調理後全体", result);
        }

        [TestMethod]
        public void MakeShortFoodNameBeef()//肉
        {
            var result = TextMold.MakeShortFoodName("＜畜肉類＞　うし　［和牛肉］　かた　赤肉　生");
            Assert.AreEqual("［和牛肉］かた赤肉生", result);
        }

        [TestMethod]
        public void MakeShortFoodNameTonziru()//調理済み
        {
            var result = TextMold.MakeShortFoodName("和風料理　汁物類　とん汁");
            Assert.AreEqual("とん汁", result);
        }

        [TestMethod]
        public void MakeDisplayNutrientValue0()//整数
        {
            var result = TextMold.MakeDisplayNutrientValue((float)0.02, 0);
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void MakeDisplayNutrientValue1()//小数点第一位
        {
            var result = TextMold.MakeDisplayNutrientValue((float)0.02, 1);
            Assert.AreEqual("Tr", result);
        }

        [TestMethod]
        public void MakeDisplayNutrientValue2()//小数点第ニ位
        {
            var result = TextMold.MakeDisplayNutrientValue((float)0.02, 2);
            Assert.AreEqual("0.02", result);
        }

        [TestMethod]
        public void NewLineFigureItemName1()
        {
            var result = TextMold.NewLineFigureItemName("あいうえお(g)");
            Assert.AreEqual("あいう\nえお\n(g)", result);
        }

        [TestMethod]
        public void NewLineFigureItemName2()
        {
            var result = TextMold.NewLineFigureItemName("あい(g)");
            Assert.AreEqual("あい\n(g)", result);
        }

        [TestMethod]
        public void RepleceKakko()
        {
            var result = TextMold.ReplaceKAKKO("あい(g)");
            Assert.AreEqual("あいg", result);
        }
    }
}
