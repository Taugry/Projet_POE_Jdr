namespace Projet_Jdr.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutEntityToken : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        Status = c.Boolean(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            DropColumn("dbo.Games", "Tokens");
            Sql("INSERT INTO Tokens(Name,Status,value) Values('indice_01','false',0)");
            Sql("INSERT INTO Tokens(Name,Status,value) Values('indice_02','false',0)");
            Sql("INSERT INTO Tokens(Name,Status,value) Values('indice_03','false',0)");
            Sql("INSERT INTO Tokens(Name,Status,value) Values('indice_04','false',0)");
            Sql("INSERT INTO Tokens(Name,Status,value) Values('indice_05','false',0)");
            Sql("INSERT INTO Tokens(Name,Status,value) Values('Arme','false',0)");
            Sql("INSERT INTO Tokens(Name,Status,value) Values('avancer','false',0)");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Tokens", c => c.String());
            DropTable("dbo.Tokens");
        }
    }
}
