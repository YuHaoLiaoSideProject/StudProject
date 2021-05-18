using System;
using System.Linq;
using StudProject.Models;

namespace StudProject.CardVerifies
{
    public class FourOfaKindCardVerify : BaseCardVerify
    {
        public FourOfaKindCardVerify(VerifyModel verify) : base(verify) { }

        public override bool IsValidate()
        {
            return _CardCount.Values.Contains(4);
        }
    }
}
