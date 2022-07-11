using Overview.Core.Entities;
using System;
using Xunit;

namespace Softensity.Tests.Core.Entities
{
    public class EmployeeTests
    {
        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoName()
        {
            int id = 1;
            string name = string.Empty;
            int countryId = 1;
            int communityId = 1;
            int projectId = 1;
            var createdAt = DateTime.Now;

            var exception = Assert.Throws<ArgumentNullException>(() => new Employee(id, createdAt, name, countryId, communityId, projectId));
            Assert.Equal("Name is mandatory (Parameter 'Name')", exception.Message);
        }

        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoCountryId()
        {
            int id = 1;
            string name = "Test";
            int countryId = 0;
            int communityId = 1;
            int projectId = 1;
            var createdAt = DateTime.Now;

            var exception = Assert.Throws<Exception>(() => new Employee(id, createdAt, name, countryId, communityId, projectId));
            Assert.Equal("CountryId should be greater than 0", exception.Message);
        }

        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoCommunityId()
        {
            int id = 1;
            string name = "Test";
            int countryId = 1;
            int communityId = 0;
            int projectId = 1;
            var createdAt = DateTime.Now;

            var exception = Assert.Throws<Exception>(() => new Employee(id, createdAt, name, countryId, communityId, projectId));
            Assert.Equal("CommunityId should be greater than 0", exception.Message);
        }

        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoProjectId()
        {
            int id = 1;
            string name = "Test";
            int countryId = 1;
            int communityId = 1;
            int projectId = 0;
            var createdAt = DateTime.Now;

            var exception = Assert.Throws<Exception>(() => new Employee(id, createdAt, name, countryId, communityId, projectId));
            Assert.Equal("ProjectId should be greater than 0", exception.Message);
        }

        [Fact]
        public void ShouldNotCreateInstance_WhenThereIsNoId()
        {
            int id = 0;
            string name = "Test";
            int countryId = 1;
            int communityId = 1;
            int projectId = 0;
            var createdAt = DateTime.Now;

            var exception = Assert.Throws<Exception>(() => new Employee(id, createdAt, name, countryId, communityId, projectId));
            Assert.Equal("id should be greater than 0", exception.Message);
        }

        [Fact]
        public void ShouldCreateInstance_WhenParamsAreValid()
        {
            int id = 1;
            string name = "Test";
            int countryId = 1;
            int communityId = 1;
            int projectId = 1;
            var createdAt = DateTime.Now;

            var employee = new Employee(id, createdAt, name, countryId, communityId, projectId);
            Assert.True(employee != null);
        }
    }
}
