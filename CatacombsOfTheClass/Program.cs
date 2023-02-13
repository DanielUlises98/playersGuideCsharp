
using CatacombsOfTheClass;
using System.Xml;


Point p = new(2,3);
Point _ = new(-4, 0);

Console.WriteLine($"First point is in ({p.CoordinateX},{p.CoordinateY})");
Console.WriteLine($"Second point is in ({_.CoordinateX},{_.CoordinateY})");

RGBColorS rmColor = new(1, 100, 3);
RGBColorS purpleColor = RGBColorS.Purple;
Console.WriteLine($"This random color ({rmColor.RgbRed},{rmColor.RgbGreen},{rmColor.RgbBlue})");
Console.WriteLine($"This purple color ({purpleColor.RgbRed},{purpleColor.RgbGreen},{purpleColor.RgbBlue})");

CardColors[] colors = new CardColors[] { CardColors.Red, CardColors.Green, CardColors.Blue, CardColors.Yellow };

CardRank[] rank = new CardRank[] {CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four,CardRank.Five,CardRank.Six,CardRank.Seven,CardRank.Eght,CardRank.Nine
,CardRank.Ten,CardRank.DollarSign,CardRank.Percentage,CardRank.Caret,CardRank.Ampersand};



foreach (CardColors col in colors)
{
    foreach(CardRank rk in rank)
    {
        TheCard card = new TheCard(col, rk);
        Console.WriteLine($"New card is created: {card.Colors}, {card.Rank}, the card is a symbol: {card.IsSymbol}");
    }
}


   
