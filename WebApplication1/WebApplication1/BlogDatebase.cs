namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BlogDatebase : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“Model1”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“WebApplication1.Model1”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“Model1”
        //连接字符串。
        public BlogDatebase()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }

        public virtual DbSet<BlogArticle> BlogArticles { get; set; }





        public class Blog
        {
            public int Id { get; set; }

            public string Title { get; set; }
        }

        public class BlogArticle
        {
            public int Id { get; set; }

            public int BlogId { get; set; }

            public string Subject { get; set; }
        }


    }
}