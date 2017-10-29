using SportLucky.Service.Domain.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using SportLucky.Service.Domain.Utility;

namespace SportLucky.Service.Domain.Business.Tests
{
    [TestClass()]
    public class CommunityControllerTest : Test.BaseControllerTest
    {
        [TestMethod()]
        public void SubmitCmuNoteTest()
        {
            var response = CommunityManager.GetInstance().SubmitCmuNote(new Contract.SubmitCmuNoteRequest
            {
                Content = "很好!",
                Imgs = null,
                UserID = 1
            });
            response.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
            response.NoteID.Should().BeGreaterThan(0);
        }

        [TestMethod()]
        public void SubmitCmuNoteCommentTest()
        {
            var response = CommunityManager.GetInstance().SubmitCmuNoteComment(new Contract.SubmitCmuNoteCommentRequest
            {
                NoteID = 1,
                Content = "很好!",
                IsAgreed = true,
                UserID = 1
            });
            response.Should().NotBeNull();
            response.Result.Should().Be(ResultCode.Success);
            response.NoteCommentID.Should().BeGreaterThan(0);
        }
    }
}
