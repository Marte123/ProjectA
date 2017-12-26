namespace ProjectA.Migrations.MediaFolder
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Born = c.String(),
                        KnownFor = c.String(),
                        PersonalDetails = c.String(),
                        MovieName = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.ActorId)
                .ForeignKey("dbo.Movies", t => t.MovieName)
                .Index(t => t.MovieName);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieName = c.String(nullable: false, maxLength: 40),
                        Genre = c.String(),
                        State = c.String(),
                        Director = c.String(),
                        Duration = c.Int(nullable: false),
                        Release = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Actors", "MovieName", "dbo.Movies");
            DropIndex("dbo.Actors", new[] { "MovieName" });
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
