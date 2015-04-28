namespace wqwz.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class wqwzContainer : DbContext
    {
        public wqwzContainer()
            : base("name=wqwzContainer")
        {
        }

        public virtual DbSet<FormData> FormDataSet { get; set; }
        public virtual DbSet<FormFieldEnum> FormFieldEnumSet { get; set; }
        public virtual DbSet<FormField> FormFieldSet { get; set; }
        public virtual DbSet<Form> FormSet { get; set; }
        public virtual DbSet<FormType> FormTypeSet { get; set; }
        public virtual DbSet<News> NewsSet { get; set; }
        //public virtual DbSet<NewsType> NewsTypeSet { get; set; }
        public virtual DbSet<User> UserSet { get; set; }
        public virtual DbSet<FormTemplate> FormTemplateSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormField>()
                .HasMany(e => e.FormDatas)
                .WithRequired(e => e.FormFields)
                .HasForeignKey(e => e.FormFieldId)
                .WillCascadeOnDelete(false); 

            modelBuilder.Entity<FormField>()
                .HasMany(e => e.FormFieldEnums)
                .WithRequired(e => e.FormField)
                .HasForeignKey(e => e.FormFieldId)
                .WillCascadeOnDelete(false); 

            modelBuilder.Entity<FormType>()
                .HasMany(e => e.Forms)
                .WithRequired(e => e.FormType)
                .HasForeignKey(e => e.FormTypeId)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<NewsType>()
            //    .HasMany(e => e.News)
            //    .WithRequired(e => e.NewsType)
            //    .HasForeignKey(e => e.NewsTypeId)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.FormDatas)
                .WithRequired(e => e.PostUser)
                .HasForeignKey(e => e.PostUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Forms)
                .WithRequired(e => e.ReleaseUser)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.News)
                .WithRequired(e => e.ReleaseUser)
                .HasForeignKey(e => e.ReleaseUserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormTemplate>()
                .HasMany(e => e.Forms)
                .WithRequired(e => e.FormTemplate)
                .HasForeignKey(e => e.FormTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormTemplate>()
                .HasMany(e => e.FormFields)
                .WithRequired(e => e.FormTemplate)
                .HasForeignKey(e => e.FormTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Form>()
                .HasMany(e => e.FormDatas)
                .WithRequired(e => e.Form)
                .HasForeignKey(e => e.FormId)
                .WillCascadeOnDelete(false);
        }
    }
}
