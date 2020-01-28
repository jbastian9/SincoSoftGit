namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EliminacionCampoIdPais : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Usuario", "PaisId", "dbo.Pais");
            DropIndex("dbo.Usuario", new[] { "PaisId" });
            DropColumn("dbo.Usuario", "PaisId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "PaisId", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuario", "PaisId");
            AddForeignKey("dbo.Usuario", "PaisId", "dbo.Pais", "ID");
        }
    }
}
