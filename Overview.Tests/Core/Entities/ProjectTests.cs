using Overview.Core.Entities;
using System;
using Xunit;

namespace Overview.Tests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoName()
        {
            int id = 1;
            string name = string.Empty;
            var createdAt = DateTime.Now;
            
            var exception = Assert.Throws<ArgumentNullException>(() => new Project(id, createdAt, name));
            Assert.Equal("Name is mandatory (Parameter 'Name')", exception.Message);
        }

        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoId()
        {
            int id = 0;
            string name = "Test";
            var createdAt = DateTime.Now;

            var exception = Assert.Throws<Exception>(() => new Project(id, createdAt, name));
            Assert.Equal("id should be greater than 0", exception.Message);
        }
    }
}
