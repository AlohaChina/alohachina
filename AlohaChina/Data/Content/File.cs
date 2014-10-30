
using System.ComponentModel.DataAnnotations.Schema;
namespace Me.AlohaChina.Data.Content
{
    public class File : BaseResource
    {
        [Column]
        public FileType FileType
        {
            get;
            set;
        }

        [Column]
        public string Name
        {
            get;
            set;
        }

        public byte[] Content
        {
            get
            {
                if (InternalContent == null)
                {
                    return null;
                }
                else
                {
                    return InternalContent.Content;
                }
            }
            set
            {
                InternalContent = new ResourceContent() { Content = value };
            }
        }

    }
}
