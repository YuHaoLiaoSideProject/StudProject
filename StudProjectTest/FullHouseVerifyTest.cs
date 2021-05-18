using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudProject;
using StudProject.CardVerifies;
using StudProject.Models;

namespace StudProjectTest
{
    [TestClass]
    public class FullHouseVerifyTest
    {
        [TestMethod]
        public void 葫蘆()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new FullHouseCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 不是葫蘆()
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
            bool isValidate = new FullHouseCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }
    }
}
