namespace MagicLibrary.Test
{
    public class MagicClassTest
    {
        [Fact]
        public void Get1_Should_Return1()
        {
            MagicClass.Get1().Should().Be(1);
        }
    }
}