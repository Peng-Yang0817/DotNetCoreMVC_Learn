using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ExamineNoteRecord
{
    public int Id { get; set; }

    public int OneNformTypeId { get; set; }

    public int OneNformId { get; set; }

    public string SchoolName { get; set; } = null!;

    public string? RemindText { get; set; }

    public string? ApprovedResults { get; set; }

    public string? ExResultNum { get; set; }

    public string? Remork { get; set; }
}
