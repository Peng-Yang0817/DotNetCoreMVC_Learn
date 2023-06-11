using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Nform034ClassSizeManage
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public string DepartmentNum { get; set; } = null!;

    public string Degree { get; set; } = null!;

    public string? DivideClassInfo { get; set; }
}
