using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csv_Cars.Migrations
{
    /// <inheritdoc />
    public partial class Initialize2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "carName",
                table: "Cars",
                newName: "carBrand");

            migrationBuilder.AddColumn<string>(
                name: "carModel",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevelle malibu" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "skylark 320" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "satellite" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "rebel sst" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "torino" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "galaxie 500" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "impala" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "fury iii" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "catalina" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "ambassador dpl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "challenger se" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "'cuda 340" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "monte carlo" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "estate wagon (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corona mark ii" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "duster" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "hornet" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "maverick" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "pl510" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "1131 deluxe sedan" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "peugeot", "504" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "audi", "100 ls" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "saab", "99e" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "bmw", "2002" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "gremlin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "f250" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevy", "c20" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "d200" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "hi", "1200d" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "pl510" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "vega 2300" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corona" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "pinto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "gremlin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "satellite custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevelle malibu" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "torino 500" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "matador" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "impala" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "catalina brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "galaxie 500" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "fury iii" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "monaco (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "country squire (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "safari (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "hornet sportabout (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "vega (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "firebird" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "mustang" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "capri 2000" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "opel", "1900" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "peugeot", "304" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "fiat", "124b" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla 1200" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "1200" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "model 111" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "cricket" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corona hardtop" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "colt hardtop" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "type 3" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "vega" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "pinto runabout" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "impala" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "catalina" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "fury iii" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "galaxie 500" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "ambassador sst" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "marquis" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "lesabre custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "delta 88 royale" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chrysler", "newport royal" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "rx2 coupe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "matador (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevelle concours (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "gran torino (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "satellite custom (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volvo", "145e (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "411 (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "peugeot", "504 (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "renault", "12 (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "pinto (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "510 (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyouta", "corona mark ii (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "colt (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla 1600 (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "century 350" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "matador" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "malibu" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "gran torino" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "coronet custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "marquis brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "caprice classic" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "ltd" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "fury gran sedan" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chrysler", "new yorker brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "electra 225 custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "ambassador brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "valiant" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "nova custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "hornet" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "maverick" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "duster" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "super beetle" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "impala" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "country" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "custom suburb" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "vista cruiser" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "gremlin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "carina" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "vega" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "610" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "maxda", "rx3" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "pinto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "capri v6" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "fiat", "124 sport coupe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "monte carlo s" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "grand prix" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "fiat", "128" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "opel", "manta" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "audi", "100ls" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volvo", "144ea" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "dart custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "saab", "99le" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "mark ii" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "omega" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "duster" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "maverick" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "hornet" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "nova" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "b210" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "pinto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla 1200" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "vega" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevelle malibu classic" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "matador" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "satellite sebring" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "gran torino" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "century luxus (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "coronet custom (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "gran torino (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "matador (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "audi", "fox" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "dasher" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "opel", "manta" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corona" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "710" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "colt" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "fiat", "128" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "fiat", "124 tc" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "civic" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 151,
                column: "carModel",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "fiat", "x1.9" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "valiant custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "nova" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "monarch" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "maverick" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "catalina" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "bel air" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "grand fury" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "ltd" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "century" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevroelt", "chevelle malibu" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "matador" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "fury" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "skyhawk" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "monza 2+2" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "mustang ii" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "pinto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "gremlin" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "astro" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corona" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "dasher" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "710" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "pinto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "rabbit" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "pacer" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "audi", "100ls" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "peugeot", "504" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volvo", "244dl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "saab", "99le" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "civic cvcc" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "fiat", "131" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "opel", "1900" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "capri", "ii" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "colt" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "renault", "12tl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevelle malibu classic" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "coronet brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "matador" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "gran torino" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "valiant" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "nova" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "maverick" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "hornet" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevette" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "woody" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "vw", "rabbit" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "civic" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "aspen se" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "granada ghia" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "ventura sj" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "pacer d/l" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "rabbit" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "b-210" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "pinto" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volvo", "245" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "volare premier v8" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "peugeot", "504" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "mark ii" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercedes-benz", "280s" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "cadillac", "seville" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevy", "c10" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "f108" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "d100" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "accord cvcc" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "opel isuzu deluxe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "renault", "5 gtl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "arrow gs" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "f-10 hatchback" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "caprice classic" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "cutlass supreme" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "monaco brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "cougar brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "concours" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "skylark" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "volare custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "granada" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "grand prix lj" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "monte carlo landau" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chrysler", "cordoba" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "thunderbird" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "rabbit custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "sunbird coupe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla liftback" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "mustang ii 2+2" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevette" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "colt m/m" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "subaru", "dl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "dasher" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "810" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "bmw", "320i" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "rx-4" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "rabbit custom diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "fiesta" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "glc deluxe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "b210 gx" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "civic cvcc" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "cutlass salon brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "diplomat" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "monarch ghia" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "phoenix lj" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "malibu" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "fairmont (auto)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "fairmont (man)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "volare" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "concord" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "century special" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "zephyr" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "aspen" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "concord d/l" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "monte carlo landau" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "regal sport coupe (turbo)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "futura" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "magnum xe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevette" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corona" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "510" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "omni" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "celica gt liftback" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "sapporo" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "starfire sx" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "200-sx" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "audi", "5000" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volvo", "264gl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "saab", "99gle" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "peugeot", "604sl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "scirocco" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "accord lx" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "lemans v6" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "zephyr 6" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "fairmont 4" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "concord dl 6" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "aspen 6" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "caprice classic" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "ltd landau" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "grand marquis" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "st. regis" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "estate wagon (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "country squire (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "malibu classic (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chrysler", "lebaron town @ country (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "vw", "rabbit custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "maxda", "glc deluxe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "colt hatchback custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "spirit dl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercedes", "benz 300d" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "cadillac", "eldorado" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "peugeot", "504" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "cutlass salon brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "horizon" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "horizon tc3" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "210" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "fiat", "strada custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "skylark limited" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "citation" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "omega brougham" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "phoenix" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "vw", "rabbit" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla tercel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "chevette" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "310" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "citation" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "fairmont" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "concord" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "aspen" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "audi", "4000" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corona liftback" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "626" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "510 hatchback" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "glc" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "colt" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "210" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "vw", "rabbit c (diesel)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "vw", "dasher (diesel)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "audi", "5000s (diesel)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercedes-benz", "240d" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "civic 1500 gl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "renault", "lecar deluxe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "subaru", "dl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "vokswagen", "rabbit" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "280-zx" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "rx-7 gs" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "triumph", "tr7 coupe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "mustang cobra" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "accord" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "reliant" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "skylark" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "aries wagon (sw)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "citation" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "reliant" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "starlet" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "champ" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "civic 1300" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 347,
                column: "carModel",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "210 mpg" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "tercel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "glc 4" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "horizon 4" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "escort 4w" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "escort 2h" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "jetta" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "renault", "18i" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "prelude" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "200sx" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "626" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "peugeot", "505s turbo diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volvo", "diesel" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "cressida" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "810 maxima" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "century" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "cutlass ls" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "granada gl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chrysler", "lebaron salon" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "cavalier" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "cavalier wagon" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "cavalier 2-door" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "j2000 se hatchback" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "aries se" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "pontiac", "phoenix" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "fairmont futura" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "amc", "concord dl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "volkswagen", "rabbit l" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "glc custom l" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mazda", "glc custom" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "plymouth", "horizon miser" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "mercury", "lynx l" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "nissan", "stanza xe" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "accord" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "corolla" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "civic" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "honda", "civic (auto)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "datsun", "310 gx" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "buick", "century limited" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "oldsmobile", "cutlass ciera (diesel)" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chrysler", "lebaron medallion" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "granada l" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "toyota", "celica gt" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "charger 2.2" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevrolet", "camaro" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "mustang gl" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "vw", "pickup" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "dodge", "rampage" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "ford", "ranger" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "carBrand", "carModel" },
                values: new object[] { "chevy", "s-10" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "carModel",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "carBrand",
                table: "Cars",
                newName: "carName");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "carName",
                value: "chevrolet chevelle malibu");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "carName",
                value: "buick skylark 320");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "carName",
                value: "plymouth satellite");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "carName",
                value: "amc rebel sst");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "carName",
                value: "ford torino");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "carName",
                value: "ford galaxie 500");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "carName",
                value: "chevrolet impala");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "carName",
                value: "plymouth fury iii");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                column: "carName",
                value: "pontiac catalina");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                column: "carName",
                value: "amc ambassador dpl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                column: "carName",
                value: "dodge challenger se");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                column: "carName",
                value: "plymouth 'cuda 340");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                column: "carName",
                value: "chevrolet monte carlo");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                column: "carName",
                value: "buick estate wagon (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                column: "carName",
                value: "toyota corona mark ii");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                column: "carName",
                value: "plymouth duster");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                column: "carName",
                value: "amc hornet");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                column: "carName",
                value: "ford maverick");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                column: "carName",
                value: "datsun pl510");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                column: "carName",
                value: "volkswagen 1131 deluxe sedan");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21,
                column: "carName",
                value: "peugeot 504");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22,
                column: "carName",
                value: "audi 100 ls");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23,
                column: "carName",
                value: "saab 99e");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24,
                column: "carName",
                value: "bmw 2002");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25,
                column: "carName",
                value: "amc gremlin");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26,
                column: "carName",
                value: "ford f250");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27,
                column: "carName",
                value: "chevy c20");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28,
                column: "carName",
                value: "dodge d200");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29,
                column: "carName",
                value: "hi 1200d");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30,
                column: "carName",
                value: "datsun pl510");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31,
                column: "carName",
                value: "chevrolet vega 2300");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32,
                column: "carName",
                value: "toyota corona");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33,
                column: "carName",
                value: "ford pinto");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34,
                column: "carName",
                value: "amc gremlin");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35,
                column: "carName",
                value: "plymouth satellite custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36,
                column: "carName",
                value: "chevrolet chevelle malibu");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37,
                column: "carName",
                value: "ford torino 500");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38,
                column: "carName",
                value: "amc matador");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39,
                column: "carName",
                value: "chevrolet impala");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40,
                column: "carName",
                value: "pontiac catalina brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41,
                column: "carName",
                value: "ford galaxie 500");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42,
                column: "carName",
                value: "plymouth fury iii");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43,
                column: "carName",
                value: "dodge monaco (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44,
                column: "carName",
                value: "ford country squire (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45,
                column: "carName",
                value: "pontiac safari (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46,
                column: "carName",
                value: "amc hornet sportabout (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47,
                column: "carName",
                value: "chevrolet vega (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48,
                column: "carName",
                value: "pontiac firebird");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49,
                column: "carName",
                value: "ford mustang");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50,
                column: "carName",
                value: "mercury capri 2000");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 51,
                column: "carName",
                value: "opel 1900");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 52,
                column: "carName",
                value: "peugeot 304");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 53,
                column: "carName",
                value: "fiat 124b");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 54,
                column: "carName",
                value: "toyota corolla 1200");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 55,
                column: "carName",
                value: "datsun 1200");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 56,
                column: "carName",
                value: "volkswagen model 111");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 57,
                column: "carName",
                value: "plymouth cricket");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 58,
                column: "carName",
                value: "toyota corona hardtop");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 59,
                column: "carName",
                value: "dodge colt hardtop");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 60,
                column: "carName",
                value: "volkswagen type 3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 61,
                column: "carName",
                value: "chevrolet vega");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 62,
                column: "carName",
                value: "ford pinto runabout");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 63,
                column: "carName",
                value: "chevrolet impala");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 64,
                column: "carName",
                value: "pontiac catalina");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 65,
                column: "carName",
                value: "plymouth fury iii");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 66,
                column: "carName",
                value: "ford galaxie 500");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 67,
                column: "carName",
                value: "amc ambassador sst");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 68,
                column: "carName",
                value: "mercury marquis");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 69,
                column: "carName",
                value: "buick lesabre custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 70,
                column: "carName",
                value: "oldsmobile delta 88 royale");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 71,
                column: "carName",
                value: "chrysler newport royal");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 72,
                column: "carName",
                value: "mazda rx2 coupe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 73,
                column: "carName",
                value: "amc matador (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 74,
                column: "carName",
                value: "chevrolet chevelle concours (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 75,
                column: "carName",
                value: "ford gran torino (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 76,
                column: "carName",
                value: "plymouth satellite custom (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 77,
                column: "carName",
                value: "volvo 145e (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 78,
                column: "carName",
                value: "volkswagen 411 (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 79,
                column: "carName",
                value: "peugeot 504 (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 80,
                column: "carName",
                value: "renault 12 (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 81,
                column: "carName",
                value: "ford pinto (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 82,
                column: "carName",
                value: "datsun 510 (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 83,
                column: "carName",
                value: "toyouta corona mark ii (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 84,
                column: "carName",
                value: "dodge colt (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 85,
                column: "carName",
                value: "toyota corolla 1600 (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 86,
                column: "carName",
                value: "buick century 350");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 87,
                column: "carName",
                value: "amc matador");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 88,
                column: "carName",
                value: "chevrolet malibu");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 89,
                column: "carName",
                value: "ford gran torino");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 90,
                column: "carName",
                value: "dodge coronet custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 91,
                column: "carName",
                value: "mercury marquis brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 92,
                column: "carName",
                value: "chevrolet caprice classic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 93,
                column: "carName",
                value: "ford ltd");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 94,
                column: "carName",
                value: "plymouth fury gran sedan");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 95,
                column: "carName",
                value: "chrysler new yorker brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 96,
                column: "carName",
                value: "buick electra 225 custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 97,
                column: "carName",
                value: "amc ambassador brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 98,
                column: "carName",
                value: "plymouth valiant");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 99,
                column: "carName",
                value: "chevrolet nova custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 100,
                column: "carName",
                value: "amc hornet");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 101,
                column: "carName",
                value: "ford maverick");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 102,
                column: "carName",
                value: "plymouth duster");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 103,
                column: "carName",
                value: "volkswagen super beetle");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 104,
                column: "carName",
                value: "chevrolet impala");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 105,
                column: "carName",
                value: "ford country");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 106,
                column: "carName",
                value: "plymouth custom suburb");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 107,
                column: "carName",
                value: "oldsmobile vista cruiser");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 108,
                column: "carName",
                value: "amc gremlin");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 109,
                column: "carName",
                value: "toyota carina");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 110,
                column: "carName",
                value: "chevrolet vega");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 111,
                column: "carName",
                value: "datsun 610");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 112,
                column: "carName",
                value: "maxda rx3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 113,
                column: "carName",
                value: "ford pinto");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 114,
                column: "carName",
                value: "mercury capri v6");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 115,
                column: "carName",
                value: "fiat 124 sport coupe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 116,
                column: "carName",
                value: "chevrolet monte carlo s");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 117,
                column: "carName",
                value: "pontiac grand prix");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 118,
                column: "carName",
                value: "fiat 128");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 119,
                column: "carName",
                value: "opel manta");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 120,
                column: "carName",
                value: "audi 100ls");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 121,
                column: "carName",
                value: "volvo 144ea");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 122,
                column: "carName",
                value: "dodge dart custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 123,
                column: "carName",
                value: "saab 99le");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 124,
                column: "carName",
                value: "toyota mark ii");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 125,
                column: "carName",
                value: "oldsmobile omega");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 126,
                column: "carName",
                value: "plymouth duster");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 127,
                column: "carName",
                value: "ford maverick");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 128,
                column: "carName",
                value: "amc hornet");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 129,
                column: "carName",
                value: "chevrolet nova");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 130,
                column: "carName",
                value: "datsun b210");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 131,
                column: "carName",
                value: "ford pinto");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 132,
                column: "carName",
                value: "toyota corolla 1200");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 133,
                column: "carName",
                value: "chevrolet vega");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 134,
                column: "carName",
                value: "chevrolet chevelle malibu classic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 135,
                column: "carName",
                value: "amc matador");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 136,
                column: "carName",
                value: "plymouth satellite sebring");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 137,
                column: "carName",
                value: "ford gran torino");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 138,
                column: "carName",
                value: "buick century luxus (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 139,
                column: "carName",
                value: "dodge coronet custom (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 140,
                column: "carName",
                value: "ford gran torino (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 141,
                column: "carName",
                value: "amc matador (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 142,
                column: "carName",
                value: "audi fox");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 143,
                column: "carName",
                value: "volkswagen dasher");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 144,
                column: "carName",
                value: "opel manta");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 145,
                column: "carName",
                value: "toyota corona");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 146,
                column: "carName",
                value: "datsun 710");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 147,
                column: "carName",
                value: "dodge colt");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 148,
                column: "carName",
                value: "fiat 128");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 149,
                column: "carName",
                value: "fiat 124 tc");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 150,
                column: "carName",
                value: "honda civic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 152,
                column: "carName",
                value: "fiat x1.9");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 153,
                column: "carName",
                value: "plymouth valiant custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 154,
                column: "carName",
                value: "chevrolet nova");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 155,
                column: "carName",
                value: "mercury monarch");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 156,
                column: "carName",
                value: "ford maverick");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 157,
                column: "carName",
                value: "pontiac catalina");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 158,
                column: "carName",
                value: "chevrolet bel air");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 159,
                column: "carName",
                value: "plymouth grand fury");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 160,
                column: "carName",
                value: "ford ltd");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 161,
                column: "carName",
                value: "buick century");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 162,
                column: "carName",
                value: "chevroelt chevelle malibu");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 163,
                column: "carName",
                value: "amc matador");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 164,
                column: "carName",
                value: "plymouth fury");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 165,
                column: "carName",
                value: "buick skyhawk");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 166,
                column: "carName",
                value: "chevrolet monza 2+2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 167,
                column: "carName",
                value: "ford mustang ii");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 168,
                column: "carName",
                value: "toyota corolla");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 169,
                column: "carName",
                value: "ford pinto");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 170,
                column: "carName",
                value: "amc gremlin");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 171,
                column: "carName",
                value: "pontiac astro");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 172,
                column: "carName",
                value: "toyota corona");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 173,
                column: "carName",
                value: "volkswagen dasher");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 174,
                column: "carName",
                value: "datsun 710");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 175,
                column: "carName",
                value: "ford pinto");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 176,
                column: "carName",
                value: "volkswagen rabbit");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 177,
                column: "carName",
                value: "amc pacer");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 178,
                column: "carName",
                value: "audi 100ls");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 179,
                column: "carName",
                value: "peugeot 504");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 180,
                column: "carName",
                value: "volvo 244dl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 181,
                column: "carName",
                value: "saab 99le");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 182,
                column: "carName",
                value: "honda civic cvcc");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 183,
                column: "carName",
                value: "fiat 131");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 184,
                column: "carName",
                value: "opel 1900");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 185,
                column: "carName",
                value: "capri ii");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 186,
                column: "carName",
                value: "dodge colt");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 187,
                column: "carName",
                value: "renault 12tl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 188,
                column: "carName",
                value: "chevrolet chevelle malibu classic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 189,
                column: "carName",
                value: "dodge coronet brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 190,
                column: "carName",
                value: "amc matador");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 191,
                column: "carName",
                value: "ford gran torino");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 192,
                column: "carName",
                value: "plymouth valiant");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 193,
                column: "carName",
                value: "chevrolet nova");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 194,
                column: "carName",
                value: "ford maverick");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 195,
                column: "carName",
                value: "amc hornet");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 196,
                column: "carName",
                value: "chevrolet chevette");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 197,
                column: "carName",
                value: "chevrolet woody");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 198,
                column: "carName",
                value: "vw rabbit");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 199,
                column: "carName",
                value: "honda civic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 200,
                column: "carName",
                value: "dodge aspen se");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 201,
                column: "carName",
                value: "ford granada ghia");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 202,
                column: "carName",
                value: "pontiac ventura sj");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 203,
                column: "carName",
                value: "amc pacer d/l");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 204,
                column: "carName",
                value: "volkswagen rabbit");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 205,
                column: "carName",
                value: "datsun b-210");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 206,
                column: "carName",
                value: "toyota corolla");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 207,
                column: "carName",
                value: "ford pinto");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 208,
                column: "carName",
                value: "volvo 245");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 209,
                column: "carName",
                value: "plymouth volare premier v8");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 210,
                column: "carName",
                value: "peugeot 504");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 211,
                column: "carName",
                value: "toyota mark ii");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 212,
                column: "carName",
                value: "mercedes-benz 280s");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 213,
                column: "carName",
                value: "cadillac seville");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 214,
                column: "carName",
                value: "chevy c10");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 215,
                column: "carName",
                value: "ford f108");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 216,
                column: "carName",
                value: "dodge d100");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 217,
                column: "carName",
                value: "honda accord cvcc");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 218,
                column: "carName",
                value: "buick opel isuzu deluxe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 219,
                column: "carName",
                value: "renault 5 gtl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 220,
                column: "carName",
                value: "plymouth arrow gs");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 221,
                column: "carName",
                value: "datsun f-10 hatchback");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 222,
                column: "carName",
                value: "chevrolet caprice classic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 223,
                column: "carName",
                value: "oldsmobile cutlass supreme");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 224,
                column: "carName",
                value: "dodge monaco brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 225,
                column: "carName",
                value: "mercury cougar brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 226,
                column: "carName",
                value: "chevrolet concours");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 227,
                column: "carName",
                value: "buick skylark");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 228,
                column: "carName",
                value: "plymouth volare custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 229,
                column: "carName",
                value: "ford granada");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 230,
                column: "carName",
                value: "pontiac grand prix lj");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 231,
                column: "carName",
                value: "chevrolet monte carlo landau");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 232,
                column: "carName",
                value: "chrysler cordoba");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 233,
                column: "carName",
                value: "ford thunderbird");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 234,
                column: "carName",
                value: "volkswagen rabbit custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 235,
                column: "carName",
                value: "pontiac sunbird coupe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 236,
                column: "carName",
                value: "toyota corolla liftback");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 237,
                column: "carName",
                value: "ford mustang ii 2+2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 238,
                column: "carName",
                value: "chevrolet chevette");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 239,
                column: "carName",
                value: "dodge colt m/m");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 240,
                column: "carName",
                value: "subaru dl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 241,
                column: "carName",
                value: "volkswagen dasher");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 242,
                column: "carName",
                value: "datsun 810");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 243,
                column: "carName",
                value: "bmw 320i");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 244,
                column: "carName",
                value: "mazda rx-4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 245,
                column: "carName",
                value: "volkswagen rabbit custom diesel");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 246,
                column: "carName",
                value: "ford fiesta");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 247,
                column: "carName",
                value: "mazda glc deluxe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 248,
                column: "carName",
                value: "datsun b210 gx");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 249,
                column: "carName",
                value: "honda civic cvcc");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 250,
                column: "carName",
                value: "oldsmobile cutlass salon brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 251,
                column: "carName",
                value: "dodge diplomat");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 252,
                column: "carName",
                value: "mercury monarch ghia");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 253,
                column: "carName",
                value: "pontiac phoenix lj");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 254,
                column: "carName",
                value: "chevrolet malibu");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 255,
                column: "carName",
                value: "ford fairmont (auto)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 256,
                column: "carName",
                value: "ford fairmont (man)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 257,
                column: "carName",
                value: "plymouth volare");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 258,
                column: "carName",
                value: "amc concord");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 259,
                column: "carName",
                value: "buick century special");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 260,
                column: "carName",
                value: "mercury zephyr");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 261,
                column: "carName",
                value: "dodge aspen");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 262,
                column: "carName",
                value: "amc concord d/l");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 263,
                column: "carName",
                value: "chevrolet monte carlo landau");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 264,
                column: "carName",
                value: "buick regal sport coupe (turbo)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 265,
                column: "carName",
                value: "ford futura");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 266,
                column: "carName",
                value: "dodge magnum xe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 267,
                column: "carName",
                value: "chevrolet chevette");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 268,
                column: "carName",
                value: "toyota corona");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 269,
                column: "carName",
                value: "datsun 510");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 270,
                column: "carName",
                value: "dodge omni");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 271,
                column: "carName",
                value: "toyota celica gt liftback");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 272,
                column: "carName",
                value: "plymouth sapporo");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 273,
                column: "carName",
                value: "oldsmobile starfire sx");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 274,
                column: "carName",
                value: "datsun 200-sx");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 275,
                column: "carName",
                value: "audi 5000");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 276,
                column: "carName",
                value: "volvo 264gl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 277,
                column: "carName",
                value: "saab 99gle");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 278,
                column: "carName",
                value: "peugeot 604sl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 279,
                column: "carName",
                value: "volkswagen scirocco");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 280,
                column: "carName",
                value: "honda accord lx");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 281,
                column: "carName",
                value: "pontiac lemans v6");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 282,
                column: "carName",
                value: "mercury zephyr 6");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 283,
                column: "carName",
                value: "ford fairmont 4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 284,
                column: "carName",
                value: "amc concord dl 6");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 285,
                column: "carName",
                value: "dodge aspen 6");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 286,
                column: "carName",
                value: "chevrolet caprice classic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 287,
                column: "carName",
                value: "ford ltd landau");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 288,
                column: "carName",
                value: "mercury grand marquis");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 289,
                column: "carName",
                value: "dodge st. regis");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 290,
                column: "carName",
                value: "buick estate wagon (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 291,
                column: "carName",
                value: "ford country squire (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 292,
                column: "carName",
                value: "chevrolet malibu classic (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 293,
                column: "carName",
                value: "chrysler lebaron town @ country (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 294,
                column: "carName",
                value: "vw rabbit custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 295,
                column: "carName",
                value: "maxda glc deluxe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 296,
                column: "carName",
                value: "dodge colt hatchback custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 297,
                column: "carName",
                value: "amc spirit dl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 298,
                column: "carName",
                value: "mercedes benz 300d");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 299,
                column: "carName",
                value: "cadillac eldorado");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 300,
                column: "carName",
                value: "peugeot 504");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 301,
                column: "carName",
                value: "oldsmobile cutlass salon brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 302,
                column: "carName",
                value: "plymouth horizon");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 303,
                column: "carName",
                value: "plymouth horizon tc3");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 304,
                column: "carName",
                value: "datsun 210");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 305,
                column: "carName",
                value: "fiat strada custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 306,
                column: "carName",
                value: "buick skylark limited");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 307,
                column: "carName",
                value: "chevrolet citation");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 308,
                column: "carName",
                value: "oldsmobile omega brougham");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 309,
                column: "carName",
                value: "pontiac phoenix");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 310,
                column: "carName",
                value: "vw rabbit");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 311,
                column: "carName",
                value: "toyota corolla tercel");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 312,
                column: "carName",
                value: "chevrolet chevette");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 313,
                column: "carName",
                value: "datsun 310");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 314,
                column: "carName",
                value: "chevrolet citation");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 315,
                column: "carName",
                value: "ford fairmont");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 316,
                column: "carName",
                value: "amc concord");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 317,
                column: "carName",
                value: "dodge aspen");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 318,
                column: "carName",
                value: "audi 4000");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 319,
                column: "carName",
                value: "toyota corona liftback");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 320,
                column: "carName",
                value: "mazda 626");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 321,
                column: "carName",
                value: "datsun 510 hatchback");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 322,
                column: "carName",
                value: "toyota corolla");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 323,
                column: "carName",
                value: "mazda glc");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 324,
                column: "carName",
                value: "dodge colt");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 325,
                column: "carName",
                value: "datsun 210");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 326,
                column: "carName",
                value: "vw rabbit c (diesel)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 327,
                column: "carName",
                value: "vw dasher (diesel)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 328,
                column: "carName",
                value: "audi 5000s (diesel)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 329,
                column: "carName",
                value: "mercedes-benz 240d");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 330,
                column: "carName",
                value: "honda civic 1500 gl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 331,
                column: "carName",
                value: "renault lecar deluxe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 332,
                column: "carName",
                value: "subaru dl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 333,
                column: "carName",
                value: "vokswagen rabbit");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 334,
                column: "carName",
                value: "datsun 280-zx");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 335,
                column: "carName",
                value: "mazda rx-7 gs");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 336,
                column: "carName",
                value: "triumph tr7 coupe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 337,
                column: "carName",
                value: "ford mustang cobra");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 338,
                column: "carName",
                value: "honda accord");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 339,
                column: "carName",
                value: "plymouth reliant");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 340,
                column: "carName",
                value: "buick skylark");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 341,
                column: "carName",
                value: "dodge aries wagon (sw)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 342,
                column: "carName",
                value: "chevrolet citation");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 343,
                column: "carName",
                value: "plymouth reliant");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 344,
                column: "carName",
                value: "toyota starlet");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 345,
                column: "carName",
                value: "plymouth champ");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 346,
                column: "carName",
                value: "honda civic 1300");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 348,
                column: "carName",
                value: "datsun 210 mpg");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 349,
                column: "carName",
                value: "toyota tercel");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 350,
                column: "carName",
                value: "mazda glc 4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 351,
                column: "carName",
                value: "plymouth horizon 4");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 352,
                column: "carName",
                value: "ford escort 4w");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 353,
                column: "carName",
                value: "ford escort 2h");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 354,
                column: "carName",
                value: "volkswagen jetta");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 355,
                column: "carName",
                value: "renault 18i");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 356,
                column: "carName",
                value: "honda prelude");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 357,
                column: "carName",
                value: "toyota corolla");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 358,
                column: "carName",
                value: "datsun 200sx");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 359,
                column: "carName",
                value: "mazda 626");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 360,
                column: "carName",
                value: "peugeot 505s turbo diesel");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 361,
                column: "carName",
                value: "volvo diesel");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 362,
                column: "carName",
                value: "toyota cressida");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 363,
                column: "carName",
                value: "datsun 810 maxima");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 364,
                column: "carName",
                value: "buick century");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 365,
                column: "carName",
                value: "oldsmobile cutlass ls");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 366,
                column: "carName",
                value: "ford granada gl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 367,
                column: "carName",
                value: "chrysler lebaron salon");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 368,
                column: "carName",
                value: "chevrolet cavalier");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 369,
                column: "carName",
                value: "chevrolet cavalier wagon");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 370,
                column: "carName",
                value: "chevrolet cavalier 2-door");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 371,
                column: "carName",
                value: "pontiac j2000 se hatchback");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 372,
                column: "carName",
                value: "dodge aries se");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 373,
                column: "carName",
                value: "pontiac phoenix");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 374,
                column: "carName",
                value: "ford fairmont futura");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 375,
                column: "carName",
                value: "amc concord dl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 376,
                column: "carName",
                value: "volkswagen rabbit l");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 377,
                column: "carName",
                value: "mazda glc custom l");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 378,
                column: "carName",
                value: "mazda glc custom");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 379,
                column: "carName",
                value: "plymouth horizon miser");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 380,
                column: "carName",
                value: "mercury lynx l");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 381,
                column: "carName",
                value: "nissan stanza xe");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 382,
                column: "carName",
                value: "honda accord");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 383,
                column: "carName",
                value: "toyota corolla");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 384,
                column: "carName",
                value: "honda civic");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 385,
                column: "carName",
                value: "honda civic (auto)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 386,
                column: "carName",
                value: "datsun 310 gx");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 387,
                column: "carName",
                value: "buick century limited");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 388,
                column: "carName",
                value: "oldsmobile cutlass ciera (diesel)");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 389,
                column: "carName",
                value: "chrysler lebaron medallion");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 390,
                column: "carName",
                value: "ford granada l");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 391,
                column: "carName",
                value: "toyota celica gt");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 392,
                column: "carName",
                value: "dodge charger 2.2");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 393,
                column: "carName",
                value: "chevrolet camaro");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 394,
                column: "carName",
                value: "ford mustang gl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 395,
                column: "carName",
                value: "vw pickup");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 396,
                column: "carName",
                value: "dodge rampage");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 397,
                column: "carName",
                value: "ford ranger");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 398,
                column: "carName",
                value: "chevy s-10");
        }
    }
}
