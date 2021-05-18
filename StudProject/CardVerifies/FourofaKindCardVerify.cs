using System;
using System.Linq;
using StudProject.Models;

namespace StudProject.CardVerifies
{
    public class FourofaKindCardVerify : BaseCardVerify
    {
        public FourofaKindCardVerify(VerifyModel verify) : base(verify) { }

        public override bool IsValidate()
        {
            return _CardCount.Values.Contains(4);
        }
    }
}
