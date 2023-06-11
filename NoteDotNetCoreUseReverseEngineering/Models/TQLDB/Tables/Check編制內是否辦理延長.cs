using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check編制內是否辦理延長
{
    public int Id { get; set; }

    public string? 編制內是否辦理延長 { get; set; }

    public int? EditAuth001Id { get; set; }

    public DateTime? EditTime { get; set; }
}
