using StudProject.Models;

namespace StudProject.CardVerifies
{
    /// <summary>
    /// 雙對子
    /// </summary>
    public class TwoPairsCardVerify : BaseCardVerify
    {
        public TwoPairsCardVerify(VerifyModel verify) : base(verify) { }

        public override bool IsValidate()
        {
            //篩選數量為２的資料且兩組
            return _CardCount.Values.IsContainTimes(quantity: 2, frequency: 2);
        }
    }
}
