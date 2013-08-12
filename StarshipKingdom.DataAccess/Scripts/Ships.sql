USE [starshipkingdom]
GO

/****** Object:  Table [dbo].[Ships]    Script Date: 12.08.2013 16:51:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ships](
	[Id] [bigint] NOT NULL IDENTITY(1,1),
	[Name] [nvarchar](50) NOT NULL,
	[Attack] [int] NOT NULL,
	[Defence] [int] NOT NULL,
	[Mobility] [int] NOT NULL,
	[Accuracy] [int] NOT NULL,
	[Experience] [int] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[MaxHp] [int] NOT NULL,
	[CurrentHp] [int] NOT NULL,
 CONSTRAINT [PK_Ships] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Ships] ADD  CONSTRAINT [DF_Ships_Attack]  DEFAULT ((1)) FOR [Attack]
GO

ALTER TABLE [dbo].[Ships] ADD  CONSTRAINT [DF_Ships_Defence]  DEFAULT ((1)) FOR [Defence]
GO

ALTER TABLE [dbo].[Ships] ADD  CONSTRAINT [DF_Ships_Mobility]  DEFAULT ((1)) FOR [Mobility]
GO

ALTER TABLE [dbo].[Ships] ADD  CONSTRAINT [DF_Ships_Experience]  DEFAULT ((0)) FOR [Experience]
GO

ALTER TABLE [dbo].[Ships] ADD  CONSTRAINT [DF_Ships_MaxHp]  DEFAULT ((1)) FOR [MaxHp]
GO

ALTER TABLE [dbo].[Ships] ADD  CONSTRAINT [DF_Ships_CurrentHp]  DEFAULT ((1)) FOR [CurrentHp]
GO

ALTER TABLE [dbo].[Ships]  WITH CHECK ADD  CONSTRAINT [FK_Ships_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO

ALTER TABLE [dbo].[Ships] CHECK CONSTRAINT [FK_Ships_Users]
GO


