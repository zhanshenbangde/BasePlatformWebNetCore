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
            options.DbType = DatabaseType.MySQL.ToString();//���ݿ�������SqlServer,�����������Ͳ���ö��DatabaseType
            options.Author = "yilezhu";//��������
            options.OutputPath = "C:\\CzarCmsCodeGenerator";//ģ��������ɵ�·��
            options.ModelsNamespace = "Czar.Cms.Models";//ʵ�������ռ�
            options.IRepositoryNamespace = "Czar.Cms.IRepository";//�ִ��ӿ������ռ�
            options.RepositoryNamespace = "Czar.Cms.Repository.SqlServer";//�ִ������ռ�
            options.IServicesNamespace = "Czar.Cms.IServices";//����ӿ������ռ�
            options.ServicesNamespace = "Czar.Cms.Services";//���������ռ�



            CodeGenerator cg = new CodeGenerator(options);

            cg.GenerateTemplateCodesFromDatabase(true);
        }
    }
}
