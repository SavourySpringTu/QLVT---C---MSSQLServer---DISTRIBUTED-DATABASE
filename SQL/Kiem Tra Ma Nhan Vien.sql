USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaVT]    Script Date: 7/31/2023 3:14:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_KiemTraMaVT]
@MA NCHAR(4)
AS
BEGIN
	IF EXISTS(SELECT MAVT FROM Vattu WHERE MAVT= @MA)
		RETURN 1;
	RETURN 0;
END