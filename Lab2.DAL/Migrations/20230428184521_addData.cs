using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab2.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTicket_Develeopers_DevelopersId",
                table: "DeveloperTicket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Develeopers",
                table: "Develeopers");

            migrationBuilder.RenameTable(
                name: "Develeopers",
                newName: "Developers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Accounting" },
                    { 3, "Marketing" },
                    { 4, "HR" },
                    { 5, "Operations" },
                    { 6, "Legal" },
                    { 7, "Sales" },
                    { 8, "Customer Service" },
                    { 9, "Engineering" },
                    { 10, "Research and Development" }
                });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Doe" },
                    { 3, "Bob Smith" },
                    { 4, "Alice Johnson" },
                    { 5, "Mike Brown" },
                    { 6, "Sarah Lee" },
                    { 7, "David Kim" },
                    { 8, "Emily Chen" },
                    { 9, "Alex Rodriguez" },
                    { 10, "Jessica Lee" }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Description", "Title", "departmentId" },
                values: new object[,]
                {
                    { 1, "The printer in the accounting department is not printing anything.", "Printer not working", 2 },
                    { 2, "I'm unable to access my email account. It keeps saying my password is incorrect.", "Can't access email", 1 },
                    { 3, "The internet connection in the marketing department is very slow and keeps dropping.", "Networking issue", 3 },
                    { 4, "The new software we installed in the HR department is not functioning properly.", "Software not working", 4 },
                    { 5, "I'm unable to connect to the company VPN. It keeps giving me an error.", "Can't connect to VPN", 5 },
                    { 6, "My laptop is very old and slow. I need a new one to do my work effectively.", "Need new laptop", 1 },
                    { 7, "The printer in the sales department is jammed and needs to be fixed.", "Printer jam", 2 },
                    { 8, "The company website is not loading. I keep getting a 404 error.", "Website down", 3 },
                    { 9, "I'm running out of storage space on my computer. Can I get an external hard drive?", "Need more storage space", 4 },
                    { 10, "I'm trying to print a document in color, but it's only coming out in black and white.", "Can't print in color", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTicket_Developers_DevelopersId",
                table: "DeveloperTicket",
                column: "DevelopersId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperTicket_Developers_DevelopersId",
                table: "DeveloperTicket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "Developers",
                newName: "Develeopers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Develeopers",
                table: "Develeopers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperTicket_Develeopers_DevelopersId",
                table: "DeveloperTicket",
                column: "DevelopersId",
                principalTable: "Develeopers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
