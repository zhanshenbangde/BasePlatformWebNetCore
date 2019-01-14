/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：数据库基类操作测试                                                    
*│　作    者：yilezhu                                             
*│　版    本：1.0                                                 
*│　创建时间：2018/12/22 22:13:04                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间： Czar.Cms.Test                                   
*│　类    名： BaseRepositoryTest                                      
*└──────────────────────────────────────────────────────────────┘
*/
using Xunit;

namespace Poya.BasePlatform.WebNetCore.Test
{
    public class BaseRepositoryTest
    {


        //public void TestBaseFactory()
        //{
        //    IServiceProvider serviceProvider = Common.BuildServiceForSqlServer();
        //    IArticleCategoryRepository categoryRepository = serviceProvider.GetService<IArticleCategoryRepository>();
        //    var category1 = new ArticleCategory
        //    {
        //        Title = "随笔1",
        //        ParentId = 0,
        //        ClassList = "",
        //        ClassLayer = 0,
        //        Sort = 0,
        //        ImageUrl = "",
        //        SeoTitle = "随笔的SEOTitle",
        //        SeoKeywords = "随笔的SeoKeywords",
        //        SeoDescription = "随笔的SeoDescription",
        //        IsDeleted = false,
        //    };
        //    var category2 = new ArticleCategory
        //    {
        //        Title = null,
        //        ParentId = 0,
        //        ClassList = "",
        //        ClassLayer = 0,
        //        Sort = 0,
        //        ImageUrl = "",
        //        SeoTitle = "随笔的SEOTitle",
        //        SeoKeywords = "随笔的SeoKeywords",
        //        SeoDescription = "随笔的SeoDescription",
        //        IsDeleted = false,
        //    };
        //    var categoryId = categoryRepository.Insert(category1);
        //    var categoryId2 = categoryRepository.Insert(category2);
        //    var list = categoryRepository.GetList();
        //    Assert.True(2 == list.Count());
        //    Assert.Equal("随笔1", list.FirstOrDefault().Title);
        //    categoryRepository.DeleteList("where 1=1");
        //    var count = categoryRepository.RecordCount();
        //    Assert.True(0 == count);
        //}



    }
}
