
using System.ComponentModel.DataAnnotations.Schema;
namespace Me.AlohaChina.Data.Content
{
    public class Reply : BaseResource
    {
        [Column]
        public BaseResource ReplyTo
        {
            get;
            set;
        }

        public ResourceContent Content
        {
            get;
            set;
        }

        [Column]
        public Reply Refer
        {
            get;
            set;
        }
    }
}
