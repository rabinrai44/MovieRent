namespace MovieRent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'24e23812-5f6f-4e54-9a72-46af3c8ada8a', N'admin@movierent.com', 0, N'AP8VVZWQbT1yD4Gm+dgtUCJGpQw0XIMldAqJSe7x8qGbAf8b4lR6j/HnczA+hi6ymQ==', N'fba18a4c-dc51-40f4-8b0a-34f900984889', NULL, 0, 0, NULL, 1, 0, N'admin@movierent.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'82604e6e-4e85-4b23-9636-46b51c6f33e0', N'guest@movierent.com', 0, N'AG1qyy5ka/jX33Q1lCEhs7v47ygY+taLLi06lFoAtrbjM5FB7bA9uA0qiDc5yzJFhw==', N'10acde92-e616-421c-b62e-8b9c31e3df02', NULL, 0, 0, NULL, 1, 0, N'guest@movierent.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'60b74909-caa9-4d7a-becd-5936c20ec3c9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'24e23812-5f6f-4e54-9a72-46af3c8ada8a', N'60b74909-caa9-4d7a-becd-5936c20ec3c9')

");
        }
        
        public override void Down()
        {
        }
    }
}
