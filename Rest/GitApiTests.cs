using Rest.Builder;
using Xunit;

namespace Rest
{
    public class GitApiTests : BaseTest
    {
        public GitApiTests() : base()
        {
        }


        [Fact]
        public void Test_Get_Github_User_Success()
        {

            var emails = Api.GetEmails();

            Assert.True(ExpectedEmails.GetExpectedUser().Equals(emails[0]));
        }
    }
}
