using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Views;

public partial class TQLDBViewsContext : DbContext
{
    public TQLDBViewsContext()
    {
    }

    public TQLDBViewsContext(DbContextOptions<TQLDBViewsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ViewOneNformCaseNameList> ViewOneNformCaseNameLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:TQLDBConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ViewOneNformCaseNameList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewOneNForm_CaseNameList");

            entity.Property(e => e.ExportFileName).HasMaxLength(50);
            entity.Property(e => e.MainField).HasMaxLength(50);
            entity.Property(e => e.MainFieldEdited)
                .HasMaxLength(50)
                .HasColumnName("MainField_Edited");
            entity.Property(e => e.OneNformAdjustment)
                .HasMaxLength(128)
                .HasColumnName("OneNFormAdjustment");
            entity.Property(e => e.OneNformId).HasColumnName("OneNFormId");
            entity.Property(e => e.OneNformType)
                .HasMaxLength(128)
                .HasColumnName("OneNFormType");
            entity.Property(e => e.OneNformTypeId).HasColumnName("OneNFormTypeId");
            entity.Property(e => e.SchoolName)
                .HasMaxLength(128)
                .HasColumnName("schoolName");
            entity.Property(e => e.SubField).HasMaxLength(50);
            entity.Property(e => e.SubFieldEdited)
                .HasMaxLength(50)
                .HasColumnName("SubField_Edited");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .HasColumnName("year");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
