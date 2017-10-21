using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    class Card
    {
        public static Random randy = new Random((int)DateTime.Now.Millisecond);
        public TypeList Type;
        public RankList Rank;

        public Card()
        {
            Type = RandomType();
            Rank = RandomRank();
        }

        private TypeList RandomType()
        {

            return (TypeList)randy.Next(0, Enum.GetNames(typeof(TypeList)).Length);

        }

        private RankList RandomRank()
        {

            return (RankList)randy.Next(2, Enum.GetNames(typeof(RankList)).Length+2);

        }

        public enum ColorList
        {
            black,
            red
        }

        public enum TypeList
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades

        }

        public enum RankList
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 12,
            Queen = 13,
            King = 14,
            Ace = 11

        }

    }
}
