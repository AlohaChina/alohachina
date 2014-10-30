
using System.ComponentModel.DataAnnotations.Schema;
namespace Me.AlohaChina.Data.Content
{
    public class FileHistory : BaseResourceHistory
    {
        [Column]
        public File OriginalFile
        {
            get;
            set;
        }

        public byte[] OriginalContent
        {
            get
            {
                if (InternalOriginalContent == null)
                {
                    return null;
                }
                else
                {
                    return InternalOriginalContent.Content;
                }
            }
            set
            {
                InternalOriginalContent = new ResourceContent() { Content = value };
            }
        }
    }
}
