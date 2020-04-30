namespace LigaMX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ligas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Equipo = c.String(),
                        DirectorTecnico = c.String(),
                        Estadio = c.String(),
                        Capacidad = c.Int(nullable: false),
                        Fundacion = c.DateTime(),
                        Campeonatos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ligas");
        }
    }
}
