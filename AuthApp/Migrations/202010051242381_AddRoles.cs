namespace AuthApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoles : DbMigration
    {
        public override void Up()
        {
            string sqlScript = "INSERT INTO AspNetRoles VALUES('580145F6-920E-4D72-99D3-7AF997CC3993', 'Admin');" +
                "INSERT INTO AspNetRoles VALUES('BE7B1B66-4680-4507-8533-51F15DBBE414', 'User');";
            Sql(sqlScript);
        }
        
        public override void Down()
        {
        }
    }
}
