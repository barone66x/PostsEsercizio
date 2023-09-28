namespace PostsEsercizio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificaIdinCodeetype : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Posts", name: "Title", newName: "Titolo");
            AlterColumn("dbo.Posts", "Titolo", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Titolo", c => c.String());
            RenameColumn(table: "dbo.Posts", name: "Titolo", newName: "Title");
        }
    }
}
