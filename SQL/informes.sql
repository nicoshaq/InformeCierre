USE [pruebasxml]
GO
/****** Object:  Table [dbo].[cierre_sucursal]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cierre_sucursal](
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[BANCO] [nvarchar](max) NULL,
	[CIERRE_SUCURSAL] [nvarchar](max) NULL,
	[SUCURSAL] [nvarchar](max) NULL,
	[TIPO_SUCURSAL] [nvarchar](max) NULL,
	[FECHA_REGISTRO] [nvarchar](max) NULL,
	[FECHA_CIERRE] [nvarchar](max) NULL,
	[Id] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Final1MAy5800]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Final1MAy5800](
	[MONEDA] [nvarchar](max) NULL,
	[BANCO] [nvarchar](max) NULL,
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[FECHA_CIERRE] [nvarchar](max) NULL,
	[SUCURSAL] [nvarchar](max) NULL,
	[TIPO_SUCURSAL] [nvarchar](max) NULL,
	[transaccion] [nvarchar](max) NULL,
	[FECHA_PROCESO] [nvarchar](max) NULL,
	[TIPO_OPERACION] [nvarchar](max) NULL,
	[CIERRE_SUCURSAL] [nvarchar](max) NULL,
	[CREDITO] [nvarchar](max) NULL,
	[COMISION_X_TRAN] [nvarchar](max) NULL,
	[COMISION_RECAUD] [nvarchar](max) NULL,
	[FORMULARIO] [nvarchar](max) NULL,
	[CUIT] [nvarchar](max) NULL,
	[USUARIO] [nvarchar](max) NULL,
	[PUESTO] [nvarchar](max) NULL,
	[FECHA_ANULACION] [nvarchar](max) NULL,
	[FORMA_PAGO] [nvarchar](max) NULL,
	[BANCO_CHEQUE] [nvarchar](max) NULL,
	[SUCURSAL_CHEQUE] [nvarchar](max) NULL,
	[NUMERO_CHEQUE] [nvarchar](max) NULL,
	[IMPUESTO] [nvarchar](max) NULL,
	[IVA] [nvarchar](max) NULL,
	[RETENCION_IVA] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Final1Men5800]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Final1Men5800](
	[MONEDA] [nvarchar](max) NULL,
	[BANCO] [nvarchar](max) NULL,
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[FECHA_CIERRE] [nvarchar](max) NULL,
	[SUCURSAL] [nvarchar](max) NULL,
	[TIPO_SUCURSAL] [nvarchar](max) NULL,
	[TRANSACCION] [nvarchar](max) NULL,
	[FECHA_PROCESO] [nvarchar](max) NULL,
	[TIPO_OPERACION] [nvarchar](max) NULL,
	[CIERRE_SUCURSAL] [nvarchar](max) NULL,
	[CREDITO] [nvarchar](max) NULL,
	[COMISION_X_TRAN] [nvarchar](max) NULL,
	[COMISION_RECAUD] [nvarchar](max) NULL,
	[FORMULARIO] [nvarchar](max) NULL,
	[CUIT] [nvarchar](max) NULL,
	[USUARIO] [nvarchar](max) NULL,
	[PUESTO] [nvarchar](max) NULL,
	[FECHA_ANULACION] [nvarchar](max) NULL,
	[FORMA_PAGO] [nvarchar](max) NULL,
	[BANCO_CHEQUE] [nvarchar](max) NULL,
	[SUCURSAL_CHEQUE] [nvarchar](max) NULL,
	[NUMERO_CHEQUE] [nvarchar](max) NULL,
	[IMPUESTO] [nvarchar](max) NULL,
	[IVA] [nvarchar](max) NULL,
	[RETENCION_IVA] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fmlr_cheque]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fmlr_cheque](
	[TRANSACCION_ID] [nvarchar](max) NULL,
	[NUMERO_CHEQUE] [nvarchar](max) NULL,
	[BANCO_CHEQUE] [nvarchar](max) NULL,
	[SUCURSAL_CHEQUE] [nvarchar](max) NULL,
	[COD_POSTAL] [nvarchar](max) NULL,
	[CTA_CTE] [nvarchar](max) NULL,
	[FECHA_ACREDITACION] [nvarchar](max) NULL,
	[Id] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fmlr_obligacion]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fmlr_obligacion](
	[TRANSACCION_ID] [nvarchar](max) NULL,
	[IMPUESTO] [nvarchar](max) NULL,
	[SECSEC] [nvarchar](max) NULL,
	[CONCEPTO] [nvarchar](max) NULL,
	[SUBCONCEPTO] [nvarchar](max) NULL,
	[PERIODO_FISCAL] [nvarchar](max) NULL,
	[ANTICIPO_CUOTA] [nvarchar](max) NULL,
	[MONTO_INGRESADO] [nvarchar](max) NULL,
	[Id] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hola2]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hola2](
	[MONEDA] [nvarchar](max) NULL,
	[BANCO] [nvarchar](max) NULL,
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[FECHA_CIERRE] [nvarchar](max) NULL,
	[SUCURSAL] [nvarchar](max) NULL,
	[TIPO_SUCURSAL] [nvarchar](max) NULL,
	[TRANSACCION] [nvarchar](max) NULL,
	[FECHA_PROCESO] [nvarchar](max) NULL,
	[TIPO_OPERACION] [nvarchar](max) NULL,
	[CIERRE_SUCURSAL] [nvarchar](max) NULL,
	[CREDITO] [nvarchar](max) NULL,
	[COMISION_X_TRAN] [nvarchar](max) NULL,
	[COMISION_RECAUD] [nvarchar](max) NULL,
	[FORMULARIO] [nvarchar](max) NULL,
	[CUIT] [nvarchar](max) NULL,
	[USUARIO] [nvarchar](max) NULL,
	[PUESTO] [nvarchar](max) NULL,
	[FECHA_ANULACION] [nvarchar](max) NULL,
	[FORMA_PAGO] [nvarchar](max) NULL,
	[BANCO_CHEQUE] [nvarchar](max) NULL,
	[SUCURSAL_CHEQUE] [nvarchar](max) NULL,
	[NUMERO_CHEQUE] [nvarchar](max) NULL,
	[IMPUESTO] [nvarchar](max) NULL,
	[IVA] [nvarchar](max) NULL,
	[RETENCION_IVA] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[informe]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[informe](
	[TRANSACCION_ID] [nvarchar](max) NULL,
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[BANCO] [nvarchar](max) NULL,
	[TIPO_SUCURSAL] [nvarchar](max) NULL,
	[SUCURSAL] [nvarchar](max) NULL,
	[TRANSACCION] [nvarchar](max) NULL,
	[CIERRE_SUCURSAL] [nvarchar](max) NULL,
	[FORMA_PAGO] [nvarchar](max) NULL,
	[TIPO_OPERACION] [nvarchar](max) NULL,
	[USUARIO] [nvarchar](max) NULL,
	[PUESTO] [nvarchar](max) NULL,
	[FORMULARIO] [nvarchar](max) NULL,
	[VERSION] [nvarchar](max) NULL,
	[VERIFICADOR] [nvarchar](max) NULL,
	[FECHA_REGISTRO] [nvarchar](max) NULL,
	[FECHA_CIERRE] [nvarchar](max) NULL,
	[FECHA_PROCESO] [nvarchar](max) NULL,
	[CREDITO] [nvarchar](max) NULL,
	[COMISION_X_TRAN] [nvarchar](max) NULL,
	[COMISION_RECAUD] [nvarchar](max) NULL,
	[BANCO_CHEQUE] [nvarchar](max) NULL,
	[SUCURSAL_CHEQUE] [nvarchar](max) NULL,
	[NUMERO_CHEQUE] [nvarchar](max) NULL,
	[CUIT] [nvarchar](max) NULL,
	[ESTABLECIMIENTO] [nvarchar](max) NULL,
	[CANT_ERROR] [nvarchar](max) NULL,
	[CANT_DETALLE] [nvarchar](max) NULL,
	[CANT_CAMPO] [nvarchar](max) NULL,
	[CANT_PAGO] [nvarchar](max) NULL,
	[CANT_OBLIGACION] [nvarchar](max) NULL,
	[CANT_CHEQUE] [nvarchar](max) NULL,
	[TOTAL_MONTO_INGRESADO] [nvarchar](max) NULL,
	[COD_CONTROL] [nvarchar](max) NULL,
	[COD_CONTROL_AFIP] [nvarchar](max) NULL,
	[ENTIDAD_DE_PAGO] [nvarchar](max) NULL,
	[IVA] [nvarchar](max) NULL,
	[RETENCION_IVA] [nvarchar](max) NULL,
	[Id] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[myData]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[myData](
	[Name] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[Id] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nota_obligacion]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nota_obligacion](
	[BANCO] [nvarchar](max) NULL,
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[IMPUESTO] [nvarchar](max) NULL,
	[SECSEC] [nvarchar](max) NULL,
	[TRANSACCION_ID] [nvarchar](max) NULL,
	[CREDITO] [nvarchar](max) NULL,
	[MONEDA] [nvarchar](max) NULL,
	[COMISION_RECAUD] [nvarchar](max) NULL,
	[COMISION_X_TRAN] [nvarchar](max) NULL,
	[IVA] [nvarchar](max) NULL,
	[RETENCION_IVA] [nvarchar](max) NULL,
	[Id] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[obligacion]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[obligacion](
	[TRANSACCION_ID] [nvarchar](max) NULL,
	[IMPUESTO] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TotalesMay5800]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TotalesMay5800](
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[BANCO] [nvarchar](max) NULL,
	[transaccion_ID] [nvarchar](max) NULL,
	[MONEDA] [nvarchar](max) NULL,
	[CREDITO] [nvarchar](max) NULL,
	[COMISION_X_TRAN] [nvarchar](max) NULL,
	[COMISION_RECAUD] [nvarchar](max) NULL,
	[IMPUESTO] [nvarchar](max) NULL,
	[IVA] [nvarchar](max) NULL,
	[RETENCION_IVA] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TotalesMen5800]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TotalesMen5800](
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[BANCO] [nvarchar](max) NULL,
	[transaccion_ID] [nvarchar](max) NULL,
	[MONEDA] [nvarchar](max) NULL,
	[CREDITO] [nvarchar](max) NULL,
	[COMISION_X_TRAN] [nvarchar](max) NULL,
	[COMISION_RECAUD] [nvarchar](max) NULL,
	[IVA] [nvarchar](max) NULL,
	[RETENCION_IVA] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[transaccion]    Script Date: 18-Feb-19 2:31:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaccion](
	[TRANSACCION_ID] [nvarchar](max) NULL,
	[CIERRE_BANCO] [nvarchar](max) NULL,
	[BANCO] [nvarchar](max) NULL,
	[TIPO_SUCURSAL] [nvarchar](max) NULL,
	[SUCURSAL] [nvarchar](max) NULL,
	[TRANSACCION] [nvarchar](max) NULL,
	[CIERRE_SUCURSAL] [nvarchar](max) NULL,
	[FORMA_PAGO] [nvarchar](max) NULL,
	[TIPO_OPERACION] [nvarchar](max) NULL,
	[USUARIO] [nvarchar](max) NULL,
	[PUESTO] [nvarchar](max) NULL,
	[FORMULARIO] [nvarchar](max) NULL,
	[VERSION] [nvarchar](max) NULL,
	[VERIFICADOR] [nvarchar](max) NULL,
	[FECHA_REGISTRO] [nvarchar](max) NULL,
	[FECHA_PROCESO] [nvarchar](max) NULL,
	[CUIT] [nvarchar](max) NULL,
	[ESTABLECIMIENTO] [nvarchar](max) NULL,
	[CANT_ERROR] [nvarchar](max) NULL,
	[CANT_DETALLE] [nvarchar](max) NULL,
	[CANT_CAMPO] [nvarchar](max) NULL,
	[CANT_PAGO] [nvarchar](max) NULL,
	[CANT_OBLIGACION] [nvarchar](max) NULL,
	[CANT_CHEQUE] [nvarchar](max) NULL,
	[TOTAL_MONTO_INGRESADO] [nvarchar](max) NULL,
	[COD_CONTROL] [nvarchar](max) NULL,
	[COD_CONTROL_AFIP] [nvarchar](max) NULL,
	[ENTIDAD_DE_PAGO] [nvarchar](max) NULL,
	[Id] [nvarchar](max) NULL,
	[FECHA_ANULACION] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
