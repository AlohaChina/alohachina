using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Me.AlohaChina.Data.Content
{
    public class Topic : BaseResource
    {
        [Column]
        public string Title
        {
            get;
            set;
        }

        [Column]
        public string Author
        {
            get;
            set;
        }

        public string Content
        {
            get
            {
                if (InternalContent == null)
                {
                    return string.Empty;
                }
                else
                {
                    return Encoding.Unicode.GetString(InternalContent.Content);
                }
            }
            set
            {
                InternalContent = new ResourceContent() { Content = Encoding.Unicode.GetBytes(value) };
            }
        }

        [Column]
        public IList<Reply> Replies
        {
            get;
            set;
        }

    }
}
