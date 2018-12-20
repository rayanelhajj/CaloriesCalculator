using System;
using System.Collections.Generic;
using System.Text;

namespace CaloriesCalculator
{
  public class CaloriesCalculator
  {

    public static int Calculate_BasicCalories(User user)
    {
      int calories = 0;

      if (user.Age >= 18 && user.Age < 30)
      {
        user.Age_Category = User.Age_Categories.Adult;
      }
      else if (user.Age >= 30 && user.Age < 60)
      {
        user.Age_Category = User.Age_Categories.MidAged;
      }
      else if (user.Age >= 60)
      {
        user.Age_Category = User.Age_Categories.Old;
      }
      else
      {
        // exit
        return -1;
      }

      switch (user.Age_Category)
      {
        case User.Age_Categories.Adult:
          if (user.Gender == User.Gender_Val.MALE)
          {
            calories = (int)(15.4 * user.Weight) + 679;
          }
          if (user.Gender == User.Gender_Val.FEMALE)
          {
            calories = (int)(14.7 * user.Weight) + 496;
          }
          break;
        case User.Age_Categories.MidAged:
          if (user.Gender == User.Gender_Val.MALE)
          {
            calories = (int)(11.6 * user.Weight) + 879;
          }
          if (user.Gender == User.Gender_Val.FEMALE)
          {
            calories = (int)(8.7 * user.Weight) + 829;
          }
          break;
        case User.Age_Categories.Old:
          if (user.Gender == User.Gender_Val.MALE)
          {
            calories = (int)(13.5 * user.Weight) + 487;
          }
          if (user.Gender == User.Gender_Val.FEMALE)
          {
            calories = (int)(10.5 * user.Weight) + 596;
          }
          break;
      }

      user.Basic_Calories = calories;
      return calories;
    }

    public static double Get_Activity_Factor(User user)
    {
      double activity_factor = 0.0;

      switch (user.GetActivity_Level)
      {
        case User.Activity_Level.Light:
          activity_factor = 0.2;
          break;
        case User.Activity_Level.Medium:
          activity_factor = 0.3;
          break;
        case User.Activity_Level.High:
          activity_factor = 0.4;
          break;
        case User.Activity_Level.Extreme:
          activity_factor = 0.5;
          break;
      }
      return activity_factor;
    }

    public static double CalculateActivityNeeds(User user, double activity_Factor)
    {
      if (user.Basic_Calories == 0)
      {
        return 0.0;
      }

      double activity_needs = user.Basic_Calories * activity_Factor;
      user.Activity_Calories = activity_needs;

      return activity_needs;
    }

    public static double CalculateDigestionCalories(User user)
    {
      if (user.Basic_Calories == 0 || user.Activity_Calories == 0.0)
      {
        return 0.0;
      }
      double digestion_calories = (user.Basic_Calories + user.Activity_Calories) * 0.1;
      user.Digestion_Calories = digestion_calories;

      return digestion_calories;
    }

    public static int CalculateTotalCalories(User user)
    {
      if (user.Basic_Calories == 0 || user.Activity_Calories == 0.0 || user.Digestion_Calories == 0.0)
      {
        return 0;
      }
      int total_calories = (int)(user.Basic_Calories + user.Activity_Calories + user.Digestion_Calories);
      user.Total_Calories = total_calories;

      return total_calories;
    }
  }
}
