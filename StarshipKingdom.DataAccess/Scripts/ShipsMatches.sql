USE [starshipkingdom]
GO

/****** Object:  Table [dbo].[ShipsMatches]    Script Date: 12.08.2013 16:51:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ShipsMatches](
	[Id] [bigint] NOT NULL IDENTITY(1,1),
	[MatchId] [bigint] NOT NULL,
	[ShipId] [bigint] NOT NULL,
 CONSTRAINT [PK_ShipsMatches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ShipsMatches]  WITH CHECK ADD  CONSTRAINT [FK_ShipsMatches_Matches] FOREIGN KEY([MatchId])
REFERENCES [dbo].[Matches] ([Id])
GO

ALTER TABLE [dbo].[ShipsMatches] CHECK CONSTRAINT [FK_ShipsMatches_Matches]
GO

ALTER TABLE [dbo].[ShipsMatches]  WITH CHECK ADD  CONSTRAINT [FK_ShipsMatches_Ships] FOREIGN KEY([ShipId])
REFERENCES [dbo].[Ships] ([Id])
GO

ALTER TABLE [dbo].[ShipsMatches] CHECK CONSTRAINT [FK_ShipsMatches_Ships]
GO


