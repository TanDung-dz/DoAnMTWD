USE [master]
GO
/****** Object:  Database [PKNhaKhoa]    Script Date: 10/25/2023 8:16:59 PM ******/
CREATE DATABASE [PKNhaKhoa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PKNhaKhoa', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PKNhaKhoa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PKNhaKhoa_log', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PKNhaKhoa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PKNhaKhoa] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PKNhaKhoa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PKNhaKhoa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET ARITHABORT OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PKNhaKhoa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PKNhaKhoa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PKNhaKhoa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PKNhaKhoa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET RECOVERY FULL 
GO
ALTER DATABASE [PKNhaKhoa] SET  MULTI_USER 
GO
ALTER DATABASE [PKNhaKhoa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PKNhaKhoa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PKNhaKhoa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PKNhaKhoa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PKNhaKhoa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PKNhaKhoa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PKNhaKhoa] SET QUERY_STORE = ON
GO
ALTER DATABASE [PKNhaKhoa] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PKNhaKhoa]
GO
/****** Object:  Table [dbo].[BaoHanh]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoHanh](
	[MaBH] [varchar](10) NOT NULL,
	[TenBH] [nvarchar](50) NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
 CONSTRAINT [PK_BaoHanh] PRIMARY KEY CLUSTERED 
(
	[MaBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBN] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NamSinh] [varchar](10) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[NgayKham] [date] NULL,
	[LiDoKham] [nvarchar](50) NULL,
	[MaKT] [varchar](10) NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CanLS]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanLS](
	[MaCD] [varchar](10) NOT NULL,
	[MaBH] [varchar](10) NULL,
	[MaKT] [varchar](10) NULL,
	[KetQua] [nvarchar](50) NULL,
	[KetLuan] [nvarchar](50) NULL,
 CONSTRAINT [PK_CanLS] PRIMARY KEY CLUSTERED 
(
	[MaCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DCVT]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DCVT](
	[MaDC] [varchar](10) NOT NULL,
	[TenDC] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
	[DVT] [nvarchar](30) NULL,
	[SL] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_DungCu-VatTu] PRIMARY KEY CLUSTERED 
(
	[MaDC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DieuTri]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DieuTri](
	[MaDV] [varchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[MaRang] [varchar](10) NULL,
	[SoLuong] [int] NULL,
	[DVT] [nvarchar](30) NULL,
	[DonGia] [decimal](18, 0) NULL,
	[MaCD] [varchar](10) NULL,
	[MaDC] [varchar](10) NULL,
 CONSTRAINT [PK_DieuTri] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaBN] [varchar](10) NULL,
	[MaThuoc] [varchar](10) NULL,
	[MaDV] [varchar](10) NULL,
	[SDT] [varchar](10) NULL,
	[TongTien] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rang]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rang](
	[MaRang] [varchar](10) NOT NULL,
	[LoaiRang] [nvarchar](50) NULL,
	[TenRang] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rang] PRIMARY KEY CLUSTERED 
(
	[MaRang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [varchar](10) NOT NULL,
	[Tenthuoc] [nvarchar](50) NULL,
	[MoTa] [nvarchar](50) NULL,
	[DVT] [nvarchar](40) NULL,
	[SL] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrongRang]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrongRang](
	[MaCL] [varchar](10) NOT NULL,
	[PhanLoai] [nvarchar](50) NULL,
	[ChatLieu] [nvarchar](50) NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_TrongRang] PRIMARY KEY CLUSTERED 
(
	[MaCL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XN-XQUANG]    Script Date: 10/25/2023 8:16:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XN-XQUANG](
	[MaKT] [varchar](10) NOT NULL,
	[LoaiKT] [nvarchar](20) NULL,
	[Ten] [nvarchar](20) NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_XN-XQUANG] PRIMARY KEY CLUSTERED 
(
	[MaKT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BaoHanh] ([MaBH], [TenBH], [NgayBatDau], [NgayKetThuc]) VALUES (N'BH01', N'Răng Sứ', CAST(N'2023-01-10' AS Date), CAST(N'2024-01-10' AS Date))
INSERT [dbo].[BaoHanh] ([MaBH], [TenBH], [NgayBatDau], [NgayKetThuc]) VALUES (N'BH02', N'Răng Tháo Lắp', CAST(N'2022-03-04' AS Date), CAST(N'2023-03-04' AS Date))
INSERT [dbo].[BaoHanh] ([MaBH], [TenBH], [NgayBatDau], [NgayKetThuc]) VALUES (N'BH03', N'Niềng Răng', CAST(N'2023-05-08' AS Date), CAST(N'2023-11-08' AS Date))
INSERT [dbo].[BaoHanh] ([MaBH], [TenBH], [NgayBatDau], [NgayKetThuc]) VALUES (N'BH04', N'Implant', CAST(N'2021-12-23' AS Date), CAST(N'2022-12-23' AS Date))
GO
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [NgayKham], [LiDoKham], [MaKT]) VALUES (N'01', N'Đường Tăng Tạng', N'1998', N'Nam', N'TPHCM', N'', CAST(N'2023-07-08' AS Date), N'Đau chân răng', NULL)
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [NgayKham], [LiDoKham], [MaKT]) VALUES (N'02', N'Hoàng Thị Trúc', N'2000', N'Nữ', N'Thủ Đức', NULL, CAST(N'2022-09-01' AS Date), N'Niềng răng', NULL)
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [NgayKham], [LiDoKham], [MaKT]) VALUES (N'04', N'Lê Ngọc Anh', N'2003', N'Nữ', N'TPHCM', NULL, CAST(N'2023-05-27' AS Date), N'Niềng răng', NULL)
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [NgayKham], [LiDoKham], [MaKT]) VALUES (N'07', N'Hoàng Thị Trúcc', N'2000', N'Nữ', N'Thủ Đức', N'04567890', CAST(N'2023-10-24' AS Date), N'Niềng răng', N'')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [NgayKham], [LiDoKham], [MaKT]) VALUES (N'08', N'Bạch Cốt Tinh', N'1992', N'Nữ', N'HaNoi', N'0147852987', CAST(N'2023-10-25' AS Date), N'Dau rang', N'')
INSERT [dbo].[BenhNhan] ([MaBN], [HoTen], [NamSinh], [GioiTinh], [DiaChi], [SDT], [NgayKham], [LiDoKham], [MaKT]) VALUES (N'09', N'Hoàng Thị Trúc', N'2000', N'Nữ', N'Thủ Đức', N'4567890', CAST(N'2023-10-24' AS Date), N'Niềng răng', N'')
GO
INSERT [dbo].[CanLS] ([MaCD], [MaBH], [MaKT], [KetQua], [KetLuan]) VALUES (N'08', NULL, NULL, N'BenhNang', N'Dien')
INSERT [dbo].[CanLS] ([MaCD], [MaBH], [MaKT], [KetQua], [KetLuan]) VALUES (N'123', NULL, NULL, N'Đau Rang', N'Đau Rang')
GO
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'01', N'Mũi Khoan', N'', N'cái', NULL, CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'02', N'Tay Khoan', NULL, N'cái', NULL, CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'03', N'Mũi cắm Implant', NULL, N'cái', NULL, CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'04', N'Máy cạo vôi', NULL, N'cái', NULL, CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'05', N'Đèn quang', NULL, N'cái', NULL, CAST(300000 AS Decimal(18, 0)))
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'06', N'Bông gòn', NULL, N'miếng', NULL, CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'07', N'Máy hút', NULL, N'cái', NULL, CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'08', N'Mắc cài', NULL, N'cái', NULL, CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[DCVT] ([MaDC], [TenDC], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'09', N'Vít', NULL, N'cái', NULL, NULL)
GO
INSERT [dbo].[DieuTri] ([MaDV], [TenDV], [MaRang], [SoLuong], [DVT], [DonGia], [MaCD], [MaDC]) VALUES (N'01', N'Cạo Vôi', NULL, NULL, N'Cái', CAST(100000 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[DieuTri] ([MaDV], [TenDV], [MaRang], [SoLuong], [DVT], [DonGia], [MaCD], [MaDC]) VALUES (N'02', N'Tẩy Trắng', NULL, NULL, N'Cái', CAST(100000 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[DieuTri] ([MaDV], [TenDV], [MaRang], [SoLuong], [DVT], [DonGia], [MaCD], [MaDC]) VALUES (N'03', N'Nhổ Răng', NULL, NULL, N'Cái', CAST(100000 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[DieuTri] ([MaDV], [TenDV], [MaRang], [SoLuong], [DVT], [DonGia], [MaCD], [MaDC]) VALUES (N'04', N'Trám Răng', NULL, NULL, N'Cái', CAST(150000 AS Decimal(18, 0)), NULL, NULL)
INSERT [dbo].[DieuTri] ([MaDV], [TenDV], [MaRang], [SoLuong], [DVT], [DonGia], [MaCD], [MaDC]) VALUES (N'05', N'Nội Nha', NULL, NULL, N'Cái', CAST(200000 AS Decimal(18, 0)), NULL, NULL)
GO
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S1', N'Sâu', N'S1')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S10', N'Khôn', N'Hàm Dưới')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S11', N'Mòn', NULL)
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S12', N'Thưa', NULL)
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S13', NULL, N'Răng Cửa')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S14', NULL, N'Răng Tiền Cối')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S15', NULL, N'Răng Cối')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S2', N'Sâu', N'S2')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S3', N'Sâu', N'S3')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S4', N'Trước', N'1 Chân')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S5', N'Hàm', N'Nhiều Chân')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S6', N'Khó', N'')
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S7', N'LungLay', NULL)
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S8', N'Sữa', NULL)
INSERT [dbo].[Rang] ([MaRang], [LoaiRang], [TenRang]) VALUES (N'S9', N'Khôn', N'Hàm Trên')
GO
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'01', N' Ibuprofen', N'Kháng viêm', N'Viên', NULL, CAST(1200 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'02', N'Paracetamol', N'Giảm đau', N'Viên', NULL, CAST(1200 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'03', N'Prilocaine', N'Gây tê', N'Lọ', NULL, CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'04', N'Lidocaine', N'Gây tê', N'Lọ', NULL, CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'05', N'Benzocain', N'Gây tê cục bộ', N'Lọ', NULL, CAST(75000 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'06', N'amoxicillin', N'Kháng sinh', N'Viên', NULL, CAST(1500 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'07', N'Spiramycin', N'Kháng sinh', N'Viên', NULL, CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'08', N'Tetracycline', N'Chảy máu chân răng', N'Viên', NULL, CAST(2500 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'09', N'Penicillin', N'Chảy máu chân răng', N'Viên', NULL, CAST(1500 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'10', N'Dentanalgi', N'Thuốc chấm đau răng', N'Viên', NULL, CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'11', N'Dorogyne', N'Giảm đau kháng viêm', N'Viên', NULL, CAST(2500 AS Decimal(18, 0)))
INSERT [dbo].[Thuoc] ([MaThuoc], [Tenthuoc], [MoTa], [DVT], [SL], [DonGia]) VALUES (N'12', N'Rodogyl', N'Kháng sinh', N'Viên', NULL, CAST(1000 AS Decimal(18, 0)))
GO
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'01', N'Răng Sứ', N'Kim Loại', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'02', N'Răng Sứ', N'Titan', CAST(600000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'03', N'Răng Sứ', N'Toàn Sứ', CAST(700000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'04', N'Răng Tháo Lắp', N'NỀN NHỰA
CỨNG BÁN
HÀM', CAST(700000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'05', N'Răng Tháo Lắp', N'NỀN NHỰA
CỨNG TOÀN
HÀM', CAST(1300000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'08', N'Răng Tháo Lắp', N'RĂNG NHỰA
VIỆT NAM', CAST(500000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'09', N'Răng Tháo Lắp', N'RĂNG NHỰA
NGOẠI', CAST(750000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'10', N'Răng Tháo Lắp', N'RĂNG
COMPOSITE', CAST(600000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'11', N'Răng Tháo Lắp', N'RĂNG SỨ', CAST(700000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'12', N'Răng Tháo Lắp', N'HÀM KHUNG
KIM LOẠI', CAST(550000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'13', N'Răng Tháo Lắp', N'HÀM KHUNG
LIÊN KẾT', CAST(820000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'14', N'Răng Tháo Lắp', N'HÀM KHUNG
NHỰA CỨNG', CAST(450000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'15', N'Răng Tháo Lắp', N'HÀM KHUNG
NHỰA MỀM', CAST(550000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'16', N'Niềng Răng', N'MẮC CÀI KIM

LOẠI', CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'17', N'Niềng Răng', N'MẮC CÀI SỨ', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'18', N'IMPLANT', N'Hàn Quốc', CAST(450000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'19', N'IMPLANT', N'Ý ', CAST(550000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'20', N'IMPLANT', N'Mỹ', CAST(650000 AS Decimal(18, 0)))
INSERT [dbo].[TrongRang] ([MaCL], [PhanLoai], [ChatLieu], [DonGia]) VALUES (N'21', N'IMPLANT', N'Khác', CAST(500000 AS Decimal(18, 0)))
GO
INSERT [dbo].[XN-XQUANG] ([MaKT], [LoaiKT], [Ten], [DonGia]) VALUES (N'01', N'Xét Nghiệm', N'XNMáu', CAST(240000 AS Decimal(18, 0)))
INSERT [dbo].[XN-XQUANG] ([MaKT], [LoaiKT], [Ten], [DonGia]) VALUES (N'02', N'Đo', N'Đo Huyết Áp', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[XN-XQUANG] ([MaKT], [LoaiKT], [Ten], [DonGia]) VALUES (N'03', N'X-Quang', N'X-Quang', CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[XN-XQUANG] ([MaKT], [LoaiKT], [Ten], [DonGia]) VALUES (N'04', N'Siêu Âm', N'Siêu Âm Tim', CAST(250000 AS Decimal(18, 0)))
INSERT [dbo].[XN-XQUANG] ([MaKT], [LoaiKT], [Ten], [DonGia]) VALUES (N'05', N'Đo ', N'Đường Huyết', CAST(110000 AS Decimal(18, 0)))
GO
ALTER TABLE [dbo].[CanLS]  WITH CHECK ADD  CONSTRAINT [FK_CanLS_BaoHanh] FOREIGN KEY([MaBH])
REFERENCES [dbo].[BaoHanh] ([MaBH])
GO
ALTER TABLE [dbo].[CanLS] CHECK CONSTRAINT [FK_CanLS_BaoHanh]
GO
ALTER TABLE [dbo].[CanLS]  WITH CHECK ADD  CONSTRAINT [FK_CanLS_XN-XQUANG] FOREIGN KEY([MaKT])
REFERENCES [dbo].[XN-XQUANG] ([MaKT])
GO
ALTER TABLE [dbo].[CanLS] CHECK CONSTRAINT [FK_CanLS_XN-XQUANG]
GO
ALTER TABLE [dbo].[DieuTri]  WITH CHECK ADD  CONSTRAINT [FK_DieuTri_CanLS] FOREIGN KEY([MaCD])
REFERENCES [dbo].[CanLS] ([MaCD])
GO
ALTER TABLE [dbo].[DieuTri] CHECK CONSTRAINT [FK_DieuTri_CanLS]
GO
ALTER TABLE [dbo].[DieuTri]  WITH CHECK ADD  CONSTRAINT [FK_DieuTri_DungCu-VatTu] FOREIGN KEY([MaDC])
REFERENCES [dbo].[DCVT] ([MaDC])
GO
ALTER TABLE [dbo].[DieuTri] CHECK CONSTRAINT [FK_DieuTri_DungCu-VatTu]
GO
ALTER TABLE [dbo].[DieuTri]  WITH CHECK ADD  CONSTRAINT [FK_DieuTri_Rang] FOREIGN KEY([MaRang])
REFERENCES [dbo].[Rang] ([MaRang])
GO
ALTER TABLE [dbo].[DieuTri] CHECK CONSTRAINT [FK_DieuTri_Rang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_BenhNhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[BenhNhan] ([MaBN])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_BenhNhan]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DieuTri] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DieuTri] ([MaDV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DieuTri]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Thuoc]
GO
USE [master]
GO
ALTER DATABASE [PKNhaKhoa] SET  READ_WRITE 
GO
