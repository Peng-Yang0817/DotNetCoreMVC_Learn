﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check進修地區
{
    public int Id { get; set; }

    public string 進修地區 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
