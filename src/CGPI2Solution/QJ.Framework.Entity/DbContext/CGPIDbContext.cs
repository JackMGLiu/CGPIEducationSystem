using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using QJ.Framework.Entity.Entities.System;

namespace QJ.Framework.Entity.DbContext
{
    public class CGPIDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CGPIDbContext(DbContextOptions<CGPIDbContext> options) : base(options)
        {
        }

        public virtual DbSet<SysUser> SysUsers { get; set; }
        public virtual DbSet<SysRole> SysRoles { get; set; }
        public virtual DbSet<SysOrganize> SysOrganizes { get; set; }
        public virtual DbSet<SysMenu> SysMenus { get; set; }
        public virtual DbSet<SysDict> SysDicts { get; set; }
        public virtual DbSet<SysDictDetail> SysDictDetails { get; set; }
        public virtual DbSet<SysLog> SysLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysUser>().ToTable("SysUser");
            modelBuilder.Entity<SysRole>().ToTable("SysRole");
            modelBuilder.Entity<SysOrganize>().ToTable("SysOrganize");
            modelBuilder.Entity<SysMenu>().ToTable("SysMenu");
            modelBuilder.Entity<SysDict>().ToTable("SysDict");
            modelBuilder.Entity<SysDictDetail>().ToTable("SysDictDetail");
            modelBuilder.Entity<SysLog>().ToTable("SysLog");

            //org
            modelBuilder.Entity<SysOrganize>().HasMany(ur => ur.SysOrgUsers).WithOne(u => u.Organize).HasForeignKey(ur => ur.OrganizeId);
            modelBuilder.Entity<SysOrganize>().HasMany(ur => ur.SysDepUsers).WithOne(u => u.Department).HasForeignKey(ur => ur.DepartmentId);

            modelBuilder.Entity<UserRole>().ToTable("UserRole");
            modelBuilder.Entity<UserAuthorize>().ToTable("UserAuthorize");
            modelBuilder.Entity<RoleAuthorize>().ToTable("RoleAuthorize");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
