using Microsoft.EntityFrameworkCore;

namespace RestAPIloomisejuhend.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {
        }
        public DbSet<Exercise> ExerciseList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    Id = 1,
                    Title = "kätekõverdused",
                    Description = "tavalised",
                    Intensity = Exercise.ExerciseIntensity.Normal,
                    RecommendedDurationInSeconds = 40,
                    RecommendedTimeInSecondsAfterExercise = 10,
                    RecommendedTimeInSecondsBeforeExercise = 10
                },
                new Exercise
                {
                    Id = 2,
                    Title = "slaalomhüpped",
                    Description = "kükid",
                    Intensity = Exercise.ExerciseIntensity.High,
                    RecommendedDurationInSeconds = 40,
                    RecommendedTimeInSecondsBeforeExercise = 10,
                    RecommendedTimeInSecondsAfterExercise = 10,
                    RestTimeInstructions = "asd"
                },
                new Exercise
                {
                    Id = 3,
                    Title = "alt läbi jooks",
                    Description = "toenglamang",
                    Intensity = Exercise.ExerciseIntensity.Normal,
                    RecommendedDurationInSeconds = 40,
                    RecommendedTimeInSecondsBeforeExercise = 10,
                    RecommendedTimeInSecondsAfterExercise = 10
                });

        }
    }
}
