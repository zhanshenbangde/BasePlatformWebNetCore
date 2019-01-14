using Poya.BasePlatform.WebNetCore.Infrastructure.CodeGenerator;
using Poya.BasePlatform.WebNetCore.Infrastructure.Model;
using Poya.BasePlatform.WebNetCore.Infrastructure.Options;
using System;
using Xunit;

namespace XUnitTestProject3
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CodeGenerateOption options = new CodeGenerateOption();
            options.ConnectionString = "Server=localhost;uid=root;pwd=poya123#;Database=base_platform";
            options.DbType = DatabaseType.MySQL.ToString();//数据库类型是SqlServer,其他数据类型参照枚举DatabaseType
            options.Author = "yilezhu";//作者名称
            options.OutputPath = "C:\\CzarCmsCodeGenerator";//模板代码生成的路径
            options.ModelsNamespace = "Czar.Cms.Models";//实体命名空间
            options.IRepositoryNamespace = "Czar.Cms.IRepository";//仓储接口命名空间
            options.RepositoryNamespace = "Czar.Cms.Repository.SqlServer";//仓储命名空间
            options.IServicesNamespace = "Czar.Cms.IServices";//服务接口命名空间
            options.ServicesNamespace = "Czar.Cms.Services";//服务命名空间



            CodeGenerator cg = new CodeGenerator(options);

            cg.GenerateTemplateCodesFromDatabase(true);
        }
    }
}
