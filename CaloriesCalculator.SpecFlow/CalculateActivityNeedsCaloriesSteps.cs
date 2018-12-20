using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace CaloriesCalculator.SpecFlow
{
  [Binding]
  public sealed class CalculateActivityNeedsCaloriesSteps
  {
    User user;
    double activity_factor;

    [Given(@"I have calculated my (.*)")]
    public void GivenIHaveCalculatedMy(int basicCalories)
    {
      user = new User
      {
        Basic_Calories = basicCalories
      };  
    }

    [Given(@"I have entered my (.*)")]
    public void GivenIHaveEnteredMy(int activity_level)
    {
      user.GetActivity_Level = (User.Activity_Level) activity_level;
      activity_factor = CaloriesCalculator.Get_Activity_Factor(user);
    }

    [When(@"I press calculate activity needs")]
    public void WhenIPressCalculateActivityNeeds()
    {
      CaloriesCalculator.CalculateActivityNeeds(user, activity_factor);
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(double activity_needs)
    {
      Assert.Equal(activity_needs, user.Activity_Calories, 2);
    }

  }
}
