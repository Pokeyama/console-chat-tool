using SampleOnionClient;
using Xunit;

namespace ChatTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var args = new ChatArg(new []{"--userName=hirayama"});
        Assert.Equal("hirayama", args.userName);
    }
    
    [Fact]
    public void Test2()
    {
        var args = new ChatArg(new []{"--userName=hirayama"});
        Assert.Equal("sampleRoom", args.roomName);
    }
    
    [Fact]
    public void Test3()
    {
        var args = new ChatArg(new []{"--userName=hirayama","--roomName=linqroom"});
        Assert.Equal("linqroom", args.roomName);
    }
}