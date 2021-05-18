using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudProject;
using StudProject.CardVerifies;
using StudProject.Models;

namespace StudProjectTest
{
    [TestClass]
    public class OnePairsCardVerifyTest
    {
        [TestMethod]
        public void 對子()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "K"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "J"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new OnePairsCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 不是對子是葫蘆()
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
            bool isValidate = new OnePairsCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }

        [TestMethod]
        public void 不是對子是雙對子 ()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "K"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new OnePairsCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }
    }
}
