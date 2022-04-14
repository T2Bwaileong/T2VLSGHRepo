using Microsoft.EntityFrameworkCore;

namespace CourseWebAPI.Models
{
    public class VLSContext : DbContext
    {
        public VLSContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certificate>()
                .HasKey(nameof(Certificate.CourseId), nameof(Certificate.StudentId));
            modelBuilder.Entity<StudentCourse>()
                .HasKey(nameof(StudentCourse.CourseId), nameof(StudentCourse.StudentId));

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 1,
                Name = ".NET Core",
                Description = "random string",
                Start = "20-04-2022",
                End = "25-04-2022",
                Cost = 59.90f,
                Video = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                AuthorId = 1,

            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 2,
                Name = "How to be Happy",
                Description = "U smile and then u happy",
                Start = "20-04-2022",
                End = "20-05-2022",
                Cost = 1.50f,
                Video = "https://www.youtube.com/watch?v=kB8pG1-dIAA",
                AuthorId = 2,

            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 3,
                Name = "How to be truly agile",
                Description = "focus on the things not done",
                Start = "01-05-2022",
                End = "05-05-2022",
                Cost = 12.90f,
                Video = "https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                AuthorId = 3,

            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 4,
                Name = "Long test and how to copy paste",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                Start = "20-04-2022",
                End = "20-06-2022",
                Cost = 0.00f,
                Video = "https://www.youtube.com/watch?v=kB8pG1-dIAA",
                AuthorId = 3,

            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 1,
                Name = "Daniel",
                Number = "987654321",
                Email = "daniel@.net.com",
                Specialization = "HTML5, CSS, JS, TS"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 2,
                Name = "Alif",
                Number = "987654321",
                Email = "alif@.net.com",
                Specialization = "Angular"
            });

            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 3,
                Name = "Subbu",
                Number = "987654321",
                Email = "subbu@.net.com",
                Specialization = ".NET, Angular, HTML5, CSS, JS, TS"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 4,
                Name = "Meer",
                Number = "987654321",
                Email = "meer@.net.com",
                Specialization = ".NET, Angular"
            });
        }
    }
}
