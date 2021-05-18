using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudProject;
using StudProject.CardVerifies;
using StudProject.Models;

namespace StudProjectTest
{
    [TestClass]
    public class ThreeOfAKindCardVerifyTest
    {
        [TestMethod]
        public void 三條()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new ThreeOfAKindCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 不是三條是鐵支()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new ThreeOfAKindCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }

        [TestMethod]
        public void 不是三條是葫蘆()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new ThreeOfAKindCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }

        [TestMethod]
        public void 不是三條是對子()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = "2"},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = "3"},
                new CardModel{ Type = CardTypeEnum.Heart,Value = "4"},
                new CardModel{ Type = CardTypeEnum.Spade,Value = "A"},
                new CardModel{ Type = CardTypeEnum.Club,Value = "A"},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new ThreeOfAKindCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }
    }
}
