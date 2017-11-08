using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Groot.IntegrrationTests.TextFixtures
{
    [CollectionDefinition("BaseCollection")]
    public class Collection : ICollectionFixture<TestContext>
    {
    }
}
