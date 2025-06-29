
using AzureKeyVaultEmulator.TestContainers;
using AzureKeyVaultEmulator.TestContainers.Helpers;
using System.Threading.Tasks;

namespace AzureKeyVaultEmulator.TestContainersDemo
{
    public class BasicUsageTests : IAsyncLifetime
    {
        private AzureKeyVaultEmulatorContainer? _container;
        private readonly string _basicSecretName = Guid.NewGuid().ToString();
        private readonly string _basicSecretValue = Guid.NewGuid().ToString();

        public async Task InitializeAsync()
        {
            _container = new AzureKeyVaultEmulatorContainer();

            await _container.StartAsync();

            var client = _container.GetSecretClient();

            await client.SetSecretAsync(_basicSecretName, _basicSecretValue);
        }

        public async Task DisposeAsync()
        {
            if(_container is not null)
                await _container.DisposeAsync();
        }

        [Fact]
        public async Task CreateSecret()
        {
            ArgumentNullException.ThrowIfNull(_container);

            var client = _container.GetSecretClient();

            var secretFromStore = await client.GetSecretAsync(_basicSecretName);

            Assert.Equal(_basicSecretValue, secretFromStore.Value.Value);
        }
    }
}
