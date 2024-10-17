using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_4.Models;
[Table("Answer")]

public partial class Answer
{
    public int Id { get; set; }

    public string? Content { get; set; }

    public bool? Correct { get; set; }

    public int? QuestionId { get; set; }

    public virtual Question? Question { get; set; }
}
