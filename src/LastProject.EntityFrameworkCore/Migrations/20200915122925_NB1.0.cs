using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LastProject.Migrations
{
    public partial class NB10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    MyProperty1 = table.Column<int>(nullable: false),
                    MyProperty2 = table.Column<int>(nullable: false),
                    MyProperty3 = table.Column<int>(nullable: false),
                    MyProperty4 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaseInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    BGuo = table.Column<string>(nullable: true),
                    BJia = table.Column<string>(nullable: true),
                    BGe = table.Column<string>(nullable: true),
                    BFu = table.Column<string>(nullable: true),
                    BFa = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChineseInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    CDan = table.Column<int>(nullable: false),
                    CNum = table.Column<int>(nullable: false),
                    CUserType = table.Column<int>(nullable: false),
                    CPin = table.Column<int>(nullable: false),
                    CSum = table.Column<decimal>(nullable: false),
                    UPId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChineseInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeptInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Dname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeptInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EjrInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Eid = table.Column<int>(nullable: false),
                    Epno = table.Column<string>(nullable: true),
                    Ename = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Esex = table.Column<string>(nullable: true),
                    Eage = table.Column<int>(nullable: false),
                    Etel = table.Column<string>(nullable: true),
                    Ezs = table.Column<string>(nullable: true),
                    Etime = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Eperson = table.Column<string>(nullable: true),
                    Estate = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: false),
                    JobName = table.Column<int>(nullable: false),
                    Rid = table.Column<int>(nullable: false),
                    Rname = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EjrInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Epno = table.Column<string>(nullable: true),
                    Ename = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Esex = table.Column<string>(nullable: true),
                    Eage = table.Column<int>(nullable: false),
                    Etel = table.Column<string>(nullable: true),
                    Ezs = table.Column<string>(nullable: true),
                    DeptId = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    Etime = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Eperson = table.Column<string>(nullable: true),
                    Estate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployJob",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Eid = table.Column<int>(nullable: false),
                    Epno = table.Column<string>(nullable: true),
                    Ename = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Esex = table.Column<string>(nullable: true),
                    Eage = table.Column<int>(nullable: false),
                    Etel = table.Column<string>(nullable: true),
                    Ezs = table.Column<string>(nullable: true),
                    Etime = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Eperson = table.Column<string>(nullable: true),
                    Estate = table.Column<int>(nullable: false),
                    JobId = table.Column<int>(nullable: false),
                    JobName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployJob", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Eid = table.Column<int>(nullable: false),
                    Epno = table.Column<string>(nullable: true),
                    Ename = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    Pwd = table.Column<string>(nullable: true),
                    Esex = table.Column<string>(nullable: true),
                    Eage = table.Column<int>(nullable: false),
                    Etel = table.Column<string>(nullable: true),
                    Ezs = table.Column<string>(nullable: true),
                    Etime = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Eperson = table.Column<string>(nullable: true),
                    Estate = table.Column<int>(nullable: false),
                    Rid = table.Column<int>(nullable: false),
                    Rname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GetMoney",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    GetMoneyTypeId = table.Column<int>(nullable: false),
                    RegInfoId = table.Column<int>(nullable: false),
                    OfficeInfoId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    GetQian = table.Column<int>(nullable: false),
                    GetTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetMoney", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    JobName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    JobId = table.Column<int>(nullable: false),
                    JobName = table.Column<string>(nullable: true),
                    Rid = table.Column<int>(nullable: false),
                    Rname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MestInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    CDan = table.Column<int>(nullable: false),
                    CDay = table.Column<int>(nullable: false),
                    CPing = table.Column<int>(nullable: false),
                    CUserType = table.Column<int>(nullable: false),
                    CPin = table.Column<int>(nullable: false),
                    CSum = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MestInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    KName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PinInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    PName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PinInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    HName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    GDanhao = table.Column<string>(nullable: true),
                    KeShi = table.Column<int>(nullable: false),
                    LType = table.Column<string>(nullable: true),
                    Doctor = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    GDate = table.Column<DateTime>(nullable: false),
                    GuaName = table.Column<string>(nullable: true),
                    GName = table.Column<string>(nullable: true),
                    GNum = table.Column<string>(nullable: true),
                    GAge = table.Column<int>(nullable: false),
                    GBirthday = table.Column<DateTime>(nullable: false),
                    GSex = table.Column<string>(nullable: true),
                    GTel = table.Column<string>(nullable: true),
                    GZheng = table.Column<string>(nullable: true),
                    GXiang = table.Column<string>(nullable: true),
                    GZhen = table.Column<string>(nullable: true),
                    GYizhu = table.Column<string>(nullable: true),
                    Yid = table.Column<int>(nullable: false),
                    Zhuang = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Rname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    UName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "yaoPinKuCun",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    YaoBianma = table.Column<string>(maxLength: 30, nullable: true),
                    YaoName = table.Column<string>(maxLength: 30, nullable: true),
                    YaoTyPeID = table.Column<int>(nullable: false),
                    YaoChang = table.Column<string>(nullable: true),
                    YaoKucun = table.Column<int>(nullable: false),
                    YaoPrice = table.Column<int>(nullable: false),
                    YaoGuige = table.Column<string>(maxLength: 30, nullable: true),
                    YaoZt = table.Column<int>(nullable: false),
                    YaoTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yaoPinKuCun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "yaoPinRuku",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Yaoruku = table.Column<string>(maxLength: 30, nullable: true),
                    YaorukuTime = table.Column<DateTime>(nullable: false),
                    YaorukurenID = table.Column<int>(nullable: false),
                    Yaogys = table.Column<string>(maxLength: 30, nullable: true),
                    YaozhidanTime = table.Column<DateTime>(nullable: false),
                    YaoBeizhu = table.Column<string>(maxLength: 30, nullable: true),
                    YaopinId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yaoPinRuku", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "yaoType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    TypeName = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yaoType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AA");

            migrationBuilder.DropTable(
                name: "CaseInfo");

            migrationBuilder.DropTable(
                name: "ChineseInfo");

            migrationBuilder.DropTable(
                name: "DeptInfo");

            migrationBuilder.DropTable(
                name: "EjrInfo");

            migrationBuilder.DropTable(
                name: "EmployInfo");

            migrationBuilder.DropTable(
                name: "EmployJob");

            migrationBuilder.DropTable(
                name: "EmployRole");

            migrationBuilder.DropTable(
                name: "GetMoney");

            migrationBuilder.DropTable(
                name: "JobInfo");

            migrationBuilder.DropTable(
                name: "JobRole");

            migrationBuilder.DropTable(
                name: "MestInfo");

            migrationBuilder.DropTable(
                name: "OfficeInfo");

            migrationBuilder.DropTable(
                name: "OrderType");

            migrationBuilder.DropTable(
                name: "PinInfo");

            migrationBuilder.DropTable(
                name: "PriceInfo");

            migrationBuilder.DropTable(
                name: "ProInfo");

            migrationBuilder.DropTable(
                name: "RegInfo");

            migrationBuilder.DropTable(
                name: "RoleInfo");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "yaoPinKuCun");

            migrationBuilder.DropTable(
                name: "yaoPinRuku");

            migrationBuilder.DropTable(
                name: "yaoType");
        }
    }
}
