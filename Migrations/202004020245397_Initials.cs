namespace HospitalProject_N01338717.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initials : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        userid = c.Int(nullable: false, identity: true),
                        userfirstname = c.String(),
                        usermiddlename = c.String(),
                        userlastname = c.String(),
                        userdob = c.String(),
                        useremailaddress = c.String(),
                        userphone = c.String(),
                        userpassword = c.String(),
                        userrole = c.String(),
                    })
                .PrimaryKey(t => t.userid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Registrations");
        }
    }
}
