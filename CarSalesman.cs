using System;

public class CarSalesman: Salesman
{
  public CarSalesman(string firstName, string lastName) :base(firstName, lastName)
   {

   }
   public override void Sell()
   {
       Console.WriteLine(string.Format("Hi my name is {0}.I would like to recommend you to buy this pen!",this.FullName));

   }
}




  /*  private string _firstName;
     private string _lastName;

     public string FullName
      {
        get
         {
            return string.Format("{0} {1}", this._firstName, this._lastName);
         } 
      } 
 
      public CarSalesman(string firstName, string lastName)
      {
        this._firstName = firstName;
        this._lastName = lastName; 
      }

      public void Sell()
      {
        Console.WriteLine(string.Format("Hi my name is {0}.I would like to recommend you to buy this car!",this.FullName));
      }
*/





