/// <summary>
/// 数据库连接选项
/// </summary>
namespace Poya.BasePlatform.WebNetCore.Infrastructure.Options
{
    public class DbOpion
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public string DbType { get; set; }
    }
}
