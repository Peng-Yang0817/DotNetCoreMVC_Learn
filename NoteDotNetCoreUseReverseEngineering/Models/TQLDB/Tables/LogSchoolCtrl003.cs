using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSchoolCtrl003
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string DepartmentAreaName { get; set; } = null!;

    public DateTime EditTime { get; set; }

    public int Auth001Id { get; set; }

    public DateTime LogTime { get; set; }
}
