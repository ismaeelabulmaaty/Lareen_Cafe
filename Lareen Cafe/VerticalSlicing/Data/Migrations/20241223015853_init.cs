using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lareen_Cafe.VerticalSlicing.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    CustomerMobile = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    CustomerBalance = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orderType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderTypeCode = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    OrderTypeName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCategoryCode = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductUnitCode = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    ProductUnitName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseTypeCode = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    PurchaseTypeName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rawMatCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawMatCategoryName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rawMatCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rawMatUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawMatUnitCode = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    RawMatUnitName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rawMatUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    SupplierMobile = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(2000)", nullable: true),
                    SupplierBalance = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "treasuries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpeningBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AvaialableBalance = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treasuries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "wareHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WareHouseCode = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    WareHouseName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wareHouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    productCategoryId = table.Column<int>(type: "int", nullable: false),
                    productUnitId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_ProductCategories_productCategoryId",
                        column: x => x.productCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_ProductUnits_productUnitId",
                        column: x => x.productUnitId,
                        principalTable: "ProductUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rawMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawMaterialName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    rawMatCategoryId = table.Column<int>(type: "int", nullable: false),
                    rawMatUnitsId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rawMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rawMaterials_rawMatCategories_rawMatCategoryId",
                        column: x => x.rawMatCategoryId,
                        principalTable: "rawMatCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rawMaterials_rawMatUnits_rawMatUnitsId",
                        column: x => x.rawMatUnitsId,
                        principalTable: "rawMatUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "refreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    ExpiresOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevokedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_refreshTokens_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userRoles_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userRoles_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    TreasuryId = table.Column<int>(type: "int", nullable: false),
                    wareHouseId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_treasuries_TreasuryId",
                        column: x => x.TreasuryId,
                        principalTable: "treasuries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Branches_wareHouses_wareHouseId",
                        column: x => x.wareHouseId,
                        principalTable: "wareHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplierId = table.Column<int>(type: "int", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPriceBefore = table.Column<double>(type: "float", nullable: false),
                    discountAmount = table.Column<double>(type: "float", nullable: false),
                    TotalAfterDiscount = table.Column<double>(type: "float", nullable: false),
                    RemainingTotal = table.Column<double>(type: "float", nullable: false),
                    PurchaseTypeId = table.Column<int>(type: "int", nullable: false),
                    wareHouseId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchases_PurchaseTypes_PurchaseTypeId",
                        column: x => x.PurchaseTypeId,
                        principalTable: "PurchaseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchases_suppliers_supplierId",
                        column: x => x.supplierId,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchases_wareHouses_wareHouseId",
                        column: x => x.wareHouseId,
                        principalTable: "wareHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsCostControls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RawMaterialId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false),
                    RawMaterialAmount = table.Column<double>(type: "float", nullable: false),
                    RawMaterialCost = table.Column<double>(type: "float", nullable: false),
                    RawMaterialsActualPrice = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsCostControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsCostControls_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsCostControls_rawMaterials_RawMaterialId",
                        column: x => x.RawMaterialId,
                        principalTable: "rawMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerId = table.Column<int>(type: "int", nullable: false),
                    orderTypeId = table.Column<int>(type: "int", nullable: false),
                    TotalOrderBefore = table.Column<double>(type: "float", nullable: false),
                    OrderDiscount = table.Column<double>(type: "float", nullable: false),
                    TotalOrderAfterDicount = table.Column<double>(type: "float", nullable: false),
                    RemainingBalance = table.Column<double>(type: "float", nullable: false),
                    branchId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Branches_branchId",
                        column: x => x.branchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_customerId",
                        column: x => x.customerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_orderType_orderTypeId",
                        column: x => x.orderTypeId,
                        principalTable: "orderType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchasesDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purchasesId = table.Column<int>(type: "int", nullable: false),
                    rawMaterialId = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<double>(type: "float", nullable: false),
                    PurchaseQuantity = table.Column<double>(type: "float", nullable: false),
                    TotalPurchaseDetails = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchasesDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchasesDetails_purchases_purchasesId",
                        column: x => x.purchasesId,
                        principalTable: "purchases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purchasesDetails_rawMaterials_rawMaterialId",
                        column: x => x.rawMaterialId,
                        principalTable: "rawMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accountsPayableReceivables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreditOrDebit = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: true),
                    purchaseId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    WareHouseId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountsPayableReceivables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_accountsPayableReceivables_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_accountsPayableReceivables_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_accountsPayableReceivables_purchases_purchaseId",
                        column: x => x.purchaseId,
                        principalTable: "purchases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_accountsPayableReceivables_wareHouses_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "wareHouses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(type: "int", nullable: false),
                    productName = table.Column<string>(type: "nvarchar(2000)", nullable: false),
                    productPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    TotalOrderDetails = table.Column<double>(type: "float", nullable: false),
                    orderId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_orderId",
                        column: x => x.orderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "purchaseLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PurchasesDetailsId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purchaseLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_purchaseLogs_purchasesDetails_PurchasesDetailsId",
                        column: x => x.PurchasesDetailsId,
                        principalTable: "purchasesDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "orderLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    orderDetailsId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    LastCreatedBy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orderLogs_OrderDetails_orderDetailsId",
                        column: x => x.orderDetailsId,
                        principalTable: "OrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accountsPayableReceivables_BranchId",
                table: "accountsPayableReceivables",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_accountsPayableReceivables_orderId",
                table: "accountsPayableReceivables",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_accountsPayableReceivables_purchaseId",
                table: "accountsPayableReceivables",
                column: "purchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_accountsPayableReceivables_WareHouseId",
                table: "accountsPayableReceivables",
                column: "WareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_TreasuryId",
                table: "Branches",
                column: "TreasuryId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_wareHouseId",
                table: "Branches",
                column: "wareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_orderId",
                table: "OrderDetails",
                column: "orderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_productId",
                table: "OrderDetails",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_orderLogs_orderDetailsId",
                table: "orderLogs",
                column: "orderDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_branchId",
                table: "Orders",
                column: "branchId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customerId",
                table: "Orders",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_orderTypeId",
                table: "Orders",
                column: "orderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_products_productCategoryId",
                table: "products",
                column: "productCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_productUnitId",
                table: "products",
                column: "productUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCostControls_productId",
                table: "ProductsCostControls",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsCostControls_RawMaterialId",
                table: "ProductsCostControls",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_purchaseLogs_PurchasesDetailsId",
                table: "purchaseLogs",
                column: "PurchasesDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_purchases_PurchaseTypeId",
                table: "purchases",
                column: "PurchaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_purchases_supplierId",
                table: "purchases",
                column: "supplierId");

            migrationBuilder.CreateIndex(
                name: "IX_purchases_wareHouseId",
                table: "purchases",
                column: "wareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_purchasesDetails_purchasesId",
                table: "purchasesDetails",
                column: "purchasesId");

            migrationBuilder.CreateIndex(
                name: "IX_purchasesDetails_rawMaterialId",
                table: "purchasesDetails",
                column: "rawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_rawMaterials_rawMatCategoryId",
                table: "rawMaterials",
                column: "rawMatCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_rawMaterials_rawMatUnitsId",
                table: "rawMaterials",
                column: "rawMatUnitsId");

            migrationBuilder.CreateIndex(
                name: "IX_refreshTokens_UserId",
                table: "refreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_userRoles_RoleId",
                table: "userRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_userRoles_UserId",
                table: "userRoles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountsPayableReceivables");

            migrationBuilder.DropTable(
                name: "orderLogs");

            migrationBuilder.DropTable(
                name: "ProductsCostControls");

            migrationBuilder.DropTable(
                name: "purchaseLogs");

            migrationBuilder.DropTable(
                name: "refreshTokens");

            migrationBuilder.DropTable(
                name: "userRoles");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "purchasesDetails");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "purchases");

            migrationBuilder.DropTable(
                name: "rawMaterials");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "orderType");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductUnits");

            migrationBuilder.DropTable(
                name: "PurchaseTypes");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "rawMatCategories");

            migrationBuilder.DropTable(
                name: "rawMatUnits");

            migrationBuilder.DropTable(
                name: "treasuries");

            migrationBuilder.DropTable(
                name: "wareHouses");
        }
    }
}
