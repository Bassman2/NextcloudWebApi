namespace NextcloudWebApiUnitTest;

[TestClass]
public class NextcloudVersionUnitTest : NextcloudBaseUnitTest
{
    [TestMethod]
    public async Task TestMethodGetUserAsync()
    {
        using var Nextcloud = new Nextcloud(storeKey, appName);

        var health = await Nextcloud.GetHealthAsync();

        Assert.IsNotNull(health, "Nextcloud version is null");
        Assert.AreEqual(new Version(11,6,1), new Version(health.Version!), nameof(health.Version));
    }
}
