using System.Data.Common;
using System.Data.Entity;
using Me.AlohaChina.Data.Content;

namespace Me.AlohaChina.Access.EF.Content
{
    public class ContentRepository : DbContext
    {
        public ContentRepository(string dbName)
            : base(dbName)
        { }

        public ContentRepository(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        { }

        public DbSet<Article> Articles
        {
            get;
            set;
        }

        public DbSet<ArticleHistory> ArticleHistories
        {
            get;
            set;
        }

        public DbSet<Topic> Topics
        {
            get;
            set;
        }

        public DbSet<TopicHistory> TopicHistories
        {
            get;
            set;
        }

        public DbSet<File> Files
        {
            get;
            set;
        }

        public DbSet<FileHistory> FileHistories
        {
            get;
            set;
        }

        public DbSet<Reply> Replies
        {
            get;
            set;
        }

    }
}
