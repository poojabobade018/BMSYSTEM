CREATE TABLE [dbo].[BILLDETAILS] (
    [bilno]   INT            NULL,
    [bildate] DATE           NULL,
    [cusid]   INT            NULL,
    [cusnm]   NVARCHAR (50)  NULL,
    [contact] NVARCHAR (50)  NULL,
	[dedate]  DATE,
	[orderli] NVARCHAR (MAX) NULL,
    [totalam] NVARCHAR (MAX) NULL,
    [paymt]   NVARCHAR (MAX) NULL
);

