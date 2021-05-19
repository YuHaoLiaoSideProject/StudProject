using System;
using System.Linq;
using StudProject.Models;

namespace StudProject.CardVerifies
{
    /// <summary>
    /// 三條
    /// </summary>
    public class ThreeOfAKindCardVerify : BaseCardVerify
    {
        public ThreeOfAKindCardVerify(VerifyModel verify) : base(verify) { }

        public override bool IsValidate()
        {
            return _CardCount.Values.Contains(3) && _CardCount.Values.IsContainTimes(value: 1, frequency: 2);
        }
    }
}
