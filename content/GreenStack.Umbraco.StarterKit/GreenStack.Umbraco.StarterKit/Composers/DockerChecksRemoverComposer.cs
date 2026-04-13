using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Infrastructure.Runtime.RuntimeModeValidators;

namespace GreenStack.Umbraco.StarterKit.Composers;

public class DockerChecksRemoverComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.RuntimeModeValidators()
            .Remove<UseHttpsValidator>();
    }
}
