using FluentMigrator;

namespace CRUD
{
    [Migration(20220520232800)]
    internal class _20220520_AdicionaTabelaPeca : Migration
    {
        public override void Up()
        {
            Create.Table("Peca")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Nome").AsString()
                .WithColumn("Categoria").AsString()
                .WithColumn("Descricao").AsString()
                .WithColumn("Estoque").AsInt64()
                .WithColumn("DataDeFabricacao").AsDateTime();
        }

        public override void Down()
        {
            Delete.Table("Peca");
        }

    }
}
