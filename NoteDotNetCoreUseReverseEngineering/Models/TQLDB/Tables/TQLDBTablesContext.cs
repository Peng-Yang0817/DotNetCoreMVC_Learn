using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class TQLDBTablesContext : DbContext
{
    public TQLDBTablesContext()
    {
    }

    public TQLDBTablesContext(DbContextOptions<TQLDBTablesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Auth001> Auth001s { get; set; }

    public virtual DbSet<Auth002> Auth002s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:TQLDBConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auth001>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Account");

            entity.ToTable("Auth001", tb => tb.HasTrigger("TR_Auth001_Modify"));

            entity.Property(e => e.Id).HasComment("PK");
            entity.Property(e => e.Address).HasMaxLength(128);
            entity.Property(e => e.Cellphone)
                .HasMaxLength(128)
                .HasComment("使用者手機");
            entity.Property(e => e.CreateTime)
                .HasDefaultValueSql("(getdate())")
                .HasComment("使用者建立時間")
                .HasColumnType("datetime")
                .HasColumnName("createTime");
            entity.Property(e => e.DepartmentName).HasMaxLength(128);
            entity.Property(e => e.Education).HasMaxLength(128);
            entity.Property(e => e.Email)
                .HasMaxLength(128)
                .HasComment("使用者 E-Mail");
            entity.Property(e => e.Fax)
                .HasMaxLength(128)
                .HasComment("使用者傳真號碼");
            entity.Property(e => e.IsChangePassword).HasColumnName("isChangePassword");
            entity.Property(e => e.JobTitle).HasMaxLength(128);
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasComment("使用者姓名");
            entity.Property(e => e.Office)
                .HasMaxLength(128)
                .HasComment("使用者單位");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasComment("使用者密碼");
            entity.Property(e => e.Phone)
                .HasMaxLength(128)
                .HasComment("使用者電話");
            entity.Property(e => e.RoleRange)
                .HasMaxLength(128)
                .HasComment("SysCtrl002 roleRange")
                .HasColumnName("roleRange");
            entity.Property(e => e.SchoolCtrl001Id).HasComment("SchoolCtrl001 FK");
            entity.Property(e => e.Specialty).HasMaxLength(128);
            entity.Property(e => e.State006Id).HasComment("使用者狀態(開啟,關閉)");
            entity.Property(e => e.State013Id).HasComment("審查委員負責之送審領域");
            entity.Property(e => e.Username)
                .HasMaxLength(128)
                .HasComment("使用者帳號");
        });

        modelBuilder.Entity<Auth002>(entity =>
        {
            entity.ToTable("Auth002");

            entity.Property(e => e.Id).HasComment("PK");
            entity.Property(e => e.Auth001Id).HasComment("FK Auth001Id");
            entity.Property(e => e.ChangePwdeadline)
                .HasDefaultValueSql("(getdate())")
                .HasComment("密碼修改期限")
                .HasColumnType("datetime")
                .HasColumnName("ChangePWDeadline");
            entity.Property(e => e.ChangePwtime)
                .HasColumnType("datetime")
                .HasColumnName("ChangePWTime");
            entity.Property(e => e.Password1)
                .HasMaxLength(128)
                .HasComment("最近一次被修改的密碼");
            entity.Property(e => e.Password2)
                .HasMaxLength(128)
                .HasComment("第二次被修改的密碼");
            entity.Property(e => e.Password3)
                .HasMaxLength(128)
                .HasComment("第三次被修改的密碼");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
