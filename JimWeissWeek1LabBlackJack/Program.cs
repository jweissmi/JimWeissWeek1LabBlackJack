using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimWeissWeek1LabBlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a comment.

            //This is another comment.

            Console.WriteLine("Do you want to play Blackjack? (y/n)");
            string answer = Console.ReadLine();

            if (answer == "n")
            {
                return;
            }

            Card currCard = new Card();
            string suit = "";

            List<Card> UnShuffDeck = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                    suit = "Heart";
                else if (i == 1)
                    suit = "Diamond";
                else if (i == 2)
                    suit = "Spade";
                else
                    suit = "Club";
                for (int j = 0; j < 13; j++)
                {
                    currCard = new Card();
                    currCard.Suit = suit;

                    if (j == 0)
                    {
                        currCard.Face = "A";
                        currCard.Value = 1;
                    }
                    else if (j > 0 && j < 10)
                    {
                        currCard.Face = (j + 1).ToString();
                        currCard.Value = j + 1;
                    }
                    else if (j == 10)
                    {
                        currCard.Face = "J";
                        currCard.Value = 10;
                    }
                    else if (j == 11)
                    {
                        currCard.Face = "Q";
                        currCard.Value = 10;
                    }
                    else if (j == 12)
                    {
                        currCard.Face = "K";
                        currCard.Value = 10;
                    }
                    UnShuffDeck.Add(currCard);
                }
            }
            // shuffCard
            List<Card> randomDeck = UnShuffDeck.OrderBy(x => Guid.NewGuid()).ToList();

            Person player = new Person();
            Person dealer = new Person();

            Card dealerCard1 = new Card();
            dealerCard1 = randomDeck[1];
            dealer.Hand.Add(dealerCard1);
            Console.WriteLine("The dealer's first card is " + dealerCard1.Face + " " + dealerCard1.Suit);

            Card playerCard1 = new Card();
            playerCard1 = randomDeck[0];
            player.Hand.Add(playerCard1);
            Console.WriteLine("Your first card is " + playerCard1.Face + " " + playerCard1.Suit);

            Card playerCard2 = new Card();
            playerCard2 = randomDeck[2];
            player.Hand.Add(playerCard2);
            Console.WriteLine("Your second card is " + playerCard2.Face + " " + playerCard2.Suit);

            Card dealerCard2 = new Card();
            dealerCard2 = randomDeck[3];
            dealer.Hand.Add(dealerCard2);

            Console.WriteLine("Your total is " + player.sumHand());

            if (player.sumHand() > 21)
            {
                Console.WriteLine("You lose");
                Console.WriteLine("Your total is " + player.sumHand());
                Console.WriteLine("The dealer's total is " + dealer.sumHand());
            }
            else if (player.sumHand() == 21 && dealer.sumHand() != 21)
            {
                Console.WriteLine("You win");
                Console.WriteLine("Your total is " + player.sumHand());
                Console.WriteLine("The dealer's total is " + dealer.sumHand());
            }
            else if (player.sumHand() == 21 && dealer.sumHand() == 21)
            {
                Console.WriteLine("Tie. You lose.");
                Console.WriteLine("Your total is " + player.sumHand());
                Console.WriteLine("The dealer's total is " + dealer.sumHand());
            }
            else if (player.sumHand() < 21)
            {
                string playerAnswer = "";
                Console.WriteLine("Would you like another card? (y/n)");
                playerAnswer = Console.ReadLine();

                if (playerAnswer == "n")
                {
                    if (player.sumHand() < 21 && dealer.sumHand() > player.sumHand() && dealer.sumHand() <= 21)
                    {
                        Console.WriteLine("You lose");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());
                    }
                    else if (player.sumHand() == 21 && dealer.sumHand() == 21)
                    {
                        Console.WriteLine("Tie. You lose.");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());
                    }
                    else if (player.sumHand() == 21 && dealer.sumHand() != 21)
                    {
                        Console.WriteLine("You win");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());
                    }
                    else if (player.sumHand() < 21 && player.sumHand() > dealer.sumHand())
                    {
                        Console.WriteLine("You win");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());
                    }
                    else if (player.sumHand() < 21 && player.sumHand() == dealer.sumHand())
                    {
                        Console.WriteLine("Tie. You lose.");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());
                    }
                    else if (player.sumHand() < 21 && player.sumHand() < dealer.sumHand())
                    {
                        Console.WriteLine("You lose");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());
                    }
                }
                else
                {
                    //select another card
                    Card dealerCard3 = new Card();
                    dealerCard3 = randomDeck[4];
                    dealer.Hand.Add(dealerCard3);
                    Console.WriteLine("The dealer's third card is " + dealerCard3.Face + " " + dealerCard3.Suit);

                    Card playerCard3 = new Card();
                    playerCard3 = randomDeck[5];
                    player.Hand.Add(playerCard3);
                    Console.WriteLine("Your third card is " + playerCard3.Face + " " + playerCard3.Suit);

                    if (player.sumHand() > 21)
                    {
                        Console.WriteLine("You lose");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());

                    }
                    else if (player.sumHand() == 21 && dealer.sumHand() == 21)
                    {
                        Console.WriteLine("Tie. You lose.");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());

                    }
                    else if (player.sumHand() == 21 && dealer.sumHand() != 21)
                    {
                        Console.WriteLine("You win");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());

                    }
                    else if (player.sumHand() < 21 && player.sumHand() < dealer.sumHand())
                    {
                        Console.WriteLine("You win");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());

                    }
                    else if (player.sumHand() < 21 && player.sumHand() == dealer.sumHand())
                    {
                        Console.WriteLine("Tie. You lose.");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());
                    }
                    else if (player.sumHand() < 21 && player.sumHand() > dealer.sumHand())
                    {
                        Console.WriteLine("You lose");
                        Console.WriteLine("Your total is " + player.sumHand());
                        Console.WriteLine("The dealer's total is " + dealer.sumHand());

                    }

                }
            }

            //does anyone have 21 ?
            //Dealer.hand total =?
            //Player.hand.total = ?

            //if dealer.hand total = 21 && player hand total = 21
            //Dealer Wins
            //Game over.  Want to play again?


            //foreach (Card C in randomDeck)
            //{
            //    Console.WriteLine(C.Face + C.Suit);
            //}

            Console.WriteLine("Game over.  Want to play again?");
            string answer2 = Console.ReadLine();

            if (answer == "n")
            {
                return;
            }

        }
    }
    public class Card
    {
        #region Properties

        private string _suit;
        private string _face;
        private int _value;

        #endregion

        public string Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }
        public string Face
        {
            get { return _face; }
            set { _face = value; }
        }
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

    public class Person
    {
        #region Properties

        private List<Card> _hand;
        private bool _winspush;

        #endregion


        public Person()
        {
            this.Hand = new List<Card>();
        }

        #region Methods

        //This method will return an integer that is a sum of all cards in a hand.

        public int sumHand()
        {
            int sum = 0;
            foreach (Card card in _hand)
            {
                sum = sum + card.Value;
            }
            return sum;
        }

        #endregion

        public List<Card> Hand
        {
            get { return _hand; }
            set { _hand = value; }
        }
        public bool Winspush
        {
            get { return _winspush; }
            set { _winspush = value; }
        }
    }
}
