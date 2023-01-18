namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Avion",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(),
                        Denominacion = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdLineaAerea = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAvion)
                .ForeignKey("dbo.LineaAerea", t => t.IdLineaAerea, cascadeDelete: true)
                .Index(t => t.IdLineaAerea);
            
            CreateTable(
                "dbo.LineaAerea",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "IdLineaAerea", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "IdLineaAerea" });
            DropTable("dbo.LineaAerea");
            DropTable("dbo.Avion");
        }
    }
}
