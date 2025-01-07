﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizApplication.Infrastructure;

#nullable disable

namespace QuizApplication.Infrastructure.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    partial class QuizDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuizApplication.Domain.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerText")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnswerText = "Rome",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            AnswerText = "Madrid",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            AnswerText = "Berlin",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 4,
                            AnswerText = "Brussels",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 5,
                            AnswerText = "Jupiter",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            AnswerText = "Venus",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 7,
                            AnswerText = "Mars",
                            IsCorrect = true,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 8,
                            AnswerText = "Saturn",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 9,
                            AnswerText = "Charles Dickens",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            AnswerText = "William Shakespeare",
                            IsCorrect = true,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 11,
                            AnswerText = "Jane Austen",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 12,
                            AnswerText = "Mark Twain",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 13,
                            AnswerText = "Mercury",
                            IsCorrect = true,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 14,
                            AnswerText = "Uranus",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 15,
                            AnswerText = "Neptunus",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 16,
                            AnswerText = "Earth",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 17,
                            AnswerText = "Oxygen",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 18,
                            AnswerText = "Nitrogen",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 19,
                            AnswerText = "Carbon dioxide",
                            IsCorrect = true,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 20,
                            AnswerText = "Hydrogen",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 21,
                            AnswerText = "Vincent van Gogh",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 22,
                            AnswerText = "Pablo Picasso",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 23,
                            AnswerText = "Leonardo da Vinci",
                            IsCorrect = true,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 24,
                            AnswerText = "Michelangelo",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 25,
                            AnswerText = "Elephant",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 26,
                            AnswerText = "Giraffe",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 27,
                            AnswerText = "Blue whale",
                            IsCorrect = true,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 28,
                            AnswerText = "Lion",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 29,
                            AnswerText = "Beijing",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 30,
                            AnswerText = "Seoul",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 31,
                            AnswerText = "Shanghai",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 32,
                            AnswerText = "Tokyo",
                            IsCorrect = true,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 33,
                            AnswerText = "Oxygen",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 34,
                            AnswerText = "Carbon dioxide",
                            IsCorrect = true,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 35,
                            AnswerText = "Hydrogen",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 36,
                            AnswerText = "Nitrogen",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 37,
                            AnswerText = "Brain",
                            IsCorrect = false,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 38,
                            AnswerText = "Skin",
                            IsCorrect = true,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 39,
                            AnswerText = "Heart",
                            IsCorrect = false,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 40,
                            AnswerText = "Liver",
                            IsCorrect = false,
                            QuestionId = 10
                        });
                });

            modelBuilder.Entity("QuizApplication.Domain.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionString")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            QuestionString = "What is the capital of France?"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            QuestionString = "Which planet is known as the 'Red Planet'?"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            QuestionString = "Who wrote the play 'Romeo and Juliet'?"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            QuestionString = "What is the closest planet to the sun?"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            QuestionString = "Which gas do plants absorb from the atmosphere during photosynthesis?"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            QuestionString = "Who painted the Mona Lisa?"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            QuestionString = "What is the largest mammal in the world?"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            QuestionString = "What is the capital of Japan?"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            QuestionString = "Which gas do humans exhale when they breathe?"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            QuestionString = "What is the largest organ in the human body?"
                        });
                });

            modelBuilder.Entity("QuizApplication.Domain.Answer", b =>
                {
                    b.HasOne("QuizApplication.Domain.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QuizApplication.Domain.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
