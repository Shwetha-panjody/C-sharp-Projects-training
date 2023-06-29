USE [studentmgtsys]
GO

/****** Object:  Table [dbo].[Student2]    Script Date: 29-06-2023 15:55:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student2](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[regno] [varchar](50) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[class] [int] NOT NULL,
	[science] [decimal](18, 0) NOT NULL,
	[math] [decimal](18, 0) NOT NULL,
	[computer] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Student2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


