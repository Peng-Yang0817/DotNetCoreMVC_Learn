using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class OneNformSchoolUploadFile
{
    public int Id { get; set; }

    public string Year { get; set; } = null!;

    public int SchoolCtrl001Id { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string FileGuid { get; set; } = null!;

    public DateTime EditTime { get; set; }

    public int EditAuth001 { get; set; }
}
