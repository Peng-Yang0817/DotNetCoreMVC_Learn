using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Check合約有無經法院公證
{
    public int Id { get; set; }

    public string 合約有無經法院公證 { get; set; } = null!;

    public bool Tt83 { get; set; }

    public int EditAuth001d { get; set; }

    public DateTime EditTime { get; set; }
}
