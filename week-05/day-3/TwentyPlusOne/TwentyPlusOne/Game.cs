using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
    public class Game
    {
        static List<Card> cards = new List<Card>();
        Card playerCard = new Card();
        Card playerCard2 = new Card();
        public static int playerVal = 0;
        public static int counter = 0;
        public static int highScore = 0;
        public int housesHand = Card.randy.Next(15, 22);
        public static string nameAndScore;

        public Game()
        {
            
        }

        internal void Start()
        {
            Console.WriteLine("Press a key to shuffle cards first!");
            Console.ReadKey();
            Console.WriteLine("Cards suffled and ready to go!");
            for (int i = 0; i <= 52; i++)
            {
                cards.Add(new Card());
            }
            PlayersChoice();
            PlayersChoice();
        }

        public void PlayersChoice()
        {
            Console.WriteLine("Enter [r]andom, [f]irstCard, [l]astcard pulling.");
            string playersChoice = Console.ReadLine();
            if (playersChoice == "r")
            {
                Console.WriteLine("Randomly pulling card from deck.");
                PullRandom();
            }
            else if (playersChoice == "f")
            {
                Console.WriteLine("Pulling the very first card of deck.");
                PullFirst();
            }
            else if (playersChoice == "l")
            {
                Console.WriteLine("Pulling the last card of deck.");
                PullLast();
            }
            else PlayersChoice();
        }

        public void PullFirst()
        {
            playerCard = cards[0 + counter];
            Console.WriteLine($"You pulled the card: {playerCard.Type} {playerCard.Rank}");
            ConverterForCardToInt();
        }

        public void PullLast()
        {
            playerCard = cards[cards.Count() - 1 - counter];
            Console.WriteLine($"You pulled the card: {playerCard.Type} {playerCard.Rank}");
            ConverterForCardToInt();
        }

        public void PullRandom()
        {
            playerCard = cards[Card.randy.Next(0, cards.Count())];
            Console.WriteLine($"You pulled the card: {playerCard.Type} {playerCard.Rank}");
            ConverterForCardToInt();
        }

        public void ConverterForCardToInt()
        {
            
            if (playerCard.Rank == Card.RankList.Jack || playerCard.Rank == Card.RankList.King 
            | playerCard.Rank == Card.RankList.Queen)
            {
                playerVal = playerVal + 10;
            }
            else if (playerCard.Rank == Card.RankList.Ace && playerVal > 10)
            {
                playerVal = playerVal + 1;
            }
            else
            {
                playerVal += (int)playerCard.Rank;
            }
            counter++;
           PlayersHand();
        }

        internal void PlayersChoiceForHit()
        {
            Console.WriteLine("Would you like another card? Press [y]es or [n]o.");
            string choice = Console.ReadLine();
            if (choice == "y")
            {
                PlayersChoice();
            }
            else if (choice == "n")
            {
                Console.WriteLine($"The value of your hand is: {playerVal}.");
                WinOrLose();
            }
            else
            {
                PlayersChoiceForHit();
            }
        }

        public void PlayersHand()
        {
            Console.WriteLine($"The value of your hand is: {playerVal}.");
            
            if (playerVal < 21 && counter >= 2)
            {
                PlayersChoiceForHit();
            }
            else if (playerVal >= 21)
            {
                WinOrLose();
            }
        }

        internal void HousesHand()
        {
            Console.WriteLine($"The hand of the House is: {housesHand}.");
        }

        internal void HighScoreCounter()
        {
            highScore = 100 * (playerVal - housesHand) + 10 * (2 - counter);
        }

        public void WinOrLose()
        {
            HousesHand();
            if (housesHand < playerVal && playerVal <= 21)
            {
                Console.WriteLine("Player won! Congrats!");
                Console.WriteLine("Please enter your name for the BlackJack Wall Of Fame for your highscore!");
                string nameOfWinner = Console.ReadLine();
                HighScoreCounter();
                nameAndScore = $"{nameOfWinner} {highScore}";
                HighScore.HighAdder(nameAndScore);
            }
            else if(housesHand == playerVal)
            {
                Console.WriteLine("Player's hand and House's hand have same value! Better luck next time!");
            }
            else
            {
                Console.WriteLine("House won! You lost this time, mate.");
            }
            Console.WriteLine("Wanna see current BlackJack Wall Of Fame highscore list? Press [y]es!");
            string wantToSeeHighScore = Console.ReadLine();
            if (wantToSeeHighScore == "y")
            {
                HighScore.HighLister();
                Console.ReadKey();
            }
            Console.WriteLine("Would you like a new game? Press [y]es!");
            string wantNewGame = Console.ReadLine();
            if (wantNewGame == "y")
            {
                housesHand = Card.randy.Next(15, 22);
                playerVal = 0;
                counter = 0;
                highScore = 0;
                cards = new List<Card>();
                this.Start();
            }

        }
    }
}

