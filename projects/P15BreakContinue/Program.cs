
/* if (DrawCard == 1)
{
    DrawAmmount = DrawAmmount - 1;
    Console.WriteLine(" The AI drew 1 match");
    Console.WriteLine("There are now " + DrawAmmount + " matches left.");
}
*/

namespace BlackJack;

class blackJackgame
{
    static void Main()
  {
      Console.WriteLine("Welcome to Blackjack!");
      Random random = new Random();
      int cards = 0;
      int dealer = 0;
      
      while (cards < 1)
      {
        PlayerDraw();
        
      }

      void PlayerDraw()
      {
          for (int i = 0; 1 <= 20; i++)
          {
              int playerDraw = random.Next(1, 12);
              cards += playerDraw;
              Console.WriteLine("you drew " + playerDraw + " for a total of " +cards);
              Thread.Sleep(1000);
              Console.WriteLine("Do you want to draw another card? Y/N");
              string yesNo = Console.ReadLine();

              bool drawAgain = yesNo == "y";
              bool stopDraw = yesNo == "n";

              if (drawAgain)
              { 
                  Thread.Sleep(100);
              }
              else if (stopDraw)
              {
                 break;
              }
              
          }
          
      }






  }
  
  
}

