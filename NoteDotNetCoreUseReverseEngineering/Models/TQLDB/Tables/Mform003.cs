using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Mform003
{
    /// <summary>
    /// PK
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK MForm001 Id 匯入報表
    /// </summary>
    public int Mform001Id { get; set; }

    /// <summary>
    /// FK MForm002 Id 輸出報表
    /// </summary>
    public int Mform002Id { get; set; }
}
