
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Me.AlohaChina.Data.Content
{
    public class ResourceContent
    {
        [Key]
        public string ContentID
        {
            get;
            set;
        }

        [Column]
        public byte[] Content
        {
            get;
            set;
        }
    }
}
