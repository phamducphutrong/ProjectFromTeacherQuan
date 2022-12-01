using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectWeb.Migrations
{
    public partial class ProjectWeb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    url = table.Column<string>(nullable: true),
                    modalId = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    description1 = table.Column<string>(nullable: true),
                    description2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    document_name = table.Column<string>(nullable: true),
                    document_id = table.Column<string>(nullable: true),
                    signed_day = table.Column<DateTime>(nullable: false),
                    book_number = table.Column<string>(nullable: true),
                    version = table.Column<string>(nullable: true),
                    last_fix = table.Column<int>(nullable: false),
                    tag = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Dear_to = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.id);
                    table.ForeignKey(
                        name: "FK_Records_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nghị định" },
                    { 2, "Quyết định" },
                    { 3, "Thông báo" },
                    { 4, "Thông tư" }
                });

            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "description1", "description2", "modalId", "name", "title", "url" },
                values: new object[,]
                {
                    { 1, "Tờ khai đăng ký kết hôn hiện nay được áp dụng theo quy định tại Thông tư 04/2020/TT-BTP quy định thi hành một số điều của Luật Hộ tịch, có hiệu lực từ ngày 16/7/2020. Theo đó, nếu đi làm thủ tục đăng ký kết hôn, hai người nam nữ phải khai vào tờ khai đăng ký kết hôn để cơ quan có thẩm quyền xác định thông tin nhân thân, nơi cư trú, đã kết hôn mấy lần rồi... Qua đó, làm căn cứ để tiến hành làm thủ tục đăng ký kết hôn cho hai người.", "", "m1", "kethon", "Mẫu đơn đăng ký kết hôn", "https://cms.luatvietnam.vn/uploaded/Images/Original/2019/04/11/to-khai-dang-ky-ket-hon-chuan_1104141938.jpg" },
                    { 2, "Giấy quyết định ly hôn hay được gọi bằng một tên gọi gần gũi hơn là trích lục ly hôn - là một giấy tờ pháp lý do cơ quan có thẩm quyền ở đây là Tòa án Nhân dân sau khi hoàn thành việc giải quyết ly hôn theo thủ tục ly hôn đơn phương theo quy định pháp luật về tố tụng dân sự và hôn nhân gia dình. Giấy quyết định ly hôn có hiệu lực pháp lý tương đương với bản án quyết định ly hôn của Tòa án. Chính vì vậy, khi xảy ra trường hợp bản án quyết định ly hôn của Tòa án không còn tồn tại thì giấy quyết định ly hôn là một văn bản có hiệu lực pháp lý thay thế.", "", "m2", "kethon", "Mẫu đơn ly hôn", "https://cdn.thuvienphapluat.vn/phap-luat/2022/202201/PVQ/thang7/220719/305-1.jpg" },
                    { 3, "Bổ nhiệm là việc giao cho một người giữ một chức vụ trong bộ máy nhà nước bằng quyết định của cá nhân hay của cơ quan nhà nước có thẩm quyền. Bổ nhiệm là việc giao cho một người giữ chức vụ trong bộ máy nhà nước bằng quyết định của cá nhân hay của cơ quan nhà nước có thẩm quyền. Bổ nhiệm là việc làm mang tính chất quyền lực nhà nước của người giữ chức vụ nhất định để góp phần kiện toàn và củng cố bộ máy nhà nước, đảm bảo cho bộ máy nhà nước hoạt động có hiệu quả và hiệu lực trên thực tế.", "", "m3", "quyen", "Quyết định bổ nhiệm", "https://sanketoan.vn/public/library_staff/25094/images/tailieu2/5(16).PNG" },
                    { 4, "Mẫu phiếu đề xuất bổ nhiệm cán bộ là mẫu phiếu được gửi tới cơ quan có thẩm quyền để xem xét bổ nhiệm cán bộ. Mẫu phiếu bổ nhiệm cán bộ được nêu rõ thông tin cá nhân của người được bổ nhiệm, lý do bổ nhiệm, ý kiến của phòng nhân sự, ý kiến của ban giám đốc về việc bổ nhiệm cán bộ mới. ", "", "m4", "quyen", "Đề xuất bổ nhiệm nhân sự", "http://1001vieclam.com/bieu-mau-nhan-su/wp-content/uploads/2017/08/de-xuat-bo-nhiem-nhan-su-1.jpg" },
                    { 5, "Hợp đồng mua bán nhà ở là sự thoả thuận bằng văn bản giữa bên mua và bên bán, theo đó bên bán có nghĩa vụ chuyển giao nhà ở và quyền sở hữu nhà ở cho bên mua. Bên mua có nghĩa vụ trả tiền cho bên bán đúng thời hạn, địa điểm theo phương thức mà các bên đã thoả thuận trong hợp đồng mua bán nhà ở.", "Đối tượng của hợp đồng mua bán nhà ở là ngôi nhà hoặc diện tích nhà dùng vào việc ở, sinh hoạt hàng ngày của con người. Nhà ở khác với nhà dùng vào mục đích khác như làm văn phòng, trụ sở cơ quan, kho chứa, cửa hàng, cửa hiệu… Nhưng, khi mua bán nhà ở để dùng vào mục đích khác cũng phải tuân theo các quy định của pháp luật về mua bán nhà ở.", "m5", "dat", "Hợp đồng mua bán nhà ở và chuyển đổi quyền sử dung đất", "https://sudospaces.com/ketoanleanh/2020/10/hop-dong-mua-ban-nha-o.jpg" },
                    { 6, @"Theo pháp luật hiện hành, đơn khiếu nại lấn chiếm không gian là loại văn bản được người khiếu nại dùng để khiếu nại về việc lấn chiếm không gian phát sinh khi khoảng không gian nằm trong diện tích đất của mình bị lấn chiếm bất hợp pháp.

                Trên thực tế, việc khiếu nại tranh chấp lối đi chung là một trong những trường hợp phổ biến xảy ra nhất.", "", "m6", "dat", "Đơn khiếu nại lấn chiếm đất", "https://o.vdoc.vn/data/image/2022/06/09/don-khieu-nai-giai-quyet-tranh-chap-dat-dai-1.jpg" },
                    { 7, @"Theo pháp luật hiện hành, đơn khiếu nại lấn chiếm không gian là loại văn bản được người khiếu nại dùng để khiếu nại về việc lấn chiếm không gian phát sinh khi khoảng không gian nằm trong diện tích đất của mình bị lấn chiếm bất hợp pháp.

                Trên thực tế, việc khiếu nại tranh chấp lối đi chung là một trong những trường hợp phổ biến xảy ra nhất.", "", "m7", "dat", "Đơn khiếu nại lấn chiếm đất", "https://o.vdoc.vn/data/image/2022/06/09/don-khieu-nai-giai-quyet-tranh-chap-dat-dai-1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "id", "CategoryId", "Content", "Dear_to", "Destination", "book_number", "document_id", "document_name", "last_fix", "signed_day", "tag", "version" },
                values: new object[] { 1, 1, "Đơn xin thôi việc", "Trưởng phòng nhân sự", "Phòng nhân sự", "b-123", "2204", "abcd", 15, new DateTime(2015, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đất đai", "#123" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "id", "CategoryId", "Content", "Dear_to", "Destination", "book_number", "document_id", "document_name", "last_fix", "signed_day", "tag", "version" },
                values: new object[] { 2, 2, "Đơn xin nghỉ học", @"Trưởng ban quản lí sinh viên
", "Phòng cộng tác sinh viên", "b-321", "2205", "efgh", 10, new DateTime(2016, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Đất đai", "#321" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "id", "CategoryId", "Content", "Dear_to", "Destination", "book_number", "document_id", "document_name", "last_fix", "signed_day", "tag", "version" },
                values: new object[] { 3, 3, "Đơn xin xác nhận học bổng", @"Hiệu trưởng
Hiệu phó", "Trường đại học Greenwich", "b-456", "2206", "jklm", 20, new DateTime(2017, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sở giáo dục", "#456" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Records_CategoryId",
                table: "Records",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
