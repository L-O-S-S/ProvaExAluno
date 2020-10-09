namespace exAluno.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlunoModel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Curso = c.String(nullable: false),
                        Fone = c.String(nullable: false),
                        Endereco = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Fili = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AlunoModel");
        }
    }
}
