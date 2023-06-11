using System;
using System.Collections.Generic;

namespace NoteDotNetCoreUseReverseEngineering.Models.TQLDB.Tables;

public partial class ViewBoardPublish
{
    public int Id { get; set; }

    public int BoardCategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string Title { get; set; } = null!;

    public string? Contents { get; set; }

    public DateTime BoardTime { get; set; }

    public int EditAuth001Id { get; set; }

    public DateTime EditTime { get; set; }

    public int? FileId { get; set; }

    public string? FileGuid { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public int? FileEditAuth001Id { get; set; }

    public DateTime? FileEditTime { get; set; }
}
