using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace GreenStack.Umbraco.TheStarterKit.Composers;

public class DataProtectionComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        var environment = builder.Services.BuildServiceProvider()
            .GetRequiredService<IHostEnvironment>();

        var keysPath = environment.IsProduction()
            ? "/app/keys"
            : Path.Combine(environment.ContentRootPath, "DataProtection-Keys");

        if (!Directory.Exists(keysPath))
        {
            Directory.CreateDirectory(keysPath);
        }

        builder.Services.AddDataProtection()
            .PersistKeysToFileSystem(new DirectoryInfo(keysPath));
    }
}
