using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Me.AlohaChina.Data.Content
{
    public class TopicHistory : BaseResourceHistory
    {
        [Column]
        public Topic OriginalTopic
        {
            get;
            set;
        }

        public string OriginalContent
        {
            get
            {
                if (InternalOriginalContent == null)
                {
                    return string.Empty;
                }
                else
                {
                    return Encoding.Unicode.GetString(InternalOriginalContent.Content);
                }
            }
            set
            {
                InternalOriginalContent = new ResourceContent() { Content = Encoding.Unicode.GetBytes(value) };
            }
        }
    }
}
