﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogState005
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string GuanKongLeiName { get; set; } = null!;

    public DateTime LogTime { get; set; }
}
