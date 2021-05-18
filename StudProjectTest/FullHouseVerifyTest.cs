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
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Three},
                new CardModel{ Type = CardTypeEnum.Diamond,Value =CardEnum.Three},
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.A},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new FullHouseCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 不是葫蘆是三條()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Two},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Three},
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.A},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new FullHouseCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }

        [TestMethod]
        public void 不是葫蘆是鐵支()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Two},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.A},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new FullHouseCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }
    }
}
