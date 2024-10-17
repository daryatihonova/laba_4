using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_4.Models;
[Table("Question")]
public partial class Question
{
    public Question()
    {
        Answers = new HashSet<Answer>();
    }
    public int Id { get; set; }

    public string? Content { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();
}
