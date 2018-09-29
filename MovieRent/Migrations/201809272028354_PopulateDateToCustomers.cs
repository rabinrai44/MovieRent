namespace MovieRent.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateDateToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate  = '01/01/2001' WHERE Id = 1 ");
            Sql("UPDATE Customers SET BirthDate  = '01/01/1966' WHERE Id = 2 ");
            Sql("UPDATE Customers SET BirthDate  = '01/01/1986' WHERE Id = 3 ");
            Sql("UPDATE Customers SET BirthDate  = '01/01/1990' WHERE Id = 4 ");
        }
        
        public override void Down()
        {
        }
    }
}
