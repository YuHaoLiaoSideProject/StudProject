using System;
using System.Collections.Generic;
using System.Linq;
using StudProject.Models;

namespace StudProject.CardVerifies
{
    /// <summary>
    /// 順子
    /// </summary>
    public class StraightCardVerify : BaseCardVerify
    {
        public StraightCardVerify(VerifyModel verify) : base(verify) { }

        public override bool IsValidate()
        {
            //花色相同
            bool isSameType = _TypeCount.Values.Any(e => e == 5);


            return isSameType == false && IsStraight();
        }
        protected bool IsStraight()
        {
            //正常情境順子
            bool isStraight = IsStraight(_Cards.Select(e=>e.Value.ToInt()));

            if (isStraight)
            {
                return true;
            }

            //不包含Ａ
            if (_Cards.Select(e => e.Value).Contains(CardEnum.A) == false)
            {
                return false;
            }
            //特殊情境判斷 10 J Q K A
            var cards = _Cards.Select(e =>
                {
                    int value = e.Value.ToInt();
                    if (e.Value == CardEnum.A)
                    {
                        value = 14;
                    }
                    return value;
                }
            );
            return IsStraight(cards);
        }

        private bool IsStraight(IEnumerable<int> cards)
        {
            bool isStraight = cards.OrderBy(e => e).Select((item, index) => item - index).Distinct().Count() == 1;
            return isStraight;
        }
    }
}
