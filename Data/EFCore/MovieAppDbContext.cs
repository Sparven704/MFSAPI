﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MFSAPI.Models
{
    public partial class MovieAppDbContext : DbContext
    {
        public MovieAppDbContext()
        {
        }

        public MovieAppDbContext(DbContextOptions<MovieAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonGenre> PersonGenre { get; set; }
        public DbSet<TMDB> TMDB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movie_Genre");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Movie)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movie_Person");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PersonGenre>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.PersonGenre)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonGenre_Genre");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonGenre)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonGenre_Person");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}