
---- Modify Project Table to drop Client column and
---- add ClientId column with foreign key to Client Table

USE [TaskyDB]
GO

--- Delete Data in all dependent tables
Delete From ProjectTaskMap where ProjectId >= 0

Delete From UserProject where ProjectId >= 0

Delete From Task where ProjectId >= 0
--- 

--- Delete all data in Project Table
Delete From Project where ProjectId >= 0


---- Create Client Table

USE [TaskyDB]
GO

/****** Object:  Table [dbo].[Client]    Script Date: 5/12/2016 6:17:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Client](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


--- Delete Column Client
ALTER TABLE Project
DROP COLUMN Client


ALTER TABLE Project
ADD ClientId int not null

ALTER TABLE Project
ADD CONSTRAINT FK_Project_Client
FOREIGN KEY (ClientId)
REFERENCES Client(ClientId)

GO







