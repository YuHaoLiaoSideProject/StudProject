using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudProject;
using StudProject.CardVerifies;
using StudProject.Models;

namespace StudProjectTest
{
    [TestClass]
    public class TwoPairsCardVerifyTest
    {
        [TestMethod]
        public void 雙對子()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "K"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new TwoPairsCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 不是雙對子是葫蘆()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new TwoPairsCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }

        [TestMethod]
        public void 不是雙對子是對子 ()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "K"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "J"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new TwoPairsCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }
    }
}
