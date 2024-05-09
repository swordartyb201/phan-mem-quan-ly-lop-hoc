Các bước thực hiện demo phần mềm
Buoc 1: Tắt tường lửa ở máy Sinh Viên và máy Giảng Viên
Buoc 2: Kiểm tra mạng

Tại máy Giảng Viên -> Cmd gõ ipconfig, xem lại ip của mạng hiện tại (wifi hoặc lan) thường là 192.168.1.x (x từ 1 -> 255) Ghi lại ip này, đây là ip máy chủ sql.

Từ các máy Sinh Viên -> Cmd gõ ping <ip máy chủ sql> ví dụ : ping 192.168.1.21 xem các Sinh Viên đã thông với máy Giảng Viên chưa.

Setup nếu sử dụng máy ảo
Nhấn vào change settings, tại mục bridged (bridged to: ) chọn card mạng đang sử dụng (local hoặc intel wireless-ac), nhấn ok để save lại.
Restart lại các máy ảo. Và kiểm tra thông mạng lại.

Sau khi các máy Sinh Viên đã thông với máy Giảng Viên.

Trong file appconfig ở cả hai module Giảng Viên và Sinh Viên thực hiện cấu hình để kết nối đến CSDL:
	- Ở máy giảng viên: connect PTMSConnectionString4 sửa địa chỉ ip là ip của máy giảng viên
	- Ở máy sinh viên: connect PTMSConnectionString1 sửa địa chỉ ip là ip của máy giảng viên

Bước 3. Chạy ứng dụng quản lý của Giảng Viên ở máy chủ, và chạy các ứng dụng của Sinh Viên máy client.

Note: Trong CSDL ở db.Computers thêm hostname của máy Sinh Viên muốn đăng nhập  
