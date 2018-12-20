using TechTalk.SpecFlow;
using Xunit;

namespace CaloriesCalculator.SpecFlow
{
  [Binding]
  public sealed class CalculateBasicCaloriesSteps
  {
    User user;

    [Given(@"I have entered (.*) and (.*) and (.*)")]
    public void GivenIHaveEnteredAndAnd(int age, int gender, int weight)
    {
      user = new User
      {
        Age = age,
        Gender = (User.Gender_Val)gender,
        Weight = weight
      };
    }


    [When(@"I press calculate basic calories")]
    public void WhenIPressCalculateBasicCalories()
    {
      CaloriesCalculator.Calculate_BasicCalories(user);
    }

    [Then(@"the result should be (.*) on the screen")]
    public void ThenTheResultShouldBeOnTheScreen(int calories)
    {
      Assert.Equal(calories, user.Basic_Calories);
    }
  }
}
