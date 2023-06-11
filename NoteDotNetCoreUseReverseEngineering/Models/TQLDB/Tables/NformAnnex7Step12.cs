using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class NformAnnex7Step12
{
    public int Id { get; set; }

    /// <summary>
    /// 生師比值基準
    /// </summary>
    public int? TeacherRatioStandard { get; set; }

    /// <summary>
    /// 外加名額最少數
    /// </summary>
    public int? ExternalMinimum { get; set; }
}
