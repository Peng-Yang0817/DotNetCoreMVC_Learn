﻿using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class LogNform003
{
    public string Atype { get; set; } = null!;

    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public int State004Id { get; set; }

    public int SchoolCtrl001Id { get; set; }

    public int ABoShiBanJqs { get; set; }

    public int AShuoShiBanJqs { get; set; }

    public int AShuoShiZaiZhiZhuanBanJqs { get; set; }

    public int BSiJiRiJianBuGauJrJqs { get; set; }

    public int BSiJiRiJianBuGauYuanNeiGaoZhongShengJqs { get; set; }

    public int BSiJiRiJianBuGauYuanWaiJiaGaoZhongShengJqs { get; set; }

    public int BSiJiJinXiuBuJqs { get; set; }

    public int BSiJiZaiZhiZhuanBanJqs { get; set; }

    public int BErJiRiJianBuJqs { get; set; }

    public int BErJiJinXiuBuJqs { get; set; }

    public int BErJiJinXiuXueYuanJqs { get; set; }

    public int CWuZhuanJqs { get; set; }

    public int CErZhuanRiJianBuJqs { get; set; }

    public int CErZhuanYeJianBuJqs { get; set; }

    public int CErZhuanZaiZhiZhuanBanJqs { get; set; }

    public int CErZhuanJinXiuZhuanXiaoJqs { get; set; }

    public string? DocNum { get; set; }

    public string? UserNote { get; set; }

    public int Auth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public DateTime LogTime { get; set; }
}
