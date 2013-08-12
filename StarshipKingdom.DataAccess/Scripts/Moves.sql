USE [starshipkingdom]
GO

/****** Object:  Table [dbo].[Moves]    Script Date: 12.08.2013 16:51:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Moves](
	[Id] [bigint] NOT NULL IDENTITY(1,1),
	[MoveNumber] [int] NOT NULL,
	[MatchId] [bigint] NOT NULL,
 CONSTRAINT [PK_Moves] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Moves]  WITH CHECK ADD  CONSTRAINT [FK_Moves_Matches] FOREIGN KEY([MatchId])
REFERENCES [dbo].[Matches] ([Id])
GO

ALTER TABLE [dbo].[Moves] CHECK CONSTRAINT [FK_Moves_Matches]
GO


