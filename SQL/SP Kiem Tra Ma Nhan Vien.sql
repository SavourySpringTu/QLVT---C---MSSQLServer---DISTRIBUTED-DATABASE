USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_TraCuu_KiemTraMaNhanVien]    Script Date: 7/31/2023 3:19:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[sp_TraCuu_KiemTraMaNhanVien]
	@MANHANVIEN int
as
begin
	if exists( select * from LINK2.QLVT_DATHANG.DBO.NHANVIEN as NV where NV.MANV = @MANHANVIEN)
		return 1;
	return 0; 
end