USE [NhanVien]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 04/06/2022 10:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[MaNV] [nchar](10) NOT NULL,
	[NgayDangNhap] [date] NOT NULL,
	[ThoiGianDangNhap] [time](7) NOT NULL,
	[TrangThaiDangNhap] [nchar](10) NOT NULL,
	[TreGioCoPhep] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangXuat]    Script Date: 04/06/2022 10:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangXuat](
	[MaNV] [nchar](10) NULL,
	[NgayDangXuat] [date] NOT NULL,
	[ThoiGianDangXuat] [time](7) NOT NULL,
	[TrangThaiDangXuat] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NghiPhep]    Script Date: 04/06/2022 10:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NghiPhep](
	[MaNV] [nchar](10) NULL,
	[TenNV] [nchar](50) NULL,
	[NghiTuNgay] [nchar](10) NULL,
	[NghiDenNgay] [nchar](10) NULL,
	[LyDoNghi] [nchar](50) NULL,
	[XacNhanChoNghi] [nchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/06/2022 10:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nchar](50) NULL,
	[NgaySinhNV] [date] NULL,
	[DiaChiNV] [nchar](50) NULL,
	[SDT] [nchar](20) NULL,
	[CMND] [nchar](20) NULL,
	[GioiTinh] [nchar](10) NULL,
	[ChucVu] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DangNhap] ADD  CONSTRAINT [DF__DangNhap__NgayDa__2E1BDC42]  DEFAULT (getdate()) FOR [NgayDangNhap]
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD  CONSTRAINT [FK_DangNhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DangNhap] CHECK CONSTRAINT [FK_DangNhap_NhanVien]
GO
ALTER TABLE [dbo].[NghiPhep]  WITH CHECK ADD  CONSTRAINT [FK_NghiPhep_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NghiPhep] CHECK CONSTRAINT [FK_NghiPhep_NhanVien]
GO
