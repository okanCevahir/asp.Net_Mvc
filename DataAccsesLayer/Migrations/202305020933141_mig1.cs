namespace DataAccsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "Writerid", c => c.Int());
            CreateIndex("dbo.Contents", "Writerid");
            AddForeignKey("dbo.Contents", "Writerid", "dbo.Writers", "Writerid");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "Writerid", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "Writerid" });
            DropColumn("dbo.Contents", "Writerid");
        }
    }
}
