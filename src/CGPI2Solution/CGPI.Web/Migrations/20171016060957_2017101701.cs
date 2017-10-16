using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CGPI.Web.Migrations
{
    public partial class _2017101701 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsEnableed",
                table: "UserRole",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "UserRole",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "UserRole",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<bool>(
                name: "IsEnableed",
                table: "UserAuthorize",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "UserAuthorize",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "UserAuthorize",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysUser",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysUser",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysRole",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysRole",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysRole",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysOrganize",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysOrganize",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysOrganize",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysMenu",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysMenu",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysMenu",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysDictDetail",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysDictDetail",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysDictDetail",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysDict",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysDict",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysDict",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<bool>(
                name: "IsEnableed",
                table: "RoleAuthorize",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "RoleAuthorize",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "RoleAuthorize",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.CreateTable(
                name: "ClassType",
                columns: table => new
                {
                    CTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Iorder = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassType", x => x.CTId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Iorder = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    ParentDepId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepId);
                });

            migrationBuilder.CreateTable(
                name: "LessionType",
                columns: table => new
                {
                    LTId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Iorder = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TypeCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessionType", x => x.LTId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Belief = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    CardId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CharitDomain = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnglishLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GPLCreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    GPLScale = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    IsPassport = table.Column<bool>(type: "bit", nullable: true),
                    IsUSPassport = table.Column<bool>(type: "bit", nullable: true),
                    LessionIds = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LoginPass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NativePlace = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OpenKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OrgAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OrgBack = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OrgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassportImg = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PassportNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassportValid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PostName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QQ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QQOpenId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Taboo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UrgentEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UrgentFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UrgentMobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UrgentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UrgentPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VisaImg = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VisaType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VisaValid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WeChart = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Weibo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WeixinOpenId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WelfareWorkTimeSpan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AppointmentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AssessmentContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AssessmentScore = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BankAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClassCost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Contacts = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Coordinator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Iorder = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    IsScanning = table.Column<bool>(type: "bit", nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: true),
                    Matters = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OtherContacts = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassportStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassportTimeSpan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PersonRemark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PostName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SysUserId = table.Column<int>(type: "int", nullable: false),
                    TeachLessions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teacher_SysUser_SysUserId",
                        column: x => x.SysUserId,
                        principalTable: "SysUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassInfo",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClassContent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClassRemark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CTId = table.Column<int>(type: "int", nullable: true),
                    DepId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    IsReg = table.Column<bool>(type: "bit", nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: true),
                    RegEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RegStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Tuition = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassInfo", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_CLASSINF_REFERENCE_CLASSTYP",
                        column: x => x.CTId,
                        principalTable: "ClassType",
                        principalColumn: "CTId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CLASSINF_REFERENCE_DEPARTME",
                        column: x => x.DepId,
                        principalTable: "Department",
                        principalColumn: "DepId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkUser",
                columns: table => new
                {
                    WuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BankAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DepId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EnglishName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Iorder = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PostName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SysUserId = table.Column<int>(type: "int", nullable: false),
                    WorkPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkUser", x => x.WuId);
                    table.ForeignKey(
                        name: "FK_WORKUSER_REFERENCE_DEPARTME",
                        column: x => x.DepId,
                        principalTable: "Department",
                        principalColumn: "DepId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkUser_SysUser_SysUserId",
                        column: x => x.SysUserId,
                        principalTable: "SysUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lession",
                columns: table => new
                {
                    LessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    LessionCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LessionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LTId = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lession", x => x.LessionId);
                    table.ForeignKey(
                        name: "FK_LESSION_REFERENCE_LESSIONT",
                        column: x => x.LTId,
                        principalTable: "LessionType",
                        principalColumn: "LTId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EducationExperience",
                columns: table => new
                {
                    EeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Education = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EndDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    SchoolName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StartDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationExperience", x => x.EeId);
                    table.ForeignKey(
                        name: "FK_EDUCATIO_REFERENCE_STUDENT",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCode",
                columns: table => new
                {
                    SCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    SCCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SCCodeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCode", x => x.SCId);
                    table.ForeignKey(
                        name: "FK_STUDENTC_REFERENCE_STUDENT2",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentProperty",
                columns: table => new
                {
                    SPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Iorder = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    SPName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SPValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentProperty", x => x.SPId);
                    table.ForeignKey(
                        name: "FK_STUDENTP_REFERENCE_STUDENT",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperience",
                columns: table => new
                {
                    WeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EndDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UnitPost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperience", x => x.WeId);
                    table.ForeignKey(
                        name: "FK_WORKEXPE_REFERENCE_STUDENT",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherProperty",
                columns: table => new
                {
                    TPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Iorder = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: true),
                    TPName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TPValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherProperty", x => x.TPId);
                    table.ForeignKey(
                        name: "FK_TEACHERP_REFERENCE_TEACHER",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentClass",
                columns: table => new
                {
                    SCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    IsTemporary = table.Column<bool>(type: "bit", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClass", x => x.SCId);
                    table.ForeignKey(
                        name: "FK_STUDENTC_REFERENCE_CLASSINF",
                        column: x => x.ClassId,
                        principalTable: "ClassInfo",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_STUDENTC_REFERENCE_STUDENT",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassManager",
                columns: table => new
                {
                    CMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    WuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassManager", x => x.CMId);
                    table.ForeignKey(
                        name: "FK_CLASSMAN_REFERENCE_CLASSINF",
                        column: x => x.ClassId,
                        principalTable: "ClassInfo",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CLASSMAN_REFERENCE_WORKUSER",
                        column: x => x.WuId,
                        principalTable: "WorkUser",
                        principalColumn: "WuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkUserProperty",
                columns: table => new
                {
                    WPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Iorder = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    WPName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WPValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkUserProperty", x => x.WPId);
                    table.ForeignKey(
                        name: "FK_WORKUSER_REFERENCE_WORKUSER",
                        column: x => x.WuId,
                        principalTable: "WorkUser",
                        principalColumn: "WuId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassLession",
                columns: table => new
                {
                    CLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(18, 2)", nullable: true, defaultValueSql: "((0))"),
                    EndDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    LessionId = table.Column<int>(type: "int", nullable: true),
                    RealTotal = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShouldTotal = table.Column<int>(type: "int", nullable: true),
                    StartDateTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TeacherName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TimeRemark = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLession", x => x.CLId);
                    table.ForeignKey(
                        name: "FK_CLASSLES_REFERENCE_CLASSINF",
                        column: x => x.ClassId,
                        principalTable: "ClassInfo",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CLASSLES_REFERENCE_LESSION",
                        column: x => x.LessionId,
                        principalTable: "Lession",
                        principalColumn: "LessionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassLessionItem",
                columns: table => new
                {
                    CLIId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CLId = table.Column<int>(type: "int", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    EndLessionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    LessionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    StartLessionTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassLessionItem", x => x.CLIId);
                    table.ForeignKey(
                        name: "FK_CLASSLES_REFERENCE_CLASSLES",
                        column: x => x.CLId,
                        principalTable: "ClassLession",
                        principalColumn: "CLId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentLession",
                columns: table => new
                {
                    SLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckinTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CheckoutTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CLIId = table.Column<int>(type: "int", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))"),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLession", x => x.SLId);
                    table.ForeignKey(
                        name: "FK_STUDENTL_REFERENCE_CLASSLES",
                        column: x => x.CLIId,
                        principalTable: "ClassLessionItem",
                        principalColumn: "CLIId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_STUDENTL_REFERENCE_STUDENT",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentLeave",
                columns: table => new
                {
                    LId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    LeaveContent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LeaveTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RStatus = table.Column<int>(type: "int", nullable: true),
                    SLId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLeave", x => x.LId);
                    table.ForeignKey(
                        name: "FK_STUDENTL_REFERENCE_STUDENTL",
                        column: x => x.SLId,
                        principalTable: "StudentLession",
                        principalColumn: "SLId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarkupLession",
                columns: table => new
                {
                    MLId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsEnableed = table.Column<bool>(type: "bit", nullable: false),
                    LId = table.Column<int>(type: "int", nullable: true),
                    MLEndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    MLStartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkupLession", x => x.MLId);
                    table.ForeignKey(
                        name: "FK_MARKUPLE_REFERENCE_STUDENTL",
                        column: x => x.LId,
                        principalTable: "StudentLeave",
                        principalColumn: "LId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassInfo_CTId",
                table: "ClassInfo",
                column: "CTId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassInfo_DepId",
                table: "ClassInfo",
                column: "DepId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassLession_ClassId",
                table: "ClassLession",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassLession_LessionId",
                table: "ClassLession",
                column: "LessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassLessionItem_CLId",
                table: "ClassLessionItem",
                column: "CLId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassManager_ClassId",
                table: "ClassManager",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassManager_WuId",
                table: "ClassManager",
                column: "WuId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationExperience_StudentId",
                table: "EducationExperience",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lession_LTId",
                table: "Lession",
                column: "LTId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkupLession_LId",
                table: "MarkupLession",
                column: "LId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_ClassId",
                table: "StudentClass",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClass_StudentId",
                table: "StudentClass",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCode_StudentId",
                table: "StudentCode",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLeave_SLId",
                table: "StudentLeave",
                column: "SLId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLession_CLIId",
                table: "StudentLession",
                column: "CLIId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentLession_StudentId",
                table: "StudentLession",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentProperty_StudentId",
                table: "StudentProperty",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SysUserId",
                table: "Teacher",
                column: "SysUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProperty_TeacherId",
                table: "TeacherProperty",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperience_StudentId",
                table: "WorkExperience",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkUser_DepId",
                table: "WorkUser",
                column: "DepId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkUser_SysUserId",
                table: "WorkUser",
                column: "SysUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkUserProperty_WuId",
                table: "WorkUserProperty",
                column: "WuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassManager");

            migrationBuilder.DropTable(
                name: "EducationExperience");

            migrationBuilder.DropTable(
                name: "MarkupLession");

            migrationBuilder.DropTable(
                name: "StudentClass");

            migrationBuilder.DropTable(
                name: "StudentCode");

            migrationBuilder.DropTable(
                name: "StudentProperty");

            migrationBuilder.DropTable(
                name: "TeacherProperty");

            migrationBuilder.DropTable(
                name: "WorkExperience");

            migrationBuilder.DropTable(
                name: "WorkUserProperty");

            migrationBuilder.DropTable(
                name: "StudentLeave");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "WorkUser");

            migrationBuilder.DropTable(
                name: "StudentLession");

            migrationBuilder.DropTable(
                name: "ClassLessionItem");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "ClassLession");

            migrationBuilder.DropTable(
                name: "ClassInfo");

            migrationBuilder.DropTable(
                name: "Lession");

            migrationBuilder.DropTable(
                name: "ClassType");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "LessionType");

            migrationBuilder.AlterColumn<bool>(
                name: "IsEnableed",
                table: "UserRole",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "UserRole",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "UserRole",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsEnableed",
                table: "UserAuthorize",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "UserAuthorize",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "UserAuthorize",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysUser",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysUser",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysRole",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysRole",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysRole",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysOrganize",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysOrganize",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysOrganize",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysMenu",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysMenu",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysMenu",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysDictDetail",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysDictDetail",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysDictDetail",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<int>(
                name: "SortCode",
                table: "SysDict",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "SysDict",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "SysDict",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<bool>(
                name: "IsEnableed",
                table: "RoleAuthorize",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "RoleAuthorize",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "RoleAuthorize",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
