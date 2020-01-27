namespace actividadWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablasFaltantes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudads",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Correo = c.String(),
                        Telefono = c.String(),
                        Estado = c.Byte(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        CiudadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ciudads", t => t.CiudadId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.CiudadId);
            
            CreateTable(
                "dbo.HistorialCorreosEnviados",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ContactoId = c.Int(nullable: false),
                        CorreoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Contactoes", t => t.ContactoId, cascadeDelete: true)
                .ForeignKey("dbo.Correos", t => t.CorreoId, cascadeDelete: true)
                .Index(t => t.ContactoId)
                .Index(t => t.CorreoId);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PaisNMCiudades",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PaisId = c.Int(nullable: false),
                        CiudadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ciudads", t => t.CiudadId, cascadeDelete: true)
                .ForeignKey("dbo.Pais", t => t.PaisId, cascadeDelete: true)
                .Index(t => t.PaisId)
                .Index(t => t.CiudadId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaisNMCiudades", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.PaisNMCiudades", "CiudadId", "dbo.Ciudads");
            DropForeignKey("dbo.HistorialCorreosEnviados", "CorreoId", "dbo.Correos");
            DropForeignKey("dbo.HistorialCorreosEnviados", "ContactoId", "dbo.Contactoes");
            DropForeignKey("dbo.Contactoes", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Contactoes", "CiudadId", "dbo.Ciudads");
            DropIndex("dbo.PaisNMCiudades", new[] { "CiudadId" });
            DropIndex("dbo.PaisNMCiudades", new[] { "PaisId" });
            DropIndex("dbo.HistorialCorreosEnviados", new[] { "CorreoId" });
            DropIndex("dbo.HistorialCorreosEnviados", new[] { "ContactoId" });
            DropIndex("dbo.Contactoes", new[] { "CiudadId" });
            DropIndex("dbo.Contactoes", new[] { "UsuarioId" });
            DropTable("dbo.PaisNMCiudades");
            DropTable("dbo.Pais");
            DropTable("dbo.HistorialCorreosEnviados");
            DropTable("dbo.Contactoes");
            DropTable("dbo.Ciudads");
        }
    }
}
