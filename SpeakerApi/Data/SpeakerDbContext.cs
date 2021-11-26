using System;
using Microsoft.EntityFrameworkCore;
using SpeakerLibrary;

public class SpeakerDbContext : DbContext {
  public DbSet<Speaker> Students { get; set; }

  public SpeakerDbContext(DbContextOptions<SpeakerDbContext> options) : base(options) { }

  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<Speaker>().HasData(
        new {
            SpeakerId = Guid.NewGuid().ToString(),
            FirstName = "Jim",
            LastName = "Bar",
            Email = "jim@bar.ca",
            MobileNumber = "2223334444",
            Specialization = "Software engineer",
            City = "Chilliwack",
            Province = "BC",
            Employer = "BC Hydro"
        },
        new {
            SpeakerId = Guid.NewGuid().ToString(),
            FirstName = "Jane",
            LastName = "Douglas",
            Email = "jane@amazon.ca",
            MobileNumber = "3334445555",
            Specialization = "Software engineer",
            City = "Vancouver",
            Province = "BC",
            Employer = "Amazon"
        },
        new {
            SpeakerId = Guid.NewGuid().ToString(),
            FirstName = "Tom",
            LastName = "Gardner",
            Email = "tom@ubc.ca",
            MobileNumber = "4445556666",
            Specialization = "Software Architecture",
            City = "Richmond",
            Province = "BC",
            Employer = "UBC"
        }
    );
  }
}
