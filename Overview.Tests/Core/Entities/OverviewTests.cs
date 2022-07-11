using Overview.Core.Entities;
using System;
using Xunit;

namespace Overview.Tests.Core.Entities
{
    public class OverviewTests
    {
        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoNotes()
        {
            var id = 1;
            var notes = string.Empty;
            var createdAt = DateTime.Now;
            var emploeyeeId = 1;

            var exception = Assert.Throws<ArgumentNullException>(() => new OverviewEntity(id, createdAt, emploeyeeId, notes));
            Assert.Equal("Notes is mandatory (Parameter 'Notes')", exception.Message);
        }

        [Fact]
        public void ShouldNotCreateInstance_WhenEmploeyeeIdIsNotGreaterThanZero()
        {
            var id = 1;
            var notes = "Test";
            var createdAt = DateTime.Now;
            var emploeyeeId = -1;

            var exception = Assert.Throws<Exception>(() => new OverviewEntity(id, createdAt, emploeyeeId, notes));
            Assert.Equal("EmploeyeeId should be greater than 0", exception.Message);
        }

        [Fact]
        public void ShouldCreateInstance_WhenParamsAreValid()
        {
            var id = 1;
            var notes = "Test";
            var createdAt = DateTime.Now;
            var emploeyeeId = 1;

            var overview =  new OverviewEntity(id, createdAt, emploeyeeId, notes);
            Assert.True(overview != null);
        }
    }
}
