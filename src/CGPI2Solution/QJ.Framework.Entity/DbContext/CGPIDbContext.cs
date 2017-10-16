using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.Entities.Educational;
using QJ.Framework.Entity.Entities.System;

namespace QJ.Framework.Entity.DbContext
{
    public class CGPIDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CGPIDbContext(DbContextOptions<CGPIDbContext> options) : base(options)
        {
        }

        #region 基础数据

        public virtual DbSet<SysUser> SysUsers { get; set; }
        public virtual DbSet<SysRole> SysRoles { get; set; }
        public virtual DbSet<SysOrganize> SysOrganizes { get; set; }
        public virtual DbSet<SysMenu> SysMenus { get; set; }
        public virtual DbSet<SysDict> SysDicts { get; set; }
        public virtual DbSet<SysDictDetail> SysDictDetails { get; set; }
        public virtual DbSet<SysLog> SysLogs { get; set; }

        #endregion

        #region 梁坤基础数据
        public virtual DbSet<ClassInfo> ClassInfo { get; set; }
        public virtual DbSet<ClassLession> ClassLession { get; set; }
        public virtual DbSet<ClassLessionItem> ClassLessionItem { get; set; }
        public virtual DbSet<ClassManager> ClassManager { get; set; }
        public virtual DbSet<ClassType> ClassType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<EducationExperience> EducationExperience { get; set; }
        public virtual DbSet<Lession> Lession { get; set; }
        public virtual DbSet<LessionType> LessionType { get; set; }
        public virtual DbSet<MarkupLession> MarkupLession { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentClass> StudentClass { get; set; }
        public virtual DbSet<StudentCode> StudentCode { get; set; }
        public virtual DbSet<StudentLeave> StudentLeave { get; set; }
        public virtual DbSet<StudentLession> StudentLession { get; set; }
        public virtual DbSet<StudentProperty> StudentProperty { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeacherProperty> TeacherProperty { get; set; }
        public virtual DbSet<WorkExperience> WorkExperience { get; set; }
        public virtual DbSet<WorkUser> WorkUser { get; set; }
        public virtual DbSet<WorkUserProperty> WorkUserProperty { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysUser>().ToTable("SysUser");
            modelBuilder.Entity<SysUser>(entity =>
            {
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<SysRole>().ToTable("SysRole");
            modelBuilder.Entity<SysRole>(entity =>
            {
                entity.Property(e => e.SortCode).HasDefaultValue(0);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<SysOrganize>().ToTable("SysOrganize");
            modelBuilder.Entity<SysOrganize>(entity =>
            {
                entity.Property(e => e.SortCode).HasDefaultValue(0);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<SysMenu>().ToTable("SysMenu");
            modelBuilder.Entity<SysMenu>(entity =>
            {
                entity.Property(e => e.SortCode).HasDefaultValue(0);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<SysDict>().ToTable("SysDict");
            modelBuilder.Entity<SysDict>(entity =>
            {
                entity.Property(e => e.SortCode).HasDefaultValue(0);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<SysDictDetail>().ToTable("SysDictDetail");
            modelBuilder.Entity<SysDictDetail>(entity =>
            {
                entity.Property(e => e.SortCode).HasDefaultValue(0);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<SysLog>().ToTable("SysLog");

            //org
            modelBuilder.Entity<SysOrganize>().HasMany(ur => ur.SysOrgUsers).WithOne(u => u.Organize).HasForeignKey(ur => ur.OrganizeId);
            modelBuilder.Entity<SysOrganize>().HasMany(ur => ur.SysDepUsers).WithOne(u => u.Department).HasForeignKey(ur => ur.DepartmentId);

            modelBuilder.Entity<UserRole>().ToTable("UserRole");
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.Property(e => e.IsEnableed).HasDefaultValue(true);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<UserAuthorize>().ToTable("UserAuthorize");
            modelBuilder.Entity<UserAuthorize>(entity =>
            {
                entity.Property(e => e.IsEnableed).HasDefaultValue(true);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<RoleAuthorize>().ToTable("RoleAuthorize");
            modelBuilder.Entity<RoleAuthorize>(entity =>
            {
                entity.Property(e => e.IsEnableed).HasDefaultValue(true);
                entity.Property(e => e.CreateTime).HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            #region 梁坤基础数据

            modelBuilder.Entity<ClassInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ClassId");
                entity.Property(e => e.ClassCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClassContent).HasMaxLength(200);

                entity.Property(e => e.ClassImage).HasMaxLength(200);

                entity.Property(e => e.ClassName).HasMaxLength(50);

                entity.Property(e => e.ClassType).HasMaxLength(50);

                entity.Property(e => e.Ctid).HasColumnName("CTId");

                entity.Property(e => e.RegEndDate).HasColumnType("datetime");

                entity.Property(e => e.RegStartDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Ct)
                    .WithMany(p => p.ClassInfo)
                    .HasForeignKey(d => d.Ctid)
                    .HasConstraintName("FK_CLASSINF_REFERENCE_CLASSTYP");

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.ClassInfo)
                    .HasForeignKey(d => d.DepId)
                    .HasConstraintName("FK_CLASSINF_REFERENCE_DEPARTME");
            });

            modelBuilder.Entity<ClassLession>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("CLId");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Credit).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TeacherName).HasMaxLength(500);

                entity.Property(e => e.TimeRemark).HasMaxLength(50);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassLession)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_CLASSLES_REFERENCE_CLASSINF");

                entity.HasOne(d => d.Lession)
                    .WithMany(p => p.ClassLession)
                    .HasForeignKey(d => d.LessionId)
                    .HasConstraintName("FK_CLASSLES_REFERENCE_LESSION");
            });

            modelBuilder.Entity<ClassLessionItem>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("CLIId");

                entity.Property(e => e.Clid).HasColumnName("CLId");

                entity.Property(e => e.EndLessionTime).HasColumnType("datetime");

                entity.Property(e => e.LessionDate).HasColumnType("datetime");

                entity.Property(e => e.StartLessionTime).HasColumnType("datetime");

                entity.HasOne(d => d.Cl)
                    .WithMany(p => p.ClassLessionItem)
                    .HasForeignKey(d => d.Clid)
                    .HasConstraintName("FK_CLASSLES_REFERENCE_CLASSLES");
            });

            modelBuilder.Entity<ClassManager>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("CMId");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassManager)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_CLASSMAN_REFERENCE_CLASSINF");

                entity.HasOne(d => d.Wu)
                    .WithMany(p => p.ClassManager)
                    .HasForeignKey(d => d.WuId)
                    .HasConstraintName("FK_CLASSMAN_REFERENCE_WORKUSER");
            });

            modelBuilder.Entity<ClassType>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("CTId");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeCode).HasMaxLength(50);

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("DepId");

                entity.Property(e => e.DepCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EducationExperience>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("EeId");

                entity.Property(e => e.Education).HasMaxLength(50);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.SchoolName).HasMaxLength(50);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.EducationExperience)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_EDUCATIO_REFERENCE_STUDENT");
            });

            modelBuilder.Entity<Lession>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("LessionId");
                entity.Property(e => e.LessionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LessionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ltid).HasColumnName("LTId");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Lt)
                    .WithMany(p => p.Lession)
                    .HasForeignKey(d => d.Ltid)
                    .HasConstraintName("FK_LESSION_REFERENCE_LESSIONT");
            });

            modelBuilder.Entity<LessionType>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("LTId");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeCode).HasMaxLength(50);

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<MarkupLession>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("MLId");

                entity.Property(e => e.Lid).HasColumnName("LId");

                entity.Property(e => e.MlendTime)
                    .HasColumnName("MLEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MlstartTime)
                    .HasColumnName("MLStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.L)
                    .WithMany(p => p.MarkupLession)
                    .HasForeignKey(d => d.Lid)
                    .HasConstraintName("FK_MARKUPLE_REFERENCE_STUDENTL");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("StudentId");
                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Belief).HasMaxLength(100);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CardId).HasMaxLength(50);

                entity.Property(e => e.CharitDomain).HasMaxLength(200);

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EnglishLevel).HasMaxLength(50);

                entity.Property(e => e.EnglishName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.GplcreateDate)
                    .HasColumnName("GPLCreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gplscale)
                    .HasColumnName("GPLScale")
                    .HasMaxLength(50);

                entity.Property(e => e.IsUspassport).HasColumnName("IsUSPassport");

                entity.Property(e => e.LessionIds).HasMaxLength(200);

                entity.Property(e => e.LoginPass).HasMaxLength(200);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Nation).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.NativePlace).HasMaxLength(50);

                entity.Property(e => e.OpenKey).HasMaxLength(200);

                entity.Property(e => e.OrgAddress).HasMaxLength(200);

                entity.Property(e => e.OrgBack).HasMaxLength(200);

                entity.Property(e => e.OrgName).HasMaxLength(50);

                entity.Property(e => e.PassportImg).HasMaxLength(200);

                entity.Property(e => e.PassportNum).HasMaxLength(50);

                entity.Property(e => e.PassportValid).HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(200);

                entity.Property(e => e.PostName).HasMaxLength(50);

                entity.Property(e => e.Qq)
                    .HasColumnName("QQ")
                    .HasMaxLength(50);

                entity.Property(e => e.QqopenId)
                    .HasColumnName("QQOpenId")
                    .HasMaxLength(200);

                entity.Property(e => e.RealName).HasMaxLength(50);

                entity.Property(e => e.Taboo).HasMaxLength(100);

                entity.Property(e => e.UrgentEmail).HasMaxLength(100);

                entity.Property(e => e.UrgentFax).HasMaxLength(50);

                entity.Property(e => e.UrgentMobile).HasMaxLength(50);

                entity.Property(e => e.UrgentName).HasMaxLength(50);

                entity.Property(e => e.UrgentPhone).HasMaxLength(50);

                entity.Property(e => e.VisaImg).HasMaxLength(200);

                entity.Property(e => e.VisaType).HasMaxLength(50);

                entity.Property(e => e.VisaValid).HasMaxLength(50);

                entity.Property(e => e.WeChart).HasMaxLength(50);

                entity.Property(e => e.Weibo).HasMaxLength(50);

                entity.Property(e => e.WeixinOpenId).HasMaxLength(200);

                entity.Property(e => e.WelfareWorkTimeSpan).HasMaxLength(50);

                entity.Property(e => e.WorkPhone).HasMaxLength(50);
            });

            modelBuilder.Entity<StudentClass>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("SCId");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.StudentClass)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_STUDENTC_REFERENCE_CLASSINF");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentClass)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_STUDENTC_REFERENCE_STUDENT");
            });

            modelBuilder.Entity<StudentCode>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("SCId");

                entity.Property(e => e.Sccode)
                    .HasColumnName("SCCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SccodeType)
                    .HasColumnName("SCCodeType")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentCode)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_STUDENTC_REFERENCE_STUDENT2");
            });

            modelBuilder.Entity<StudentLeave>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("LId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveContent).HasMaxLength(200);

                entity.Property(e => e.LeaveTitle).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Rstatus).HasColumnName("RStatus");

                entity.Property(e => e.Slid).HasColumnName("SLId");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Sl)
                    .WithMany(p => p.StudentLeave)
                    .HasForeignKey(d => d.Slid)
                    .HasConstraintName("FK_STUDENTL_REFERENCE_STUDENTL");
            });

            modelBuilder.Entity<StudentLession>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("SLId");

                entity.Property(e => e.CheckinTime).HasColumnType("datetime");

                entity.Property(e => e.CheckoutTime).HasColumnType("datetime");

                entity.Property(e => e.Cliid).HasColumnName("CLIId");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Cli)
                    .WithMany(p => p.StudentLession)
                    .HasForeignKey(d => d.Cliid)
                    .HasConstraintName("FK_STUDENTL_REFERENCE_CLASSLES");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentLession)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_STUDENTL_REFERENCE_STUDENT");
            });

            modelBuilder.Entity<StudentProperty>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("SPId");

                entity.Property(e => e.Spname)
                    .HasColumnName("SPName")
                    .HasMaxLength(100);

                entity.Property(e => e.Spvalue)
                    .HasColumnName("SPValue")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentProperty)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_STUDENTP_REFERENCE_STUDENT");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("TeacherId");
                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AppointmentType).HasMaxLength(50);

                entity.Property(e => e.AssessmentContent).HasMaxLength(500);

                entity.Property(e => e.AssessmentScore).HasMaxLength(50);

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.ClassCost).HasMaxLength(50);

                entity.Property(e => e.Contacts).HasMaxLength(50);

                entity.Property(e => e.Coordinator).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EnglishName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Matters).HasMaxLength(500);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.OtherContacts).HasMaxLength(50);

                entity.Property(e => e.PassportStatus).HasMaxLength(50);

                entity.Property(e => e.PassportTimeSpan).HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(200);

                entity.Property(e => e.PostName).HasMaxLength(500);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeachLessions).HasMaxLength(500);


                entity.Property(e => e.WorkPhone).HasMaxLength(50);
            });

            modelBuilder.Entity<TeacherProperty>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("TPId");

                entity.Property(e => e.Tpname)
                    .HasColumnName("TPName")
                    .HasMaxLength(100);

                entity.Property(e => e.Tpvalue)
                    .HasColumnName("TPValue")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherProperty)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_TEACHERP_REFERENCE_TEACHER");
            });

            modelBuilder.Entity<WorkExperience>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("WeId");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UnitPost).HasMaxLength(50);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.WorkExperience)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_WORKEXPE_REFERENCE_STUDENT");
            });

            modelBuilder.Entity<WorkUser>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("WuId");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.BankAccount).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EnglishName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Photo).HasMaxLength(200);

                entity.Property(e => e.PostName).HasMaxLength(50);

                entity.Property(e => e.RealName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(200);


                entity.Property(e => e.WorkPhone).HasMaxLength(50);

                entity.HasOne(d => d.Dep)
                    .WithMany(p => p.WorkUser)
                    .HasForeignKey(d => d.DepId)
                    .HasConstraintName("FK_WORKUSER_REFERENCE_DEPARTME");
            });

            modelBuilder.Entity<WorkUserProperty>(entity =>
            {

                entity.Property(e => e.Id).HasColumnName("WPId");

                entity.Property(e => e.Wpname)
                    .HasColumnName("WPName")
                    .HasMaxLength(100);

                entity.Property(e => e.Wpvalue)
                    .HasColumnName("WPValue")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Wu)
                    .WithMany(p => p.WorkUserProperty)
                    .HasForeignKey(d => d.WuId)
                    .HasConstraintName("FK_WORKUSER_REFERENCE_WORKUSER");
            });

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
