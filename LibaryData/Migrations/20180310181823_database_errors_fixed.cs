using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibaryData.Migrations
{
    public partial class database_errors_fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranch_BranchId",
                table: "BranchHours");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_LibraryCard_LibraryCardId",
                table: "Checkout");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_LibraryAsset_libraryAssetId",
                table: "Checkout");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistory_LibraryCard_LibraryCardId",
                table: "CheckoutHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistory_LibraryAsset_libraryAssetId",
                table: "CheckoutHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Hold_LibraryAsset_LibraryAssetId",
                table: "Hold");

            migrationBuilder.DropForeignKey(
                name: "FK_Hold_LibraryCard_LibraryCardId",
                table: "Hold");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAsset_LibraryBranch_LocationId",
                table: "LibraryAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAsset_Status_StatusId",
                table: "LibraryAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_Patron_LibraryBranch_HomeLibraryBranchId",
                table: "Patron");

            migrationBuilder.DropForeignKey(
                name: "FK_Patron_LibraryCard_LibraryCardId",
                table: "Patron");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patron",
                table: "Patron");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryCard",
                table: "LibraryCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBranch",
                table: "LibraryBranch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryAsset",
                table: "LibraryAsset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hold",
                table: "Hold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckoutHistory",
                table: "CheckoutHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checkout",
                table: "Checkout");

            migrationBuilder.RenameTable(
                name: "Patron",
                newName: "Patrons");

            migrationBuilder.RenameTable(
                name: "LibraryCard",
                newName: "LibraryCards");

            migrationBuilder.RenameTable(
                name: "LibraryBranch",
                newName: "LibraryBranches");

            migrationBuilder.RenameTable(
                name: "LibraryAsset",
                newName: "LibraryAssets");

            migrationBuilder.RenameTable(
                name: "Hold",
                newName: "Holds");

            migrationBuilder.RenameTable(
                name: "CheckoutHistory",
                newName: "CheckoutHistories");

            migrationBuilder.RenameTable(
                name: "Checkout",
                newName: "Checkouts");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_LibraryCardId",
                table: "Patrons",
                newName: "IX_Patrons_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_HomeLibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_HomeLibraryBranchId");

            migrationBuilder.RenameColumn(
                name: "DeweyIndrx",
                table: "LibraryAssets",
                newName: "DeweyIndex");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAsset_StatusId",
                table: "LibraryAssets",
                newName: "IX_LibraryAssets_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAsset_LocationId",
                table: "LibraryAssets",
                newName: "IX_LibraryAssets_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Hold_LibraryCardId",
                table: "Holds",
                newName: "IX_Holds_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Hold_LibraryAssetId",
                table: "Holds",
                newName: "IX_Holds_LibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistory_libraryAssetId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_libraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistory_LibraryCardId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkout_libraryAssetId",
                table: "Checkouts",
                newName: "IX_Checkouts_libraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkout_LibraryCardId",
                table: "Checkouts",
                newName: "IX_Checkouts_LibraryCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryCards",
                table: "LibraryCards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBranches",
                table: "LibraryBranches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryAssets",
                table: "LibraryAssets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holds",
                table: "Holds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckoutHistories",
                table: "CheckoutHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checkouts",
                table: "Checkouts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours",
                column: "BranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                table: "CheckoutHistories",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_libraryAssetId",
                table: "CheckoutHistories",
                column: "libraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryCards_LibraryCardId",
                table: "Checkouts",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryAssets_libraryAssetId",
                table: "Checkouts",
                column: "libraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryCards_LibraryCardId",
                table: "Holds",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets",
                column: "LocationId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_Status_StatusId",
                table: "LibraryAssets",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_libraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryCards_LibraryCardId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryAssets_libraryAssetId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryCards_LibraryCardId",
                table: "Holds");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_Status_StatusId",
                table: "LibraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryCards",
                table: "LibraryCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBranches",
                table: "LibraryBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryAssets",
                table: "LibraryAssets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holds",
                table: "Holds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checkouts",
                table: "Checkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckoutHistories",
                table: "CheckoutHistories");

            migrationBuilder.RenameTable(
                name: "Patrons",
                newName: "Patron");

            migrationBuilder.RenameTable(
                name: "LibraryCards",
                newName: "LibraryCard");

            migrationBuilder.RenameTable(
                name: "LibraryBranches",
                newName: "LibraryBranch");

            migrationBuilder.RenameTable(
                name: "LibraryAssets",
                newName: "LibraryAsset");

            migrationBuilder.RenameTable(
                name: "Holds",
                newName: "Hold");

            migrationBuilder.RenameTable(
                name: "Checkouts",
                newName: "Checkout");

            migrationBuilder.RenameTable(
                name: "CheckoutHistories",
                newName: "CheckoutHistory");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patron",
                newName: "IX_Patron_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patron",
                newName: "IX_Patron_HomeLibraryBranchId");

            migrationBuilder.RenameColumn(
                name: "DeweyIndex",
                table: "LibraryAsset",
                newName: "DeweyIndrx");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAssets_StatusId",
                table: "LibraryAsset",
                newName: "IX_LibraryAsset_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAssets_LocationId",
                table: "LibraryAsset",
                newName: "IX_LibraryAsset_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Holds_LibraryCardId",
                table: "Hold",
                newName: "IX_Hold_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Holds_LibraryAssetId",
                table: "Hold",
                newName: "IX_Hold_LibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkouts_libraryAssetId",
                table: "Checkout",
                newName: "IX_Checkout_libraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkouts_LibraryCardId",
                table: "Checkout",
                newName: "IX_Checkout_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_libraryAssetId",
                table: "CheckoutHistory",
                newName: "IX_CheckoutHistory_libraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryCardId",
                table: "CheckoutHistory",
                newName: "IX_CheckoutHistory_LibraryCardId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patron",
                table: "Patron",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryCard",
                table: "LibraryCard",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBranch",
                table: "LibraryBranch",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryAsset",
                table: "LibraryAsset",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hold",
                table: "Hold",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checkout",
                table: "Checkout",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckoutHistory",
                table: "CheckoutHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranch_BranchId",
                table: "BranchHours",
                column: "BranchId",
                principalTable: "LibraryBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_LibraryCard_LibraryCardId",
                table: "Checkout",
                column: "LibraryCardId",
                principalTable: "LibraryCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_LibraryAsset_libraryAssetId",
                table: "Checkout",
                column: "libraryAssetId",
                principalTable: "LibraryAsset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistory_LibraryCard_LibraryCardId",
                table: "CheckoutHistory",
                column: "LibraryCardId",
                principalTable: "LibraryCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistory_LibraryAsset_libraryAssetId",
                table: "CheckoutHistory",
                column: "libraryAssetId",
                principalTable: "LibraryAsset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hold_LibraryAsset_LibraryAssetId",
                table: "Hold",
                column: "LibraryAssetId",
                principalTable: "LibraryAsset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hold_LibraryCard_LibraryCardId",
                table: "Hold",
                column: "LibraryCardId",
                principalTable: "LibraryCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAsset_LibraryBranch_LocationId",
                table: "LibraryAsset",
                column: "LocationId",
                principalTable: "LibraryBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAsset_Status_StatusId",
                table: "LibraryAsset",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_LibraryBranch_HomeLibraryBranchId",
                table: "Patron",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_LibraryCard_LibraryCardId",
                table: "Patron",
                column: "LibraryCardId",
                principalTable: "LibraryCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
