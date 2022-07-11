using Overview.Core.Entities;
using Overview.Core.Enums;
using System;
using Xunit;

namespace Softensity.Tests.Core.Entities
{
    public class FollowUpTests
    {
        [Fact]
        public void ShouldNotCreateInstance_WhenOverviewIdIsNotGreaterThanZero()
        {
            var id = 1;
            var overviewId = -1;
            var feedbackType = FeedbackType.Career;
            var createdAt = DateTime.Now;
            var evaluation = FollowUpEvaluation.Green;

            var exception = Assert.Throws<Exception>(() => new FollowUp(id, overviewId, feedbackType, evaluation, createdAt));
            Assert.Equal("OverviewId should be greater than 0", exception.Message);
        }

        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoId()
        {
            var id = -1;
            var overviewId = 1;
            var feedbackType = FeedbackType.Career;
            var createdAt = DateTime.Now;
            var evaluation = FollowUpEvaluation.Green;

            var exception = Assert.Throws<Exception>(() => new FollowUp(id, overviewId, feedbackType, evaluation, createdAt));
            Assert.Equal("id should be greater than 0", exception.Message);
        }

        [Fact]
        public void ShouldCreateInstance_WhenParamsAreValid()
        {
            var id = 1;
            var overviewId = 1;
            var feedbackType = FeedbackType.Career;
            var createdAt = DateTime.Now;
            var evaluation = FollowUpEvaluation.Green;

            var followUp = new FollowUp(id, overviewId, feedbackType, evaluation, createdAt);
            Assert.True(followUp != null);
        }
    }
}
