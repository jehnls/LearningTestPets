using System;
using Xunit;
using Pets;


public class UnitTest1
{
    [Fact]
    public void DogTalkToOwnerReturnsWoof()
    {
        string expected = "Woof";
        string actual = new Dog().TalkToOwner();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CatTalkToOwnerReturnsMeow()
    {
        string expected = "Meow!";
        var actual = new Cat().TalkToOwner();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BirdTalkToOwnerReturnsTweet()
    {
        string expected = "Tweet!";
        var actual = new Bird().TalkToOwner();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestName()
    {
        string expected = "Hiin in in";
        var actual =  new Horse().TalkToOwner();

        Assert.Equal(expected, actual);
    }
}

//https://learn.microsoft.com/en-us/dotnet/core/tutorials/testing-with-cli