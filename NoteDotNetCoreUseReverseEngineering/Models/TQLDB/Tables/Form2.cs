using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Form2
{
    public string? SchoolName { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public string? CollegeName { get; set; }

    public int? SchoolCtrl002Id { get; set; }

    public string? TotalName { get; set; }

    public string DaShiueBuName { get; set; } = null!;

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public string? DepartmentAreaName { get; set; }

    public int SchoolCtrl005Id { get; set; }

    public string SiJiJinXiuBuState { get; set; } = null!;

    public string SiJiZaiZhiZhuanBanState { get; set; } = null!;

    public string ErJiRiJianBuState { get; set; } = null!;

    public string ErJiJinXiuBuState { get; set; } = null!;

    public string ErJiJinXiuXueYuanState { get; set; } = null!;

    public int? NewSiJiJinXiuBuJqs { get; set; }

    public int? NewSiJiJinXiuBuDeposit { get; set; }

    public int? NewSiJiJinXiuBuDepositRecover { get; set; }

    public int? NewSiJiZaiZhiZhuanBanJqs { get; set; }

    public int? NewSiJiZaiZhiZhuanBanDeposit { get; set; }

    public int? NewSiJiZaiZhiZhuanBanDepositRecover { get; set; }

    public int? NewErJiRiJianBuJqs { get; set; }

    public int? NewErJiRiJianBuDeposit { get; set; }

    public int? NewErJiRiJianBuDepositRecover { get; set; }

    public int? NewErJiJinXiuBuJqs { get; set; }

    public int? NewErJiJinXiuBuDeposit { get; set; }

    public int? NewErJiJinXiuBuDepositRecover { get; set; }

    public int? NewErJiJinXiuXueYuanJqs { get; set; }

    public int? NewErJiJinXiuXueYuanDeposit { get; set; }

    public int? NewErJiJinXiuXueYuanDepositRecover { get; set; }

    public int? OldSiJiJinXiuBuJqs { get; set; }

    public int? OldSiJiZaiZhiZhuanBanJqs { get; set; }

    public int? OldErJiRiJianBuJqs { get; set; }

    public int? OldErJiJinXiuBuJqs { get; set; }

    public int? OldErJiJinXiuXueYuanJqs { get; set; }

    public int? SumSiJiJinXiuBuDeposit { get; set; }

    public int? SumSiJiZaiZhiZhuanBanDeposit { get; set; }

    public int? SumErJiRiJianBuDeposit { get; set; }

    public int? SumErJiJinXiuBuDeposit { get; set; }

    public int? SumErJiJinXiuXueYuanDeposit { get; set; }
}
