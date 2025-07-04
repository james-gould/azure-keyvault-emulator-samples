using AzureKeyVaultEmulator.Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var options = new KeyVaultEmulatorOptions
{
    Persist  = true, // Store data in a reusable database, local on the host machine.
    LocalCertificatePath = @"C:/MyPath/To/TheFiles", // Configure where the certificates and db are stored.
    ShouldGenerateCertificates = true, // Should generate SSL certificates for you to install
    LoadCertificatesIntoTrustStore = true, // Install the SSL certificates automatically into the user trust store.
    Lifetime = ContainerLifetime.Persistent, // Prevent the container shutting down between sessions,
    ForceCleanupOnShutdown = false // Unstable, removes all local files from the LocalCertificatePath.
};

// Redirect existing resource to the emulator:

var keyVault = builder
    .AddAzureKeyVault("keyvault")
    .RunAsEmulator(/*options*/);

// Or directly create it without an existing Azure tenancy

//var keyVault = builder.AddAzureKeyVaultEmulator("keyvault"/*, options*/);

// Reference as usual!
builder
    .AddProject<Projects.WebApiWithEmulator>("webapiwithemulator")
    .WithReference(keyVault)
    .WaitFor(keyVault);

builder.Build().Run();