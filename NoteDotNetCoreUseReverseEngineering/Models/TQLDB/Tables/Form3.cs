using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class Form3
{
    public string? SchoolName { get; set; }

    public int? SchoolCtrl001Id { get; set; }

    public string? TotalName { get; set; }

    public string JuanKeBuName { get; set; } = null!;

    public string? ClassName { get; set; }

    public string? GroupName { get; set; }

    public string? DepartmentAreaName { get; set; }

    public int SchoolCtrl007Id { get; set; }

    public string WuZhuanState { get; set; } = null!;

    public string ErZhuanRiJianBuState { get; set; } = null!;

    public string ErZhuanYeJianBuState { get; set; } = null!;

    public string ErZhuanZaiZhiZhuanBanState { get; set; } = null!;

    public string ErZhuanJinXiuZhuanXiaoState { get; set; } = null!;

    public int? NewWuZhuanJqs { get; set; }

    public int? NewWuZhuanDeposit { get; set; }

    public int? NewWuZhuanDepositRecover { get; set; }

    public int? NewErZhuanRiJianBuJqs { get; set; }

    public int? NewErZhuanRiJianBuDeposit { get; set; }

    public int? NewErZhuanRiJianBuDepositRecover { get; set; }

    public int? NewErZhuanYeJianBuJqs { get; set; }

    public int? NewErZhuanYeJianBuDeposit { get; set; }

    public int? NewErZhuanYeJianBuDepositRecover { get; set; }

    public int? NewErZhuanZaiZhiZhuanBanJqs { get; set; }

    public int? NewErZhuanZaiZhiZhuanBanDeposit { get; set; }

    public int? NewErZhuanZaiZhiZhuanBanDepositRecover { get; set; }

    public int? NewErZhuanJinXiuZhuanXiaoJqs { get; set; }

    public int? NewErZhuanJinXiuZhuanXiaoDeposit { get; set; }

    public int? NewErZhuanJinXiuZhuanXiaoDepositRecover { get; set; }

    public int? OldWuZhuanJqs { get; set; }

    public int? OldErZhuanRiJianBuJqs { get; set; }

    public int? OldErZhuanYeJianBuJqs { get; set; }

    public int? OldErZhuanZaiZhiZhuanBanJqs { get; set; }

    public int? OldErZhuanJinXiuZhuanXiaoJqs { get; set; }

    public int? SumWuZhuanDeposit { get; set; }

    public int? SumErZhuanRiJianBuDeposit { get; set; }

    public int? SumErZhuanYeJianBuDeposit { get; set; }

    public int? SumErZhuanZaiZhiZhuanBanDeposit { get; set; }

    public int? SumErZhuanJinXiuZhuanXiaoDeposit { get; set; }
}
