using System;

class MainClass {
  public static void Main (string[] args) {

    string userAnswer = "yes";

    while (userAnswer == "yes") {
      Console.WriteLine("Total Parking Charge: $" + calculateCharges());

      Console.WriteLine("\nIs there another customer?");
      userAnswer = Console.ReadLine();
      userAnswer.ToLower();

      if (userAnswer == "no") {
        break;
      }
      else if (userAnswer == "yes") {
        continue;
      }
      else {
        while (userAnswer != "yes" && userAnswer != "no") {
          Console.WriteLine("\nInvalid answer! Is there another customer?");
          userAnswer = Console.ReadLine();
          userAnswer.ToLower();
        }
      }
    }
  }

  public static double calculateCharges() {

    int hoursParked = 0;
    int extraChargeHours = 0;
    double extraParkingCharge = 0.00;
    double totalParkingCharge = 0.00;
    
    Console.WriteLine("Total hours parked: ");
    hoursParked = Convert.ToInt32(Console.ReadLine());

    if (hoursParked <= 3) {
      totalParkingCharge += 2.00;
    }
    else if (hoursParked > 3) {
        extraChargeHours = hoursParked - 3;
        extraParkingCharge = extraChargeHours * 0.50;
        totalParkingCharge = 2.00 + extraParkingCharge;
    }

    if (totalParkingCharge > 10.00) {
      totalParkingCharge = 10.00;
    }

    return totalParkingCharge;
  }
}