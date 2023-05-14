  alter table ClientContactPerson add IsWizkindConnected [bit];
  alter table ClientContactPerson add WizkindAgencyId int;
  alter table ClientContactPerson add WizkindSecret nvarchar(255);
  update ClientContactPerson set IsWizkindConnected=0;
  update ClientContactPerson set WizkindAgencyId=0;
  update ClientContactPerson set WizkindSecret='';


  CREATE TABLE [dbo].[UserNotes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UUID] [varchar](255) NOT NULL,
	[LoginUUID] [varchar](255) NOT NULL,
	[UserUUID] [varchar](255) NOT NULL,
	[Type] [varchar](255) NOT NULL,
	[Notes] [varchar](255) NOT NULL,
	[CreatedBy] [varchar](255) NULL,
	[CreatedOn] [datetime] NULL,
	[UpdatedBy] [varchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
	[IsActive] bit,
 CONSTRAINT [PK__UserNotes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO