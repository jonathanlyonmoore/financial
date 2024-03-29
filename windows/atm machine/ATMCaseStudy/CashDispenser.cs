// CashDispenser.cs
// Represents the cash dispenser of the ATM
public class CashDispenser
{
   // the default initial number of bills in the cash dispenser
   private const int INITIAL_COUNT = 500;
   private int billCount; // number of $20 bills remaining

   // parameterless constructor initializes billCount to INITIAL_COUNT
   public CashDispenser()
   {
      billCount = INITIAL_COUNT; // set billCount to INITIAL_COUNT
   } // end constructor

   // simulates dispensing the specified amount of cash
   public void DispenseCash( decimal amount )
   {
      // number of $20 bills required
      int billsRequired = ( ( int ) amount ) / 20;
      billCount -= billsRequired;
   } // end method DispenseCash

   // indicates whether cash dispenser can dispense desired amount
   public bool IsSufficientCashAvailable( decimal amount ) 
   {
      // number of $20 bills required
      int billsRequired = ( ( int ) amount ) / 20;

      // return whether there are enough bills available
      return ( billCount >= billsRequired );
   } // end method IsSufficientCashAvailable
} // end class CashDispenser

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
