namespace actividadWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaCorreo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Correos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Extension = c.String(),
                        Cuerpo = c.String(),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Correos", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Correos", new[] { "UsuarioId" });
            DropTable("dbo.Correos");
        }
    }
}
