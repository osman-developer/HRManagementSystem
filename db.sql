USE [HRSystem]
GO
/****** Object:  Table [dbo].[TBL_DEPARTMENT]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_DEPARTMENT](
	[DEPARTMENT_ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[ADDRESS] [nvarchar](max) NOT NULL,
	[MOBILE] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TBL_DEPARTMENT] PRIMARY KEY CLUSTERED 
(
	[DEPARTMENT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_EMPLOYEE]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_EMPLOYEE](
	[EMPLOYEE_ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [nvarchar](50) NOT NULL,
	[LAST_NAME] [nvarchar](50) NOT NULL,
	[MOBILE] [nvarchar](20) NULL,
	[AGE] [int] NOT NULL,
	[SALARY] [decimal](18, 0) NOT NULL,
	[DEPARTMENT_ID] [int] NOT NULL,
 CONSTRAINT [PK_TBL_EMPLOYEE] PRIMARY KEY CLUSTERED 
(
	[EMPLOYEE_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_MANAGER]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_MANAGER](
	[MANAGER_ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [nvarchar](50) NOT NULL,
	[LAST_NAME] [nvarchar](50) NOT NULL,
	[DEPARTMENT_ID] [int] NOT NULL,
 CONSTRAINT [PK_TBL_MANAGER] PRIMARY KEY CLUSTERED 
(
	[MANAGER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_PERSON]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_PERSON](
	[PERSON_ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](20) NOT NULL,
	[IMG_URL] [nvarchar](max) NULL,
 CONSTRAINT [PK_TBL_PERSON] PRIMARY KEY CLUSTERED 
(
	[PERSON_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TBL_DEPARTMENT] ON 

INSERT [dbo].[TBL_DEPARTMENT] ([DEPARTMENT_ID], [NAME], [ADDRESS], [MOBILE]) VALUES (1, N'LS', N'beirut', N'111111')
INSERT [dbo].[TBL_DEPARTMENT] ([DEPARTMENT_ID], [NAME], [ADDRESS], [MOBILE]) VALUES (2, N'TS', N'triploli', N'111322')
INSERT [dbo].[TBL_DEPARTMENT] ([DEPARTMENT_ID], [NAME], [ADDRESS], [MOBILE]) VALUES (3, N'KM', N'tripoli', N'33333')
SET IDENTITY_INSERT [dbo].[TBL_DEPARTMENT] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_EMPLOYEE] ON 

INSERT [dbo].[TBL_EMPLOYEE] ([EMPLOYEE_ID], [FIRST_NAME], [LAST_NAME], [MOBILE], [AGE], [SALARY], [DEPARTMENT_ID]) VALUES (1, N'Tarek', N'Abed', N'712312', 23, CAST(2200 AS Decimal(18, 0)), 1)
INSERT [dbo].[TBL_EMPLOYEE] ([EMPLOYEE_ID], [FIRST_NAME], [LAST_NAME], [MOBILE], [AGE], [SALARY], [DEPARTMENT_ID]) VALUES (2, N'Samer', N'abdallah', N'5823647', 19, CAST(3400 AS Decimal(18, 0)), 1)
INSERT [dbo].[TBL_EMPLOYEE] ([EMPLOYEE_ID], [FIRST_NAME], [LAST_NAME], [MOBILE], [AGE], [SALARY], [DEPARTMENT_ID]) VALUES (3, N'loai', N'abdalla', N'7854632', 22, CAST(3200 AS Decimal(18, 0)), 2)
INSERT [dbo].[TBL_EMPLOYEE] ([EMPLOYEE_ID], [FIRST_NAME], [LAST_NAME], [MOBILE], [AGE], [SALARY], [DEPARTMENT_ID]) VALUES (4, N'sandy', N'jisr', N'4321123', 41, CAST(3200 AS Decimal(18, 0)), 2)
INSERT [dbo].[TBL_EMPLOYEE] ([EMPLOYEE_ID], [FIRST_NAME], [LAST_NAME], [MOBILE], [AGE], [SALARY], [DEPARTMENT_ID]) VALUES (7, N'Helena', N'Abood', N'71105886', 22, CAST(1999 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[TBL_EMPLOYEE] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_MANAGER] ON 

INSERT [dbo].[TBL_MANAGER] ([MANAGER_ID], [FIRST_NAME], [LAST_NAME], [DEPARTMENT_ID]) VALUES (3, N'Ahmad', N'moussawel', 1)
INSERT [dbo].[TBL_MANAGER] ([MANAGER_ID], [FIRST_NAME], [LAST_NAME], [DEPARTMENT_ID]) VALUES (4, N'wael', N'moussawel', 2)
INSERT [dbo].[TBL_MANAGER] ([MANAGER_ID], [FIRST_NAME], [LAST_NAME], [DEPARTMENT_ID]) VALUES (5, N'samer', N'moussawel', 2)
INSERT [dbo].[TBL_MANAGER] ([MANAGER_ID], [FIRST_NAME], [LAST_NAME], [DEPARTMENT_ID]) VALUES (6, N'samir', N'moussawel', 1)
INSERT [dbo].[TBL_MANAGER] ([MANAGER_ID], [FIRST_NAME], [LAST_NAME], [DEPARTMENT_ID]) VALUES (7, N'ali', N'moussawel', 1)
SET IDENTITY_INSERT [dbo].[TBL_MANAGER] OFF
GO
SET IDENTITY_INSERT [dbo].[TBL_PERSON] ON 

INSERT [dbo].[TBL_PERSON] ([PERSON_ID], [NAME], [IMG_URL]) VALUES (1, N'Osman', N'\uploads\askc-slider-1.jpg')
SET IDENTITY_INSERT [dbo].[TBL_PERSON] OFF
GO
ALTER TABLE [dbo].[TBL_EMPLOYEE]  WITH CHECK ADD  CONSTRAINT [FK_TBL_EMPLOYEE_TBL_DEPARTMENT] FOREIGN KEY([DEPARTMENT_ID])
REFERENCES [dbo].[TBL_DEPARTMENT] ([DEPARTMENT_ID])
GO
ALTER TABLE [dbo].[TBL_EMPLOYEE] CHECK CONSTRAINT [FK_TBL_EMPLOYEE_TBL_DEPARTMENT]
GO
ALTER TABLE [dbo].[TBL_MANAGER]  WITH CHECK ADD  CONSTRAINT [FK_TBL_MANAGER_TBL_DEPARTMENT] FOREIGN KEY([DEPARTMENT_ID])
REFERENCES [dbo].[TBL_DEPARTMENT] ([DEPARTMENT_ID])
GO
ALTER TABLE [dbo].[TBL_MANAGER] CHECK CONSTRAINT [FK_TBL_MANAGER_TBL_DEPARTMENT]
GO
/****** Object:  StoredProcedure [dbo].[UP_DELETE_DEPARTMENT]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_DELETE_DEPARTMENT] 
(  
  @DEPARTMENT_ID AS INT  
)  
AS  
BEGIN  
 DELETE  
 FROM  TBL_DEPARTMENT   
 WHERE DEPARTMENT_ID = @DEPARTMENT_ID
END
GO
/****** Object:  StoredProcedure [dbo].[UP_DELETE_EMPLOYEE]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_DELETE_EMPLOYEE]
(    
  @EMPLOYEE_ID AS INT    
)    
AS    
BEGIN    
 DELETE    
 FROM  TBL_EMPLOYEE     
 WHERE EMPLOYEE_ID = @EMPLOYEE_ID
END
GO
/****** Object:  StoredProcedure [dbo].[UP_DELETE_MANAGER]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_DELETE_MANAGER]   
(    
  @MANAGER_ID AS INT    
)    
AS    
BEGIN    
 DELETE    
 FROM  TBL_MANAGER     
 WHERE MANAGER_ID =@MANAGER_ID
END
GO
/****** Object:  StoredProcedure [dbo].[UP_EDIT_DEPARTMENT]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_EDIT_DEPARTMENT]
(  
  @DEPARTMENT_ID AS INT,  
  @NAME AS NVARCHAR(50),  
  @ADDRESS AS NVARCHAR(MAX),
  @MOBILE as NVARCHAR(20)
)  
AS  
BEGIN  
 IF @DEPARTMENT_ID  = -1  
 BEGIN  
  INSERT INTO TBL_DEPARTMENT(NAME,ADDRESS,MOBILE) VALUES (@NAME,@ADDRESS,@MOBILE)  
 END  
 ELSE  
 BEGIN  
  UPDATE TBL_DEPARTMENT  
  SET    NAME = @NAME,  
         ADDRESS = @ADDRESS,
		 MOBILE = @MOBILE
  WHERE  DEPARTMENT_ID = @DEPARTMENT_ID
 END  
END
GO
/****** Object:  StoredProcedure [dbo].[UP_EDIT_EMPLOYEE]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_EDIT_EMPLOYEE]   
(
@EMPLOYEE_ID AS INT,
@FIRST_NAME AS NVARCHAR(50),
@LAST_NAME AS NVARCHAR(50),
@MOBILE AS NVARCHAR(20),
@AGE AS INT,
@SALARY AS decimal(18, 0),  
@DEPARTMENT_ID AS INT  
 ) 
 AS
BEGIN    
 IF @EMPLOYEE_ID  = -1    
 BEGIN    
  INSERT INTO TBL_EMPLOYEE(FIRST_NAME,LAST_NAME,MOBILE,AGE,SALARY,DEPARTMENT_ID) VALUES (@FIRST_NAME,@LAST_NAME,@MOBILE,@AGE,@SALARY,@DEPARTMENT_ID)    
 END    
 ELSE    
 BEGIN  
   UPDATE  TBL_EMPLOYEE  
    SET   
     FIRST_NAME = @FIRST_NAME,  
    LAST_NAME = @LAST_NAME,
	MOBILE=@MOBILE,
	AGE=@AGE,
	SALARY=@SALARY,
	DEPARTMENT_ID = @DEPARTMENT_ID
    WHERE  EMPLOYEE_ID = @EMPLOYEE_ID
  END  
  END
GO
/****** Object:  StoredProcedure [dbo].[UP_EDIT_MANAGER]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_EDIT_MANAGER]  
( @MANAGER_ID AS INT,   
  @DEPARTMENT_ID AS INT,    
  @FIRST_NAME AS NVARCHAR(50),    
  @LAST_NAME AS NVARCHAR(MAX)  
 
)    
AS    
BEGIN    
 IF @MANAGER_ID  = -1    
 BEGIN    
  INSERT INTO TBL_MANAGER(FIRST_NAME,LAST_NAME,DEPARTMENT_ID) VALUES (@FIRST_NAME,@LAST_NAME,@DEPARTMENT_ID)    
 END    
 ELSE    
 BEGIN    
  UPDATE TBL_MANAGER    
  SET    FIRST_NAME = @FIRST_NAME,    
         LAST_NAME = @LAST_NAME,  
   DEPARTMENT_ID = @DEPARTMENT_ID  
  WHERE  MANAGER_ID = @MANAGER_ID
 END    
END
GO
/****** Object:  StoredProcedure [dbo].[UP_EDIT_PERSON]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_EDIT_PERSON]   
( @PERSON_ID AS INT,          
  @NAME AS NVARCHAR(20),      
  @IMG_URL AS NVARCHAR(MAX)    
   
)      
AS      
BEGIN      
 IF @PERSON_ID  = -1      
 BEGIN      
  INSERT INTO TBL_PERSON(NAME,IMG_URL) VALUES (@NAME,@IMG_URL)      
 END      
 ELSE      
 BEGIN      
  UPDATE TBL_PERSON     
  SET    NAME = @NAME,      
         IMG_URL = @IMG_URL     
  WHERE  PERSON_ID = @PERSON_ID  
 END      
END
GO
/****** Object:  StoredProcedure [dbo].[UP_GET_DEPARTMENT]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_GET_DEPARTMENT]
AS  
BEGIN   
 SELECT *  
 FROM   TBL_DEPARTMENT
END
GO
/****** Object:  StoredProcedure [dbo].[UP_GET_EMPLOYEES]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_GET_EMPLOYEES]  
AS  
BEGIN   
 SELECT * FROM TBL_EMPLOYEE  
END
GO
/****** Object:  StoredProcedure [dbo].[UP_GET_HIGHEST_PAID_EMPLOYEE]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UP_GET_HIGHEST_PAID_EMPLOYEE]    
@DEPARTMENT_ID AS INT  
AS    
BEGIN     
select * from TBL_EMPLOYEE where (salary = (select max(salary) from TBL_EMPLOYEE where DEPARTMENT_ID=@DEPARTMENT_ID))

END
GO
/****** Object:  StoredProcedure [dbo].[UP_GET_MANAGER]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_GET_MANAGER]    
AS    
BEGIN     
 SELECT * FROM TBL_MANAGER    
END
GO
/****** Object:  StoredProcedure [dbo].[UP_GET_MANAGERS_OF_DEPARTMENT]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_GET_MANAGERS_OF_DEPARTMENT]  
@DEPARTMENT_ID AS INT
AS  
BEGIN   
 SELECT * FROM TBL_MANAGER  
 WHERE DEPARTMENT_ID=@DEPARTMENT_ID
END
GO
/****** Object:  StoredProcedure [dbo].[UP_GET_PERSON]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_GET_PERSON]     
AS      
BEGIN       
 SELECT * FROM TBL_PERSON
END
GO
/****** Object:  StoredProcedure [dbo].[UP_GET_YOUNGEST_EMPLOYEE]    Script Date: 1/24/2021 2:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UP_GET_YOUNGEST_EMPLOYEE]      
@DEPARTMENT_ID AS INT    
AS      
BEGIN       
select * from TBL_EMPLOYEE where (age = (select min(age) from TBL_EMPLOYEE  where DEPARTMENT_ID=@DEPARTMENT_ID)) 
 
END
GO
