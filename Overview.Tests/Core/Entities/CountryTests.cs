using Overview.Core.Entities;
using System;
using Xunit;

namespace Softensity.Tests.Core.Entities
{
    public class CountryTests
    {
        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoName()
        {
            int id = 1;
            string name = string.Empty;
            var createdAt = DateTime.Now;

            var exception = Assert.Throws<ArgumentNullException>(() => new Country(id, createdAt, name));
            Assert.Equal("Name is mandatory (Parameter 'Name')", exception.Message);
        }

        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoId()
        {
            int id = 0;
            string name = "Test";
            var createdAt = DateTime.Now;

            var exception = Assert.Throws<Exception>(() => new Country(id, createdAt, name));
            Assert.Equal("id should be greater than 0", exception.Message);
        }
    }
}
