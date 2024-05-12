CREATE TABLE [dbo].[TaiKhoan] (
    [tenTaiKhoan] NVARCHAR (50) NOT NULL,
    [matKhau]     NVARCHAR (50) NOT NULL,
    [gmail]       NVARCHAR (50) NULL,
    [loai]        NCHAR (10)    NULL,
    [maTaiKhoan]  int  identity NOT NULL, 
    CONSTRAINT [PK_TaiKhoan] PRIMARY KEY ([maTaiKhoan])
);

