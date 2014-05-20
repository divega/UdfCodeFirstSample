using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UdfCodeFirstSample
{
    public class GetAgeStoreFunctionInjectionConvention : IStoreModelConvention<EdmModel>
    {
        public void Apply(EdmModel item, DbModel model)
        {
            var parameter = FunctionParameter.Create(
                "birthDate",
                model.GetStorePrimitiveType(PrimitiveTypeKind.DateTime),
                ParameterMode.In);

            var returnValue = FunctionParameter.Create(
                "result",
                model.GetStorePrimitiveType(PrimitiveTypeKind.Int32),
                ParameterMode.ReturnValue);

            var function = item.CreateAndAddFunction(
                "GetAge",
                new[] {parameter},
                new[] {returnValue});
        }
    }
}
