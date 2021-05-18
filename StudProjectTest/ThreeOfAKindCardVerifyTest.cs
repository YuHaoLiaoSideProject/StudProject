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
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Three},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Two},
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.A},
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
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Two},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.A},
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
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Two},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Two},
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.A},
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
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Two},
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Three},
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.Four},
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.A},
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.A},
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new ThreeOfAKindCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }
    }
}
