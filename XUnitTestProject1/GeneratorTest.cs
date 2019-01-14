using Microsoft.Extensions.DependencyInjection;
using Poya.BasePlatform.WebNetCore.Infrastructure.CodeGenerator;
using Poya.BasePlatform.WebNetCore.Infrastructure.Model;
using Xunit;

namespace Poya.BasePlatform.WebNetCore.Test
{
    /// <summary>
    /// yilezhu
    /// 2018.12.12
    /// ���Դ���������
    /// ��ʱֻʵ����SqlServer��ʵ���������
    /// </summary>
    public class GeneratorTest
    {
        [Fact]
        public void GeneratorModelForSqlServer()
        {
            var serviceProvider = Common.BuildServiceForSqlServer();
            var codeGenerator = serviceProvider.GetRequiredService<CodeGenerator>();
            codeGenerator.GenerateTemplateCodesFromDatabase(true);
            Assert.Equal("SQLServer", DatabaseType.SqlServer.ToString(), ignoreCase: true);

        }

      
    }
}
