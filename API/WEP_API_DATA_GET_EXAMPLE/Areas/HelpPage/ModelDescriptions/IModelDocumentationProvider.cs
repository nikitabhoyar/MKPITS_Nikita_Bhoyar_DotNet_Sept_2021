using System;
using System.Reflection;

namespace WEPAPI_DATA_GET_EXAMPLE.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}