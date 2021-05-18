using System.Collections.Generic;
using System.Linq;
using StudProject.Models;

namespace StudProject
{
    public static class ExtCard
    {
        public static VerifyModel GetVerifyModel(this List<CardModel> cards)
        {
            Dictionary<string, int> cardCount =
                cards.GroupBy(e => e.Value)
                .ToDictionary(e => e.Key, e => e.Count());

            Dictionary<CardTypeEnum, int> typeCount =
                cards.GroupBy(e => e.Type)
                .ToDictionary(e => e.Key, e => e.Count());

            VerifyModel verify = new VerifyModel
            {
                Cards = cards,
                CardCount = cardCount,
                TypeCount = typeCount
            };
            return verify;
        }
    }
}
