﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuestionarioC_.Models.Context;

namespace QuestionarioC.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190502110518_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuestionarioC_.Models.Answer", b =>
                {
                    b.Property<int>("QuestionId");

                    b.Property<int>("UserId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Observations");

                    b.HasKey("QuestionId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Answers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Answer");
                });

            modelBuilder.Entity("QuestionarioC_.Models.AnswerChoice", b =>
                {
                    b.Property<int>("AnswerChoiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("AnswerChoiceId");

                    b.ToTable("AnswerChoices");

                    b.HasData(
                        new
                        {
                            AnswerChoiceId = 1,
                            Name = "A"
                        },
                        new
                        {
                            AnswerChoiceId = 2,
                            Name = "B"
                        },
                        new
                        {
                            AnswerChoiceId = 3,
                            Name = "C"
                        },
                        new
                        {
                            AnswerChoiceId = 4,
                            Name = "D"
                        });
                });

            modelBuilder.Entity("QuestionarioC_.Models.Inquiry", b =>
                {
                    b.Property<int>("InquiryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("InquiryId");

                    b.ToTable("Inquiries");

                    b.HasData(
                        new
                        {
                            InquiryId = 1,
                            Name = "Inquérito Pós-Parto"
                        },
                        new
                        {
                            InquiryId = 2,
                            Name = "Inquérito de Satisfação"
                        });
                });

            modelBuilder.Entity("QuestionarioC_.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<int>("QuestionnaireId");

                    b.HasKey("QuestionId");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("Questions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Question");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            Description = "Descreva o seu veredicto final dos funcionários neste hospital.",
                            Name = "Avaliação geral dos funcionários",
                            QuestionnaireId = 1
                        });
                });

            modelBuilder.Entity("QuestionarioC_.Models.QuestionAnswerChoice", b =>
                {
                    b.Property<int>("QuestionId");

                    b.Property<int>("AnswerChoiceId");

                    b.HasKey("QuestionId", "AnswerChoiceId");

                    b.HasIndex("AnswerChoiceId");

                    b.ToTable("QuestionAnswerChoices");

                    b.HasData(
                        new
                        {
                            QuestionId = 2,
                            AnswerChoiceId = 1
                        },
                        new
                        {
                            QuestionId = 2,
                            AnswerChoiceId = 2
                        },
                        new
                        {
                            QuestionId = 2,
                            AnswerChoiceId = 3
                        },
                        new
                        {
                            QuestionId = 2,
                            AnswerChoiceId = 4
                        },
                        new
                        {
                            QuestionId = 3,
                            AnswerChoiceId = 1
                        },
                        new
                        {
                            QuestionId = 3,
                            AnswerChoiceId = 2
                        },
                        new
                        {
                            QuestionId = 3,
                            AnswerChoiceId = 3
                        },
                        new
                        {
                            QuestionId = 3,
                            AnswerChoiceId = 4
                        });
                });

            modelBuilder.Entity("QuestionarioC_.Models.Questionnaire", b =>
                {
                    b.Property<int>("QuestionnaireId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InquiryId");

                    b.Property<string>("Name");

                    b.HasKey("QuestionnaireId");

                    b.HasIndex("InquiryId");

                    b.ToTable("Questionnaires");

                    b.HasData(
                        new
                        {
                            QuestionnaireId = 1,
                            InquiryId = 1,
                            Name = "Avaliação dos funcionários"
                        },
                        new
                        {
                            QuestionnaireId = 2,
                            InquiryId = 1,
                            Name = "Avaliação de aspetos secundários do hospital"
                        });
                });

            modelBuilder.Entity("QuestionarioC_.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("PersonalId");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            IsAdmin = true,
                            Name = "José Simões",
                            Password = "$2b$12$boHLVtvH8J5lW//wh8no8.IKugql6MkBSiBDhE2ZXSgOOpqOg6vsO",
                            PersonalId = 170100228
                        },
                        new
                        {
                            UserId = 2,
                            IsAdmin = false,
                            Name = "Ricardo Silva",
                            Password = "$2b$12$KjnyU9JPmABFOPtWZe4MEe9PoBZwz19WW4NBxUdgc.HQN8e3kxJAa",
                            PersonalId = 170100229
                        });
                });

            modelBuilder.Entity("QuestionarioC_.Models.UserInquiry", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("InquiryId");

                    b.HasKey("UserId", "InquiryId");

                    b.HasIndex("InquiryId");

                    b.ToTable("UserInquiries");

                    b.HasData(
                        new
                        {
                            UserId = 2,
                            InquiryId = 1
                        },
                        new
                        {
                            UserId = 2,
                            InquiryId = 2
                        });
                });

            modelBuilder.Entity("QuestionarioC_.Models.ChosenAnswer", b =>
                {
                    b.HasBaseType("QuestionarioC_.Models.Answer");

                    b.Property<int>("AnswerChoiceId");

                    b.HasIndex("AnswerChoiceId");

                    b.HasDiscriminator().HasValue("ChosenAnswer");
                });

            modelBuilder.Entity("QuestionarioC_.Models.FreeAnswer", b =>
                {
                    b.HasBaseType("QuestionarioC_.Models.Answer");

                    b.Property<string>("Answer");

                    b.HasDiscriminator().HasValue("FreeAnswer");
                });

            modelBuilder.Entity("QuestionarioC_.Models.ChoiceQuestion", b =>
                {
                    b.HasBaseType("QuestionarioC_.Models.Question");

                    b.Property<int>("PossibleAnswers");

                    b.HasDiscriminator().HasValue("ChoiceQuestion");

                    b.HasData(
                        new
                        {
                            QuestionId = 2,
                            Description = "Avalie a simpatia dos funcionários.",
                            Name = "Avaliação da simpatia",
                            QuestionnaireId = 1,
                            PossibleAnswers = 1
                        },
                        new
                        {
                            QuestionId = 3,
                            Description = "Avalie a qualidade do estacionamento.",
                            Name = "Avaliação do estacionamento",
                            QuestionnaireId = 2,
                            PossibleAnswers = 1
                        });
                });

            modelBuilder.Entity("QuestionarioC_.Models.Answer", b =>
                {
                    b.HasOne("QuestionarioC_.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuestionarioC_.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuestionarioC_.Models.Question", b =>
                {
                    b.HasOne("QuestionarioC_.Models.Questionnaire", "Questionnaire")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionnaireId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuestionarioC_.Models.QuestionAnswerChoice", b =>
                {
                    b.HasOne("QuestionarioC_.Models.AnswerChoice", "AnswerChoice")
                        .WithMany()
                        .HasForeignKey("AnswerChoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuestionarioC_.Models.ChoiceQuestion", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuestionarioC_.Models.Questionnaire", b =>
                {
                    b.HasOne("QuestionarioC_.Models.Inquiry", "Inquiry")
                        .WithMany("Questionnaires")
                        .HasForeignKey("InquiryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuestionarioC_.Models.UserInquiry", b =>
                {
                    b.HasOne("QuestionarioC_.Models.Inquiry", "Inquiry")
                        .WithMany()
                        .HasForeignKey("InquiryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("QuestionarioC_.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("QuestionarioC_.Models.ChosenAnswer", b =>
                {
                    b.HasOne("QuestionarioC_.Models.AnswerChoice", "AnswerChoice")
                        .WithMany()
                        .HasForeignKey("AnswerChoiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}