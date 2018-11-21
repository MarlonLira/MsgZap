using System;

namespace MsgZap.Helper
{
    class Hlp
    {

        public String RandomIdGenerator()
        {
            String Id = "";
            String Rd = "";

            try
            {
                Rd = Guid.NewGuid().ToString();

                Id = "msg-" + RandomNumber(0, 99) + "-" + Rd;

                int RandomNumber(int min, int max)
                {
                    Random random = new Random();
                    return random.Next(min, max);
                }

                return Id;
            }
            finally
            {
                Id = "";
                Rd = "";
            }


            
        }
    }
}
