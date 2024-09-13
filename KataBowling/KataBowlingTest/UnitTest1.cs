namespace KataBowlingTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Bowling game = new Bowling();

        for (int i = 0; i < 20; i++)
        {
            game.Roll(0);
        }

        Assert.Equal(game.Score(), 0);
    }
}

public class Bowling
{
    public void Roll(int i)
    {
        
    }

    public int Score()
    {
        return -1;
    }
}