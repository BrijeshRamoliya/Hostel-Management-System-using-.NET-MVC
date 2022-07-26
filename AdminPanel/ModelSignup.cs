namespace AdminPanel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelSignup : DbContext
    {
        public ModelSignup()
            : base("name=ModelSignup")
        {
        }

        public virtual DbSet<SignUp> SignUps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SignUp>()
                .Property(e => e.EmailId)
                .IsUnicode(false);
        }
    }
}
