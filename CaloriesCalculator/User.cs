using System;

namespace CaloriesCalculator
{
  public class User
  {
    public enum Gender_Val { MALE = 0, FEMALE = 1 }
    public enum Activity_Level { Light, Medium, High, Extreme }
    public enum Age_Categories { Adult, MidAged, Old }

    private int total_calories;

    public int Total_Calories
    {
      get { return total_calories; }
      set { total_calories = value; }
    }

    private int basic_calories;

    public int Basic_Calories
    {
      get { return basic_calories; }
      set { basic_calories = value; }
    }

    private double digestion_calories;

    public double Digestion_Calories
    {
      get { return digestion_calories; }
      set { digestion_calories = value; }
    }


    private double activity_calories;

    public double Activity_Calories
    {
      get { return activity_calories; }
      set { activity_calories = value; }
    }

    private Age_Categories age_Category;

    public Age_Categories Age_Category
    {
      get { return age_Category; }
      set { age_Category = value; }
    }

    private Activity_Level activity_Level;

    public Activity_Level GetActivity_Level
    {
      get { return activity_Level; }
      set { activity_Level = value; }
    }

    private int age;

    public int Age
    {
      get { return age; }
      set { age = value; }
    }

    private Gender_Val gender;

    public Gender_Val Gender
    {
      get { return gender; }
      set { gender = value; }
    }

    private double height;

    public double Height
    {
      get { return height; }
      set { height = value; }
    }

    private double weight;

    public double Weight
    {
      get { return weight; }
      set { weight = value; }
    }

    public User()
    {

    }
  }
}
