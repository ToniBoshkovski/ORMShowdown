using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMShowdown.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "Code",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 643, new Guid("2f583545-c72a-4715-b903-6525a5b222d8"), "VOGZSZFQGNWRKWJ", 9965 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 868, new Guid("e82c0b6e-f4d0-4b0c-b0c7-b48bc06ca9f3"), "GTRYGYKNRBHXKKV", 5027 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 155, new Guid("eb5c0551-91a1-474b-ab5b-f1ef6e77f968"), "UBEKDCQGVDTFIKP", 1002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 228, new Guid("b3c5f882-a37e-4d06-9b6b-690f9dd36c84"), "RAKYNSSIULMQTHJ", 8870 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 444, new Guid("513963a2-69bd-4ad8-808e-f5ce1bd22704"), "ALZPSPVSGXBZQHR", 4539 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 86, new Guid("16522253-8ddb-49bc-862e-f59fbabdd1f8"), "IZYNPHDEZTRHOJQ", 6449 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 25, new Guid("682b647b-68e8-4169-aa04-57290135e7c3"), "SNWLIRNVEHHBWHB", 4440 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 572, new Guid("2b92d841-2add-4b7d-bce9-f285162a27e7"), "FWARBGFDZPMZXYT", 4015 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 10, new Guid("92baf413-968b-49ca-a47d-2999cc6a12f1"), "ULGWPWZTFQKCVSG", 4080 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 539, new Guid("a23650b2-f0ef-4f62-83b9-50e89e9d7182"), "GTABXYVYRLLFQQU", 9094 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 851, new Guid("b9d9033b-d71c-452d-a753-d5df5d896187"), "HICYMJQRWVKIEWB", 4558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 556, new Guid("029cd7e0-0829-425e-8c2f-9eac3e63cfe5"), "NTGQPMDEYFNPFKN", 2988 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 526, new Guid("05766146-7f78-47fe-97b5-477929e629a5"), "RKVVQBAQUAVDCIF", 1239 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 929, new Guid("c6bf6084-df6b-48cf-a2f6-9d6df92842bc"), "ABYXVSXUIWGDVJP", 8635 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 776, new Guid("a4bd4657-b9cd-412b-afe3-e49d4172997f"), "XWDELBZCVOCIVXP", 1297 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 369, new Guid("682c989f-da30-4129-bf94-eadd74fc55bb"), "RBHOJLZBWYZFLEF", 6185 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 909, new Guid("04f066be-8bc6-4946-9f7c-900b1e728f51"), "RVHWPBGLENPOZIJ", 1248 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 698, new Guid("26569654-d105-4af1-92b2-cb5394aa5f5d"), "FTSRJHAEBDNCIXP", 1773 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 911, new Guid("f2797e7b-29b9-449c-8b0e-af56c7c33735"), "WGNWXYLFONOHLLO", 1677 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 964, new Guid("6ffe78c1-2933-4dbd-b954-ceef8c6eddd5"), "HRRAAIRWJRKPSFJ", 5761 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 136, new Guid("eb0656fb-86a7-4e62-ba87-bf770805f011"), "YYDOYAAEGBPEVBA", 8866 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 735, new Guid("a25358bb-1a3b-47ba-b2a0-77030433931d"), "OUCQTCYJZGWWZEV", 8688 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 224, new Guid("f81941d3-662d-4f77-af9b-63e9f95bc415"), "AKBAGNICHJAVGPF", 6303 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 712, new Guid("1c9814f0-52fc-46c9-8e2e-b675ff863db6"), "YKAKBOZDNUHROMP", 3173 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 92, new Guid("83a1f76a-5f31-4448-972d-680badff3b2a"), "YINXOHXJZDQHRWC", 4624 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 681, new Guid("273d5247-e5c6-4c61-a89a-4c0936743724"), "QTTVDFQNTPWZTZD", 5979 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 535, new Guid("b9093027-d8d0-4d29-8f13-647ee812a88e"), "UFCEOSDXWTPRSFN", 2667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 659, new Guid("2eb030c6-1162-4751-a96b-dcf4dcb38b82"), "JKQIKIKHFIBOYPJ", 7631 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 719, new Guid("94ebd854-54aa-426a-ad3d-8854f734ea2e"), "WOKZCVMPIFOLRCT", 4654 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 190, new Guid("604e2dff-c0a9-4975-90fc-8572dac08256"), "RNAFUJSMOAYPRBH", 1843 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 273, new Guid("05249b4b-b8ad-4b2c-818b-60dca90d15b9"), "QXLDLBNNUADAZIU", 6253 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 794, new Guid("7aaa253c-db00-417f-b471-de4c845b977f"), "TIBLJBWLLNLBYAG", 2381 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 521, new Guid("23125e74-5bda-4f5a-b23f-39c98dc93700"), "WXLKFAYMXGCZNPW", 6870 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 145, new Guid("6b12a150-717a-4c77-b3ea-62079854c786"), "ESYKOVVIXNZAFRB", 7869 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 390, new Guid("2a9fd601-a1e7-44fa-9d60-6e9beb512a53"), "YMUSOFKKQQXXZVB", 9485 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 491, new Guid("f1578748-bed7-46e3-a27e-6eaa461838ab"), "VKHGVHHPPPXRKFH", 7852 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 302, new Guid("f76941b1-ddcd-44cb-9739-c6db34a80242"), "PVFKDTZSUMKQPYQ", 5604 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 52, new Guid("04aa263a-3ad5-4179-a3e2-e58492a1da19"), "FMBOMASQCDPDMHC", 6131 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 619, new Guid("3351c822-3cf4-42a2-8da8-f6dbc116687b"), "NGBUXODEQETZZLI", 4525 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 749, new Guid("ce36e390-edeb-4d52-ac06-fe6152d91099"), "RKXUDLPJEUHURXJ", 8057 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 683, new Guid("0a7a8deb-f6f8-4ea0-b0c1-6a83ffeb5841"), "ZQXPJBTKNBHEUHU", 9300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 225, new Guid("704277af-1fc6-43cf-bc55-03c61e69b900"), "MTUJKZTVWFMIPYZ", 8018 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 31, new Guid("fdd0bfba-9a78-4945-b131-f81b2f1519ba"), "PHWRNBWPBDLEHJH", 2495 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 278, new Guid("a776793d-83e4-4a67-9a98-4d9bf90713eb"), "RMGLOFPWKXTGGJV", 4052 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 715, new Guid("fe0663e0-3902-4085-baba-180981cf5321"), "TCRJENQOMQQBYTY", 6365 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 45, new Guid("664bed48-b556-42d1-850c-6de917a07343"), "IDCZXSROSHUGRFW", 1717 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 57, new Guid("7192eb81-55d8-4cea-9b3d-458acb2ebca1"), "QHKUOXSRJFNSPUK", 7503 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 781, new Guid("32c1c99c-0ec6-487a-bb74-070b5cf3e4c2"), "HOHIEMNPMZGIEWA", 5705 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 575, new Guid("51093578-ad68-40b0-b320-4b99f47caa5a"), "NTKUVQURIGNJLEC", 3628 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 121, new Guid("d4ba2f33-4387-48ac-80a4-6767b9d8d4db"), "IUNWOWCQZKGDGNB", 1513 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 584, new Guid("d7517e42-efd2-4553-95d7-4b246cc0df96"), "YFYFCEVZWHNOQHP", 1502 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 602, new Guid("ceb58f2a-7d20-4216-9a99-e92429a96a33"), "TCVVAQRSPPYXCOL", 3694 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 247, new Guid("5492b255-3f0f-459d-b637-9a63098b4d98"), "PVCAENMMNYMBKAE", 5528 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 816, new Guid("b800ea43-67c7-4625-a718-3571e9f95c44"), "BLIYZJXURETUFIA", 2144 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 896, new Guid("be4158f3-dc5f-4d83-b55f-dd82f1a544bb"), "MGXKGWFEFZUEFIU", 3128 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 49, new Guid("283efba6-3668-4a7d-8561-381341617feb"), "EVURBOPGQJOLODR", 3203 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 995, new Guid("1ef0fcf0-5363-4702-b55a-5007b0eb684f"), "LDLNGCEELWINJVQ", 5368 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 604, new Guid("a111b284-4a8f-4408-a6fb-10c4a7836592"), "SHAWEOZJVTLBLZJ", 8769 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 127, new Guid("987151bc-a9eb-48ff-a57c-132d3b488b49"), "TPTTSYWCJZNQEUY", 2351 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 708, new Guid("58350493-32b0-4f78-b46f-09e6eaa6de41"), "VNSCNKPGZGBRLOC", 6498 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 108, new Guid("3ccec910-9770-4c57-b6ee-433d5f9ac8fe"), "ZMUXASBTNOOTRYK", 4619 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 655, new Guid("ca66cc21-1a45-435b-85cb-2d139630cc1c"), "BWLEERZGJYUBZTD", 8421 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 130, new Guid("c3dd4e35-a3ec-4d43-aa59-5a3db1eab7af"), "BTWTTLIQSFCMLWK", 5324 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 747, new Guid("c07b1cbc-1d25-4e58-abbf-02555996336b"), "ZRLNBDRAYEDUEFA", 8954 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 705, new Guid("958fad03-d494-43d5-bc41-deb450199810"), "NPZHBPLBICXDNRA", 8918 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 876, new Guid("322d4d84-21c3-419f-bd05-0095c6afab68"), "XSDWFRCJBFSIZGS", 3072 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 880, new Guid("803e4b5e-b7fc-49b2-93fa-49a7b999d438"), "TDGDYRQHACTVLUY", 8538 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 332, new Guid("5d2acdcb-618a-4873-861b-758fb325d5b7"), "SOCRKMBCXJWOXJK", 1094 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 419, new Guid("bbd546ba-8fb8-4358-977f-5326f4f519ec"), "NZKDYZMRYFZRONE", 7715 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 185, new Guid("890125bd-7dbc-4631-87b0-5fe6ac51e848"), "RGQAELAFFXVZSAD", 1734 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 541, new Guid("79a463cd-2d2e-442e-973d-3274392097d3"), "OSRMQBXMUBNBPDS", 4822 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 845, new Guid("91a6eb69-e2b2-4d90-8573-9f43516bd132"), "ORBEMJGNFRTDVJL", 3335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 698, new Guid("70fe364f-42b1-4f69-aa80-473abcf59003"), "XCJXGNGSTFPCBDC", 7032 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 57, new Guid("1fac1201-993f-489a-bc91-ccbdebecf12c"), "KGKIINBHANFLKUC", 9359 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 181, new Guid("533bbf24-3e9b-4949-8288-858680fbeaab"), "YSTJAVSIXAUFTLA", 5335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 281, new Guid("de4baa94-195c-4dc3-adbe-f7b089107b66"), "CSYEZFKJJXWRYGZ", 6440 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 978, new Guid("3f6700f8-7dd6-417f-bbb9-6fd4ff50dcb8"), "QMZIWTJSWXFVYHK", 6472 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 988, new Guid("36c5202d-7158-4d03-8821-7c5fcbc491c1"), "MRTKACCZFIHXXEG", 6098 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 935, new Guid("ac0bf880-69bf-4e46-9cb8-454416e714ef"), "BTWEOSCQBKRRGWV", 7514 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 157, new Guid("7ae84757-bfd0-477d-ace1-afdbce440da9"), "QHCTPVRBNSWVZQC", 8846 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 803, new Guid("adee19da-875c-4102-b684-cf5df8f7c8a5"), "XVCXZTKDOZESGAC", 2281 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 589, new Guid("e84ea182-d09a-406c-8ed2-65c799959f8f"), "XBZONVNIZUAWZLU", 8099 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 710, new Guid("318e0aaa-1cdf-4ec7-ae4b-741755e9c050"), "KMWZIHULGENCLXV", 4192 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 58, new Guid("9ce31c69-d223-4131-9b5b-a76a3e4c79de"), "NCPZLJCRIQRJYRM", 9087 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 84, new Guid("deb95c9e-208e-4628-91d9-902ac2ed8f0d"), "MHEKNCYGBHKRVZC", 6246 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 412, new Guid("4934a96c-d5d1-4f46-a75f-84ca41394220"), "GDPAYVATOBZSUVI", 6670 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 255, new Guid("a46745c1-23a9-46f7-8270-cf578bf965c8"), "LHSUGPXWIOWZLOG", 3256 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 635, new Guid("79b48d65-5e93-4231-bbe6-4673ca1be34e"), "CBAJABZAYKCTFVE", 7118 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 129, new Guid("b6d1ef9c-be67-4bda-b2ca-e6367556eddc"), "JVEDACOOQEIGRKO", 3646 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 373, new Guid("04698d79-8b2f-4680-b648-ddc3a2ebbbb6"), "URBBVVGZAWFBGEB", 6063 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 73, new Guid("6d57c74c-989f-4523-b1c6-832221246569"), "QPEROVVJIJAPPHQ", 4213 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 34, new Guid("c7759fa5-71f2-4221-919e-aac8c468e66f"), "AKSHIBHKIBDICFL", 3584 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 200, new Guid("ab930912-8040-4fb1-800c-7583e2b8e3fe"), "DWMOSYJGBFAJUZF", 7771 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 510, new Guid("72313c05-ec72-40db-a7ea-aaff5e0b60cb"), "QXNMQMIFCERQHCJ", 8998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 539, new Guid("8cb2cb5f-8234-4b3e-b0a2-8733c2d31171"), "RNERYJYHAHGFSTG", 4494 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 540, new Guid("415d73e7-8fb9-4a86-93fa-6649ef7081d0"), "BTIMOECICLZIFNU", 4945 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 854, new Guid("e77a5644-1103-441a-86e9-e4f937612641"), "LOUWDYBVJMEADKQ", 3648 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 874, new Guid("f83cc943-4203-4d3c-973c-abbdd2809b96"), "RIRDXHINLALVSOF", 1836 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 274, new Guid("b48d98d2-3b40-4631-ab70-7c2248120f25"), "PPGJUXYMUKJTWOD", 2119 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Amount", "Code", "Name", "Price" },
                values: new object[] { 870, new Guid("b3c969df-1528-48b4-ad1d-8c27dc88234c"), "OBANZXRXEHDWOOU", 6330 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6357 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5245 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4264 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1921 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9498 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6780 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4173 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8781 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4231 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9098 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1206 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5072 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8168 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9064 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3587 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2027 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 7690 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8641 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4552 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4906 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5782 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3820 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8285 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9818 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6889 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3309 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6733 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2058 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8491 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4529 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8212 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1301 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5946 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5115 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3697 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8275 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1185 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9276 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4513 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 7661 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6700 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9753 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3591 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4216 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6697 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8343 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 7045 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3492 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3852 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6699 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3791 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1332 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6622 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9791 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1984 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1784 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9931 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8684 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2465 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8337 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6599 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4808 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2887 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 7752 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9405 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9814 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8306 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3576 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1418 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2082 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 7517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9106 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5644 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5208 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6227 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6562 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3230 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5585 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4369 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 6697 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4084 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 7618 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9333 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 3793 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 4216 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8451 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 5842 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1781 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9593 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2551 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 9967 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 8030 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 7021 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2149 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2184 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 1291 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Random Product", 2532 });
        }
    }
}
