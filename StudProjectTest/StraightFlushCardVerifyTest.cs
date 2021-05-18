using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudProject;
using StudProject.CardVerifies;
using StudProject.Models;

namespace StudProjectTest
{
    [TestClass]
    public class StraightFlushCardVerifyTest
    {
        [TestMethod]
        public void 同花順()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.A },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Three },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Two },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Four },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Five },
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new StraightFlushCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 特殊同花順()
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
            bool isValidate = new StraightFlushCardVerify(verify).IsValidate();
            Assert.IsTrue(isValidate);
        }
        [TestMethod]
        public void 不是同花順是順子()
        {
            List<CardModel> cards = new List<CardModel>
            {
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.A },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.K },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.J },
                new CardModel{ Type = CardTypeEnum.Diamond,Value = CardEnum.Ten },
                new CardModel{ Type = CardTypeEnum.Club,Value = CardEnum.Q },
            };
            VerifyModel verify = cards.GetVerifyModel();
            bool isValidate = new StraightFlushCardVerify(verify).IsValidate();
            Assert.IsFalse(isValidate);
        }

    }
}
