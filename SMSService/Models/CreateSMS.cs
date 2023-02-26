namespace SMSService.Models
{
    public class CreateSMS
    {
        private string smstext;

        public string SMSText
        {
            get { return smstext; }
            set
            {
                if (smstext.Length > 140)
                {
                    throw new ArgumentException("SMS must be less than 140 characters");
                }
                smstext = value;
            }
        }

        private int sendermobile;

        public int SenderMobile
        {
            get { return sendermobile; }
            set
            {
                if (string.IsNullOrEmpty(SenderMobile.ToString()))
                {
                    throw new ArgumentException("Senders number cannot be emptied;");
                }
                sendermobile = value;
            }
        }


        private int receivermobile;

        public int ReceiverMobile
        {
            get { return receivermobile; }
            set
            {
                if (string.IsNullOrEmpty(ReceiverMobile.ToString()))
                {
                    throw new ArgumentException("Senders number cannot be emptied;");
                }
                receivermobile = value;
            }
        }
    }
}
