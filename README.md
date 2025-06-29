# Azure Key Vault Emulator Sample Projects

<p align="center"><img src="assets/hero.png" height="25%" width="100%"></p>

> [!NOTE]
> The main repository for the [Azure Key Vault Emulator is here.](https://github.com/james-gould/azure-keyvault-emulator)

If you want to get going with the Emulator quickly these samples will show you a variety of applications and scripts you can run in your development environment.

## Running a sample

- Clone down the repository: `git clone https://github.com/james-gould/azure-keyvault-emulator-samples.git`
- `cd` into the directory: `cd azure-keyvault-emulator-samples`
- Navigate to the sample you want to run
- Use the `README.md` in the project for assistance if you're unsure.

## Available samples

### C#/.NET

The Emulator has direct support for .NET Aspire and can override an existing `AzureKeyVaultResource` to prevent provisioning at dev-time.

- [.NET 8 using Aspire.](dotnet/WebApiWithEmulator-dotnet8/)
- [.NET 9 using Aspire.](dotnet/WebApiWithEmulator-dotnet9/)

### Docker

Without Aspire you need to directly configure the container on your local machine. To make this easier scripts are available for major OS types.

It's highly recommended that you run the fully automated script, which supports all operating systems:

```
bash <(curl -fsSL https://github.com/james-gould/azure-keyvault-emulator/blob/master/docs/setup.sh)
```

If you wish to manually configure them, [documentation is available here.](https://github.com/james-gould/azure-keyvault-emulator/tree/master/docs/CertificateUtilities)