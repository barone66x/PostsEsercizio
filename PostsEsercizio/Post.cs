using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsEsercizio
{
    internal class Post
    {
        //tutto si riferisce solo alla proprietà sottostante
        [Key] //dichiarazione esplicita chiave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto increment
        [Column("codice")] //la colonna del db si chiamerà codice e non code
        public int Code { get; set; }

        [Column("Titolo", TypeName = "nvarchar")] // il tipo della colonna è nvarchar 
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime PubDate { get; set; }


        [Column("author")]
        [ForeignKey("Author")]
        public string AuthorLogin { get; set; } //vera e propria foreign key
        public User Author { get; set; } //associazione navigabile in c#
    }
}
