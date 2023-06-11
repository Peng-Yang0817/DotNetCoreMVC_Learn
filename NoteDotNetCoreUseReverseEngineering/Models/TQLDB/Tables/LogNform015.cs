using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogNform015
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public int SchoolCtrl005Id { get; set; }

    public int GauJungShengHuLiLeiB3 { get; set; }

    public int Deposit { get; set; }

    public int DepositRecover { get; set; }

    public int Auth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public DateTime LogTime { get; set; }
}
