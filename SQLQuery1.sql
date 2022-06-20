select * from DangNhap
delete from DangNhap

select * from DangXuat	
delete from DangXuat

select DangNhap.MaNV as MãNV,NhanVien.TenNV as TênNV, DangNhap.NgayDangNhap as NgàyVào, DangNhap.ThoiGianDangNhap as ThờiGianVào,DangNhap.TrangThaiDangNhap as TrạngTháiVào, DangXuat.ThoiGianDangXuat as ThờiGianRa,DangXuat.TrangThaiDangXuat as TrạngTháiRa
from DangNhap join DangXuat on DangXuat.NgayDangXuat=DangNhap.NgayDangNhap and DangXuat.MaNV=DangNhap.MaNV join NhanVien on DangNhap.MaNV=NhanVien.MaNV

select * from DangNhap
where TrangThaiDangNhap='Di tre'
