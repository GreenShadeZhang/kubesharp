namespace Kubesharp.Kube.UnitTest;

public class ClientConnectTest
{
    [Fact]
    public async Task ClientConnectTest_Connect_Success()
    {
        var factory = new KubeClientFactory();

        using var file = File.Open(@"C:\Users\bluec\.kube\config", FileMode.Open, FileAccess.Read);

        var client = await factory.CreateOrGetKubeClientAsync("", p => file);

        var result = await client.NamespaceApi.ListAsync(CancellationToken.None);

        Assert.NotNull(result);
        Assert.NotEmpty(result);
    }
}