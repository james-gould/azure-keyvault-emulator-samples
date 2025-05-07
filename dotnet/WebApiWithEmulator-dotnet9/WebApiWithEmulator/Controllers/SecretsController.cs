using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Mvc;

namespace WebApiWithEmulator.Controllers;

[Route("secrets")]
public class SecretsController(SecretClient secretClient) : ControllerBase
{
    [HttpGet("create")]
    public async Task<IActionResult> CreateSecret(
        [FromQuery] string name = "test",
        [FromQuery] string value = "123")
    {
        var secret = await secretClient.SetSecretAsync(name, value);

        return Ok(secret);
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetSecret([FromQuery] string name = "test")
    {
        var secretFromContainer = await secretClient.GetSecretAsync(name);

        return secretFromContainer is null ? NotFound($"Could not find secret with name {name}") : Ok(secretFromContainer);
    }
}
