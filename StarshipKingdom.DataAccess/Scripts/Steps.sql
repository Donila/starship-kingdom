USE [starshipkingdom]
GO

/****** Object:  Table [dbo].[Steps]    Script Date: 12.08.2013 16:51:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Steps](
	[Id] [bigint] NOT NULL IDENTITY(1,1),
	[MoveId] [bigint] NOT NULL,
	[ShipId] [bigint] NOT NULL,
	[HitCode] [bit] NOT NULL,
 CONSTRAINT [PK_Steps] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Steps]  WITH CHECK ADD  CONSTRAINT [FK_Steps_Moves] FOREIGN KEY([MoveId])
REFERENCES [dbo].[Moves] ([Id])
GO

ALTER TABLE [dbo].[Steps] CHECK CONSTRAINT [FK_Steps_Moves]
GO

ALTER TABLE [dbo].[Steps]  WITH CHECK ADD  CONSTRAINT [FK_Steps_Ships] FOREIGN KEY([ShipId])
REFERENCES [dbo].[Ships] ([Id])
GO

ALTER TABLE [dbo].[Steps] CHECK CONSTRAINT [FK_Steps_Ships]
GO


