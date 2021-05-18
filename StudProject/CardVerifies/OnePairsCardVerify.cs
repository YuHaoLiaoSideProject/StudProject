using StudProject.Models;

namespace StudProject.CardVerifies
{
    public class OnePairsCardVerify : BaseCardVerify
    {
        public OnePairsCardVerify(VerifyModel verify) : base(verify) { }

        public override bool IsValidate()
        {
            return _CardCount.Values.IsContainTimes(quantity: 2, frequency: 1)
                && _CardCount.Values.IsContainTimes(quantity: 1, frequency: 3);
        }
    }
}
