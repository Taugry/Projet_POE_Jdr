namespace Projet_Jdr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTokenGameModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Tokens", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Tokens");
        }
    }
}
