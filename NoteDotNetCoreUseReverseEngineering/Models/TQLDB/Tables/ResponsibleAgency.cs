using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ResponsibleAgency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Checked { get; set; }
}
