namespace Genesis.Join.UnitTests
{
    using System.Linq;
    using Xunit;

    public sealed class JoinFixture
    {
        [Theory]
        [InlineData(new string[0], "", "")]
        [InlineData(new string[0], "-", "")]
        [InlineData(new[] { "foo", "bar" }, "", "foobar")]
        [InlineData(new[] { "foo", "bar" }, "-", "foo-bar")]
        [InlineData(new[] { "foo", "bar", "baz" }, "===", "foo===bar===baz")]
        [InlineData(new[] { "foo", "", "baz" }, "===", "foo======baz")]
        [InlineData(new[] { "foo", null, "baz" }, "===", "foo======baz")]
        public void join_joins_all_the_provided_strings(string[] strings, string separator, string expectedResult)
        {
            var result = strings.Join(separator);
            Assert.Equal(expectedResult, result);
        }
    }
}