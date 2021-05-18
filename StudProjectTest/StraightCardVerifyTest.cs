using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudProject;
using StudProject.CardVerifies;
using StudProject.Models;

namespace StudProjectTest
{
    [TestClass]
    public class StraightCardVerifyTest
    {
        [TestMethod]
        public void 順子()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.A },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Three },
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.Two },
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.Four },
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Five },
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new StraightCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 特殊順子()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.A },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.K },
                new CardModel{ Type = CardTypeEnum.Heart,Value = CardEnum.J },
                new CardModel{ Type = CardTypeEnum.Spade,Value = CardEnum.Ten },
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Q },
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new StraightCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 不是順子是同花順()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.A },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.K },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.J },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Ten },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Q },
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new StraightCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }

    }
}
