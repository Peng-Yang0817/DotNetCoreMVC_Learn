using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ExtensionCategory
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;
}
