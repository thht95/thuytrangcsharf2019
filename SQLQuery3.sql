create database qldiemhocsinh
use qldiemhocsinh
go

create table NHOMMONHOC
(
	MaNMH int IDENTITY primary key,
	TenNMH nvarchar(50),
);

insert into NHOMMONHOC values(N'Nhóm Toán')
insert into NHOMMONHOC values(N'Nhóm Văn')
insert into NHOMMONHOC values(N'Nhóm Ngoại Ngữ')
insert into NHOMMONHOC values(N'Nhóm Khoa Học Xã Hội')
insert into NHOMMONHOC values(N'Nhóm Khoa Học Tự Nhiên')
insert into NHOMMONHOC values(N'Nhóm Công Nghệ và Nghệ Thuật')
insert into NHOMMONHOC values(N'Nhóm Giáo dục thể chất')

create table MONHOC
(
	MaMH int IDENTITY primary key,
	MaNMH int,
	TenMH nvarchar(50),
	SoTiet int,
	constraint fk_MaNMH foreign key (MaNMH) references NHOMMONHOC(MaNMH)on delete no action on update no action,
);

INSERT INTO MONHOC VALUES( '1',N'Toán Học',	90)
INSERT INTO MONHOC VALUES( '5',N'Vật Lý',		60)
INSERT INTO MONHOC VALUES( '5',N'Hóa Học',		60)
INSERT INTO MONHOC VALUES( '5',N'Sinh Học',	60)
INSERT INTO MONHOC VALUES( '2',N'Ngữ Văn',		90)
INSERT INTO MONHOC VALUES( '4',N'Lịch sử',		45)
INSERT INTO MONHOC VALUES( '4',N'Địa Lý',		45)
INSERT INTO MONHOC VALUES( '3',N'Anh Văn',		45)
INSERT INTO MONHOC VALUES( '4',N'GD Công Dân',	30)
INSERT INTO MONHOC VALUES( '6',N'Tin Học',		30)
INSERT INTO MONHOC VALUES( '7',N'Thể Dục',		30)
INSERT INTO MONHOC VALUES( '6',N'Công Nghệ',	30)

create table LOPHOC
(
	Malophoc int IDENTITY primary key,
	Tenlophoc nvarchar(20),
	Khoilop nvarchar(20),
	SiSo int,

);

INSERT INTO LOPHOC VALUES('6A1',N'KHỐI 6' , 35)
INSERT INTO LOPHOC VALUES('6A2',N'KHỐI 6' , 36)
INSERT INTO LOPHOC VALUES('6A3',N'KHỐI 6' , 34)
INSERT INTO LOPHOC VALUES('7A1',N'KHỐI 7' , 37)
INSERT INTO LOPHOC VALUES('7A2',N'KHỐI 7' , 38)
INSERT INTO LOPHOC VALUES('8A1',N'KHỐI 8' , 39)
INSERT INTO LOPHOC VALUES('8A2',N'KHỐI 8' , 39)
INSERT INTO LOPHOC VALUES('9A1',N'KHỐI 9' , 39)
INSERT INTO LOPHOC VALUES('9A2',N'KHỐI 9' , 39)

create table LOAIDIEM
(	
	Maloaidiem int IDENTITY primary key,
	Tenloai nvarchar(20),
	Hocky int,
	Heso int,	
);

INSERT INTO LOAIDIEM VALUES(N'Kiểm tra miệng',	1, 1)
INSERT INTO LOAIDIEM VALUES(N'Kiểm tra 15 phút',1, 1)
INSERT INTO LOAIDIEM VALUES(N'Kiểm tra 1 tiết', 1, 2)
INSERT INTO LOAIDIEM VALUES(N'Thi học kỳ',		1, 3)

create table HOCSINH
(
	Mahocsinh int IDENTITY primary key,
	Tenhocsinh nvarchar(50),
	Gioitinh bit,
	Ngaysinh date,
	Diachi nvarchar(50),
	Dantoc nvarchar(20),
	Malophoc int ,
	constraint fk_Malophoc foreign key (Malophoc) references LOPHOC(Malophoc)on delete no action on update no action,
);

INSERT INTO HOCSINH VALUES(N'Nguyễn Hà An',			'0','01/02/1992',N'Ninh Bình',  'Kinh','1')
INSERT INTO HOCSINH VALUES(N'Nguyễn Ngọc An',		'0','01/02/1993',N'Hà Nội',		'Kinh','2')
INSERT INTO HOCSINH VALUES(N'Lê Hoàng Anh',			'0','04/15/1992',N'Bắc Giang',	'Kinh','3')
INSERT INTO HOCSINH VALUES(N'Huỳnh Thiên Chi',		'0','01/02/1991',N'Thanh Hóa',	'Kinh','4')
INSERT INTO HOCSINH VALUES(N'Lý Ngọc Duy',			'0','01/02/1992',N'Thái Bình',	'Kinh','5')
INSERT INTO HOCSINH VALUES(N'Huỳnh Ngọc Diệp',		'1','01/02/1992',N'Ninh Bình',	'Kinh','6')
INSERT INTO HOCSINH VALUES(N'Trần Thị Huệ',			'1','04/15/1994',N'Lạng Sơn',	'Kinh','7')
INSERT INTO HOCSINH VALUES(N'Nguyễn Thanh Huy',		'0','01/02/1991',N'Thái Bình',	'Kinh','8')
INSERT INTO HOCSINH VALUES(N'Trần Phúc Lâm',		'0','01/02/1992',N'Hà Nội',		'Kinh','9')
INSERT INTO HOCSINH VALUES(N'Trương Thị Nga',		'1','01/02/1992',N'Bắc Giang',	'Kinh','1')
INSERT INTO HOCSINH VALUES(N'Nguyên Thị Nga',		'1','04/15/1992',N'Hà Nội',		'Kinh','2')
INSERT INTO HOCSINH VALUES(N'Trần Thị Hồng Nghi',	'1','01/02/1991',N'Nam Định',	'Kinh','3')
INSERT INTO HOCSINH VALUES(N'Huỳnh Thị My Ngọc',	'1','01/02/1992',N'Ninh Bình',	'Kinh','4')
INSERT INTO HOCSINH VALUES(N'Trần Thị Mỹ Nhân',		'1','01/02/1993',N'Thanh Hóa',	'Kinh','5')
INSERT INTO HOCSINH VALUES(N'Trương Ngọc Nhung',    '1','04/15/1992',N'Bắc Giang',	'Kinh','6')
INSERT INTO HOCSINH VALUES(N'Hà Quốc Phưong',		'0','01/02/1991',N'Thái Bình',	'Kinh','7')
INSERT INTO HOCSINH VALUES(N'Lý Ngọc Phương',		'1','01/02/1992',N'Hà Nội',		'Kinh','8')
INSERT INTO HOCSINH VALUES(N'Nguyễn Thị Phương',	'1','01/02/1994',N'Lạng Sơn',	'Kinh','9')
INSERT INTO HOCSINH VALUES(N'Nguyễn Phú Quốc',		'0','04/15/1992',N'Bắc Giang',	'Kinh','1')
INSERT INTO HOCSINH VALUES(N'Võ Thiên Quốc',		'0','01/02/1991',N'Hà Nội',		'Kinh','2')
INSERT INTO HOCSINH VALUES(N'Trần Văn Khang',		'0','01/02/1992',N'Hà Nam',		'Kinh','3')
INSERT INTO HOCSINH VALUES(N'Vũ Hữu Tâm',			'0','01/02/1992',N'Bắc Giang',	'Kinh','4')
INSERT INTO HOCSINH VALUES(N'Lê Minh Tâm',			'0','04/15/1993',N'Thái Bình',	'Kinh','5')
INSERT INTO HOCSINH VALUES(N'Nguyễn Đức Tâm',		'0','01/02/1991',N'Lạng Sơn',	'Kinh','6')
INSERT INTO HOCSINH VALUES('Nguyễn Thanh Tâm',		'0','01/02/1992',N'Thanh Hóa',	'Kinh','7')
INSERT INTO HOCSINH VALUES(N'Trần Ngọc Minh Tân',	'0','01/02/1992',N'Ninh Bình',	'Kinh','8')
INSERT INTO HOCSINH VALUES(N'Dương Kim Thanh',		'1','04/15/1992',N'Hà Nội',		'Kinh','9')
INSERT INTO HOCSINH VALUES(N'Nguyễn Sĩ Thanh',		'0','01/02/1994',N'Nam Định',	'Kinh','1')
INSERT INTO HOCSINH VALUES(N'Đỗ Thị Bích Thảo',		'1','01/02/1992',N'Hà Nội',		'Kinh','2')
INSERT INTO HOCSINH VALUES(N'Hà Minh Thiên',		'0','01/02/1992',N'Bắc Giang',	'Kinh','3')
INSERT INTO HOCSINH VALUES(N'Nguyễn Thị Anh Thư',	'1','04/15/1992',N'Hà Nội',		'Kinh','4')
INSERT INTO HOCSINH VALUES(N'Phạm Nguyên Trinh',	'1','01/02/1991',N'Hà Nam',		'Kinh','5')
INSERT INTO HOCSINH VALUES(N'Võ Ngọc Trinh',		'1','01/02/1994',N'Nam Định',	'Kinh','6')
INSERT INTO HOCSINH VALUES(N'Nguyễn Minh Trí',      '0','01/02/1993',N'Hà Nam',		'Kinh','7')
INSERT INTO HOCSINH VALUES(N'Đỗ Xuân Trinh',		'0','04/15/1992',N'Hà Nam',		'Kinh','8')
INSERT INTO HOCSINH VALUES(N'Nguyễn Hiếu Trung',	'0','01/02/1991',N'Hà Nội',		'Kinh','9')
INSERT INTO HOCSINH VALUES(N'Trần Thanh Trâm',		'1','01/02/1993',N'Thanh Hóa',	'Kinh','1')


create table NHAPDIEM
(
	MaDiem int IDENTITY primary key,
	Mahocsinh int,
	Mamonhoc int,
	Maloaidiem int,
	Diem float,
	constraint fk_Mahocsinh foreign key (Mahocsinh) references HOCSINH(Mahocsinh)on delete no action on update no action,
	constraint fk_Mamonhoc foreign key (Mamonhoc) references MONHOC(MaMH)on delete no action on update no action,
	constraint fk_Maloaidiem foreign key (Maloaidiem) references LOAIDIEM(Maloaidiem)on delete no action on update no action,
);



INSERT INTO NHAPDIEM VALUES('01', '1'	,'1',6)
INSERT INTO NHAPDIEM VALUES('02', '2'	,'2',7)
INSERT INTO NHAPDIEM VALUES('03', '3'	,'3',7)
INSERT INTO NHAPDIEM VALUES('04', '4'	,'4',8)
INSERT INTO NHAPDIEM VALUES('05', '5'	,'1',5)
INSERT INTO NHAPDIEM VALUES('06', '6'	,'2',6)
INSERT INTO NHAPDIEM VALUES('07', '7'	,'3',6)
INSERT INTO NHAPDIEM VALUES('08', '8'	,'4',6)
INSERT INTO NHAPDIEM VALUES('09', '9'	,'1',0)
INSERT INTO NHAPDIEM VALUES('10', '10'	,'2',7)
INSERT INTO NHAPDIEM VALUES('11', '11'	,'3',5)
INSERT INTO NHAPDIEM VALUES('12', '12'	,'4',4)
INSERT INTO NHAPDIEM VALUES('13', '1'	,'1',6)
INSERT INTO NHAPDIEM VALUES('14', '2'	,'2',1)
INSERT INTO NHAPDIEM VALUES('15', '3'	,'3',7)
INSERT INTO NHAPDIEM VALUES('16', '4'	,'4',6)
INSERT INTO NHAPDIEM VALUES('17', '5'	,'1',1)
INSERT INTO NHAPDIEM VALUES('18', '6'	,'2',6)
INSERT INTO NHAPDIEM VALUES('19', '7'	,'3',5)
INSERT INTO NHAPDIEM VALUES('20', '8'	,'4',6)
INSERT INTO NHAPDIEM VALUES('21', '9'	,'1',6)
INSERT INTO NHAPDIEM VALUES('22', '10'	,'2',9)
INSERT INTO NHAPDIEM VALUES('23', '11'	,'3',6)
INSERT INTO NHAPDIEM VALUES('24', '12'	,'4',8)
INSERT INTO NHAPDIEM VALUES('25', '1'	,'1',6)
INSERT INTO NHAPDIEM VALUES('26', '2'	,'2',6)
INSERT INTO NHAPDIEM VALUES('27', '3'	,'3',9)
INSERT INTO NHAPDIEM VALUES('28', '4'	,'4',6)
INSERT INTO NHAPDIEM VALUES('29', '5'	,'1',8)
INSERT INTO NHAPDIEM VALUES('30', '6'	,'2',4)
INSERT INTO NHAPDIEM VALUES('31', '7'	,'3',7)
INSERT INTO NHAPDIEM VALUES('32', '8'	,'4',7)
INSERT INTO NHAPDIEM VALUES('33', '9'	,'1',8)
INSERT INTO NHAPDIEM VALUES('34', '10'	,'2',5)
INSERT INTO NHAPDIEM VALUES('35', '11'	,'3',6)
INSERT INTO NHAPDIEM VALUES('36', '12'	,'4',6)
INSERT INTO NHAPDIEM VALUES('37', '1'	,'1',6)


----------------------------------NHÓM MÔN HỌC--------------------------------------------------------
-------------------KIỂM TRA MÃ --------------------------------
create proc kiemtra_NMH
@ma varchar(20)
as
select*from [dbo].[CHITIETDIEM] where [MaDiem]=@ma	

-------------------lấy thông tin nhóm môn học --------------------------------		

create proc select_NMH
as
select*from [dbo].[NHOMMONHOC]
-------------------INSERT NMH-----------------------------------
create proc insert_NMH
@ma int,
@ten varchar(20)

as
insert into [dbo].[NHOMMONHOC] values(@ten)

------------------update NMH-----------------------------------		
create proc update_NMH
@ma int,
@ten varchar(20)
as
update [dbo].[NHOMMONHOC] set  [TenNMH]=@ten where [MaNMH]=@ma 		 

------------------delete NMH-----------------------------------	
create proc delete_NMH
@manmh int
as
delete from [dbo].[NHOMMONHOC] where [MaNMH]=@manmh


----------------------------------LỚP HỌC--------------------------------------------------------
-------------------KIỂM TRA MÃ --------------------------------
create proc kiemtra_LH
@ma varchar(20)
as
select*from [dbo].[LOPHOC] where [Malophoc]=@ma	

-------------------lấy thông tin lớp học --------------------------------		

create proc select_LH
as
select*from [dbo].[LOPHOC]
-------------------INSERT LH-----------------------------------
create proc insert_LH

@tenlop varchar(20),
@khoilop nvarchar(20),
@siso int

as
insert into [dbo].[LOPHOC] values(@tenlop,@khoilop,@siso)

------------------update LH-----------------------------------		
create proc update_LH
@tenlop varchar(20),
@khoilop nvarchar(20),
@siso int
as
update [dbo].[LOPHOC] set  [Tenlophoc]=@tenlop,[Khoilop] =@khoilop, [SiSo]= @siso where [Tenlophoc]=@tenlop 		 

------------------delete LH-----------------------------------	
create proc delete_LH
@tenlop varchar(20)
as
delete from [dbo].[LOPHOC] where [Tenlophoc]=@tenlop



-----------------------------LOẠI ĐIỂM------------------------------------------------------------
-------------------KIỂM TRA MÃ --------------------------------
create proc kiemtra_LD
@ma int
as
select*from [dbo].[LOAIDIEM] where [Maloaidiem]=@ma	

-------------------lấy thông tin loại điểm --------------------------------		

create proc select_LD
as
select*from [dbo].[LOAIDIEM]
-------------------INSERT Loại điểm-----------------------------------
create proc insert_LD
@tenloai varchar(20),
@hocky int,
@heso int

as
insert into [dbo].[LOAIDIEM] values(@tenloai,@hocky,@heso)

------------------update loại điểm-----------------------------------		
create proc update_LD

@tenloai varchar(20),
@hocky int,
@heso int
as
update [dbo].[LOAIDIEM] set  [Tenloai]=@tenloai, [Hocky]=@hocky, [Heso]= @heso where [Tenloai]=@tenloai	 

------------------delete  loại điểm-----------------------------------	
create proc delete_LD
@tenloai varchar(20)
as
delete from [dbo].[LOAIDIEM] where [Tenloai]=@tenloai

-----------------------------NHẬP ĐIỂM-----------------------------------------------------------------------

-------------------lấy thông tin cbo hoc sinh --------------------------------	

create proc cbo_HS
as
select [Mahocsinh],[Tenhocsinh] from [dbo].[HOCSINH]
-------------------lấy thông tin cbo môn học --------------------------------	

create proc cbo_MH
as
select [MaMH],[TenMH] from [dbo].[MONHOC]

-------------------lấy thông tin cbo loại điểm --------------------------------	

create proc cbo_LD
as
select [Maloaidiem],[Tenloai] from [dbo].[LOAIDIEM]
-------------------KIỂM TRA MÃ --------------------------------
create proc kiemtra_ND
@ma int
as
select*from [dbo].[NHAPDIEM] where [MaDiem]=@ma	

-------------------lấy thông tin Nhập điểm --------------------------------		

create proc select_ND
as
select [MaDiem],[Tenhocsinh],[TenMH],[Tenloai],[Diem] from [dbo].[NHAPDIEM] inner join [dbo].[HOCSINH] on [dbo].[HOCSINH].Mahocsinh=[dbo].[NHAPDIEM].Mahocsinh
inner join  [dbo].[MONHOC] on [dbo].[MONHOC].MaMH=[dbo].[NHAPDIEM].Mamonhoc
inner join [dbo].[LOAIDIEM] on [dbo].[LOAIDIEM].Maloaidiem=[dbo].[NHAPDIEM].Maloaidiem
-------------------INSERT nhập điểm-----------------------------------
create proc insert_ND
@madiem int,
@mahs int,
@mamon int,
@maloai int,
@diem float

as
insert into [dbo].[NHAPDIEM] values(@mahs,@maloai,@mamon,@diem)

------------------update nhập điểm-----------------------------------		
create proc update_ND
@madiem int,
@mahs int,
@mamon int,
@maloai int,
@diem float
as
update [dbo].[NHAPDIEM] set  [Mahocsinh]=@mahs, [Mamonhoc]=@mamon, [Maloaidiem]= @maloai , [Diem]=@diem where [MaDiem] =@madiem		 

------------------delete  nhập điểm-----------------------------------	
create proc delete_ND
@madiem int
as
delete from [dbo].[NHAPDIEM] where [MaDiem]=@madiem


---------------------------------------------------------------
-----------------------------MÔN HỌC----------------------------------------------------------------------

-------------------lấy thông tin cbo NMH --------------------------------	

create proc cbo_NMH
as
select [MaNMH],[TenNMH] from [dbo].[NHOMMONHOC]
-------------------KIỂM TRA MÃ --------------------------------
create proc kiemtra_MH
@ma int
as
select*from [dbo].[MONHOC] where [MaMH]=@ma	

-------------------lấy thông tin môn học--------------------------------		

create proc select_MH
as
select [MaMH],[TenMH],[TenNMH],[SoTiet]from [dbo].[MONHOC] inner join [dbo].[NHOMMONHOC] 
on [dbo].[MONHOC].[MaNMH]=[dbo].[NHOMMONHOC].[MaNMH]

-------------------INSERT môn học-----------------------------------
create proc insert_MH

@tenmon nvarchar(50),
@sotiet int,
@manmh int
as
insert into [dbo].[MONHOC] values(@manmh,@tenmon,@sotiet)

------------------update môn học-----------------------------------		
create proc update_MH
--@mamon int,
@tenmon nvarchar(50),
@sotiet int,
@manmh int
as
update [dbo].[MONHOC] set  [TenMH]=@tenmon, [SoTiet]= @sotiet, [MaNMH]=@manmh where [TenMH]=@tenmon

------------------delete  môn học-----------------------------------	
create proc delete_MH
@tenmon nvarchar(50)
as
delete from [dbo].[MONHOC] where [TenMH]=@tenmon


-----------------------------HỌC SINH------------------------------------------------------------
-------------------KIỂM TRA MÃ --------------------------------
create proc kiemtra_HS
@ma int
as
select*from [dbo].[HOCSINH] where [Mahocsinh]=@ma	
-------------------lấy thông tin cbo lớp học --------------------------------	

create proc cbo_LH
as
select [Malophoc],[Tenlophoc] from [dbo].[LOPHOC]
-------------------lấy thông tin hocsinh --------------------------------		

create proc select_HS
as
select [Mahocsinh],[Tenhocsinh],case when [Gioitinh] = 1 then N'Nam' else N'Nữ' end as 'Gioitinh',[Ngaysinh],[Diachi],[Dantoc],[Tenlophoc]from [dbo].[HOCSINH] inner join [dbo].[LOPHOC]
on [dbo].[HOCSINH].[Malophoc]=[dbo].[LOPHOC].[Malophoc]
------------------delete  hoc sinh -----------------------------------	
create proc delete_HS
@tenhs nvarchar(50)
as
delete from [dbo].[HOCSINH] where [Tenhocsinh]=@tenhs


---------------------------Insert học sinh----------------------
								  
create proc insert_HS
@ten nvarchar(50),
@gt nvarchar(3),
@ns date,
@dc nvarchar(50),
@dt nvarchar (50),
@malop int
as
insert into [dbo].[HOCSINH] values (@ten,@gt,@ns,@dc,@dt,@malop)
GO	

-----------------------------------UPDATE-HS------------------------------------------
create proc update_HS
@ten nvarchar(50),
@gt nvarchar(3),
@ns date,
@dc nvarchar(50),
@dt nvarchar (50),
@malop int
as
update [dbo].[HOCSINH] set [Tenhocsinh]=@ten ,[Gioitinh]=@gt, [Ngaysinh]=@ns,[Diachi]=@dc,[Dantoc]=@dt,[Malophoc]=@malop
where [Tenhocsinh]=@ten


----------------------------------------TIM KIẾM----------------------
create view TK_HS
as
select [Tenhocsinh],[Tenloai],[Tenlophoc],[TenMH],[Diem]
from (((([dbo].[HOCSINH] inner join [dbo].[LOPHOC] on [dbo].[HOCSINH].[Malophoc]=[dbo].[LOPHOC].[Malophoc])
inner join [dbo].[NHAPDIEM] on [dbo].[NHAPDIEM].[Mahocsinh]=[dbo].[HOCSINH].[Mahocsinh])
inner join [dbo].[MONHOC] on [dbo].[MONHOC].[MaMH]=[dbo].[NHAPDIEM].[Mamonhoc])
inner join [dbo].[LOAIDIEM] on [dbo].[NHAPDIEM].[Maloaidiem]=[dbo].[LOAIDIEM].[Maloaidiem])

select*from TK_HS where 1=1

create proc pc_theolop
as
SELECT        HOCSINH.Tenhocsinh, HOCSINH.Gioitinh, HOCSINH.Diachi, LOPHOC.Tenlophoc, LOPHOC.Khoilop, LOPHOC.SiSo, LOPHOC.Malophoc, HOCSINH.Ngaysinh
FROM            HOCSINH INNER JOIN
                         LOPHOC ON HOCSINH.Malophoc = LOPHOC.Malophoc


create view vw_hstheolop
as
SELECT        HOCSINH.Tenhocsinh, HOCSINH.Gioitinh, HOCSINH.Diachi, LOPHOC.Tenlophoc, LOPHOC.Khoilop, LOPHOC.SiSo, LOPHOC.Malophoc, HOCSINH.Ngaysinh
FROM            HOCSINH INNER JOIN
                         LOPHOC ON HOCSINH.Malophoc = LOPHOC.Malophoc

