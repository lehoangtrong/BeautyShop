# BeautyShop

BeautyShop là một ứng dụng quản lý người dùng và sản phẩm dành cho ngành làm đẹp, giúp các cửa hàng, salon hoặc spa dễ dàng quản lý các khách hàng và sản phẩm của họ.

## Tính năng

- **Quản lý người dùng**:
  - Đăng ký và đăng nhập người dùng.
  - Quản lý thông tin cá nhân của người dùng (Tên, Email, Mật khẩu, ...).
  - Quản lý vai trò người dùng (Admin, Customer).

- **Quản lý sản phẩm**:
  - Thêm, sửa, xóa và hiển thị các sản phẩm.
  - Quản lý thông tin sản phẩm (Tên, Giá, Mô tả, ...).

## Cài đặt

### Yêu cầu hệ thống

- .NET Core 3.1 hoặc phiên bản cao hơn.
- SQL Server hoặc một hệ quản trị cơ sở dữ liệu tương thích.

### Cài đặt dự án

1. Clone repository:
    ```bash
    git clone https://github.com/lehvn/BeautyShop.git
    ```

2. Cài đặt các phụ thuộc:
    ```bash
    dotnet restore
    ```

3. Cấu hình cơ sở dữ liệu:
    - Chỉnh sửa kết nối cơ sở dữ liệu trong `appsettings.json`.

4. Chạy ứng dụng:
    ```bash
    dotnet run
    ```

## Cấu trúc dự án

- `BeautyShop`: Thư mục chính chứa mã nguồn của ứng dụng.
- `.gitignore`: Tệp cấu hình để bỏ qua các tệp không cần thiết khi commit.
- `.gitattributes`: Tệp cấu hình định dạng các tệp khi đẩy lên GitHub.
- `BeautyShop.sln`: Tệp solution của dự án.

## Đóng góp

Chúng tôi chào đón mọi đóng góp từ cộng đồng. Nếu bạn muốn đóng góp vào dự án này, vui lòng thực hiện theo các bước sau:

1. Fork repository này.
2. Tạo một nhánh mới cho tính năng của bạn (`git checkout -b feature/your-feature`).
3. Commit thay đổi của bạn (`git commit -am 'Add new feature'`).
4. Push nhánh lên repository của bạn (`git push origin feature/your-feature`).
5. Mở Pull Request.

## Giấy phép

Dự án này được cấp phép theo Giấy phép MIT - xem [LICENSE](LICENSE) để biết thêm chi tiết.

## Liên hệ

- **Tác giả**: lehoangtrong
- **Email**: [lehoangtrongcsgl@gmail.com](mailto:lehoangtrongcsgl@gmail.com)
