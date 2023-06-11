using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check是否為農林漁牧或工業領域類科系
{
    public int Id { get; set; }

    public string 是否為農林漁牧或工業領域類科系 { get; set; } = null!;

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }
}
