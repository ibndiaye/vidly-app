namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'26e18f9b-de94-495d-af29-762b0a0b0d1f', N'trueadmin@vidly.com', 0, N'AP8HD+/gfq4CfgoCedUMAcFAzrkOdxrAk1eFxQsX0UH6whjQA7tVdy750ALzcPWiWQ==', N'6ec408ca-df34-470c-9100-2a71ee2018e5', NULL, 0, 0, NULL, 1, 0, N'trueadmin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b25fd1c6-a910-4a72-b92a-0e8bbd8b892c', N'admin@vidly.com', 0, N'ABXqYoenuNZ5qoiNaW7zj9nL54B2/51+K0HEc2gXaQcccLljQTbgZ/n7Rlp/i5We7w==', N'24170400-204f-4480-94f0-0ce8389429b2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f108d1a5-c0ea-4f27-83d1-146426971ad9', N'ibrahn1290@gmail.com', 0, N'AGprkrVWTi9OsyaMtp/6A9CgG8ppQFm+orjYD0vbvQivFmufSOjCLiu0/9EWjS8gtw==', N'6501eb5f-a09d-417b-8546-1b87e1eddd72', NULL, 0, 0, NULL, 1, 0, N'ibrahn1290@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c18aec2c-b4f7-43da-8c39-46fad3f25adf', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'26e18f9b-de94-495d-af29-762b0a0b0d1f', N'c18aec2c-b4f7-43da-8c39-46fad3f25adf')

");
        }

        public override void Down()
        {
        }
    }
}