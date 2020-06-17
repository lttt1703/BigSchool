namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1,'Development')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2,'Business')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3,'Marketing')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (4,'BoChinSu')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (5,'IT')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (6,'Banking')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (7,'Photo')");
        }
        
        public override void Down()
        {
        }
    }
}
