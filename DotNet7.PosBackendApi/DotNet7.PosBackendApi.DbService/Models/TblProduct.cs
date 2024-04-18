﻿using System;
using System.Collections.Generic;

namespace DotNet7.PosBackendApi.DbService.Models;

public partial class TblProduct
{
    public int ProductId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string ProductCategoryCode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }
}