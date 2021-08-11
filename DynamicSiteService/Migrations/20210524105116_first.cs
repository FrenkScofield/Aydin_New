using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicSiteService.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailCC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlTarget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceConfig", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceConfig_ServiceConfig_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ServiceConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SiteConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartPage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartAction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    layoutID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    layoutUrlBase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    layoutUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Copyright = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefaultImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JokerPass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailGorunenAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpMailPass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpSSL = table.Column<bool>(type: "bit", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GooglePlus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tumblr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeadStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterScript = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirdhDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsKvk = table.Column<bool>(type: "bit", nullable: true),
                    IsIletisimIzın = table.Column<bool>(type: "bit", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRead = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormTypeId = table.Column<int>(type: "int", nullable: false),
                    Custom1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Custom2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Custom3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forms_FormType_FormTypeId",
                        column: x => x.FormTypeId,
                        principalTable: "FormType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContentPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentPageId = table.Column<int>(type: "int", nullable: true),
                    ContentTypesId = table.Column<int>(type: "int", nullable: false),
                    TemplateType = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExternalLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrjId = table.Column<int>(type: "int", nullable: true),
                    OrjId1 = table.Column<int>(type: "int", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    BannerText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BannerButtonText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentShort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormTypeId = table.Column<int>(type: "int", nullable: true),
                    IsGallery = table.Column<bool>(type: "bit", nullable: true),
                    IsMap = table.Column<bool>(type: "bit", nullable: true),
                    IsHeaderMenu = table.Column<bool>(type: "bit", nullable: true),
                    IsFooterMenu = table.Column<bool>(type: "bit", nullable: true),
                    IsHamburgerMenu = table.Column<bool>(type: "bit", nullable: true),
                    IsSideMenu = table.Column<bool>(type: "bit", nullable: true),
                    IsClick = table.Column<bool>(type: "bit", nullable: true),
                    IsHome = table.Column<bool>(type: "bit", nullable: true),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKeywords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContentOrderNo = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsPublish = table.Column<bool>(type: "bit", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentPage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContentPage_ContentPage_ContentPageId",
                        column: x => x.ContentPageId,
                        principalTable: "ContentPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentPage_ContentPage_OrjId1",
                        column: x => x.OrjId1,
                        principalTable: "ContentPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentPage_ContentTypes_ContentTypesId",
                        column: x => x.ContentTypesId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentPage_FormType_FormTypeId",
                        column: x => x.FormTypeId,
                        principalTable: "FormType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentPage_Lang_LangId",
                        column: x => x.LangId,
                        principalTable: "Lang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecType = table.Column<int>(type: "int", nullable: false),
                    OrjId = table.Column<int>(type: "int", nullable: true),
                    IsTanim = table.Column<bool>(type: "bit", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spec_Lang_LangId",
                        column: x => x.LangId,
                        principalTable: "Lang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spec_Spec_OrjId",
                        column: x => x.OrjId,
                        principalTable: "Spec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Spec_Spec_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Spec",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleParentId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceConfigId = table.Column<int>(type: "int", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Role_Role_RoleParentId",
                        column: x => x.RoleParentId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Role_ServiceConfig_ServiceConfigId",
                        column: x => x.ServiceConfigId,
                        principalTable: "ServiceConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Types = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Guid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: true),
                    GalleryId = table.Column<int>(type: "int", nullable: true),
                    ThumbImageId = table.Column<int>(type: "int", nullable: true),
                    BannerImageId = table.Column<int>(type: "int", nullable: true),
                    PictureId = table.Column<int>(type: "int", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_ContentPage_BannerImageId",
                        column: x => x.BannerImageId,
                        principalTable: "ContentPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_ContentPage_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "ContentPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_ContentPage_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "ContentPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_ContentPage_PictureId",
                        column: x => x.PictureId,
                        principalTable: "ContentPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_ContentPage_ThumbImageId",
                        column: x => x.ThumbImageId,
                        principalTable: "ContentPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecAttr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecId = table.Column<int>(type: "int", nullable: false),
                    AttrValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrjId = table.Column<int>(type: "int", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: false),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecAttr", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecAttr_Lang_LangId",
                        column: x => x.LangId,
                        principalTable: "Lang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecAttr_Spec_OrjId",
                        column: x => x.OrjId,
                        principalTable: "Spec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecAttr_Spec_SpecId",
                        column: x => x.SpecId,
                        principalTable: "Spec",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SpecContentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecId = table.Column<int>(type: "int", nullable: false),
                    ContentTypesId = table.Column<int>(type: "int", nullable: false),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecContentType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecContentType_ContentTypes_ContentTypesId",
                        column: x => x.ContentTypesId,
                        principalTable: "ContentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecContentType_Spec_SpecId",
                        column: x => x.SpecId,
                        principalTable: "Spec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SpecContentValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecId = table.Column<int>(type: "int", nullable: false),
                    ContentPageId = table.Column<int>(type: "int", nullable: false),
                    ContentValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangId = table.Column<int>(type: "int", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecContentValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecContentValue_ContentPage_ContentPageId",
                        column: x => x.ContentPageId,
                        principalTable: "ContentPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecContentValue_Lang_LangId",
                        column: x => x.LangId,
                        principalTable: "Lang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecContentValue_Spec_SpecId",
                        column: x => x.SpecId,
                        principalTable: "Spec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permission_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceConfigAuth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceConfigId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    PermissionId = table.Column<int>(type: "int", nullable: true),
                    IsCreate = table.Column<bool>(type: "bit", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: true),
                    IsUpdate = table.Column<bool>(type: "bit", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: true),
                    IsList = table.Column<bool>(type: "bit", nullable: true),
                    CreaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreaUser = table.Column<int>(type: "int", nullable: false),
                    ModUser = table.Column<int>(type: "int", nullable: true),
                    ModDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsStatus = table.Column<int>(type: "int", nullable: true),
                    LoginCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceConfigAuth", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceConfigAuth_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceConfigAuth_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceConfigAuth_ServiceConfig_ServiceConfigId",
                        column: x => x.ServiceConfigId,
                        principalTable: "ServiceConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceConfigAuth_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContentPage_ContentPageId",
                table: "ContentPage",
                column: "ContentPageId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentPage_ContentTypesId",
                table: "ContentPage",
                column: "ContentTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentPage_FormTypeId",
                table: "ContentPage",
                column: "FormTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentPage_LangId",
                table: "ContentPage",
                column: "LangId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentPage_OrjId1",
                table: "ContentPage",
                column: "OrjId1");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_BannerImageId",
                table: "Documents",
                column: "BannerImageId",
                unique: true,
                filter: "[BannerImageId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentId",
                table: "Documents",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_GalleryId",
                table: "Documents",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_PictureId",
                table: "Documents",
                column: "PictureId",
                unique: true,
                filter: "[PictureId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ThumbImageId",
                table: "Documents",
                column: "ThumbImageId",
                unique: true,
                filter: "[ThumbImageId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_FormTypeId",
                table: "Forms",
                column: "FormTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_RoleId",
                table: "Permission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleParentId",
                table: "Role",
                column: "RoleParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ServiceConfigId",
                table: "Role",
                column: "ServiceConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceConfig_ParentId",
                table: "ServiceConfig",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceConfigAuth_PermissionId",
                table: "ServiceConfigAuth",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceConfigAuth_RoleId",
                table: "ServiceConfigAuth",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceConfigAuth_ServiceConfigId",
                table: "ServiceConfigAuth",
                column: "ServiceConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceConfigAuth_UsersId",
                table: "ServiceConfigAuth",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Spec_LangId",
                table: "Spec",
                column: "LangId");

            migrationBuilder.CreateIndex(
                name: "IX_Spec_OrjId",
                table: "Spec",
                column: "OrjId");

            migrationBuilder.CreateIndex(
                name: "IX_Spec_ParentId",
                table: "Spec",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecAttr_LangId",
                table: "SpecAttr",
                column: "LangId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecAttr_OrjId",
                table: "SpecAttr",
                column: "OrjId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecAttr_SpecId",
                table: "SpecAttr",
                column: "SpecId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecContentType_ContentTypesId",
                table: "SpecContentType",
                column: "ContentTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecContentType_SpecId",
                table: "SpecContentType",
                column: "SpecId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecContentValue_ContentPageId",
                table: "SpecContentValue",
                column: "ContentPageId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecContentValue_LangId",
                table: "SpecContentValue",
                column: "LangId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecContentValue_SpecId",
                table: "SpecContentValue",
                column: "SpecId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "ServiceConfigAuth");

            migrationBuilder.DropTable(
                name: "SiteConfig");

            migrationBuilder.DropTable(
                name: "SpecAttr");

            migrationBuilder.DropTable(
                name: "SpecContentType");

            migrationBuilder.DropTable(
                name: "SpecContentValue");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "ContentPage");

            migrationBuilder.DropTable(
                name: "Spec");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "ContentTypes");

            migrationBuilder.DropTable(
                name: "FormType");

            migrationBuilder.DropTable(
                name: "Lang");

            migrationBuilder.DropTable(
                name: "ServiceConfig");
        }
    }
}
