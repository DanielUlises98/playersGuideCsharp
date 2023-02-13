using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatacombsOfTheClass
{
    public class TheCard
    {
        public CardColors Colors { get; set; }
        public CardRank Rank { get; set; }
        public TheCard(CardColors color, CardRank rank)
        {
            Colors= color;
            Rank= rank; 
        }
        public bool IsSymbol => Rank == CardRank.Ampersand || Rank == CardRank.Caret || Rank == CardRank.DollarSign || Rank == CardRank.Percentage;
        public bool IsNumber => !IsSymbol;
    }

    public enum CardColors{
        Red,
        Green,
        Blue,
        Yellow
    };
    public enum CardRank
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eght,
        Nine,
        Ten,
        DollarSign,
        Percentage,
        Caret,
        Ampersand

    };
}
