using System;

namespace Me.Sample.Common.Error
{
    public class BaseException : Exception
    {
        private ErrorNumber error;

        private string[] parameters;

        public BaseException(ErrorNumber error, params string[] parameters)
            : base(error.ToString())
        {
            this.error = error;
            this.parameters = parameters;
        }

        public BaseException(ErrorNumber error, Exception innerException, params string[] parameters)
            : base(error.ToString(), innerException)
        {
            this.error = error;
            this.parameters = parameters;
        }

        public string Message
        {
            get
            {
                string message = base.Message;
                if (Me.Sample.Common.Resource.Message.ResourceManager != null)
                {
                    message = Me.Sample.Common.Resource.Message.ResourceManager.GetString(error.ToString());

                    if (parameters != null && parameters.Length > 0)
                    {
                        message = string.Format(message, parameters);
                    }
                }
                return message;
            }
        }
    }
}
