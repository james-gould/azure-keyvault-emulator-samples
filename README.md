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

> [!CAUTION]
> These scripts are under active development, if they're not available please [read these docs](https://github.com/james-gould/azure-keyvault-emulator/blob/development/docs/CONFIG.md#local-docker) which will detail how to get up and running.

Without Aspire you need to directly configure the container on your local machine. To make this easier scripts are available for major OS types.

- [Linux](scripts/linux.sh)
- [MacOS](scripts/macos.sh)
- [Windows (WSL2 required)](scripts/windows.ps1)

Run your script of choice, interact when prompted and then set your `vaultUri` to `https://localhost:4997` in your application!
