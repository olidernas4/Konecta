USE [Ventas_Konect]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 5/01/2023 11:03:07 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Id_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Empleado] [varchar](50) NOT NULL,
	[Fecha_Ingreso] [varchar](50) NOT NULL,
	[Salario_Empleado] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Empleado__740562237AF06486] PRIMARY KEY CLUSTERED 
(
	[Id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Solicitud]    Script Date: 5/01/2023 11:03:07 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Solicitud](
	[Id_Solicitud] [int] IDENTITY(1,1) NOT NULL,
	[Codigo_Solicitud] [varchar](50) NOT NULL,
	[Descripcion_Solicitud] [varchar](50) NOT NULL,
	[Resumen_Solicitud] [varchar](50) NOT NULL,
	[Id_Empleado] [int] NULL,
 CONSTRAINT [PK__Solicitu__8791A50AEA5BC01F] PRIMARY KEY CLUSTERED 
(
	[Id_Solicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre_Empleado], [Fecha_Ingreso], [Salario_Empleado]) VALUES (1, N'Olider', N'2023-01-05', N'2e+006')
INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre_Empleado], [Fecha_Ingreso], [Salario_Empleado]) VALUES (2, N'Oliver Atom', N'2/01/2023 7:21:46 p. m.', N'8000000')
INSERT [dbo].[Empleado] ([Id_Empleado], [Nombre_Empleado], [Fecha_Ingreso], [Salario_Empleado]) VALUES (3, N'Daniel', N'5/01/2023 9:08:23 p. m.', N'4500000')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Solicitud] ON 

INSERT [dbo].[Solicitud] ([Id_Solicitud], [Codigo_Solicitud], [Descripcion_Solicitud], [Resumen_Solicitud], [Id_Empleado]) VALUES (1, N'2424', N'computador negro', N'toshiba', 1)
SET IDENTITY_INSERT [dbo].[Solicitud] OFF
GO
ALTER TABLE [dbo].[Solicitud]  WITH CHECK ADD  CONSTRAINT [FK_Solicitud_Empleado] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleado] ([Id_Empleado])
GO
ALTER TABLE [dbo].[Solicitud] CHECK CONSTRAINT [FK_Solicitud_Empleado]
GO
