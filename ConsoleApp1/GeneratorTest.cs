using Microsoft.Extensions.DependencyInjection;
using Poya.BasePlatform.WebNetCore.Infrastructure.CodeGenerator;
using Poya.BasePlatform.WebNetCore.Infrastructure.Model;


namespace Poya.BasePlatform.WebNetCore.Test
{
    /// <summary>
    /// yilezhu
    /// 2018.12.12
    /// 测试代码生成器
    /// 暂时只实现了SqlServer的实体代码生成
    /// </summary>
    public class GeneratorTest
    {

        public void GeneratorModelForSqlServer()
        {
            var serviceProvider = Common.BuildServiceForSqlServer();
            var codeGenerator = serviceProvider.GetRequiredService<CodeGenerator>();
            codeGenerator.GenerateTemplateCodesFromDatabase(true);


        }

      
    }
}
