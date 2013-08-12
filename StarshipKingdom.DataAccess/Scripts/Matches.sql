USE [starshipkingdom]
GO

/****** Object:  Table [dbo].[Matches]    Script Date: 12.08.2013 16:51:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Matches](
	[Id] [bigint] NOT NULL IDENTITY(1,1),
	[CreatorId] [bigint] NOT NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
 CONSTRAINT [PK_Matches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Matches]  WITH CHECK ADD  CONSTRAINT [FK_Matches_Ships] FOREIGN KEY([CreatorId])
REFERENCES [dbo].[Ships] ([Id])
GO

ALTER TABLE [dbo].[Matches] CHECK CONSTRAINT [FK_Matches_Ships]
GO


