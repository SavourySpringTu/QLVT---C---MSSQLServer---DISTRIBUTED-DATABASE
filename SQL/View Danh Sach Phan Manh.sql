CREATE VIEW view_DanhSachPhanManh
AS
	SELECT TENCN=PUBS.name, TENSERVER=subscriber_server
	 FROM sysmergepublications  PUBS, sysmergesubscriptions SUBS
 	WHERE PUBS.pubid = SUBS.pubid AND  publisher <> subscriber_server
GO