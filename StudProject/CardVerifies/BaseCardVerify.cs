using System.Collections.Generic;
using StudProject.Models;

namespace StudProject.CardVerifies
{
    public abstract class BaseCardVerify
    {
        protected List<CardModel> _Cards;
        protected Dictionary<string, int> _CardCount;
        protected Dictionary<CardTypeEnum, int> _TypeCount;
        public BaseCardVerify(VerifyModel verify)
        {
            _Cards = verify.Cards;
            _CardCount = verify.CardCount;
            _TypeCount = verify.TypeCount;
        }
        public abstract bool IsValidate();
    }
}
