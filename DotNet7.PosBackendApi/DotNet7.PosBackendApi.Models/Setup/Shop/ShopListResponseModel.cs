﻿namespace DotNet7.PosBackendApi.Models.Setup.Shop;

public class ShopListResponseModel
{
    public List<ShopModel> DataLst { get; set; }
    public MessageResponseModel MessageResponse { get; set; }
}