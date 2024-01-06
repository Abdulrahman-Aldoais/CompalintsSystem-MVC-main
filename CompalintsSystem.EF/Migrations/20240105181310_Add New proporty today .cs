﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompalintsSystem.EF.Migrations
{
    public partial class AddNewproportytoday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.CreateTable(
                name: "Collegess",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collegess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proposals",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitileProposal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescProposal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSubmeted = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "تحديد وقت ادخال الصف في قاعدية البيانات"),
                    BeneficiarieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Societys",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Societys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StagesComplaints",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StagesComplaints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusCompalints",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCompalints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeCommunications",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "varchar(150)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersNameAddType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCommunications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeComplaints",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "varchar(150)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersNameAddType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeComplaints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departmentss",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmentss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departmentss_Collegess_CollegesId",
                        column: x => x.CollegesId,
                        principalSchema: "Identity",
                        principalTable: "Collegess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubDepartmentss",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubDepartmentss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubDepartmentss_Departmentss_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalSchema: "Identity",
                        principalTable: "Departmentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegesId = table.Column<int>(type: "int", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    SubDepartmentsId = table.Column<int>(type: "int", nullable: false),
                    SocietyId = table.Column<int>(type: "int", nullable: true),
                    ProfilePicture = table.Column<string>(type: "varchar(250)", nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    originatorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Collegess_CollegesId",
                        column: x => x.CollegesId,
                        principalSchema: "Identity",
                        principalTable: "Collegess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Departmentss_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalSchema: "Identity",
                        principalTable: "Departmentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Societys_SocietyId",
                        column: x => x.SocietyId,
                        principalSchema: "Identity",
                        principalTable: "Societys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_SubDepartmentss_SubDepartmentsId",
                        column: x => x.SubDepartmentsId,
                        principalSchema: "Identity",
                        principalTable: "SubDepartmentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_User_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "Identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UploadsComplaintes",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleComplaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeComplaintId = table.Column<int>(type: "int", nullable: false),
                    DescComplaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocietyId = table.Column<int>(type: "int", nullable: true),
                    StatusCompalintId = table.Column<int>(type: "int", nullable: false),
                    StagesComplaintId = table.Column<int>(type: "int", nullable: false),
                    PropBeneficiarie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegesId = table.Column<int>(type: "int", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    SubDepartmentsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Today = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadsComplaintes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadsComplaintes_Collegess_CollegesId",
                        column: x => x.CollegesId,
                        principalSchema: "Identity",
                        principalTable: "Collegess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UploadsComplaintes_Departmentss_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalSchema: "Identity",
                        principalTable: "Departmentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UploadsComplaintes_Societys_SocietyId",
                        column: x => x.SocietyId,
                        principalSchema: "Identity",
                        principalTable: "Societys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UploadsComplaintes_StagesComplaints_StagesComplaintId",
                        column: x => x.StagesComplaintId,
                        principalSchema: "Identity",
                        principalTable: "StagesComplaints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UploadsComplaintes_StatusCompalints_StatusCompalintId",
                        column: x => x.StatusCompalintId,
                        principalSchema: "Identity",
                        principalTable: "StatusCompalints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UploadsComplaintes_SubDepartmentss_SubDepartmentsId",
                        column: x => x.SubDepartmentsId,
                        principalSchema: "Identity",
                        principalTable: "SubDepartmentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UploadsComplaintes_TypeComplaints_TypeComplaintId",
                        column: x => x.TypeComplaintId,
                        principalSchema: "Identity",
                        principalTable: "TypeComplaints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UploadsComplaintes_User_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersCommunications",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reportSubmitterId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    reportSubmitterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reporteeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BenfPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollegesId = table.Column<int>(type: "int", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    SubDepartmentsId = table.Column<int>(type: "int", nullable: false),
                    TypeCommuncationId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Titile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCommunications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersCommunications_Collegess_CollegesId",
                        column: x => x.CollegesId,
                        principalSchema: "Identity",
                        principalTable: "Collegess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersCommunications_Departmentss_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalSchema: "Identity",
                        principalTable: "Departmentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersCommunications_SubDepartmentss_SubDepartmentsId",
                        column: x => x.SubDepartmentsId,
                        principalSchema: "Identity",
                        principalTable: "SubDepartmentss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersCommunications_TypeCommunications_TypeCommuncationId",
                        column: x => x.TypeCommuncationId,
                        principalSchema: "Identity",
                        principalTable: "TypeCommunications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersCommunications_User_reportSubmitterId",
                        column: x => x.reportSubmitterId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compalints_Solutions",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UploadsComplainteId = table.Column<int>(type: "int", nullable: false),
                    SolutionProvName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionProvIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAccept = table.Column<bool>(type: "bit", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonWhySolutionRejected = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentSolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSolution = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compalints_Solutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compalints_Solutions_UploadsComplaintes_UploadsComplainteId",
                        column: x => x.UploadsComplainteId,
                        principalSchema: "Identity",
                        principalTable: "UploadsComplaintes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compalints_Solutions_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComplaintsRejecteds",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UploadsComplainteId = table.Column<int>(type: "int", nullable: false),
                    RejectedProvName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RejectedUserProvIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateSolution = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintsRejecteds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplaintsRejecteds_UploadsComplaintes_UploadsComplainteId",
                        column: x => x.UploadsComplainteId,
                        principalSchema: "Identity",
                        principalTable: "UploadsComplaintes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComplaintsRejecteds_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UpComplaintCauses",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UploadsComplainteId = table.Column<int>(type: "int", nullable: false),
                    UpProvName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpUserProvIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cause = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateUp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpComplaintCauses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpComplaintCauses_UploadsComplaintes_UploadsComplainteId",
                        column: x => x.UploadsComplainteId,
                        principalSchema: "Identity",
                        principalTable: "UploadsComplaintes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UpComplaintCauses_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ApplicationUserId", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8faa31eb-ded0-4711-8e0b-0f509c4b332f", null, "a318c051-b2e3-4c17-b0a4-691201db847e", "Beneficiarie", "BENEFICIARIE" },
                    { "81b7a93d-4221-4d50-884c-08d98676a9c8", null, "a4e004b8-3117-43a0-884e-33ce161cea4f", "AdminDepartments", "ADMINDEPARTMENTS" },
                    { "7f95d3fd-8840-466e-9da6-d7dcf06298de", null, "a61dedc2-e50e-4f32-a5f1-63dbaf959530", "AdminColleges", "ADMINCOLLEGES" },
                    { "2e803883-c018-4f7c-90e3-c3c1db0d8f00", null, "d1132c78-1c34-4f81-8319-a663138ee3e5", "AdminGeneralFederation", "ADMINGENERALFEDERATION" },
                    { "64a8ff4a-f4a2-405c-9c1a-85f0f9f46145", null, "e271d810-b120-4b92-b9f1-f13eeddc3825", "AdminSubDepartments", "ADMINSUBDEPARTMENTS" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Collegess",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "كلية الطب " },
                    { 3, "كلية التربية" },
                    { 2, " كلية الهندسة" },
                    { 4, " جميع الكليات" },
                    { 5, "زائر " }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Societys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "شئون الطلاب" },
                    { 3, "ادارة عامة" },
                    { 1, "الملتقى" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "StagesComplaints",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "موظف الشكوى" },
                    { 2, "رئيس القسم" },
                    { 3, "عميد الكلية" },
                    { 4, "رئاسة الجامعة" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "StatusCompalints",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "معلقة" },
                    { 5, "مرفوعة" },
                    { 3, "مرفوضة" },
                    { 2, "محلولة" },
                    { 1, "جديدة" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "TypeCommunications",
                columns: new[] { "Id", "CreatedDate", "Type", "UserId", "UsersNameAddType" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 1, 5, 21, 13, 8, 160, DateTimeKind.Local).AddTicks(6343), "تلاعب بالحلول", null, "قيمة افتراضية من النضام" },
                    { 1, new DateTime(2024, 1, 5, 21, 13, 8, 160, DateTimeKind.Local).AddTicks(6152), "تماطل", null, "قيمة افتراضية من النضام" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "TypeComplaints",
                columns: new[] { "Id", "CreatedDate", "Type", "UserId", "UsersNameAddType" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 5, 21, 13, 8, 161, DateTimeKind.Local).AddTicks(3135), "مالية", null, "قيمة افتراضية من النضام" },
                    { 2, new DateTime(2024, 1, 5, 21, 13, 8, 161, DateTimeKind.Local).AddTicks(3543), "فساد", null, "قيمة افتراضية من النضام" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "Departmentss",
                columns: new[] { "Id", "CollegesId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "الطب البشري" },
                    { 9, 1, "المختبرات" },
                    { 10, 1, "التمريض" },
                    { 3, 1, "صيدلة" },
                    { 11, 2, "نظم معلومات" },
                    { 12, 2, "امن سيبراني" },
                    { 13, 2, "هندسة معماري" },
                    { 2, 2, "علوم حاسوب" },
                    { 5, 2, "هندسة مدني" },
                    { 7, 4, "جميع الاقسام" },
                    { 8, 5, "زئر" },
                    { 6, 3, "فيزياء" },
                    { 4, 3, "قران" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "SubDepartmentss",
                columns: new[] { "Id", "DepartmentsId", "Name" },
                values: new object[,]
                {
                    { 1, 1, " الاول" },
                    { 43, 12, " الاول" },
                    { 44, 12, " الثاني" },
                    { 45, 12, " الثالث" },
                    { 46, 12, " الرابع" },
                    { 47, 12, " خريج" },
                    { 48, 13, " الاول" },
                    { 49, 13, " الثاني" },
                    { 50, 13, " الثالث" },
                    { 51, 13, " الرابع" },
                    { 52, 13, " خريج" },
                    { 42, 11, " خريج" },
                    { 3, 2, " الاول" },
                    { 22, 2, " الرابع" },
                    { 4, 2, " الثاني" },
                    { 10, 5, " الاول" },
                    { 11, 5, " الثاني" },
                    { 25, 5, " الثالث" },
                    { 26, 5, " الرابع" },
                    { 13, 7, " جميع المستويات" },
                    { 14, 8, " لا يوجد" },
                    { 12, 6, " الثاني" },
                    { 5, 6, "الاول" },
                    { 21, 2, " الثالث" },
                    { 41, 11, " الرابع" },
                    { 40, 11, " الثالث" },
                    { 39, 11, " الثاني" },
                    { 15, 1, " الثالث" },
                    { 16, 1, " الرابع" },
                    { 17, 1, " الخامس" },
                    { 18, 1, " السادس" },
                    { 19, 1, " السابع" },
                    { 20, 1, " خريج" },
                    { 2, 1, " الثاني" },
                    { 27, 9, " الاول" },
                    { 28, 9, " الثاني" },
                    { 29, 9, " الثالث" },
                    { 30, 9, " الرابع" },
                    { 31, 9, " خريج" },
                    { 32, 10, " خريج" },
                    { 33, 10, " الاول" },
                    { 34, 10, " الثاني" }
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "SubDepartmentss",
                columns: new[] { "Id", "DepartmentsId", "Name" },
                values: new object[,]
                {
                    { 35, 10, " الثالث" },
                    { 36, 10, " الرابع" },
                    { 37, 10, " خريج" },
                    { 6, 3, " الاول" },
                    { 7, 3, " الثاني" },
                    { 23, 3, " الثالث" },
                    { 24, 3, " الرابع" },
                    { 38, 11, " الاول" },
                    { 8, 4, " الاول" },
                    { 9, 4, " الثاني" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Identity",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_ApplicationUserId",
                schema: "Identity",
                table: "AspNetRoles",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Identity",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Identity",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Identity",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Identity",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_Solutions_UploadsComplainteId",
                schema: "Identity",
                table: "Compalints_Solutions",
                column: "UploadsComplainteId");

            migrationBuilder.CreateIndex(
                name: "IX_Compalints_Solutions_UserId",
                schema: "Identity",
                table: "Compalints_Solutions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintsRejecteds_UploadsComplainteId",
                schema: "Identity",
                table: "ComplaintsRejecteds",
                column: "UploadsComplainteId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintsRejecteds_UserId",
                schema: "Identity",
                table: "ComplaintsRejecteds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Departmentss_CollegesId",
                schema: "Identity",
                table: "Departmentss",
                column: "CollegesId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDepartmentss_DepartmentsId",
                schema: "Identity",
                table: "SubDepartmentss",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_UpComplaintCauses_UploadsComplainteId",
                schema: "Identity",
                table: "UpComplaintCauses",
                column: "UploadsComplainteId");

            migrationBuilder.CreateIndex(
                name: "IX_UpComplaintCauses_UserId",
                schema: "Identity",
                table: "UpComplaintCauses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadsComplaintes_ApplicationUserId",
                schema: "Identity",
                table: "UploadsComplaintes",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadsComplaintes_CollegesId",
                schema: "Identity",
                table: "UploadsComplaintes",
                column: "CollegesId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadsComplaintes_DepartmentsId",
                schema: "Identity",
                table: "UploadsComplaintes",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadsComplaintes_SocietyId",
                schema: "Identity",
                table: "UploadsComplaintes",
                column: "SocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadsComplaintes_StagesComplaintId",
                schema: "Identity",
                table: "UploadsComplaintes",
                column: "StagesComplaintId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadsComplaintes_StatusCompalintId",
                schema: "Identity",
                table: "UploadsComplaintes",
                column: "StatusCompalintId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadsComplaintes_SubDepartmentsId",
                schema: "Identity",
                table: "UploadsComplaintes",
                column: "SubDepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadsComplaintes_TypeComplaintId",
                schema: "Identity",
                table: "UploadsComplaintes",
                column: "TypeComplaintId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Identity",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_User_CollegesId",
                schema: "Identity",
                table: "User",
                column: "CollegesId");

            migrationBuilder.CreateIndex(
                name: "IX_User_DepartmentsId",
                schema: "Identity",
                table: "User",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_User_SocietyId",
                schema: "Identity",
                table: "User",
                column: "SocietyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_SubDepartmentsId",
                schema: "Identity",
                table: "User",
                column: "SubDepartmentsId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Identity",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCommunications_CollegesId",
                schema: "Identity",
                table: "UsersCommunications",
                column: "CollegesId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCommunications_DepartmentsId",
                schema: "Identity",
                table: "UsersCommunications",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCommunications_reportSubmitterId",
                schema: "Identity",
                table: "UsersCommunications",
                column: "reportSubmitterId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCommunications_SubDepartmentsId",
                schema: "Identity",
                table: "UsersCommunications",
                column: "SubDepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCommunications_TypeCommuncationId",
                schema: "Identity",
                table: "UsersCommunications",
                column: "TypeCommuncationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Compalints_Solutions",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "ComplaintsRejecteds",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Proposals",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UpComplaintCauses",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UsersCommunications",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "UploadsComplaintes",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "TypeCommunications",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "StagesComplaints",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "StatusCompalints",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "TypeComplaints",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Societys",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "SubDepartmentss",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Departmentss",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Collegess",
                schema: "Identity");
        }
    }
}
