using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogNform005
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public int SchoolCtrl004Id { get; set; }

    public int ShuoShiBanJqs { get; set; }

    public int Deposit { get; set; }

    public int DepositRecover { get; set; }

    public int Auth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public DateTime LogTime { get; set; }
}
