using System;
using Xunit;
using static ExhibitXamarin.RequestBuilder;

namespace ExhibitXamarin.xUnit
{
    public class RequestBuilderTest
    {
        private readonly RequestBuilder builder;

        public RequestBuilderTest()
        {
            builder = new RequestBuilder(new RestClientMock());
        }

        [Fact]
        public void Build_Null_DoesNotExist()
        {
            Action act= () => builder.Build(null);
            AssertDoesNotExist(act);
        }

        [Fact]
        public void Build_EmptyName_DoesNotExist()
        {
            Action act = () => builder.Build("");
            AssertDoesNotExist(act);
        }

        [Fact]
        public void Build_DoesNotExist_DoesNotExist()
        {
            Action act = () => builder.Build("DoesNotExist");
            AssertDoesNotExist(act);
        }

        [Fact]
        public void Build_QuestionsRequest()
        {
            GetRequest request = builder.Build("Questions");
            Assert.True(request is GetQuestionsRequest);
        }

        private void AssertDoesNotExist(Action act)
        {
            Assert.Throws<RequestDoesNotExist>(act);
        }

        private class RestClientMock : RestClient
        {
            public RestClientMock() : base(new UrlChecker())
            {
               
            }

        }
    }
}
