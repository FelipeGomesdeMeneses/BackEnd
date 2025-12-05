using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrudMoura.Models;

[Table("Aluno")]
public partial class Aluno
{
    [Key]
    [Column("id")]
    public int id { get; set; }

    [StringLength(255)]
    public string Nome { get; set; } = null!;

    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("CPF")]
    [StringLength(14)]
    [Unicode(false)]
    public string CPF { get; set; } = null!;

    public int Idade { get; set; }
}
