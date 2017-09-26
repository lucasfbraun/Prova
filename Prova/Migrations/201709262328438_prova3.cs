namespace Prova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prova3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alunos", "faixa_Id", "dbo.Faixas");
            DropIndex("dbo.Alunos", new[] { "faixa_Id" });
            RenameColumn(table: "dbo.Alunos", name: "faixa_Id", newName: "faixaId");
            AlterColumn("dbo.Alunos", "faixaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alunos", "faixaId");
            AddForeignKey("dbo.Alunos", "faixaId", "dbo.Faixas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alunos", "faixaId", "dbo.Faixas");
            DropIndex("dbo.Alunos", new[] { "faixaId" });
            AlterColumn("dbo.Alunos", "faixaId", c => c.Int());
            RenameColumn(table: "dbo.Alunos", name: "faixaId", newName: "faixa_Id");
            CreateIndex("dbo.Alunos", "faixa_Id");
            AddForeignKey("dbo.Alunos", "faixa_Id", "dbo.Faixas", "Id");
        }
    }
}
