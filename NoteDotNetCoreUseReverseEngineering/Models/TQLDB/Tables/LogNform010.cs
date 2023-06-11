using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogNform010
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public int SchoolCtrl005Id { get; set; }

    public int ErJiJinXiuBuJqs { get; set; }

    public int Deposit { get; set; }

    public int DepositRecover { get; set; }

    public int Auth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public DateTime LogTime { get; set; }
}
