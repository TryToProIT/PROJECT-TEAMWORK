-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `web_mysqli`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `id_admin` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `admin_status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tbl_admin`
--

INSERT INTO `tbl_admin` (`id_admin`, `username`, `password`, `admin_status`) VALUES
(1, 'webbanhangdochoitreem', '202cb962ac59075b964b07152d234b70', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tbl_cart`
--

CREATE TABLE `tbl_cart` (
  `id_cart` int(11) NOT NULL,
  `id_khachhang` int(11) NOT NULL,
  `code_cart` varchar(100) NOT NULL,
  `cart_status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tbl_dangki`
--

CREATE TABLE `tbl_dangki` (
  `id_dangki` int(11) NOT NULL,
  `tenkhachhang` varchar(100) NOT NULL,
  `email` varchar(110) NOT NULL,
  `diachi` varchar(110) NOT NULL,
  `matkhau` varchar(110) NOT NULL,
  `dienthoai` varchar(110) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tbl_dangki`
--

INSERT INTO `tbl_dangki` (`id_dangki`, `tenkhachhang`, `email`, `diachi`, `matkhau`, `dienthoai`) VALUES
(6, 'Lê Anh Nhân', 'anhnhan', 'Quynhon', '123', '111'),
(9, 'Nguyễn Hữu Phước', 'huuphuoc', 'QuyNhon', '123', '222'),
(10, 'Nguyễn Hùng Vĩ', 'hungvi', 'Quynhon', '123', '333'),
(12, 'Mai Nguyễn Thành Tiến', 'thanhtien', 'Quynhon', '123', '444');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tbl_danhmuc`
--

CREATE TABLE `tbl_danhmuc` (
  `id_danhmuc` int(11) NOT NULL,
  `tendanhmuc` varchar(100) NOT NULL,
  `thutu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tbl_danhmuc`
--

INSERT INTO `tbl_danhmuc` (`id_danhmuc`, `tendanhmuc`, `thutu`) VALUES
(17, 'Đồ Chơi Mầm Non', 2),
(18, 'Đồ Chơi Thời Trang', 0),
(19, 'Robot', 4),
(21, 'Đồ Chơi Phương Tiện', 4);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tbl_sanpham`
--

CREATE TABLE `tbl_sanpham` (
  `id_sanpham` int(11) NOT NULL,
  `tensp` varchar(100) NOT NULL,
  `masp` varchar(100) NOT NULL,
  `giasp` varchar(1000) NOT NULL,
  `soluongsp` int(11) NOT NULL,
  `hinhanhsp` varchar(100) NOT NULL,
  `noidungsp` text NOT NULL,
  `id_danhmuc` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tbl_sanpham`
--

INSERT INTO `tbl_sanpham` (`id_sanpham`, `tensp`, `masp`, `giasp`, `soluongsp`, `hinhanhsp`, `noidungsp`, `id_danhmuc`) VALUES
(01, 'Đồ Chơi Học Toán Khủng Long Đáng Yêu', 'JCT13', '12.000', 50, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-hoc-toan-khung-long-dang-yeu-fisher-price-mattel-jct13_4.jpg?v=1739777082&width=990', '', 15),
(02, 'Thảm Chơi Piano', 'HRB13', '15.000', 0, 'https://www.mykingdom.com.vn/cdn/shop/files/tham-choi-piano-fisher-price-mattel-hrb13_4.png?v=1735181081&width=990', '', 16),
(03, 'Đồ Chơi Bắt Và Câu Khủng Long 5 Trong 1 Cho Bé PEEK A BOO', 'PAB053', '20.000', 50, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-bat-va-cau-khung-long-5-trong-1-cho-be-peek-a-boo-pab053.png?v=1730968165&width=990', 'Bắt và câu khủng long', 21),
(04, 'Đồ Chơi Capybara Cho Bé', 'HYR54', '17.000', 100, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-capybara-cho-be-fisher-price-mattel-hyr54_1.jpg?v=1739776824&width=990', '', 17),
(05, 'Bộ Đồ Chơi 4 Món Phát Triển Giác Quan Cho Bé Sơ Sinh', 'HRB17', '22.000', 100, 'https://www.mykingdom.com.vn/cdn/shop/files/bo-do-choi-4-mon-phat-trien-giac-quan-cho-be-so-sinh-fisher-price-mattel-hrb17_2.jpg?v=1739782967&width=990', '4 món đồ chơi', 21),
(06, 'Đồng Hồ Điện Thoại Model (Z7) Spiderman IMOO', 'W2302AO', '27.000', 100, 'https://www.mykingdom.com.vn/cdn/shop/files/dong-ho-dien-thoai-model-w2302ao-z7-spiderman-do-imoo-w2302ao_2.png?v=1735552260&width=990', 'Đồng hồ thông minh', 21),
(07, 'Ví Đeo Echo Medium Xanh Lá UPIXEL', 'UBE11', '29.000', 100, 'https://www.mykingdom.com.vn/cdn/shop/files/vi-deo-echo-medium-xanh-la-upixel-ube11-green_2.png?v=1735267241&width=990', 'Ví đeo chéo', 17),
(08, 'Túi Đeo Thời Trang Twinkle Star CLEVERHIPPO', 'CRSTAR2402', '35.000', 58, 'https://www.mykingdom.com.vn/cdn/shop/files/tui-deo-thoi-trang-twinkle-star-cleverhippo-crstar2402-pink.png?v=1731573085&width=990', 'Túi thời trang', 21),
(09, 'Vali Trang Điểm Hồng Sành Điệu MAKE IT REAL', '2508MIRA', '19.000', 21, 'https://www.mykingdom.com.vn/cdn/shop/files/vali-trang-diem-hong-sanh-dieu-make-it-real-20270914-2508mira_4.jpg?v=1730621240&width=990', 'Vali trang điểm', 21),
(10, 'Bộ Dụng Cụ Hình Xăm Nghệ Thuật COOL MAKER', '6071786', '23.000', 123, 'https://www.mykingdom.com.vn/cdn/shop/files/bo-dung-cu-hinh-xam-nghe-thuat-cool-maker-6071786_2.png?v=1732856537&width=990', 'Xăm nghệ thuật', 21),
(11, 'Đồ Chơi Robot Tự Động Thằn Lằn Tinh Nghịch VECTO', 'VT9903E', '31.000', 12938, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-robot-tu-dong-than-lan-tinh-nghich-vecto-vt9903e.jpg?v=1740390398&width=990', 'Robot thằn lằn', 24),
(12, 'Đồ Chơi Robot Chó Tương Lai Điều Khiển Từ Xa VECTO', 'VTG52', '45.000', 10923, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-robot-cho-tuong-lai-dieu-khien-tu-xa-vecto-vtg52_1.png?v=1732116060&width=990', 'Robot chó', 18),
(13, 'Đồ Chơi Robot Vệ Binh Không Gian Điều Khiển Từ Xa (Xanh) VECTO', 'VTG26', '49.000', 124, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-robot-ve-binh-khong-gian-dieu-khien-tu-xa-xanh-vecto-vtg26-gr_2.jpg?v=1732244067&width=990', 'Robot vệ binh', 21),
(14, 'Đồ Chơi Robot Tự Động Vịt Lém Lỉnh VECTO', 'VT9040C', '39.000', 123, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-robot-tu-dong-vit-lem-linh-vecto-vt9040c_1.png?v=1725425130&width=990', 'Robot vịt', 24),
(15, 'Đồ Chơi Robot Tự Động Bọ Hung Giận Dữ VECTO', 'VT9903C', '55.000', 1245, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-robot-tu-dong-bo-hung-gian-du-vecto-vt9903c_1.png?v=1724689655&width=990', 'Robot bọ', 21),
(16, 'Đồ Chơi Trạm Cảnh Sát Siêu Đẳng HOT WHEELS', 'JBM71', '71.000', 545, 'https://www.mykingdom.com.vn/cdn/shop/files/tram-canh-sat-sieu-dang-hot-wheels-jbm71_1.jpg?v=1739263324&width=990', 'Xe đua Hot Wheel', 19),
(17, 'Đồ Chơi Xe Đua F1 1:43 Aston Martin Aramco Cog Team AMR23 (2023) MAISTO', '18-38090', '25093452', 125, 'https://www.mykingdom.com.vn/cdn/shop/files/xe-dua-f1-1-43-aston-martin-aramco-cog-team-amr23-2023-maisto-14-18-38090_4.jpg?v=1741764124&width=990', 'Xe đua F1', 21),
(18, 'Đồ Chơi Xe Mô Hình Mô Tô Tỉ Lệ 1:12 2023 KTM 690 SMC R MAISTO', 'MT31101', '79.000', 1643, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-xe-mo-hinh-mo-to-ti-le-1-12-2023-ktm-690-smc-r-maisto-23094-mt31101_1.jpg?v=1741763406&width=990', '', 17),
(19, 'Đồ Chơi Mô Hình Tỉ Lệ 1:43 Xe Ferrari R & P-LaFerrari Đen MAISTO', '18-36100', '84.000', 126, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-mo-hinh-ti-le-1-43-xe-ferrari-r-p-laferrari-den-maisto-31137bla-18-36100_2.jpg?v=1741763643&width=990', 'Xe đua mô hình', 21),
(20, 'Đồ Chơi Mô Hình Máy Bay F-35 Lightning II MAISTO', 'MT15088', '89.000', 643, 'https://www.mykingdom.com.vn/cdn/shop/files/do-choi-mo-hinh-may-bay-f-35-lightning-ii-maisto-02044-mt15088_2_db8bf613-631b-4d64-aad9-10a7b6a5ef5d.jpg?v=1741767748&width=990', 'Máy bay mô hình', 24),

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`id_admin`);

--
-- Chỉ mục cho bảng `tbl_cart`
--
ALTER TABLE `tbl_cart`
  ADD PRIMARY KEY (`id_cart`);

--
-- Chỉ mục cho bảng `tbl_dangki`
--
ALTER TABLE `tbl_dangki`
  ADD PRIMARY KEY (`id_dangki`);

--
-- Chỉ mục cho bảng `tbl_danhmuc`
--
ALTER TABLE `tbl_danhmuc`
  ADD PRIMARY KEY (`id_danhmuc`);

--
-- Chỉ mục cho bảng `tbl_sanpham`
--
ALTER TABLE `tbl_sanpham`
  ADD PRIMARY KEY (`id_sanpham`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT cho bảng `tbl_cart`
--
ALTER TABLE `tbl_cart`
  MODIFY `id_cart` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `tbl_dangki`
--
ALTER TABLE `tbl_dangki`
  MODIFY `id_dangki` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT cho bảng `tbl_danhmuc`
--
ALTER TABLE `tbl_danhmuc`
  MODIFY `id_danhmuc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT cho bảng `tbl_sanpham`
--
ALTER TABLE `tbl_sanpham`
  MODIFY `id_sanpham` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
