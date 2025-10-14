using System;
using System.Threading;
using LibraryManagementAPI.Models;
using Xunit;

namespace LibraryManagementAPI.Tests.Models
{
    public class BaseEntityTests
    {
        [Fact]
        public void BaseEntity_CreatedAt_ShouldBeSetOnCreation()
        {
            var before = DateTime.UtcNow;
            var baseEntity = new TestBaseEntity();
            var after = DateTime.UtcNow;

            Assert.InRange(baseEntity.CreatedAt, before, after);
        }

        [Fact]
        public void BaseEntity_UpdatedAt_ShouldBeUpdated()
        {
            var baseEntity = new TestBaseEntity();
            var originalUpdatedAt = baseEntity.UpdatedAt;

            Thread.Sleep(10);

            var newTime = DateTime.UtcNow;
            baseEntity.UpdatedAt = newTime;

            Assert.NotEqual(originalUpdatedAt, baseEntity.UpdatedAt);
            Assert.Equal(newTime, baseEntity.UpdatedAt);
        }

        public class TestBaseEntity : BaseEntity
        {
        }
    }
}
