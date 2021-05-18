using System.Linq;
using StudProject.Models;

namespace StudProject.CardVerifies
{
    /// <summary>
    /// 同花順
    /// </summary>
    public class StraightFlushCardVerify : StraightCardVerify
    {
        public StraightFlushCardVerify(VerifyModel verify) : base(verify) { }

        public override bool IsValidate()
        {
            //花色相同
            bool isSameType = _TypeCount.Values.Any(e => e == 5);
            return isSameType && IsStraight();
        }
    }
}
