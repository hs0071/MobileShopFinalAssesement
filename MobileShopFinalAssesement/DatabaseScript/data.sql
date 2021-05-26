SET IDENTITY_INSERT [dbo].[MobileName] ON
INSERT INTO [dbo].[MobileName] ([Id], [Mobile_Category]) VALUES (1, N'Samsung')
INSERT INTO [dbo].[MobileName] ([Id], [Mobile_Category]) VALUES (2, N'Iphone')
INSERT INTO [dbo].[MobileName] ([Id], [Mobile_Category]) VALUES (3, N'Oppo')
SET IDENTITY_INSERT [dbo].[MobileName] OFF
SET IDENTITY_INSERT [dbo].[Seller] ON
INSERT INTO [dbo].[Seller] ([Id], [Seller_Name], [Seller_Address], [Seller_Contact]) VALUES (1, N'Jot', N'Auckland', N'022265767')
INSERT INTO [dbo].[Seller] ([Id], [Seller_Name], [Seller_Address], [Seller_Contact]) VALUES (2, N'Deep', N'Auckland', N'022476878')
INSERT INTO [dbo].[Seller] ([Id], [Seller_Name], [Seller_Address], [Seller_Contact]) VALUES (3, N'Lak', N'Auckland', N'022566778')
SET IDENTITY_INSERT [dbo].[Seller] OFF
SET IDENTITY_INSERT [dbo].[Buyer] ON
INSERT INTO [dbo].[Buyer] ([Id], [Buyer_Name], [Buyer_Address], [Buyer_Contact], [SellerID]) VALUES (4, N'Seem', N'Auckland', N'02278989', 4)
INSERT INTO [dbo].[Buyer] ([Id], [Buyer_Name], [Buyer_Address], [Buyer_Contact], [SellerID]) VALUES (5, N'Aen', N'Auckland', N'022878799', 5)
INSERT INTO [dbo].[Buyer] ([Id], [Buyer_Name], [Buyer_Address], [Buyer_Contact], [SellerID]) VALUES (6, N'Qet', N'Auckland', N'022789809', 6)
SET IDENTITY_INSERT [dbo].[Buyer] OFF
