using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogSchoolCtrl009
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public int OldSchoolCtrl004Id { get; set; }

    public int State002Id { get; set; }

    public int? NewSchoolCtrl004Id { get; set; }

    public string? OldShuoBoShrBanName { get; set; }

    public string? OldClassName { get; set; }

    public string? OldGroupName { get; set; }

    public string Year { get; set; } = null!;

    public string? ApprovedNum { get; set; }

    public string? Notes { get; set; }

    public string? ApprovedUnit { get; set; }

    public bool BoShiBanCw { get; set; }

    public bool ShuoShiBanCw { get; set; }

    public bool ShuoShiZaiZhiZhuanBanCw { get; set; }

    public DateTime EditTime { get; set; }

    public int Auth001Id { get; set; }

    public DateTime LogTime { get; set; }
}
