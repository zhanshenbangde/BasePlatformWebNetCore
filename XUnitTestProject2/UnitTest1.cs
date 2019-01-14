using Microsoft.Extensions.DependencyInjection;
using Poya.BasePlatform.WebNetCore.Infrastructure.CodeGenerator;
using Poya.BasePlatform.WebNetCore.Infrastructure.Model;
using Poya.BasePlatform.WebNetCore.Test;
using System;
using Xunit;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var serviceProvider = Common.BuildServiceForSqlServer();
            var codeGenerator = serviceProvider.GetRequiredService<CodeGenerator>();
            codeGenerator.GenerateTemplateCodesFromDatabase(true);
            Assert.Equal("SQLServer", DatabaseType.SqlServer.ToString(), ignoreCase: true);

        }
    }
}
