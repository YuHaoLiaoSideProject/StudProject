using System;
using System.Linq;
using StudProject.Models;

namespace StudProject.CardVerifies
{
    /// <summary>
    /// 葫蘆
    /// </summary>
    public class FullHouseCardVerify : BaseCardVerify
    {
        public FullHouseCardVerify(VerifyModel verify) : base(verify) { }

        public override bool IsValidate()
        {
            return _CardCount.Values.Contains(2) && _CardCount.Values.Contains(3);
        }
    }
}
