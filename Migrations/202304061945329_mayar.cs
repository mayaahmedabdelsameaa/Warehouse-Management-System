namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mayar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        Fax = c.String(),
                        Mobile = c.String(),
                        website = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ResponsiblePerson_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Managers", t => t.ResponsiblePerson_ID)
                .Index(t => t.ResponsiblePerson_ID);
            
            CreateTable(
                "dbo.ImportPermits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StoreId = c.Int(nullable: false),
                        PermitNumber = c.String(),
                        PermitDate = c.DateTime(nullable: false),
                        Varieties = c.String(),
                        Quantity = c.String(),
                        SupplierId = c.Int(nullable: false),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.ImportPermitDetails",
                c => new
                    {
                        ImportPermitDetailsId = c.Int(nullable: false, identity: true),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImportPermitId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ImportPermitDetailsId)
                .ForeignKey("dbo.ImportPermits", t => t.ImportPermitId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ImportPermitId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.Int(nullable: false),
                        ImportPermit_Id = c.Int(),
                        Store_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ImportPermits", t => t.ImportPermit_Id)
                .ForeignKey("dbo.Stores", t => t.Store_ID)
                .Index(t => t.ImportPermit_Id)
                .Index(t => t.Store_ID);
            
            CreateTable(
                "dbo.ExchangePermitDetails",
                c => new
                    {
                        ExchangePermitDetailsId = c.Int(nullable: false, identity: true),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExchangePermitId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExchangePermitDetailsId)
                .ForeignKey("dbo.ExchangePermits", t => t.ExchangePermitId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ExchangePermitId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ExchangePermits",
                c => new
                    {
                        ExchangePermitId = c.Int(nullable: false, identity: true),
                        StoreId = c.Int(nullable: false),
                        PermitNumber = c.String(),
                        PermitDate = c.DateTime(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExchangePermitId)
                .ForeignKey("dbo.Stores", t => t.StoreId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.StoreId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        Fax = c.String(),
                        Mobile = c.String(),
                        website = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Salary = c.Double(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TransferProducts",
                c => new
                    {
                        TransferProductId = c.Int(nullable: false, identity: true),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        FromStore_ID = c.Int(),
                        Product_ID = c.Int(),
                        Supplier_ID = c.Int(),
                        ToStore_ID = c.Int(),
                    })
                .PrimaryKey(t => t.TransferProductId)
                .ForeignKey("dbo.Stores", t => t.FromStore_ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID)
                .ForeignKey("dbo.Stores", t => t.ToStore_ID)
                .Index(t => t.FromStore_ID)
                .Index(t => t.Product_ID)
                .Index(t => t.Supplier_ID)
                .Index(t => t.ToStore_ID);
            
            CreateTable(
                "dbo.StoreCustomers",
                c => new
                    {
                        Store_ID = c.Int(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_ID, t.Customer_ID })
                .ForeignKey("dbo.Stores", t => t.Store_ID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Store_ID)
                .Index(t => t.Customer_ID);
            
            CreateTable(
                "dbo.SupplierStores",
                c => new
                    {
                        Supplier_ID = c.Int(nullable: false),
                        Store_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Supplier_ID, t.Store_ID })
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.Store_ID, cascadeDelete: true)
                .Index(t => t.Supplier_ID)
                .Index(t => t.Store_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransferProducts", "ToStore_ID", "dbo.Stores");
            DropForeignKey("dbo.TransferProducts", "Supplier_ID", "dbo.Suppliers");
            DropForeignKey("dbo.TransferProducts", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.TransferProducts", "FromStore_ID", "dbo.Stores");
            DropForeignKey("dbo.Stores", "ResponsiblePerson_ID", "dbo.Managers");
            DropForeignKey("dbo.ImportPermits", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.Products", "Store_ID", "dbo.Stores");
            DropForeignKey("dbo.ImportPermitDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ImportPermit_Id", "dbo.ImportPermits");
            DropForeignKey("dbo.ExchangePermitDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ExchangePermits", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierStores", "Store_ID", "dbo.Stores");
            DropForeignKey("dbo.SupplierStores", "Supplier_ID", "dbo.Suppliers");
            DropForeignKey("dbo.ImportPermits", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ExchangePermits", "StoreId", "dbo.Stores");
            DropForeignKey("dbo.ExchangePermitDetails", "ExchangePermitId", "dbo.ExchangePermits");
            DropForeignKey("dbo.ImportPermitDetails", "ImportPermitId", "dbo.ImportPermits");
            DropForeignKey("dbo.StoreCustomers", "Customer_ID", "dbo.Customers");
            DropForeignKey("dbo.StoreCustomers", "Store_ID", "dbo.Stores");
            DropIndex("dbo.SupplierStores", new[] { "Store_ID" });
            DropIndex("dbo.SupplierStores", new[] { "Supplier_ID" });
            DropIndex("dbo.StoreCustomers", new[] { "Customer_ID" });
            DropIndex("dbo.StoreCustomers", new[] { "Store_ID" });
            DropIndex("dbo.TransferProducts", new[] { "ToStore_ID" });
            DropIndex("dbo.TransferProducts", new[] { "Supplier_ID" });
            DropIndex("dbo.TransferProducts", new[] { "Product_ID" });
            DropIndex("dbo.TransferProducts", new[] { "FromStore_ID" });
            DropIndex("dbo.ExchangePermits", new[] { "SupplierId" });
            DropIndex("dbo.ExchangePermits", new[] { "StoreId" });
            DropIndex("dbo.ExchangePermitDetails", new[] { "ProductId" });
            DropIndex("dbo.ExchangePermitDetails", new[] { "ExchangePermitId" });
            DropIndex("dbo.Products", new[] { "Store_ID" });
            DropIndex("dbo.Products", new[] { "ImportPermit_Id" });
            DropIndex("dbo.ImportPermitDetails", new[] { "ProductId" });
            DropIndex("dbo.ImportPermitDetails", new[] { "ImportPermitId" });
            DropIndex("dbo.ImportPermits", new[] { "SupplierId" });
            DropIndex("dbo.ImportPermits", new[] { "StoreId" });
            DropIndex("dbo.Stores", new[] { "ResponsiblePerson_ID" });
            DropTable("dbo.SupplierStores");
            DropTable("dbo.StoreCustomers");
            DropTable("dbo.TransferProducts");
            DropTable("dbo.Managers");
            DropTable("dbo.Suppliers");
            DropTable("dbo.ExchangePermits");
            DropTable("dbo.ExchangePermitDetails");
            DropTable("dbo.Products");
            DropTable("dbo.ImportPermitDetails");
            DropTable("dbo.ImportPermits");
            DropTable("dbo.Stores");
            DropTable("dbo.Customers");
        }
    }
}
