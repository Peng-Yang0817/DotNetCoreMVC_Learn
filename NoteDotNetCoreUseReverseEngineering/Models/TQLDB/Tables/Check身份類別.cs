﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check身份類別
{
    public int Id { get; set; }

    public string 身份類別 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
