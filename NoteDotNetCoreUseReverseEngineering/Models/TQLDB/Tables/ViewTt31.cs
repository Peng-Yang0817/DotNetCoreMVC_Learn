using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewTt31
{
    public int Id { get; set; }

    public int? 學年度 { get; set; }

    public int 學校代碼 { get; set; }

    public string 學校名稱 { get; set; } = null!;

    public string 系所類別代碼 { get; set; } = null!;

    public int 系所代碼 { get; set; }

    public string 系所名稱 { get; set; } = null!;

    public string 學制代碼 { get; set; } = null!;

    public string 學制名稱 { get; set; } = null!;

    public decimal 畢業專業必修學分數 { get; set; }

    public decimal 畢業專業選修學分數 { get; set; }

    public decimal 畢業通識共同必修學分數 { get; set; }

    public decimal 畢業通識共同選修學分數 { get; set; }

    public decimal 畢業實習校內必修學分數 { get; set; }

    public decimal 畢業實習校內選修學分數 { get; set; }

    public decimal 畢業實習校外必修學分數 { get; set; }

    public decimal 畢業實習校外選修學分數 { get; set; }

    public decimal 其他畢業學分數 { get; set; }

    public decimal? 畢業總學分數 { get; set; }

    public int 目前年級數 { get; set; }
}
