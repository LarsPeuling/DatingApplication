using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApplication.MVVM.Models
{
    [SQLite.Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [SQLite.Column("name"), Indexed, NotNull]
        public string Name { get; set; }
        [SQLite.Column("ProfilePicture")]
        public string ProfilePicture { get; set; }
        [MaxLength(250)]
        public string Bio { get; set; }
        public int? Age { get; set; }
        public string? Adress { get; set; }
    }
}
