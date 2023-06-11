using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class SchoolCtrl003
{
    public int Id { get; set; }

    public string DepartmentAreaName { get; set; } = null!;

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime EditTime { get; set; }

    /// <summary>
    /// FK Auth001 系科所狀態建立者ID
    /// </summary>
    public int Auth001Id { get; set; }
}
