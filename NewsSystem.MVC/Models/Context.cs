namespace NewsSystem.MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using NewsSystem.Models;

    public class Context : DbContext
    {
        public Context()
            : base("NewsSystemDB")
        {
        }

        public virtual DbSet<Library> MediaLibrary { get; set; }
        public virtual DbSet<MediaFile> Media { get; set; }
        public virtual DbSet<MainUser> Users { get; set; }
        public virtual DbSet<UserSetting> UserProfile { get; set; }
        public virtual DbSet<UserPicture> UserPicture { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<NewsLetterSubscriber> Subscriber { get; set; }
        public virtual DbSet<AnnonymousUser> AnnonymousUser { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

    }
}