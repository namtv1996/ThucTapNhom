create proc personnel_search
	@key nvarchar(50)
as begin
	select * from NhanVien where Manv like N'%'+@key+'%' or HoTen like N'%'+@key+'%'
	or QueQuan like N'%'+@key+'%' or GioiTinh like N'%'+@key+'%'
	or DanToc like N'%'+@key+'%' or MaPB like N'%'+@key+'%' or matdhv like N'%'+@key+'%'
	or bacluong like N'%'+@key+'%' or NgaySinh like N'%'+@key+'%'
end

alter table NhanVien alter column GioiTinh nvarchar(20)
alter table NhanVien alter column ngaysinh datetime
alter table NhanVien alter column quequan nvarchar(100)