namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeraMigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudad",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30, unicode: false),
                        PaisId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pais", t => t.PaisId)
                .Index(t => t.PaisId);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacto",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 30, unicode: false),
                        Correo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 10, unicode: false),
                        CiudadId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ciudad", t => t.CiudadId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.CiudadId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 30, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 30, unicode: false),
                        Correo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 10, unicode: false),
                        PaisId = c.Int(nullable: false),
                        CiudadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ciudad", t => t.CiudadId)
                .ForeignKey("dbo.Pais", t => t.PaisId)
                .Index(t => t.PaisId)
                .Index(t => t.CiudadId);
            
            CreateTable(
                "dbo.Correo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Cuerpo = c.String(nullable: false, maxLength: 500, unicode: false),
                        Extension = c.String(nullable: false, maxLength: 5, unicode: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.HistorialCorreosEnviados",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CorreoId = c.Int(nullable: false),
                        ContactoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Contacto", t => t.ContactoID)
                .ForeignKey("dbo.Correo", t => t.CorreoId)
                .Index(t => t.CorreoId)
                .Index(t => t.ContactoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HistorialCorreosEnviados", "CorreoId", "dbo.Correo");
            DropForeignKey("dbo.HistorialCorreosEnviados", "ContactoID", "dbo.Contacto");
            DropForeignKey("dbo.Correo", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Contacto", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "PaisId", "dbo.Pais");
            DropForeignKey("dbo.Usuario", "CiudadId", "dbo.Ciudad");
            DropForeignKey("dbo.Contacto", "CiudadId", "dbo.Ciudad");
            DropForeignKey("dbo.Ciudad", "PaisId", "dbo.Pais");
            DropIndex("dbo.HistorialCorreosEnviados", new[] { "ContactoID" });
            DropIndex("dbo.HistorialCorreosEnviados", new[] { "CorreoId" });
            DropIndex("dbo.Correo", new[] { "UsuarioId" });
            DropIndex("dbo.Usuario", new[] { "CiudadId" });
            DropIndex("dbo.Usuario", new[] { "PaisId" });
            DropIndex("dbo.Contacto", new[] { "UsuarioId" });
            DropIndex("dbo.Contacto", new[] { "CiudadId" });
            DropIndex("dbo.Ciudad", new[] { "PaisId" });
            DropTable("dbo.HistorialCorreosEnviados");
            DropTable("dbo.Correo");
            DropTable("dbo.Usuario");
            DropTable("dbo.Contacto");
            DropTable("dbo.Pais");
            DropTable("dbo.Ciudad");
        }
    }
}
