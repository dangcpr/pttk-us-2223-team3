CREATE DATABASE QUANLYKHACHSAN

DROP TABLE IF EXISTS TAI_KHOAN
GO
CREATE TABLE TAI_KHOAN (
	ID int NOT NULL IDENTITY,
	USERNAME NVARCHAR(255) NOT NULL,
	PASSWORD NVARCHAR(255) NOT NULL,
	ROLE NVARCHAR(255) NOT NULL
);
GO
ALTER TABLE TAI_KHOAN ADD CONSTRAINT PK_TAI_KHOAN PRIMARY KEY (ID);
GO
INSERT INTO TAI_KHOAN (USERNAME, PASSWORD, ROLE) VALUES ('bellman1', '123', N'Bellman');
INSERT INTO TAI_KHOAN (USERNAME, PASSWORD, ROLE) VALUES ('khachhang1', '123', N'Kh�ch h�ng');
INSERT INTO TAI_KHOAN (USERNAME, PASSWORD, ROLE) VALUES ('letan1', '123', N'L? t�n');
