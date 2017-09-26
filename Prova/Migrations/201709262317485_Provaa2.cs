namespace Prova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Provaa2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alunoes", newName: "Alunos");
            AddColumn("dbo.Alunos", "faixa_Id", c => c.Int());
            AddColumn("dbo.Alunos", "tipoAssociacao_Id", c => c.Int());
            CreateIndex("dbo.Alunos", "faixa_Id");
            CreateIndex("dbo.Alunos", "tipoAssociacao_Id");
            AddForeignKey("dbo.Alunos", "faixa_Id", "dbo.Faixas", "Id");
            AddForeignKey("dbo.Alunos", "tipoAssociacao_Id", "dbo.TipoDeAssociacaos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alunos", "tipoAssociacao_Id", "dbo.TipoDeAssociacaos");
            DropForeignKey("dbo.Alunos", "faixa_Id", "dbo.Faixas");
            DropIndex("dbo.Alunos", new[] { "tipoAssociacao_Id" });
            DropIndex("dbo.Alunos", new[] { "faixa_Id" });
            DropColumn("dbo.Alunos", "tipoAssociacao_Id");
            DropColumn("dbo.Alunos", "faixa_Id");
            RenameTable(name: "dbo.Alunos", newName: "Alunoes");
        }
    }
}
