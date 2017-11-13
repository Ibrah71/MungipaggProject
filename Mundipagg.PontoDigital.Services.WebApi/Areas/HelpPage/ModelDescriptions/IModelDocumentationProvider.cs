using System;
using System.Reflection;

namespace Mundipagg.PontoDigital.Services.WebApi.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}