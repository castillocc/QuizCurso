USE [Quiz]
GO
BEGIN TRAN
INSERT [dbo].[Estudiante] ([Id], [Nombre], [Apellido], [Telefono], [Correo]) VALUES (1, N'Cristian', N'Castillo', 0, N'a@algo.com')
INSERT [dbo].[Estudiante] ([Id], [Nombre], [Apellido], [Telefono], [Correo]) VALUES (2, N'Alberto', N'Castillo', 888888888, N'a@aswq.com')
INSERT [dbo].[Estudiante] ([Id], [Nombre], [Apellido], [Telefono], [Correo]) VALUES (3, N'sdasd', N'asdasd', 123123, N'qw@qwq.com')
COMMIT TRAN 
GO

