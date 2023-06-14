using FluentMigrator;

namespace CRUD.Infra
{
    [Migration(20220614191200)]
    public class AdicionaTabelaPeca : Migration
    {
        public override void Up()
        {
            Create.Table("Peca")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Nome").AsString()
                .WithColumn("Categoria").AsString()
                .WithColumn("Descricao").AsString()
                .WithColumn("Estoque").AsInt32()
                .WithColumn("DataDeFabricacao").AsDateTime();
        }

        public override void Down()
        {
            Delete.Table("Peca");
        }
    }
}
