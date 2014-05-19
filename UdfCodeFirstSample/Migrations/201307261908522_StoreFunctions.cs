namespace UdfCodeFirstSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StoreFunctions : DbMigration
    {
        public override void Up()
        {
            Sql(@"CREATE FUNCTION GetAge(@birthDate datetime) RETURNS INT AS 
                  BEGIN 
                      RETURN (DATEDIFF(year, @birthDate, GETDATE()) - CASE WHEN DATEPART(dayofyear, GETDATE()) < DATEPART(dayofyear, @birthDate) THEN 1 ELSE 0 END) 
                  END");
        }

        public override void Down()
        {
            Sql("DROP FUNCTION GetAge");
        }

    }
}
